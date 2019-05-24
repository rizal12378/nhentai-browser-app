Imports CefSharp.WinForms
Imports CefSharp
Public Class browser
    Private WithEvents browse As ChromiumWebBrowser

    Public Sub New()
        InitializeComponent()

        Dim settings As New CefSettings()
        CefSharp.Cef.Initialize(settings)

        browse = New ChromiumWebBrowser("http://nhentai.net/g/" + Form1.out_text.Text) With
            {
            .Dock = DockStyle.Fill
        }
        Panel1.Controls.Add(browse)

    End Sub
    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        'WebBrowser1.Refresh()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dispose()
    End Sub

    Private Sub Browser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
End Class