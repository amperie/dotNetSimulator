Public Class Logger
    Public Shared Sub WriteToLog(entry As String)
        Console.WriteLine(Date.Now() + ": " + entry)
    End Sub
    Public Shared Sub LogException(ex As Exception)
        Console.WriteLine(Date.Now() + ": " + ex.ToString)
    End Sub
End Class
