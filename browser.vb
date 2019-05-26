Imports CefSharp.WinForms
Imports CefSharp
Imports CefSharp.WinForms.Internals
Public Class browser
    Public WithEvents browse As ChromiumWebBrowser
    Public Sub New()
        InitializeComponent()
        Dim sets As New CefSettings
        CefSharp.Cef.Initialize(sets)
        browse = New ChromiumWebBrowser("http://google.com") With
        {
            .Dock = DockStyle.Fill
        }
        bodytab.Controls.Add(browse)
    End Sub

    Private Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs)
        browse.Reload()
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Dispose()
        CefSharp.Cef.Shutdown()
        Form1.down_text.Enabled = True
        Form1.pro_btn.Enabled = True
    End Sub

    Private Sub UnblockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnblockToolStripMenuItem.Click
        bodytab.Refresh()
        browse.Load("https://nhent.ai/g/" + Form1.out_text.Text)
    End Sub

    Private Sub Browser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        urlget.Text = "http://www.google.com"
    End Sub
    Private Sub Stpbtn_Click(sender As Object, e As EventArgs)
        browse.Stop()
    End Sub

    Private Sub Go_btn_Click(sender As Object, e As EventArgs) Handles go_btn.Click
        browse.Load(urlget.Text)
    End Sub

    Private Sub IDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IDToolStripMenuItem.Click
        id_code_form.Show()
    End Sub

    Private Sub Newtab_btn_Click(sender As Object, e As EventArgs) Handles newtab_btn.Click
        Dim tabs As New TabPage

        tabs.Text = "New Tab"
        'masukin nama new tab diatas, taruh di tabname
        tabname.Controls.Add(tabs)
        'tambah tab +1 dan auto direct ke google
        tabname.SelectTab(tabname.TabCount - 1)
        browse = New ChromiumWebBrowser("http://www.google.com")
        browse.Parent = tabs
        browse.Dock = DockStyle.Fill
        urlget.Text = "http://www.google.com"
    End Sub

    Private Sub Refresh_btn_Click(sender As Object, e As EventArgs) Handles refresh_btn.Click
        browse.Refresh()
    End Sub

    Private Sub Next_btn_Click(sender As Object, e As EventArgs) Handles next_btn.Click
        If browse.CanGoForward Then
            browse.Forward
        End If
    End Sub

    Private Sub Prev_btn_Click(sender As Object, e As EventArgs) Handles prev_btn.Click
        If browse.CanGoBack Then
            browse.Back
        End If
    End Sub
    Public Sub browse_AddressChanged(ByVal sender As Object, ByVal e As AddressChangedEventArgs)
        Me.Invoke(New MethodInvoker(Function()
                                        urlget.Text = e.Address
                                    End Function))
    End Sub
End Class