Imports System.Runtime.Remoting
Imports System.Runtime.Remoting.Channels

Public Class ServerRemoting
    Inherits ServerListener

    Private _ChannelType As String
    Private _URI As String
    Private _Port As String
    Private IPCChannel As Ipc.IpcChannel
    Private HTTPChannel As Http.HttpChannel
    Private TCPChannel As Tcp.TcpChannel

    Public Sub New(ChannelType As String, Port As String, URI As String)
        _ChannelType = ChannelType
        _URI = URI
        _port = Port
    End Sub

    Public Overrides Sub StartListening()
        ClientWrapper.RemotingObject.RequestToForward = RequestToForward
        Select Case _ChannelType
            Case "IPC"
                IPCChannel = New Ipc.IpcChannel(_Port)
                Channels.ChannelServices.RegisterChannel(IPCChannel, False)
                RemotingConfiguration.RegisterWellKnownServiceType(GetType(ClientWrapper.RemotingObject), _
                                                                   _URI, WellKnownObjectMode.Singleton)
            Case "HTTP"
                HTTPChannel = New Http.HttpChannel(_Port)
                Channels.ChannelServices.RegisterChannel(HTTPChannel, False)
                RemotingConfiguration.RegisterWellKnownServiceType(GetType(ClientWrapper.RemotingObject), _
                                                                   _URI, WellKnownObjectMode.Singleton)
            Case "TCP"
                TCPChannel = New Tcp.TcpChannel(_Port)
                Channels.ChannelServices.RegisterChannel(TCPChannel, False)
                RemotingConfiguration.RegisterWellKnownServiceType(GetType(ClientWrapper.RemotingObject), _
                                                                   _URI, WellKnownObjectMode.Singleton)

        End Select
    End Sub

    Public Overrides Sub StopListening()

        Select Case _ChannelType
            Case "IPC"
                Channels.ChannelServices.UnregisterChannel(IPCChannel)
            Case "HTTP"
                Channels.ChannelServices.UnregisterChannel(HTTPChannel)
            Case "TCP"
                Channels.ChannelServices.UnregisterChannel(TCPChannel)
        End Select

    End Sub

End Class
