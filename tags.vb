Public Class tags
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            browser.Show()
            browser.browse.Load("http://nhentai.net/tag/" + TextBox1.Text)
            browser.urlget.Text = "http://nhentai.net/tag/" + TextBox1.Text
        End If
    End Sub
End Class