Option Strict Off

Imports ClientWrapper
Imports ServerWrapper

Public Class dotNetSimulatorServer

    Dim Listener As ServerListener

    Private Sub httpListen_Click(sender As Object, e As EventArgs) Handles btnListen.Click

        If btnListen.Text = "Start Listening" Then
            btnListen.Text = "Stop Listening"
            grpException.Enabled = False
            grpForward.Enabled = False
            grpListen.Enabled = False
            grpOutput.Enabled = False
            httpListenURL.Text = "http://localhost:" + httpPort.Text + "/" + httpURI.Text + "/"

            Listener = CreateServerListener()
            Listener.StartListening()

        Else
            btnListen.Text = "Start Listening"
            grpException.Enabled = True
            grpForward.Enabled = True
            grpListen.Enabled = True
            grpOutput.Enabled = True
            httpListenURL.Text = ""
            Listener.StopListening()
        End If

    End Sub

    Private Sub httpListenerLink() Handles httpListenURL.Click
        Process.Start(httpListenURL.Text)
    End Sub

    Private Function CreateServerListener() As ServerListener

        Select Case tabServer.SelectedTab.Text
            Case "WCF"
                Dim retVal As New ServerWCF
                retVal.SetEndpoint(wcfBindType.Text, wcfURL.Text)
                retVal.FwdRequests = chkEnableForwarding.Checked
                retVal.ForwardedRequest = CreateForwardClientRequest()
                Return retVal
            Case "HTTP"
                Dim retVal As New ServerHTTP
                retVal.SetURL(httpPort.Text, httpURI.Text)
                retVal.FwdRequests = chkEnableForwarding.Checked
                retVal.ForwardedRequest = CreateForwardClientRequest()
                Return retVal
            Case "Custom HTTP"
            Case "Remoting"
                Dim retVal As New ServerRemoting(remTransport.Text, remPort.Text, remURI.Text)
                retVal.FwdRequests = chkEnableForwarding.Checked
                retVal.ForwardedRequest = CreateForwardClientRequest()
                Return retVal
            Case "TCP"
        End Select

    End Function

    Private Function CreateForwardClientRequest() As ClientRequest

        If Not chkEnableForwarding.Checked Then Return Nothing
        Select Case tabForwardRequests.SelectedTab.Text
            Case "WCF"
                Return New ClientWrapper.ClientWCFRequest(wcfReqBind.Text, _
                                             wcfReqURL.Text, _
                                             cmbAsyncMode.Text, _
                                             chkExcInBT.Checked, _
                                             chkExcAcrossBT.Checked)
            Case "HTTP"
                Return New ClientHTTPRequest(fwdHTTPURL.Text, cmbAsyncMode.Text, _
                                                    chkExcInBT.Checked, chkExcAcrossBT.Checked)
            Case "Custom HTTP"
            Case "Remoting"
                Return New ClientRemoting(remReqTransport.Text, _
                                          remReqPort.Text, _
                                          remReqURI.Text, _
                                          cmbAsyncMode.Text, chkExcInBT.Checked, chkExcAcrossBT.Checked)
            Case "TCP"
        End Select
        Return Nothing

    End Function


    Delegate Sub SetTextCallback([text] As String)
    Private Sub SetText(ByVal [text] As String)

        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.txtOutput.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {[text]})
        Else
            Me.txtOutput.Text = [text]
        End If
    End Sub


    Private Sub wcfBindType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles wcfBindType.SelectedIndexChanged
        wcfUpdateURL()
    End Sub

    Private Sub wcfURL_TextChanged(sender As Object, e As EventArgs) Handles wcfURL.TextChanged
        wcfUpdateURL()
    End Sub

    Private Sub wcfUpdateURL()
        Select Case wcfBindType.SelectedItem
            Case "WSHttpBinding"
                wcfTargetURL.Text = "http://localhost:" + wcfURL.Text + "/wcf"
            Case "BasicHttpBinding"
                wcfTargetURL.Text = "http://localhost:" + wcfURL.Text + "/wcf"
            Case "NetTcpBinding"
                wcfTargetURL.Text = "net.tcp://localhost:" + wcfURL.Text + "/wcf"
        End Select
    End Sub

End Class
