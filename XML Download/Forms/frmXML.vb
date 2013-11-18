Imports System.IO
Public Class frmXML

    Private Sub btndownload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btndownload.Click
        'ftpdownload()
        download()
    End Sub
    'Public Sub ftpdownload()
    '    Try
    '        Dim dl As Net.FtpWebRequest = Net.FtpWebRequest.Create("ftp://mldlsrv.mlinc.com/c$/download/" & Trim(txtfilename.Text))
    '        dl.Credentials = New Net.NetworkCredential("Administrator", "p@ssw0rd")
    '        dl.KeepAlive = True
    '        dl.Method = System.Net.WebRequestMethods.Ftp.ListDirectory
    '        dl.Proxy = Nothing

    '        Dim sr As New IO.StreamReader(dl.GetResponse().GetResponseStream())
    '        Dim lst = sr.ReadToEnd().Split(vbNewLine)
    '        Dim fwr2 As Net.FtpWebRequest = Net.FtpWebRequest.Create("ftp://mldlsrv.mlinc.com/c$/download/" & Trim(txtfilename.Text))
    '        fwr2.Credentials = dl.Credentials
    '        fwr2.KeepAlive = True
    '        fwr2.Method = System.Net.WebRequestMethods.Ftp.DownloadFile
    '        fwr2.Proxy = Nothing

    '        Dim fileSR As New IO.StreamReader(fwr2.GetResponse().GetResponseStream())
    '        Dim fileData = fileSR.ReadToEnd()
    '        fileSR.Close()
    '        sr.Close()
    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try
    'End Sub
    Private Sub btncancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncancel.Click
        End
    End Sub
    Public Sub download()
        Try
            Dim webClient As New System.Net.WebClient
            Dim verify As System.Net.ICredentials

            verify = New System.Net.NetworkCredential(username, pass)
            webClient.Credentials = verify
            webClient.DownloadFile(server & txtfilename.Text, locdir & txtfilename.Text)
            MsgBox("Download complete", MsgBoxStyle.Information)
            btndownload.Enabled = False
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub frmXML_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cls As New clscom
        cls.INI()
        If Not Directory.Exists(locdir) Then
            IO.Directory.CreateDirectory(locdir)
        End If
    End Sub

    Private Sub txtfilename_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtfilename.TextChanged
        btndownload.Enabled = True
    End Sub
End Class