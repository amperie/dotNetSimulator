<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dotNetSimulatorClient
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpProtocol = New System.Windows.Forms.GroupBox()
        Me.tabProtocol = New System.Windows.Forms.TabControl()
        Me.tabWCF = New System.Windows.Forms.TabPage()
        Me.wcfURL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.wcfBindType = New System.Windows.Forms.ComboBox()
        Me.tabHTTP = New System.Windows.Forms.TabPage()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.httpURL = New System.Windows.Forms.TextBox()
        Me.tabCHTTP = New System.Windows.Forms.TabPage()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCustomURL = New System.Windows.Forms.TextBox()
        Me.tabRemoting = New System.Windows.Forms.TabPage()
        Me.remURI = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.remPort = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Transport = New System.Windows.Forms.Label()
        Me.remTransport = New System.Windows.Forms.ComboBox()
        Me.tabTCP = New System.Windows.Forms.TabPage()
        Me.grpAsync = New System.Windows.Forms.GroupBox()
        Me.cmbAsyncMode = New System.Windows.Forms.ComboBox()
        Me.grpException = New System.Windows.Forms.GroupBox()
        Me.chkExcAcrossBT = New System.Windows.Forms.CheckBox()
        Me.chkExcInBT = New System.Windows.Forms.CheckBox()
        Me.grpRun = New System.Windows.Forms.GroupBox()
        Me.btnRunOnce = New System.Windows.Forms.Button()
        Me.btnRunTimer = New System.Windows.Forms.Button()
        Me.lblInterval = New System.Windows.Forms.Label()
        Me.txtTimerInterval = New System.Windows.Forms.TextBox()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.grpProtocol.SuspendLayout()
        Me.tabProtocol.SuspendLayout()
        Me.tabWCF.SuspendLayout()
        Me.tabHTTP.SuspendLayout()
        Me.tabCHTTP.SuspendLayout()
        Me.tabRemoting.SuspendLayout()
        Me.grpAsync.SuspendLayout()
        Me.grpException.SuspendLayout()
        Me.grpRun.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpProtocol
        '
        Me.grpProtocol.Controls.Add(Me.tabProtocol)
        Me.grpProtocol.Location = New System.Drawing.Point(12, 12)
        Me.grpProtocol.Name = "grpProtocol"
        Me.grpProtocol.Size = New System.Drawing.Size(495, 217)
        Me.grpProtocol.TabIndex = 0
        Me.grpProtocol.TabStop = False
        Me.grpProtocol.Text = "Protocol"
        '
        'tabProtocol
        '
        Me.tabProtocol.Controls.Add(Me.tabWCF)
        Me.tabProtocol.Controls.Add(Me.tabHTTP)
        Me.tabProtocol.Controls.Add(Me.tabCHTTP)
        Me.tabProtocol.Controls.Add(Me.tabRemoting)
        Me.tabProtocol.Controls.Add(Me.tabTCP)
        Me.tabProtocol.Location = New System.Drawing.Point(6, 16)
        Me.tabProtocol.Name = "tabProtocol"
        Me.tabProtocol.SelectedIndex = 0
        Me.tabProtocol.Size = New System.Drawing.Size(478, 195)
        Me.tabProtocol.TabIndex = 0
        '
        'tabWCF
        '
        Me.tabWCF.Controls.Add(Me.wcfURL)
        Me.tabWCF.Controls.Add(Me.Label2)
        Me.tabWCF.Controls.Add(Me.Label1)
        Me.tabWCF.Controls.Add(Me.wcfBindType)
        Me.tabWCF.Location = New System.Drawing.Point(4, 22)
        Me.tabWCF.Name = "tabWCF"
        Me.tabWCF.Padding = New System.Windows.Forms.Padding(3)
        Me.tabWCF.Size = New System.Drawing.Size(470, 169)
        Me.tabWCF.TabIndex = 0
        Me.tabWCF.Text = "WCF"
        Me.tabWCF.UseVisualStyleBackColor = True
        '
        'wcfURL
        '
        Me.wcfURL.Location = New System.Drawing.Point(36, 47)
        Me.wcfURL.Name = "wcfURL"
        Me.wcfURL.Size = New System.Drawing.Size(188, 20)
        Me.wcfURL.TabIndex = 3
        Me.wcfURL.Text = "http://localhost:7890/wcf"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "URL"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Binding Type"
        '
        'wcfBindType
        '
        Me.wcfBindType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.wcfBindType.FormattingEnabled = True
        Me.wcfBindType.Items.AddRange(New Object() {"BasicHttpBinding", "NetTcpBinding"})
        Me.wcfBindType.Location = New System.Drawing.Point(81, 17)
        Me.wcfBindType.Name = "wcfBindType"
        Me.wcfBindType.Size = New System.Drawing.Size(144, 21)
        Me.wcfBindType.TabIndex = 0
        '
        'tabHTTP
        '
        Me.tabHTTP.Controls.Add(Me.Label3)
        Me.tabHTTP.Controls.Add(Me.httpURL)
        Me.tabHTTP.Location = New System.Drawing.Point(4, 22)
        Me.tabHTTP.Name = "tabHTTP"
        Me.tabHTTP.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHTTP.Size = New System.Drawing.Size(470, 169)
        Me.tabHTTP.TabIndex = 1
        Me.tabHTTP.Text = "HTTP"
        Me.tabHTTP.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "URL"
        '
        'httpURL
        '
        Me.httpURL.Location = New System.Drawing.Point(43, 9)
        Me.httpURL.Name = "httpURL"
        Me.httpURL.Size = New System.Drawing.Size(328, 20)
        Me.httpURL.TabIndex = 2
        Me.httpURL.Text = "http://localhost:8080/uri"
        '
        'tabCHTTP
        '
        Me.tabCHTTP.Controls.Add(Me.Label4)
        Me.tabCHTTP.Controls.Add(Me.txtCustomURL)
        Me.tabCHTTP.Location = New System.Drawing.Point(4, 22)
        Me.tabCHTTP.Name = "tabCHTTP"
        Me.tabCHTTP.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCHTTP.Size = New System.Drawing.Size(470, 169)
        Me.tabCHTTP.TabIndex = 4
        Me.tabCHTTP.Text = "Custom HTTP"
        Me.tabCHTTP.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "URL"
        '
        'txtCustomURL
        '
        Me.txtCustomURL.Location = New System.Drawing.Point(43, 9)
        Me.txtCustomURL.Name = "txtCustomURL"
        Me.txtCustomURL.Size = New System.Drawing.Size(328, 20)
        Me.txtCustomURL.TabIndex = 4
        Me.txtCustomURL.Text = "http://localhost:8080/uri"
        '
        'tabRemoting
        '
        Me.tabRemoting.Controls.Add(Me.remURI)
        Me.tabRemoting.Controls.Add(Me.Label12)
        Me.tabRemoting.Controls.Add(Me.remPort)
        Me.tabRemoting.Controls.Add(Me.Label13)
        Me.tabRemoting.Controls.Add(Me.Label14)
        Me.tabRemoting.Controls.Add(Me.Transport)
        Me.tabRemoting.Controls.Add(Me.remTransport)
        Me.tabRemoting.Location = New System.Drawing.Point(4, 22)
        Me.tabRemoting.Name = "tabRemoting"
        Me.tabRemoting.Size = New System.Drawing.Size(470, 169)
        Me.tabRemoting.TabIndex = 2
        Me.tabRemoting.Text = "Remoting"
        Me.tabRemoting.UseVisualStyleBackColor = True
        '
        'remURI
        '
        Me.remURI.Location = New System.Drawing.Point(44, 40)
        Me.remURI.Name = "remURI"
        Me.remURI.Size = New System.Drawing.Size(188, 20)
        Me.remURI.TabIndex = 17
        Me.remURI.Text = "RemoteObject.rem"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 16
        '
        'remPort
        '
        Me.remPort.Location = New System.Drawing.Point(43, 66)
        Me.remPort.Name = "remPort"
        Me.remPort.Size = New System.Drawing.Size(188, 20)
        Me.remPort.TabIndex = 15
        Me.remPort.Text = "9090"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(15, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "Port"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(12, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "URI"
        '
        'Transport
        '
        Me.Transport.AutoSize = True
        Me.Transport.Location = New System.Drawing.Point(12, 15)
        Me.Transport.Name = "Transport"
        Me.Transport.Size = New System.Drawing.Size(52, 13)
        Me.Transport.TabIndex = 12
        Me.Transport.Text = "Transport"
        '
        'remTransport
        '
        Me.remTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.remTransport.FormattingEnabled = True
        Me.remTransport.Items.AddRange(New Object() {"HTTP", "TCP"})
        Me.remTransport.Location = New System.Drawing.Point(70, 12)
        Me.remTransport.Name = "remTransport"
        Me.remTransport.Size = New System.Drawing.Size(144, 21)
        Me.remTransport.TabIndex = 11
        '
        'tabTCP
        '
        Me.tabTCP.Location = New System.Drawing.Point(4, 22)
        Me.tabTCP.Name = "tabTCP"
        Me.tabTCP.Size = New System.Drawing.Size(470, 169)
        Me.tabTCP.TabIndex = 3
        Me.tabTCP.Text = "TCP"
        Me.tabTCP.UseVisualStyleBackColor = True
        '
        'grpAsync
        '
        Me.grpAsync.Controls.Add(Me.cmbAsyncMode)
        Me.grpAsync.Location = New System.Drawing.Point(13, 235)
        Me.grpAsync.Name = "grpAsync"
        Me.grpAsync.Size = New System.Drawing.Size(240, 47)
        Me.grpAsync.TabIndex = 1
        Me.grpAsync.TabStop = False
        Me.grpAsync.Text = "Async Pattern"
        '
        'cmbAsyncMode
        '
        Me.cmbAsyncMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAsyncMode.FormattingEnabled = True
        Me.cmbAsyncMode.Items.AddRange(New Object() {"Synchronous", "Async/Await", ".NET Thread Pool", "Task", "Manual Thread"})
        Me.cmbAsyncMode.Location = New System.Drawing.Point(5, 18)
        Me.cmbAsyncMode.Name = "cmbAsyncMode"
        Me.cmbAsyncMode.Size = New System.Drawing.Size(229, 21)
        Me.cmbAsyncMode.TabIndex = 5
        '
        'grpException
        '
        Me.grpException.Controls.Add(Me.chkExcAcrossBT)
        Me.grpException.Controls.Add(Me.chkExcInBT)
        Me.grpException.Location = New System.Drawing.Point(11, 288)
        Me.grpException.Name = "grpException"
        Me.grpException.Size = New System.Drawing.Size(242, 70)
        Me.grpException.TabIndex = 2
        Me.grpException.TabStop = False
        Me.grpException.Text = "Exceptions"
        '
        'chkExcAcrossBT
        '
        Me.chkExcAcrossBT.AutoSize = True
        Me.chkExcAcrossBT.Location = New System.Drawing.Point(19, 45)
        Me.chkExcAcrossBT.Name = "chkExcAcrossBT"
        Me.chkExcAcrossBT.Size = New System.Drawing.Size(189, 17)
        Me.chkExcAcrossBT.TabIndex = 1
        Me.chkExcAcrossBT.Text = "Throw/Catch Across BT Boundary"
        Me.chkExcAcrossBT.UseVisualStyleBackColor = True
        '
        'chkExcInBT
        '
        Me.chkExcInBT.AutoSize = True
        Me.chkExcInBT.Location = New System.Drawing.Point(19, 22)
        Me.chkExcInBT.Name = "chkExcInBT"
        Me.chkExcInBT.Size = New System.Drawing.Size(137, 17)
        Me.chkExcInBT.TabIndex = 0
        Me.chkExcInBT.Text = "Throw/Catch Inside BT"
        Me.chkExcInBT.UseVisualStyleBackColor = True
        '
        'grpRun
        '
        Me.grpRun.Controls.Add(Me.btnRunOnce)
        Me.grpRun.Controls.Add(Me.btnRunTimer)
        Me.grpRun.Controls.Add(Me.lblInterval)
        Me.grpRun.Controls.Add(Me.txtTimerInterval)
        Me.grpRun.Location = New System.Drawing.Point(265, 235)
        Me.grpRun.Name = "grpRun"
        Me.grpRun.Size = New System.Drawing.Size(242, 123)
        Me.grpRun.TabIndex = 3
        Me.grpRun.TabStop = False
        Me.grpRun.Text = "Run"
        '
        'btnRunOnce
        '
        Me.btnRunOnce.Location = New System.Drawing.Point(16, 88)
        Me.btnRunOnce.Name = "btnRunOnce"
        Me.btnRunOnce.Size = New System.Drawing.Size(201, 27)
        Me.btnRunOnce.TabIndex = 3
        Me.btnRunOnce.Text = "Run Once"
        Me.btnRunOnce.UseVisualStyleBackColor = True
        '
        'btnRunTimer
        '
        Me.btnRunTimer.Location = New System.Drawing.Point(16, 55)
        Me.btnRunTimer.Name = "btnRunTimer"
        Me.btnRunTimer.Size = New System.Drawing.Size(201, 27)
        Me.btnRunTimer.TabIndex = 2
        Me.btnRunTimer.Text = "Run Timer"
        Me.btnRunTimer.UseVisualStyleBackColor = True
        '
        'lblInterval
        '
        Me.lblInterval.AutoSize = True
        Me.lblInterval.Location = New System.Drawing.Point(8, 26)
        Me.lblInterval.Name = "lblInterval"
        Me.lblInterval.Size = New System.Drawing.Size(120, 13)
        Me.lblInterval.TabIndex = 1
        Me.lblInterval.Text = "Timer Interval (seconds)"
        '
        'txtTimerInterval
        '
        Me.txtTimerInterval.Location = New System.Drawing.Point(128, 23)
        Me.txtTimerInterval.Name = "txtTimerInterval"
        Me.txtTimerInterval.Size = New System.Drawing.Size(48, 20)
        Me.txtTimerInterval.TabIndex = 0
        Me.txtTimerInterval.Text = "15"
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.txtOutput)
        Me.grpOutput.Location = New System.Drawing.Point(13, 366)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(493, 225)
        Me.grpOutput.TabIndex = 4
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(13, 18)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(470, 206)
        Me.txtOutput.TabIndex = 0
        '
        'dotNetSimulatorClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(519, 603)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.grpRun)
        Me.Controls.Add(Me.grpException)
        Me.Controls.Add(Me.grpAsync)
        Me.Controls.Add(Me.grpProtocol)
        Me.Name = "dotNetSimulatorClient"
        Me.Text = "dotNetSimulator Client"
        Me.grpProtocol.ResumeLayout(False)
        Me.tabProtocol.ResumeLayout(False)
        Me.tabWCF.ResumeLayout(False)
        Me.tabWCF.PerformLayout()
        Me.tabHTTP.ResumeLayout(False)
        Me.tabHTTP.PerformLayout()
        Me.tabCHTTP.ResumeLayout(False)
        Me.tabCHTTP.PerformLayout()
        Me.tabRemoting.ResumeLayout(False)
        Me.tabRemoting.PerformLayout()
        Me.grpAsync.ResumeLayout(False)
        Me.grpException.ResumeLayout(False)
        Me.grpException.PerformLayout()
        Me.grpRun.ResumeLayout(False)
        Me.grpRun.PerformLayout()
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpProtocol As System.Windows.Forms.GroupBox
    Friend WithEvents tabProtocol As System.Windows.Forms.TabControl
    Friend WithEvents tabWCF As System.Windows.Forms.TabPage
    Friend WithEvents tabHTTP As System.Windows.Forms.TabPage
    Friend WithEvents tabRemoting As System.Windows.Forms.TabPage
    Friend WithEvents tabTCP As System.Windows.Forms.TabPage
    Friend WithEvents grpAsync As System.Windows.Forms.GroupBox
    Friend WithEvents grpException As System.Windows.Forms.GroupBox
    Friend WithEvents tabCHTTP As System.Windows.Forms.TabPage
    Friend WithEvents chkExcAcrossBT As System.Windows.Forms.CheckBox
    Friend WithEvents chkExcInBT As System.Windows.Forms.CheckBox
    Friend WithEvents grpRun As System.Windows.Forms.GroupBox
    Friend WithEvents btnRunOnce As System.Windows.Forms.Button
    Friend WithEvents btnRunTimer As System.Windows.Forms.Button
    Friend WithEvents lblInterval As System.Windows.Forms.Label
    Friend WithEvents txtTimerInterval As System.Windows.Forms.TextBox
    Friend WithEvents grpOutput As System.Windows.Forms.GroupBox
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents cmbAsyncMode As System.Windows.Forms.ComboBox
    Friend WithEvents wcfURL As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents wcfBindType As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents httpURL As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCustomURL As System.Windows.Forms.TextBox
    Friend WithEvents remURI As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents remPort As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Transport As System.Windows.Forms.Label
    Friend WithEvents remTransport As System.Windows.Forms.ComboBox

End Class
