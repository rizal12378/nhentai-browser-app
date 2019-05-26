Imports CefSharp
Imports CefSharp.WinForms
Public Class Form1

    'buat angka acak dari 1 s/d 280000
    Sub randoms()
        Dim a As Integer
        Dim values As Integer = CInt(Int(1 + 280000 * Rnd()))
        out_text.Text = ""
        'taruh di label out_text
        out_text.Text = values
        a = out_text.Text
        'acak sekarang
        Randomize()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles read_btn.Click
        If out_text.Text = "" Then
            MsgBox("Kode belum di-Generate")
        Else
            browser.Show()
            browser.browse.Load("http://nhentai.net/g/" + out_text.Text)
        End If
        openBrowser_btn.Enabled = True
        pro_btn.Enabled = False
        down_text.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        out_text.Text = ""
        'openBrowser_btn.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles openBrowser_btn.Click
        'buka di browser sendiri
        If out_text.Text = "" Then
            MsgBox("Kode Belum Di-Generate")
        Else
            Process.Start("http://nhentai.net/g/" + out_text.Text)
        End If

    End Sub

    Private Sub Pro_btn_Click(sender As Object, e As EventArgs) Handles pro_btn.Click
        'kalo gamau ngerandom dan mau masukin kode sendiri, bisa langsung buka lewat sini
        browser.Show()
        browser.browse.Load(down_text.Text)
        browser.urlget.Text = "http://nhentai.net/g/" + down_text.Text
    End Sub
    Private Sub Quit_btn_Click(sender As Object, e As EventArgs) Handles quit_btn.Click
        Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles rand_btn.Click
        randoms()
        openBrowser_btn.Enabled = True
    End Sub
End Class
