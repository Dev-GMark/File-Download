Imports System.IO
Public Class clscom
    Public Sub INI()
        Dim frm1 As New frmXML
        spath = System.Environment.CurrentDirectory
        Try
            Dim sr As StreamReader = New StreamReader(spath + "\dlxml.ini")
            Dim key_username, Key_server, key_locdir, key_Pass As String

            key_username = "[Username]="
            key_Pass = "[Password]="
            Key_server = "[Dlserver]="
            key_locdir = "[LocalDir]="

            Dim line As String
            line = sr.ReadLine()
            While Not line Is Nothing
                line.Replace(" =", "=").Replace("= ", "=")
                If line.StartsWith(key_username) Then
                    username = Replace(line, key_username, "")
                End If
                If line.StartsWith(key_Pass) Then
                    pass = Replace(line, key_Pass, "")
                End If
                If line.StartsWith(Key_server) Then
                    server = Replace(line, Key_server, "")
                End If
                If line.StartsWith(key_locdir) Then
                    locdir = Replace(line, key_locdir, "")
                End If
                line = sr.ReadLine()
            End While
            sr.Close()
        Catch Ee As Exception
            MsgBox(Ee.Message)
        End Try
    End Sub
End Class
