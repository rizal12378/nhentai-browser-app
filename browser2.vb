Imports CefSharp
Imports CefSharp.WinForms
Public Class browser2
    Private WithEvents browse2 As ChromiumWebBrowser
    Public Sub New()
        InitializeComponent()

        Dim settings As New CefSettings()
        CefSharp.Cef.Initialize(settings)

        browse2 = New ChromiumWebBrowser("http://nhentai.net/g/" + Form1.down_text.Text) With
        {
            .Dock = DockStyle.Fill
        }
        Pane2.Controls.Add(browse2)

    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dispose()
    End Sub
End Class