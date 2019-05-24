
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
        'buka browser di form kedua, navigasi ke website langsung + kode ID tadi yg dirandom
        browser.Show()
        'browser.WebBrowser1.Navigate("http://nhentai.net/g/" + out_text.Text)
        'ini biar buat javascript error nggak muncul, probably IE-based, soo i need chromium embedded browser
        'pls halp
        'browser.WebBrowser1.ScriptErrorsSuppressed = True
        openBrowser_btn.Enabled = True
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        out_text.Text = ""
        openBrowser_btn.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles openBrowser_btn.Click
        'buka di browser sendiri
        Process.Start("http://nhentai.net/g/" + out_text.Text)
    End Sub

    Private Sub Pro_btn_Click(sender As Object, e As EventArgs) Handles pro_btn.Click
        'Process.Start("http://nhentai.net/g/" + down_text.Text)
        'kalo gamau ngerandom dan mau masukin kode sendiri, bisa langsung buka lewat sini
        browser2.Show()
        'browser.Panel1.Navigate("http://nhentai.net/g/" + down_text.Text)
        'browser.WebBrowser1.ScriptErrorsSuppressed = True
    End Sub
    Private Sub Quit_btn_Click(sender As Object, e As EventArgs) Handles quit_btn.Click
        Dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles rand_btn.Click
        randoms()
        openBrowser_btn.Enabled = True
    End Sub
End Class
