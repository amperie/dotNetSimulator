Imports System.Net
Imports System.Threading
Imports System.Net.Http

Public Class RequestPayload
    Public strPayload As String = "Hello World"
End Class

Public MustInherit Class ClientRequest
    Protected AsyncPattern As String
    Protected ExcInBT As Boolean
    Protected ExcAcrossBT As Boolean
    Public ForwardedRequest As Boolean = False
    Public Payload As RequestPayload

    Public Function DoRequest() As String

        Dim retVal As String = ""

        Try
            retVal = DoRequestInternal()
        Catch ex As dotNetSimulatorExceptions.ClientAcrossBTBoundaryException
            dotNetSimulatorUtilities.Logger.WriteToLog("Caught AcrossBTException")
            dotNetSimulatorUtilities.Logger.LogException(ex)
            If ForwardedRequest Then
                'If we're on the server side and it's a forwarded request
                'rethrow this so it will cross bt boundaries
                'Throw ex
            End If
        End Try

        Return retVal

    End Function

    Public Function DoRequestInternal() As String
        'This should be the entry point of the BT in order for the exception throwing to work well

        'Throw and catch an exception inside the BT
        If Me.ExcInBT Then
            Try
                Throw New dotNetSimulatorExceptions.ClientInsideBTException
            Catch ex As Exception
                dotNetSimulatorUtilities.Logger.WriteToLog("Caught InsideBTException")
                dotNetSimulatorUtilities.Logger.LogException(ex)
            End Try
        End If

        dotNetSimulatorUtilities.CallGraphFodder.Call1()

        Dim retVal As String = "Unsupported Async Pattern"

        Select Case AsyncPattern
            Case "Synchronous"
                retVal = DoRequestSync()
            Case "Async/Await"
                Dim tsk As Task(Of String) = Task.Run(Async Function()
                                                          Return Await DoRequestAsync()
                                                      End Function)
                tsk.Wait()
                retVal = tsk.Result
            Case ".NET Thread Pool"
                retVal = DoRequestThreadPool()
            Case "Task"
                retVal = DoRequestTask()
            Case "Manual Thread"
                retVal = DoRequestManualThread()
        End Select

        dotNetSimulatorUtilities.CallGraphFodder.Call1()

        'Throw a cross BT boundary exception that will get caught by DoRequest
        'DoRequest should be outside the BT as the entry point should be DoRequestInternal
        If Me.ExcAcrossBT Then
            Throw New dotNetSimulatorExceptions.ClientAcrossBTBoundaryException
        End If

        Return retVal

    End Function

    'These functions are protocol specific
    Protected MustOverride Function DoRequestSync() As String
    Protected MustOverride Function DoRequestThreadPool() As String
    Protected MustOverride Function DoRequestTask() As String
    Protected MustOverride Function DoRequestManualThread() As String
    Protected MustOverride Function DoRequestAsync() As Task(Of String)


End Class