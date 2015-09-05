Imports System.ServiceModel
Imports System.Threading

Public Class ClientWCFRequest
    Inherits ClientRequest

    Private _Client As dotNetSimulatorUtilities.ServerWCFInterface
    Private _BindType As String
    Private _URL As String

    Public Sub New(BindingType As String, URL As String, AsynchronousPattern As String, ExceptionInBT As Boolean, ExceptionAcrossBT As Boolean)

        Me.AsyncPattern = AsynchronousPattern
        Me.ExcInBT = ExceptionInBT
        Me.ExcAcrossBT = ExceptionAcrossBT
        _BindType = BindingType
        _URL = URL
        Dim Endpoint As New EndpointAddress(URL)
        Dim _ChannelFactory As ChannelFactory(Of dotNetSimulatorUtilities.ServerWCFInterface)

        Select Case BindingType
            Case "WSHttpBinding"
                _ChannelFactory = New ChannelFactory(Of dotNetSimulatorUtilities.ServerWCFInterface)(New WSHttpBinding, Endpoint)
            Case "NetTcpBinding"
                _ChannelFactory = New ChannelFactory(Of dotNetSimulatorUtilities.ServerWCFInterface)(New NetTcpBinding, Endpoint)
            Case "BasicHttpBinding"
                _ChannelFactory = New ChannelFactory(Of dotNetSimulatorUtilities.ServerWCFInterface)(New BasicHttpBinding, Endpoint)
            Case Else
                _ChannelFactory = New ChannelFactory(Of dotNetSimulatorUtilities.ServerWCFInterface)(New WSHttpBinding, Endpoint)
        End Select
        _Client = _ChannelFactory.CreateChannel()

    End Sub

    Protected Overrides Function DoRequestSync() As String
        dotNetSimulatorUtilities.CallGraphFodder.Call1()
        Return _Client.ServerWCFCall()
    End Function

    Protected Overrides Function DoRequestThreadPool() As String
        dotNetSimulatorUtilities.CallGraphFodder.Call1()
        Dim worker As New ThreadPoolWorker(_Client)
        ThreadPool.QueueUserWorkItem(AddressOf worker.DoRequestThreadPoolInternal)
        While (worker.RequestDone = False)
            Thread.Sleep(500)
        End While
        Return worker.RetVal
    End Function

    Protected Overrides Function DoRequestTask() As String
        dotNetSimulatorUtilities.CallGraphFodder.Call1()
        Dim worker As New ManualThreadWorker(_Client)
        Dim tsk As New Task(AddressOf worker.DoRequestManualThreadInternal)
        tsk.Start()
        tsk.Wait()
        Return worker.RetVal
    End Function

    Protected Overrides Function DoRequestManualThread() As String
        dotNetSimulatorUtilities.CallGraphFodder.Call1()
        Dim worker As New ManualThreadWorker(_Client)
        Dim thread As New Threading.Thread(AddressOf worker.DoRequestManualThreadInternal)
        thread.Start()
        thread.Join()
        Return worker.RetVal
    End Function

    Protected Overrides Async Function DoRequestAsync() As Task(Of String)
        dotNetSimulatorUtilities.CallGraphFodder.Call1()
        Dim retVal As String
        Dim WCFAsyncTask As Task(Of String) = _Client.AsyncServerWCFCall()
        retVal = Await WCFAsyncTask
        dotNetSimulatorUtilities.CallGraphFodder.Call1()
        Return retVal
    End Function

    Private Class ManualThreadWorker
        Private RetStr As String = ""
        Private _Client As dotNetSimulatorUtilities.ServerWCFInterface
        Public ReadOnly Property RetVal() As String
            Get
                Return RetStr
            End Get
        End Property
        Public Sub New(Client As dotNetSimulatorUtilities.ServerWCFInterface)
            _Client = Client
        End Sub
        Public Sub DoRequestManualThreadInternal()
            RetStr = _Client.ServerWCFCall()
            dotNetSimulatorUtilities.CallGraphFodder.Call1()
        End Sub
    End Class

    Private Class ThreadPoolWorker
        Private RetStr As String = ""
        Private _Client As dotNetSimulatorUtilities.ServerWCFInterface
        Private done As Boolean = False
        Public ReadOnly Property RetVal() As String
            Get
                Return RetStr
            End Get
        End Property
        Public ReadOnly Property RequestDone() As String
            Get
                Return done
            End Get
        End Property
        Public Sub New(Client As dotNetSimulatorUtilities.ServerWCFInterface)
            done = False
            _Client = Client
        End Sub
        Public Sub DoRequestThreadPoolInternal()
            RetStr = _Client.ServerWCFCall
            dotNetSimulatorUtilities.CallGraphFodder.Call1()
            done = True
        End Sub
    End Class

End Class
