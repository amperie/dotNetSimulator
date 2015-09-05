Imports System.Timers

Public Class dotNetSimulatorClient

    Private T As Timers.Timer
    Private TickStillRunning As Boolean = False
    Dim req As ClientWrapper.ClientRequest

    Private Sub dotNetSimulatorClient_Load(sender As Object, e As EventArgs) Handles Me.Load
        T = New Timer()
        AddHandler T.Elapsed, New ElapsedEventHandler(AddressOf DoTimerTick)
    End Sub

    Private Sub txtRunOnce_Click(sender As Object, e As EventArgs) Handles btnRunOnce.Click
        MakeRequest()
        RunRequest()
    End Sub

    Private Sub btnRunTimer_Click(sender As Object, e As EventArgs) Handles btnRunTimer.Click

        If tabProtocol.Enabled Then
            EnableControls(False)
            btnRunTimer.Text = "Stop Timer"
            MakeRequest()
            T.Interval = CInt(txtTimerInterval.Text) * 1000
            T.Start()
            DoTimerTick()
        Else
            EnableControls(True)
            btnRunTimer.Text = "Run Timer"
            T.Stop()
        End If

    End Sub

    Private Sub DoTimerTick()
        If Not TickStillRunning Then
            TickStillRunning = True
            RunRequest()
            TickStillRunning = False
        End If
    End Sub

    Private Sub EnableControls(Enable As Boolean)
        tabProtocol.Enabled = Enable
        btnRunOnce.Enabled = Enable
        txtTimerInterval.Enabled = Enable
    End Sub

    Private Sub MakeRequest()
        Select Case tabProtocol.SelectedTab.Text
            Case "WCF"
                req = New ClientWrapper.ClientWCFRequest(wcfBindType.Text, _
                                                             wcfURL.Text, _
                                                             cmbAsyncMode.Text, _
                                                             chkExcInBT.Checked, _
                                                             chkExcAcrossBT.Checked)
            Case "HTTP"
                req = New ClientWrapper.ClientHTTPRequest(httpURL.Text, _
                                                            cmbAsyncMode.Text, _
                                                            chkExcInBT.Checked, _
                                                            chkExcAcrossBT.Checked)
            Case "Remoting"
                req = New ClientWrapper.ClientRemoting(remTransport.Text, _
                                                       remPort.Text, _
                                                       remURI.Text, _
                                                             cmbAsyncMode.Text, _
                                                             chkExcInBT.Checked, _
                                                             chkExcAcrossBT.Checked)
            Case Else
                req = Nothing
                txtOutput.Text = "Unsupported"
                Return
        End Select
    End Sub

    Private Sub RunRequest()
        SetText(req.DoRequest)
    End Sub

    Delegate Sub SetTextCallback([text] As String)
    Private Sub SetText(ByVal [text] As String)
        ' InvokeRequired required compares the thread ID of the
        ' calling thread to the thread ID of the creating thread.
        ' If these threads are different, it returns true.
        If Me.txtOutput.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            Me.Invoke(d, New Object() {Date.Now.ToShortTimeString + ": " + [text]})
        Else
            Me.txtOutput.Text = Date.Now.ToShortTimeString + ": " + [text]
        End If
    End Sub

    Private Sub wcfBindType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles wcfBindType.SelectedIndexChanged
        wcfUpdateURL()
    End Sub

    Private Sub wcfUpdateURL()
        Select Case wcfBindType.SelectedItem
            Case "WSHttpBinding"
                wcfURL.Text = "ws://localhost:7890/wcf"
            Case "BasicHttpBinding"
                wcfURL.Text = "http://localhost:7890/wcf"
            Case "NetTcpBinding"
                wcfURL.Text = "net.tcp://localhost:7890/wcf"
        End Select
    End Sub

End Class
