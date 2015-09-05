Public Class CallGraphFodder
    Public Shared Sub Call1()
        Call2()
    End Sub
    Public Shared Sub Call2()
        Call3()
    End Sub
    Public Shared Sub Call3()
        Threading.Thread.Sleep(200)
    End Sub
End Class
