Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels
Imports dotNetSimulatorUtilities
Imports System.Threading


Public Class ClientRemoting
    Inherits ClientRequest

    Private _ChannelType As String
    Private _URI As String
    Private _Port As String
    Private IPCChannel As Ipc.IpcChannel
    Private HTTPChannel As Http.HttpChannel
    Private TCPChannel As Tcp.TcpChannel

    Public Sub New(ChannelType As String, Port As String, URI As String, AsynchronousPattern As String, ExceptionInBT As Boolean, ExceptionAcrossBT As Boolean)
        _ChannelType = ChannelType
        _URI = URI
        _Port = Port
        Me.AsyncPattern = AsynchronousPattern
        Me.ExcInBT = ExceptionInBT
        Me.ExcAcrossBT = ExceptionAcrossBT
    End Sub

    Protected Overrides Function DoRequestSync() As String

        Dim retVal As String = "Unsupported Remoting Protocol"
        Select Case _ChannelType
            Case "IPC"
                IPCChannel = New Ipc.IpcChannel()
                ChannelServices.RegisterChannel(IPCChannel, False)
                Dim RemoteURL As String = "ipc://localhost:" + _Port + "/" + _URI
                Dim RemoteType As New WellKnownClientTypeEntry(GetType(RemotingObject), _
                                                               RemoteURL)
                If (RemotingConfiguration.IsWellKnownClientType(GetType(RemotingObject)) Is Nothing) Then
                    RemotingConfiguration.RegisterWellKnownClientType(RemoteType)
                End If
                Dim RemotingService As New RemotingObject()
                Return RemotingService.RemoteMethod()
                ChannelServices.UnregisterChannel(IPCChannel)
            Case "TCP"
                TCPChannel = New Tcp.TcpChannel()
                ChannelServices.RegisterChannel(TCPChannel, False)
                Dim RemoteURL As String = "tcp://localhost:" + _Port + "/" + _URI
                Dim RemoteType As New WellKnownClientTypeEntry(GetType(RemotingObject), _
                                                               RemoteURL)
                If (RemotingConfiguration.IsWellKnownClientType(GetType(RemotingObject)) Is Nothing) Then
                    RemotingConfiguration.RegisterWellKnownClientType(RemoteType)
                End If

                Dim RemotingService As New RemotingObject()
                retVal = RemotingService.RemoteMethod()
                ChannelServices.UnregisterChannel(TCPChannel)
            Case "HTTP"
                HTTPChannel = New Http.HttpChannel()
                ChannelServices.RegisterChannel(HTTPChannel, False)
                Dim RemoteURL As String = "http://localhost:" + _Port + "/" + _URI
                Dim RemoteType As New WellKnownClientTypeEntry(GetType(RemotingObject), _
                                                               RemoteURL)
                If (RemotingConfiguration.IsWellKnownClientType(GetType(RemotingObject)) Is Nothing) Then
                    RemotingConfiguration.RegisterWellKnownClientType(RemoteType)
                End If
                Dim RemotingService As New RemotingObject()
                retVal = RemotingService.RemoteMethod()
                ChannelServices.UnregisterChannel(HTTPChannel)
        End Select
        dotNetSimulatorUtilities.CallGraphFodder.Call1()
        Return retVal

    End Function

    Protected Overrides Function DoRequestAsync() As Task(Of String)
        Return Nothing
    End Function

    Protected Overrides Function DoRequestManualThread() As String
        dotNetSimulatorUtilities.CallGraphFodder.Call1()
        Dim worker As New ThreadWorker(Me)
        Dim thread As New Threading.Thread(AddressOf worker.DoRequestThreadInternal)
        thread.Start()
        thread.Join()
        Return worker.RetVal
    End Function

    Protected Overrides Function DoRequestTask() As String
        dotNetSimulatorUtilities.CallGraphFodder.Call1()
        Dim worker As New ThreadWorker(Me)
        Dim tsk As New Task(AddressOf worker.DoRequestThreadInternal)
        tsk.Start()
        tsk.Wait()
        Return worker.RetVal
    End Function

    Protected Overrides Function DoRequestThreadPool() As String
        dotNetSimulatorUtilities.CallGraphFodder.Call1()
        Dim worker As New ThreadWorker(Me)
        ThreadPool.QueueUserWorkItem(AddressOf worker.DoRequestThreadInternal)
        While (worker.RequestDone = False)
            Thread.Sleep(500)
        End While
        Return worker.RetVal
    End Function

    Private Class ThreadWorker
        Private RemotingRequest As ClientRemoting
        Private retStr As String
        Private done As Boolean = False
        Public ReadOnly Property RetVal() As String
            Get
                Return retStr
            End Get
        End Property
        Public ReadOnly Property RequestDone() As String
            Get
                Return done
            End Get
        End Property
        Public Sub New(Request As ClientRemoting)
            done = False
            RemotingRequest = Request
        End Sub
        Public Sub DoRequestThreadInternal()
            done = False
            retStr = RemotingRequest.DoRequestSync()
            dotNetSimulatorUtilities.CallGraphFodder.Call1()
            done = True
        End Sub
    End Class

End Class
