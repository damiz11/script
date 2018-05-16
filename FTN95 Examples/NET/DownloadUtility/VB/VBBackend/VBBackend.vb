Public Class DownloadUtil
    'This class provides download utilities the methods provided
    'download a file from remoteUri then read the contents of it 
    'into the string strOut, returning the string.

    Dim webClient As New System.Net.WebClient()
    Dim strOut As System.String = Nothing
    Function DownloadFile(ByVal webAddr As String, ByVal fileName As String) As System.String
        Dim remoteUri As String = Nothing
        remoteUri = webAddr + fileName
        Try
            webClient.DownloadFile(remoteUri, fileName)
            If System.IO.File.Exists(fileName) Then
                ReadFile(fileName)
            End If
        Catch e As System.Exception
            strOut = "Download Failed"
        End Try
        Return strOut
    End Function

    Private Sub ReadFile(ByVal fileName As String)
        Dim file As System.IO.File
        Dim strm As System.IO.Stream
        strm = file.OpenRead(fileName)
        Dim strmRead As System.IO.StreamReader = New System.IO.StreamReader(strm, System.Text.Encoding.ASCII)
        strmRead.BaseStream.Seek(0, System.IO.SeekOrigin.Begin)
        While (strmRead.Peek() > -1)
            strOut = strmRead.ReadLine()
        End While
        strmRead.Close()
    End Sub
End Class
