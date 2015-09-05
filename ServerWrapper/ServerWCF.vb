Imports System.ServiceModel
Imports System.ServiceModel.Description


Public Class ServerWCF
    Inherits ServerListener

    Private BindType As String
    Private Port As Integer
    Private url As String = ""
    Private EndpointURI As Uri
    Private MexURI As Uri
    Private WCFService As ServiceHost
    Private WCFMetadata As ServiceMetadataBehavior
    Public Shared RequestToFwd As ClientWrapper.ClientRequest

    Public Sub SetEndpoint(BindingType As String, BindPort As Integer)
        BindType = BindingType
        Port = BindPort
        Select Case BindingType
            Case "WSHttpBinding"
                url = "http://localhost:" + BindPort.ToString + "/wcf"
            Case "NetTcpBinding"
                url = "net.tcp://localhost:" + BindPort.ToString + "/wcf"
            Case Else
                url = "http://localhost:" + BindPort.ToString + "/wcf"
        End Select
        MexURI = New Uri("http://localhost:" + (BindPort + 1).ToString + "/mex")
        EndpointURI = New Uri(url)

    End Sub

    Public Overrides Sub StartListening()

        Dim WCFServiceInstance As New ServerWCFService(RequestToForward)
        WCFService = New ServiceHost(WCFServiceInstance, EndpointURI)
        'Add metadata for kicks
        WCFMetadata = New ServiceMetadataBehavior()
        WCFMetadata.HttpGetEnabled = True
        WCFMetadata.HttpGetUrl = MexURI
        WCFMetadata.MetadataExporter.PolicyVersion = PolicyVersion.Policy15
        WCFService.Description.Behaviors.Add(WCFMetadata)
        If Me.ForwardRequests Then
            RequestToFwd = RequestToForward
        Else
            RequestToFwd = Nothing
        End If
        WCFService.Open()

    End Sub

    Public Overrides Sub StopListening()
        WCFService.Close()
        RequestToFwd = Nothing
    End Sub

End Class

<ServiceBehavior(InstanceContextMode:=InstanceContextMode.Single)>
Public Class ServerWCFService
    Implements dotNetSimulatorUtilities.ServerWCFInterface

    Private FwdRequest As ClientWrapper.ClientRequest = Nothing
    Public Sub New(RequestToForward As ClientWrapper.ClientRequest)
        FwdRequest = RequestToForward
    End Sub

    Public Function ServerWCFCall() As String Implements dotNetSimulatorUtilities.ServerWCFInterface.ServerWCFCall
        Dim retVal As String = "Hello from WCF"
        dotNetSimulatorUtilities.CallGraphFodder.Call1()
        'forward request

        If Not Me.FwdRequest Is Nothing Then
            retVal = retVal + vbCrLf + vbCrLf + FwdRequest.DoRequest()
        End If
        retVal = retVal.Substring(0, Math.Min(retVal.Length, 1000))
        Return retVal
    End Function

    Public Async Function ServerWCFCallAsync() As Task(Of String) Implements dotNetSimulatorUtilities.ServerWCFInterface.AsyncServerWCFCall
        dotNetSimulatorUtilities.CallGraphFodder.Call1()
        Dim retVal As String = ""
        Dim fwdReq As String = ""
        If Not Me.FwdRequest Is Nothing Then
            fwdReq = vbCrLf + FwdRequest.DoRequest()
        End If
        retVal = Await Task.Factory.StartNew(Function() "Hello from WCF Async") + fwdReq
        Return retVal
    End Function

End Class