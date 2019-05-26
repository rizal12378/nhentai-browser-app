Imports CefSharp
Imports CefSharp.WinForms
Public Class id_code_form
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            browser.browse.Load("http://nhentai.net/g/" + TextBox1.Text)
            browser.urlget.Text = "http://nhentai.net/g/" + TextBox1.Text
            Dispose()
        End If

    End Sub
End Class