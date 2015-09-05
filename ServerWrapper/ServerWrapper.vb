Imports System.Net
Imports System.Threading

Public MustInherit Class ServerListener
    Public ReadOnly Property Listening As Boolean
        Get
            Return _Listening
        End Get
    End Property
    Protected _Listening As Boolean = False
    Protected ExcInBT As Boolean = False
    Protected ExcAcrossBT As Boolean = False
    Protected ForwardRequests As Boolean = False
    Protected RequestToForward As ClientWrapper.ClientRequest

    Public MustOverride Sub StartListening()
    Public MustOverride Sub StopListening()

    Public Property FwdRequests As Boolean
        Get
            Return ForwardRequests
        End Get
        Set(value As Boolean)
            ForwardRequests = value
        End Set
    End Property
    Public Property ForwardedRequest As ClientWrapper.ClientRequest
        Get
            Return RequestToForward
        End Get
        Set(value As ClientWrapper.ClientRequest)
            RequestToForward = value
            If Not value Is Nothing Then
                RequestToForward.ForwardedRequest = True
            End If
        End Set
    End Property
End Class
