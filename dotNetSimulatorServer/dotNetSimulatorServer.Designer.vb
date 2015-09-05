<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dotNetSimulatorServer
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
        Me.tabServer = New System.Windows.Forms.TabControl()
        Me.tabWCF = New System.Windows.Forms.TabPage()
        Me.wcfTargetURL = New System.Windows.Forms.Label()
        Me.wcfURL = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.wcfBindType = New System.Windows.Forms.ComboBox()
        Me.tabHTTP = New System.Windows.Forms.TabPage()
        Me.httpListenURL = New System.Windows.Forms.LinkLabel()
        Me.httpURI = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.httpPort = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tabCHTTP = New System.Windows.Forms.TabPage()
        Me.chttpURI = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.chttpPort = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tabRemoting = New System.Windows.Forms.TabPage()
        Me.remURI = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.remPort = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Transport = New System.Windows.Forms.Label()
        Me.remTransport = New System.Windows.Forms.ComboBox()
        Me.tabTCP = New System.Windows.Forms.TabPage()
        Me.tcpPort = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnListen = New System.Windows.Forms.Button()
        Me.tabForwardRequests = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.wcfReqURL = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.wcfReqBind = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.fwdHTTPURL = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.remReqURI = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.remReqPort = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.remReqTransport = New System.Windows.Forms.ComboBox()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.grpListen = New System.Windows.Forms.GroupBox()
        Me.grpForward = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbAsyncMode = New System.Windows.Forms.ComboBox()
        Me.chkEnableForwarding = New System.Windows.Forms.CheckBox()
        Me.grpOutput = New System.Windows.Forms.GroupBox()
        Me.txtOutput = New System.Windows.Forms.TextBox()
        Me.grpException = New System.Windows.Forms.GroupBox()
        Me.chkExcAcrossBT = New System.Windows.Forms.CheckBox()
        Me.chkExcInBT = New System.Windows.Forms.CheckBox()
        Me.tabServer.SuspendLayout()
        Me.tabWCF.SuspendLayout()
        Me.tabHTTP.SuspendLayout()
        Me.tabCHTTP.SuspendLayout()
        Me.tabRemoting.SuspendLayout()
        Me.tabTCP.SuspendLayout()
        Me.tabForwardRequests.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.grpListen.SuspendLayout()
        Me.grpForward.SuspendLayout()
        Me.grpOutput.SuspendLayout()
        Me.grpException.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabServer
        '
        Me.tabServer.Controls.Add(Me.tabWCF)
        Me.tabServer.Controls.Add(Me.tabHTTP)
        Me.tabServer.Controls.Add(Me.tabCHTTP)
        Me.tabServer.Controls.Add(Me.tabRemoting)
        Me.tabServer.Controls.Add(Me.tabTCP)
        Me.tabServer.Location = New System.Drawing.Point(6, 19)
        Me.tabServer.Name = "tabServer"
        Me.tabServer.SelectedIndex = 0
        Me.tabServer.Size = New System.Drawing.Size(394, 171)
        Me.tabServer.TabIndex = 1
        '
        'tabWCF
        '
        Me.tabWCF.Controls.Add(Me.wcfTargetURL)
        Me.tabWCF.Controls.Add(Me.wcfURL)
        Me.tabWCF.Controls.Add(Me.Label2)
        Me.tabWCF.Controls.Add(Me.Label1)
        Me.tabWCF.Controls.Add(Me.wcfBindType)
        Me.tabWCF.Location = New System.Drawing.Point(4, 22)
        Me.tabWCF.Name = "tabWCF"
        Me.tabWCF.Padding = New System.Windows.Forms.Padding(3)
        Me.tabWCF.Size = New System.Drawing.Size(386, 145)
        Me.tabWCF.TabIndex = 0
        Me.tabWCF.Text = "WCF"
        Me.tabWCF.UseVisualStyleBackColor = True
        '
        'wcfTargetURL
        '
        Me.wcfTargetURL.AutoSize = True
        Me.wcfTargetURL.Location = New System.Drawing.Point(16, 77)
        Me.wcfTargetURL.Name = "wcfTargetURL"
        Me.wcfTargetURL.Size = New System.Drawing.Size(0, 13)
        Me.wcfTargetURL.TabIndex = 4
        '
        'wcfURL
        '
        Me.wcfURL.Location = New System.Drawing.Point(36, 47)
        Me.wcfURL.Name = "wcfURL"
        Me.wcfURL.Size = New System.Drawing.Size(188, 20)
        Me.wcfURL.TabIndex = 3
        Me.wcfURL.Text = "7890"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Port"
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
        Me.tabHTTP.Controls.Add(Me.httpListenURL)
        Me.tabHTTP.Controls.Add(Me.httpURI)
        Me.tabHTTP.Controls.Add(Me.Label6)
        Me.tabHTTP.Controls.Add(Me.httpPort)
        Me.tabHTTP.Controls.Add(Me.Label5)
        Me.tabHTTP.Location = New System.Drawing.Point(4, 22)
        Me.tabHTTP.Name = "tabHTTP"
        Me.tabHTTP.Padding = New System.Windows.Forms.Padding(3)
        Me.tabHTTP.Size = New System.Drawing.Size(386, 145)
        Me.tabHTTP.TabIndex = 1
        Me.tabHTTP.Text = "HTTP"
        Me.tabHTTP.UseVisualStyleBackColor = True
        '
        'httpListenURL
        '
        Me.httpListenURL.AutoSize = True
        Me.httpListenURL.Location = New System.Drawing.Point(38, 62)
        Me.httpListenURL.Name = "httpListenURL"
        Me.httpListenURL.Size = New System.Drawing.Size(0, 13)
        Me.httpListenURL.TabIndex = 9
        '
        'httpURI
        '
        Me.httpURI.Location = New System.Drawing.Point(35, 32)
        Me.httpURI.Name = "httpURI"
        Me.httpURI.Size = New System.Drawing.Size(188, 20)
        Me.httpURI.TabIndex = 7
        Me.httpURI.Text = "uri"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "URI"
        '
        'httpPort
        '
        Me.httpPort.Location = New System.Drawing.Point(35, 6)
        Me.httpPort.Name = "httpPort"
        Me.httpPort.Size = New System.Drawing.Size(188, 20)
        Me.httpPort.TabIndex = 5
        Me.httpPort.Text = "8080"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Port"
        '
        'tabCHTTP
        '
        Me.tabCHTTP.Controls.Add(Me.chttpURI)
        Me.tabCHTTP.Controls.Add(Me.Label7)
        Me.tabCHTTP.Controls.Add(Me.chttpPort)
        Me.tabCHTTP.Controls.Add(Me.Label8)
        Me.tabCHTTP.Location = New System.Drawing.Point(4, 22)
        Me.tabCHTTP.Name = "tabCHTTP"
        Me.tabCHTTP.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCHTTP.Size = New System.Drawing.Size(386, 145)
        Me.tabCHTTP.TabIndex = 4
        Me.tabCHTTP.Text = "Custom HTTP"
        Me.tabCHTTP.UseVisualStyleBackColor = True
        '
        'chttpURI
        '
        Me.chttpURI.Location = New System.Drawing.Point(36, 32)
        Me.chttpURI.Name = "chttpURI"
        Me.chttpURI.Size = New System.Drawing.Size(188, 20)
        Me.chttpURI.TabIndex = 11
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 35)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "URI"
        '
        'chttpPort
        '
        Me.chttpPort.Location = New System.Drawing.Point(36, 6)
        Me.chttpPort.Name = "chttpPort"
        Me.chttpPort.Size = New System.Drawing.Size(188, 20)
        Me.chttpPort.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(26, 13)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "Port"
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
        Me.tabRemoting.Size = New System.Drawing.Size(386, 145)
        Me.tabRemoting.TabIndex = 2
        Me.tabRemoting.Text = "Remoting"
        Me.tabRemoting.UseVisualStyleBackColor = True
        '
        'remURI
        '
        Me.remURI.Location = New System.Drawing.Point(37, 40)
        Me.remURI.Name = "remURI"
        Me.remURI.Size = New System.Drawing.Size(188, 20)
        Me.remURI.TabIndex = 10
        Me.remURI.Text = "RemoteObject.rem"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 99)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(0, 13)
        Me.Label12.TabIndex = 9
        '
        'remPort
        '
        Me.remPort.Location = New System.Drawing.Point(36, 66)
        Me.remPort.Name = "remPort"
        Me.remPort.Size = New System.Drawing.Size(188, 20)
        Me.remPort.TabIndex = 8
        Me.remPort.Text = "9090"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(8, 69)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(26, 13)
        Me.Label13.TabIndex = 7
        Me.Label13.Text = "Port"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(5, 43)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(26, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "URI"
        '
        'Transport
        '
        Me.Transport.AutoSize = True
        Me.Transport.Location = New System.Drawing.Point(5, 15)
        Me.Transport.Name = "Transport"
        Me.Transport.Size = New System.Drawing.Size(52, 13)
        Me.Transport.TabIndex = 2
        Me.Transport.Text = "Transport"
        '
        'remTransport
        '
        Me.remTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.remTransport.FormattingEnabled = True
        Me.remTransport.Items.AddRange(New Object() {"HTTP", "TCP"})
        Me.remTransport.Location = New System.Drawing.Point(63, 12)
        Me.remTransport.Name = "remTransport"
        Me.remTransport.Size = New System.Drawing.Size(144, 21)
        Me.remTransport.TabIndex = 1
        '
        'tabTCP
        '
        Me.tabTCP.Controls.Add(Me.tcpPort)
        Me.tabTCP.Controls.Add(Me.Label9)
        Me.tabTCP.Location = New System.Drawing.Point(4, 22)
        Me.tabTCP.Name = "tabTCP"
        Me.tabTCP.Size = New System.Drawing.Size(386, 145)
        Me.tabTCP.TabIndex = 3
        Me.tabTCP.Text = "TCP"
        Me.tabTCP.UseVisualStyleBackColor = True
        '
        'tcpPort
        '
        Me.tcpPort.Location = New System.Drawing.Point(36, 13)
        Me.tcpPort.Name = "tcpPort"
        Me.tcpPort.Size = New System.Drawing.Size(188, 20)
        Me.tcpPort.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Port"
        '
        'btnListen
        '
        Me.btnListen.Location = New System.Drawing.Point(257, 220)
        Me.btnListen.Name = "btnListen"
        Me.btnListen.Size = New System.Drawing.Size(148, 63)
        Me.btnListen.TabIndex = 8
        Me.btnListen.Text = "Start Listening"
        Me.btnListen.UseVisualStyleBackColor = True
        '
        'tabForwardRequests
        '
        Me.tabForwardRequests.Controls.Add(Me.TabPage1)
        Me.tabForwardRequests.Controls.Add(Me.TabPage2)
        Me.tabForwardRequests.Controls.Add(Me.TabPage3)
        Me.tabForwardRequests.Controls.Add(Me.TabPage4)
        Me.tabForwardRequests.Controls.Add(Me.TabPage5)
        Me.tabForwardRequests.Location = New System.Drawing.Point(6, 44)
        Me.tabForwardRequests.Name = "tabForwardRequests"
        Me.tabForwardRequests.SelectedIndex = 0
        Me.tabForwardRequests.Size = New System.Drawing.Size(394, 171)
        Me.tabForwardRequests.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.wcfReqURL)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.wcfReqBind)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(386, 145)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "WCF"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'wcfReqURL
        '
        Me.wcfReqURL.Location = New System.Drawing.Point(36, 47)
        Me.wcfReqURL.Name = "wcfReqURL"
        Me.wcfReqURL.Size = New System.Drawing.Size(188, 20)
        Me.wcfReqURL.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "URL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Binding Type"
        '
        'wcfReqBind
        '
        Me.wcfReqBind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.wcfReqBind.FormattingEnabled = True
        Me.wcfReqBind.Items.AddRange(New Object() {"BasicHttpBinding", "NetTcpBinding"})
        Me.wcfReqBind.Location = New System.Drawing.Point(81, 17)
        Me.wcfReqBind.Name = "wcfReqBind"
        Me.wcfReqBind.Size = New System.Drawing.Size(144, 21)
        Me.wcfReqBind.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.fwdHTTPURL)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(386, 145)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "HTTP"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(2, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 13)
        Me.Label11.TabIndex = 5
        Me.Label11.Text = "URL"
        '
        'fwdHTTPURL
        '
        Me.fwdHTTPURL.Location = New System.Drawing.Point(37, 6)
        Me.fwdHTTPURL.Name = "fwdHTTPURL"
        Me.fwdHTTPURL.Size = New System.Drawing.Size(328, 20)
        Me.fwdHTTPURL.TabIndex = 4
        Me.fwdHTTPURL.Text = "http://appdynamics.com"
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(386, 145)
        Me.TabPage3.TabIndex = 4
        Me.TabPage3.Text = "Custom HTTP"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.remReqURI)
        Me.TabPage4.Controls.Add(Me.Label15)
        Me.TabPage4.Controls.Add(Me.remReqPort)
        Me.TabPage4.Controls.Add(Me.Label16)
        Me.TabPage4.Controls.Add(Me.Label17)
        Me.TabPage4.Controls.Add(Me.Label18)
        Me.TabPage4.Controls.Add(Me.remReqTransport)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(386, 145)
        Me.TabPage4.TabIndex = 2
        Me.TabPage4.Text = "Remoting"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'remReqURI
        '
        Me.remReqURI.Location = New System.Drawing.Point(38, 42)
        Me.remReqURI.Name = "remReqURI"
        Me.remReqURI.Size = New System.Drawing.Size(188, 20)
        Me.remReqURI.TabIndex = 24
        Me.remReqURI.Text = "RemoteObject.rem"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(15, 101)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(0, 13)
        Me.Label15.TabIndex = 23
        '
        'remReqPort
        '
        Me.remReqPort.Location = New System.Drawing.Point(37, 68)
        Me.remReqPort.Name = "remReqPort"
        Me.remReqPort.Size = New System.Drawing.Size(188, 20)
        Me.remReqPort.TabIndex = 22
        Me.remReqPort.Text = "9090"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 71)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(26, 13)
        Me.Label16.TabIndex = 21
        Me.Label16.Text = "Port"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 45)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(26, 13)
        Me.Label17.TabIndex = 20
        Me.Label17.Text = "URI"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 17)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 13)
        Me.Label18.TabIndex = 19
        Me.Label18.Text = "Transport"
        '
        'remReqTransport
        '
        Me.remReqTransport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.remReqTransport.FormattingEnabled = True
        Me.remReqTransport.Items.AddRange(New Object() {"HTTP", "TCP"})
        Me.remReqTransport.Location = New System.Drawing.Point(64, 14)
        Me.remReqTransport.Name = "remReqTransport"
        Me.remReqTransport.Size = New System.Drawing.Size(144, 21)
        Me.remReqTransport.TabIndex = 18
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(386, 145)
        Me.TabPage5.TabIndex = 3
        Me.TabPage5.Text = "TCP"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'grpListen
        '
        Me.grpListen.Controls.Add(Me.tabServer)
        Me.grpListen.Location = New System.Drawing.Point(10, 12)
        Me.grpListen.Name = "grpListen"
        Me.grpListen.Size = New System.Drawing.Size(414, 195)
        Me.grpListen.TabIndex = 3
        Me.grpListen.TabStop = False
        Me.grpListen.Text = "Listen"
        '
        'grpForward
        '
        Me.grpForward.Controls.Add(Me.Label10)
        Me.grpForward.Controls.Add(Me.cmbAsyncMode)
        Me.grpForward.Controls.Add(Me.chkEnableForwarding)
        Me.grpForward.Controls.Add(Me.tabForwardRequests)
        Me.grpForward.Location = New System.Drawing.Point(9, 294)
        Me.grpForward.Name = "grpForward"
        Me.grpForward.Size = New System.Drawing.Size(414, 218)
        Me.grpForward.TabIndex = 4
        Me.grpForward.TabStop = False
        Me.grpForward.Text = "Forward Requests"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(172, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 13)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Async Pattern"
        '
        'cmbAsyncMode
        '
        Me.cmbAsyncMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAsyncMode.FormattingEnabled = True
        Me.cmbAsyncMode.Items.AddRange(New Object() {"Synchronous", "Async/Await", ".NET Thread Pool", "Task", "Manual Thread"})
        Me.cmbAsyncMode.Location = New System.Drawing.Point(248, 17)
        Me.cmbAsyncMode.Name = "cmbAsyncMode"
        Me.cmbAsyncMode.Size = New System.Drawing.Size(152, 21)
        Me.cmbAsyncMode.TabIndex = 6
        '
        'chkEnableForwarding
        '
        Me.chkEnableForwarding.AutoSize = True
        Me.chkEnableForwarding.Location = New System.Drawing.Point(9, 21)
        Me.chkEnableForwarding.Name = "chkEnableForwarding"
        Me.chkEnableForwarding.Size = New System.Drawing.Size(157, 17)
        Me.chkEnableForwarding.TabIndex = 3
        Me.chkEnableForwarding.Text = "Enable Request Forwarding"
        Me.chkEnableForwarding.UseVisualStyleBackColor = True
        '
        'grpOutput
        '
        Me.grpOutput.Controls.Add(Me.txtOutput)
        Me.grpOutput.Location = New System.Drawing.Point(10, 518)
        Me.grpOutput.Name = "grpOutput"
        Me.grpOutput.Size = New System.Drawing.Size(413, 139)
        Me.grpOutput.TabIndex = 5
        Me.grpOutput.TabStop = False
        Me.grpOutput.Text = "Output"
        '
        'txtOutput
        '
        Me.txtOutput.Location = New System.Drawing.Point(5, 14)
        Me.txtOutput.Multiline = True
        Me.txtOutput.Name = "txtOutput"
        Me.txtOutput.Size = New System.Drawing.Size(388, 118)
        Me.txtOutput.TabIndex = 0
        '
        'grpException
        '
        Me.grpException.Controls.Add(Me.chkExcAcrossBT)
        Me.grpException.Controls.Add(Me.chkExcInBT)
        Me.grpException.Location = New System.Drawing.Point(9, 213)
        Me.grpException.Name = "grpException"
        Me.grpException.Size = New System.Drawing.Size(242, 70)
        Me.grpException.TabIndex = 6
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
        'dotNetSimulatorServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 662)
        Me.Controls.Add(Me.grpException)
        Me.Controls.Add(Me.btnListen)
        Me.Controls.Add(Me.grpOutput)
        Me.Controls.Add(Me.grpForward)
        Me.Controls.Add(Me.grpListen)
        Me.Name = "dotNetSimulatorServer"
        Me.Text = "dotNetSimulator Server"
        Me.tabServer.ResumeLayout(False)
        Me.tabWCF.ResumeLayout(False)
        Me.tabWCF.PerformLayout()
        Me.tabHTTP.ResumeLayout(False)
        Me.tabHTTP.PerformLayout()
        Me.tabCHTTP.ResumeLayout(False)
        Me.tabCHTTP.PerformLayout()
        Me.tabRemoting.ResumeLayout(False)
        Me.tabRemoting.PerformLayout()
        Me.tabTCP.ResumeLayout(False)
        Me.tabTCP.PerformLayout()
        Me.tabForwardRequests.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.grpListen.ResumeLayout(False)
        Me.grpForward.ResumeLayout(False)
        Me.grpForward.PerformLayout()
        Me.grpOutput.ResumeLayout(False)
        Me.grpOutput.PerformLayout()
        Me.grpException.ResumeLayout(False)
        Me.grpException.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tabServer As System.Windows.Forms.TabControl
    Friend WithEvents tabWCF As System.Windows.Forms.TabPage
    Friend WithEvents wcfURL As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents wcfBindType As System.Windows.Forms.ComboBox
    Friend WithEvents tabHTTP As System.Windows.Forms.TabPage
    Friend WithEvents tabCHTTP As System.Windows.Forms.TabPage
    Friend WithEvents tabRemoting As System.Windows.Forms.TabPage
    Friend WithEvents tabTCP As System.Windows.Forms.TabPage
    Friend WithEvents tabForwardRequests As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents wcfReqURL As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents wcfReqBind As System.Windows.Forms.ComboBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents grpListen As System.Windows.Forms.GroupBox
    Friend WithEvents grpForward As System.Windows.Forms.GroupBox
    Friend WithEvents chkEnableForwarding As System.Windows.Forms.CheckBox
    Friend WithEvents grpOutput As System.Windows.Forms.GroupBox
    Friend WithEvents txtOutput As System.Windows.Forms.TextBox
    Friend WithEvents grpException As System.Windows.Forms.GroupBox
    Friend WithEvents chkExcAcrossBT As System.Windows.Forms.CheckBox
    Friend WithEvents chkExcInBT As System.Windows.Forms.CheckBox
    Friend WithEvents httpURI As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents httpPort As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents chttpURI As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chttpPort As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Transport As System.Windows.Forms.Label
    Friend WithEvents remTransport As System.Windows.Forms.ComboBox
    Friend WithEvents tcpPort As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnListen As System.Windows.Forms.Button
    Friend WithEvents httpListenURL As System.Windows.Forms.LinkLabel
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbAsyncMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents fwdHTTPURL As System.Windows.Forms.TextBox
    Friend WithEvents wcfTargetURL As System.Windows.Forms.Label
    Friend WithEvents remURI As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents remPort As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents remReqURI As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents remReqPort As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents remReqTransport As System.Windows.Forms.ComboBox

End Class
