Imports System.Net
Imports System.Threading

Public Class ServerHTTP
    Inherits ServerListener

    Private Listen As New HTTPListener()
    Private URL As String
    Private ListenThread As Thread

    Public Sub SetURL(port As String, uri As String)
        URL = "http://localhost:" + port + "/" + uri + "/"
        Listen.Prefixes.Add(URL)
    End Sub

    Public Overrides Sub StartListening()
        _Listening = True
        Listen.AuthenticationSchemes = AuthenticationSchemes.Anonymous
        Listen.Start()
        ListenThread = New Thread(New ParameterizedThreadStart(AddressOf HandleRequest))
        ListenThread.Start()
    End Sub

    Public Overrides Sub StopListening()
        Listen.Stop()
        _Listening = False
        Listen.Close()
    End Sub

    Private Sub HandleRequest()
        Try
            While True
                Dim ctxt As HttpListenerContext
                ctxt = Listen.GetContext()
                HandleRequestInternal(ctxt)
                dotNetSimulatorUtilities.CallGraphFodder.Call1()
            End While
        Catch ex As Exception
            'TODO
        End Try
    End Sub

    Private Sub HandleRequestInternal(ctxt As HttpListenerContext)
        Dim resp As HttpListenerResponse = ctxt.Response
        Dim respStr As String = ""

        For Each header As String In ctxt.Request.Headers.AllKeys
            respStr = respStr + vbCrLf + header + ":" + ctxt.Request.Headers.Item(header)
        Next

        'forward request
        If Me.ForwardRequests Then
            respStr = respStr + vbCrLf + vbCrLf + RequestToForward.DoRequest()
        End If
        dotNetSimulatorUtilities.CallGraphFodder.Call1()

        Dim respBuffer As Byte() = System.Text.Encoding.UTF8.GetBytes(respStr)
        resp.ContentLength64 = respBuffer.Length
        Dim output As IO.Stream = resp.OutputStream
        output.Write(respBuffer, 0, respBuffer.Length)
        output.Close()
    End Sub

End Class