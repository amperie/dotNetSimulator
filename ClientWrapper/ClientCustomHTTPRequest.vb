Imports System.Net
Imports System.Threading
Imports System.Net.Http


Public Class CustomWebClient
    Inherits WebClient
    Dim wc As New WebClient

    Public Overloads Function DownloadString(URL As String)

    End Function

End Class

Public Class ClientCustomHTTPRequest
    Inherits ClientRequest

    Protected URL As String
    Dim wc As New WebClient()

    Public Sub New(TargetURL As String, AsynchronousPattern As String, ExceptionInBT As Boolean, ExceptionAcrossBT As Boolean)
        Me.URL = TargetURL
        Me.AsyncPattern = AsynchronousPattern
        Me.ExcInBT = ExceptionInBT
        Me.ExcAcrossBT = ExceptionAcrossBT
    End Sub

    Protected Overrides Function DoRequestSync() As String

        Dim retVal As String = wc.DownloadString(URL)
        dotNetSimulatorUtilities.CallGraphFodder.Call1()
        Return retVal

    End Function

    Protected Overrides Async Function DoRequestAsync() As Task(Of String)

        dotNetSimulatorUtilities.CallGraphFodder.Call1()
        Dim retVal As String
        Dim client As New HttpClient
        Dim getStringTask As Task(Of String) = client.GetStringAsync(URL)
        retVal = Await getStringTask
        dotNetSimulatorUtilities.CallGraphFodder.Call1()
        Return retVal

    End Function

    Protected Overrides Function DoRequestThreadPool() As String

        dotNetSimulatorUtilities.CallGraphFodder.Call1()
        Dim worker As New ThreadPoolWorker(URL)
        ThreadPool.QueueUserWorkItem(AddressOf worker.DoRequestThreadPoolInternal)
        While (worker.RequestDone = False)
            Thread.Sleep(500)
        End While
        Return worker.RetVal

    End Function

    Protected Overrides Function DoRequestTask() As String

        dotNetSimulatorUtilities.CallGraphFodder.Call1()
        Dim worker As New ManualThreadWorker(URL)
        Dim tsk As New Task(AddressOf worker.DoRequestManualThreadInternal)
        tsk.Start()
        tsk.Wait()
        Return worker.RetVal

    End Function

    Protected Overrides Function DoRequestManualThread() As String

        dotNetSimulatorUtilities.CallGraphFodder.Call1()
        Dim worker As New ManualThreadWorker(URL)
        Dim thread As New Threading.Thread(AddressOf worker.DoRequestManualThreadInternal)
        thread.Start()
        thread.Join()
        Return worker.RetVal

    End Function

    Private Class ManualThreadWorker
        Private RetStr As String = ""
        Private URL As String
        Private wc As New WebClient()
        Public ReadOnly Property RetVal() As String
            Get
                Return RetStr
            End Get
        End Property
        Public Sub New(URL As String)
            Me.URL = URL
        End Sub
        Public Sub DoRequestManualThreadInternal()
            RetStr = wc.DownloadString(URL)
            dotNetSimulatorUtilities.CallGraphFodder.Call1()
        End Sub
    End Class

    Private Class ThreadPoolWorker
        Private RetStr As String = ""
        Private URL As String
        Private wc As New WebClient()
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
        Public Sub New(URL As String)
            done = False
            Me.URL = URL
        End Sub
        Public Sub DoRequestThreadPoolInternal()
            RetStr = wc.DownloadString(URL)
            dotNetSimulatorUtilities.CallGraphFodder.Call1()
            done = True
        End Sub
    End Class

End Class

