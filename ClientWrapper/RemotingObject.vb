
Public Class RemotingObject
    Inherits MarshalByRefObject

    Public Shared RequestToForward As ClientRequest

    Public Function RemoteMethod() As String
        Dim retVal As String = "Hello from Remoting" + vbCrLf + vbCrLf
        If Not RequestToForward Is Nothing Then
            retVal += RequestToForward.DoRequest()
        End If
        Return retVal
    End Function

End Class
