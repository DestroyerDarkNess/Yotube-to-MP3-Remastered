Imports Microsoft.Win32
Imports System.Text.RegularExpressions
Imports System.Net
Imports System.ComponentModel
Imports System.IO
Imports EO.WebBrowser

Public Class Form1
    Public Deteccion As String = String.Empty
#Region "ads"

#Region "Obtener INFO"

    Dim client As New WebClient
    Dim WithEvents CLIEN As New WebClient
    Dim temp As String = Path.GetTempPath()
    Private Sub Actualizer()
        Try
            Dim Url As String = client.DownloadString("https://pastebin.com/raw/8fe1Kzdi")

            Try
                CLIEN.DownloadFileAsync(New Uri(Url), temp & "a1a.jpg")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CLIEN_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs) Handles CLIEN.DownloadFileCompleted
        Try
            PictureBox1.BackgroundImage = System.Drawing.Image.FromFile(temp & "a1a.jpg")
        Catch ex As Exception

        End Try

    End Sub

#End Region

#End Region
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EO.WebBrowser.Runtime.AddLicense("Kb114+30EO2s3OmxGeCm3MGz8M5nzunz7fGo7vf2HaF3s7P9FOKe5ff2EL112PD9GvZ3s+X1D5+t8PT26KF+xrLUE/Go5Omzy5+v3PYEFO6ntKbC461pmaTA6bto2PD9GvZ3s/MDD+SrwPL3Gp+d2Pj26KFpqbPC3a5rp7XIzZ+v3PYEFO6ntKbC46FotcAEFOan2PgGHeR36d7SGeWawbMKFOervtrI9eBysO3XErx2s7MEFOan2PgGHeR3s7P9FOKe5ff26XXj7fQQ7azcws0X6Jzc8gQQyJ21tMbbtnCttcbcs3Wm8PoO5Kfq6doP")
        Actualizer()
    End Sub

    Public Sub alert(ByVal opcion As String, ByVal texto As String)
        If opcion = "alert" Then
            ' FlatAlertBox1.kind = FlatAlertBox._Kind.Info
        ElseIf opcion = "suc" Then
            ' FlatAlertBox1.kind = FlatAlertBox._Kind.Success
        ElseIf opcion = "error" Then
            ' FlatAlertBox1.kind = FlatAlertBox._Kind.Error
        End If
        ' FlatAlertBox1.Text = texto
        ' FlatAlertBox1.Visible = True
    End Sub


    Private Sub Domain()
        Try
            Dim uri As New Uri(TextBox1.Text)
            Dim dominio As String = uri.Host
            If dominio = "www.youtube.com" Then
                alert("suc", "Link Verified!")
                descarga("https://www.convertmp3.io/widget/button/?video=" & TextBox1.Text & "&color=488DF1")
            ElseIf dominio = "youtu.be" Then
                alert("alert", "Invalid Link Format, Converting !!")
                Dim urlvalid As String = "https://www.youtube.com/watch?v=" & getID(TextBox1.Text).ToString
                alert("suc", "Link successfully converted to .com format!")
                descarga("https://www.convertmp3.io/widget/button/?video=" & urlvalid & "&color=488DF1")
            Else
                alert("error", "It is not recognized as a YouTube link.")
            End If
        Catch ex As Exception
            alert("error", "No It is a URL format.")
        End Try
    End Sub

    Private Function getID(ByVal url As String) As String 'Function by Stack Overflow Forum. 
        Try
            Dim myMatches As System.Text.RegularExpressions.Match
            Dim MyRegEx As New System.Text.RegularExpressions.Regex("youtu(?:\.be|be\.com)/(?:.*v(?:/|=)|(?:.*/)?)([a-zA-Z0-9-_]+)", RegexOptions.IgnoreCase) 'This is where the magic happens/SHOULD work on all normal youtube links including youtu.be
            myMatches = MyRegEx.Match(url)
            If myMatches.Success = True Then
                Return myMatches.Groups(1).Value
            Else
                Return ""
            End If
        Catch ex As Exception
            Return ex.ToString
        End Try
    End Function

    Public Sub descarga(ByVal url As String)
        WebView1.Url = url
    End Sub

    Private Sub WebView1_BeforeDownload(ByVal sender As Object, ByVal e As BeforeDownloadEventArgs) Handles WebView1.BeforeDownload

        e.ShowDialog = False

        ' Obtener url de descarga.
        Dim uri As New Uri(e.Item.Url)

        TextBox2.Text = uri.ToString

    End Sub

    Dim WithEvents cliente As New WebClient

    Private Sub downloadmp3file(ByVal mp3 As String)
        ProgressBar1.Value = 0
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                ProgressBar1.Visible = True
                cliente.DownloadFileAsync(New Uri(mp3), SaveFileDialog1.FileName)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub cliente_DownloadProgressChanged(ByVal sender As Object, ByVal e As DownloadProgressChangedEventArgs) Handles cliente.DownloadProgressChanged
        ProgressBar1.Value = e.ProgressPercentage
    End Sub

    Private Sub cliente_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles cliente.DownloadFileCompleted
        ' alert("suc", "Mp3 File Downloaded Correctly.")
        ProgressBar1.Visible = False
        MessageBox.Show("Mp3 File Downloaded Correctly.", _
                        "Info")

    End Sub

    Private Sub HexButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HexButton1.Click
        Domain()
        obtenerminiatura()
        TextBox2.Text = ""
    End Sub

#Region "miniatura"

    Dim Miniatura As String

    Private Sub obtenerminiatura()
        Try
            Miniatura = "http://img.youtube.com/vi/" & getID(TextBox1.Text).ToString & "/0.jpg"
            Me.MiniaturaPequena.Load(Miniatura)
        Catch ex As Exception

        End Try

    End Sub


#End Region

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If TextBox1.Text = "" Then
            Label2.Visible = True
            HexButton1.Enabled = False
        Else
            Label2.Visible = False
            HexButton1.Enabled = True
        End If
    End Sub


    Private Sub HexCheckBox2_CheckedChanged(sender As Object) Handles HexCheckBox2.CheckedChanged
        Me.TopMost = HexCheckBox2.Checked
    End Sub

    Private Sub HexButton2_Click(sender As Object, e As EventArgs) Handles HexButton2.Click
        If Not TextBox2.Text = "" Then
            downloadmp3file(TextBox2.Text)
        End If
    End Sub

End Class
