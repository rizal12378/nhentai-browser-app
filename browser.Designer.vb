<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class browser
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnblockToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchByToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IDToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TagsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CloseTabToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.prev_btn = New System.Windows.Forms.Button()
        Me.next_btn = New System.Windows.Forms.Button()
        Me.urlget = New System.Windows.Forms.TextBox()
        Me.go_btn = New System.Windows.Forms.Button()
        Me.refresh_btn = New System.Windows.Forms.Button()
        Me.tabname = New System.Windows.Forms.TabControl()
        Me.bodytab = New System.Windows.Forms.TabPage()
        Me.newtab_btn = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.tabname.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.UnblockToolStripMenuItem, Me.SearchByToolStripMenuItem, Me.CloseTabToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'UnblockToolStripMenuItem
        '
        Me.UnblockToolStripMenuItem.Name = "UnblockToolStripMenuItem"
        Me.UnblockToolStripMenuItem.Size = New System.Drawing.Size(63, 20)
        Me.UnblockToolStripMenuItem.Text = "Unblock"
        '
        'SearchByToolStripMenuItem
        '
        Me.SearchByToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IDToolStripMenuItem, Me.TagsToolStripMenuItem})
        Me.SearchByToolStripMenuItem.Name = "SearchByToolStripMenuItem"
        Me.SearchByToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.SearchByToolStripMenuItem.Text = "Search By"
        '
        'IDToolStripMenuItem
        '
        Me.IDToolStripMenuItem.Name = "IDToolStripMenuItem"
        Me.IDToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.IDToolStripMenuItem.Text = "ID"
        '
        'TagsToolStripMenuItem
        '
        Me.TagsToolStripMenuItem.Name = "TagsToolStripMenuItem"
        Me.TagsToolStripMenuItem.Size = New System.Drawing.Size(98, 22)
        Me.TagsToolStripMenuItem.Text = "Tags"
        '
        'CloseTabToolStripMenuItem
        '
        Me.CloseTabToolStripMenuItem.Name = "CloseTabToolStripMenuItem"
        Me.CloseTabToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.CloseTabToolStripMenuItem.Text = "Close Tab"
        '
        'prev_btn
        '
        Me.prev_btn.Location = New System.Drawing.Point(12, 27)
        Me.prev_btn.Name = "prev_btn"
        Me.prev_btn.Size = New System.Drawing.Size(25, 23)
        Me.prev_btn.TabIndex = 0
        Me.prev_btn.Text = "<"
        Me.prev_btn.UseVisualStyleBackColor = True
        '
        'next_btn
        '
        Me.next_btn.Location = New System.Drawing.Point(43, 27)
        Me.next_btn.Name = "next_btn"
        Me.next_btn.Size = New System.Drawing.Size(25, 23)
        Me.next_btn.TabIndex = 4
        Me.next_btn.Text = ">"
        Me.next_btn.UseVisualStyleBackColor = True
        '
        'urlget
        '
        Me.urlget.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.urlget.Location = New System.Drawing.Point(137, 29)
        Me.urlget.Name = "urlget"
        Me.urlget.Size = New System.Drawing.Size(525, 20)
        Me.urlget.TabIndex = 5
        '
        'go_btn
        '
        Me.go_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.go_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.go_btn.Location = New System.Drawing.Point(668, 27)
        Me.go_btn.Name = "go_btn"
        Me.go_btn.Size = New System.Drawing.Size(49, 23)
        Me.go_btn.TabIndex = 6
        Me.go_btn.Text = "Go"
        Me.go_btn.UseVisualStyleBackColor = True
        '
        'refresh_btn
        '
        Me.refresh_btn.Location = New System.Drawing.Point(74, 27)
        Me.refresh_btn.Name = "refresh_btn"
        Me.refresh_btn.Size = New System.Drawing.Size(57, 23)
        Me.refresh_btn.TabIndex = 7
        Me.refresh_btn.Text = "Refresh"
        Me.refresh_btn.UseVisualStyleBackColor = True
        '
        'tabname
        '
        Me.tabname.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabname.Controls.Add(Me.bodytab)
        Me.tabname.Location = New System.Drawing.Point(12, 56)
        Me.tabname.Name = "tabname"
        Me.tabname.SelectedIndex = 0
        Me.tabname.Size = New System.Drawing.Size(776, 394)
        Me.tabname.TabIndex = 8
        '
        'bodytab
        '
        Me.bodytab.Location = New System.Drawing.Point(4, 22)
        Me.bodytab.Name = "bodytab"
        Me.bodytab.Padding = New System.Windows.Forms.Padding(3)
        Me.bodytab.Size = New System.Drawing.Size(768, 368)
        Me.bodytab.TabIndex = 0
        Me.bodytab.Text = "New Tab"
        Me.bodytab.UseVisualStyleBackColor = True
        '
        'newtab_btn
        '
        Me.newtab_btn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.newtab_btn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.newtab_btn.Location = New System.Drawing.Point(723, 27)
        Me.newtab_btn.Name = "newtab_btn"
        Me.newtab_btn.Size = New System.Drawing.Size(65, 23)
        Me.newtab_btn.TabIndex = 9
        Me.newtab_btn.Text = "New Tab"
        Me.newtab_btn.UseVisualStyleBackColor = True
        '
        'browser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.newtab_btn)
        Me.Controls.Add(Me.tabname)
        Me.Controls.Add(Me.refresh_btn)
        Me.Controls.Add(Me.go_btn)
        Me.Controls.Add(Me.urlget)
        Me.Controls.Add(Me.next_btn)
        Me.Controls.Add(Me.prev_btn)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "browser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "nHentai"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tabname.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnblockToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents prev_btn As Button
    Friend WithEvents next_btn As Button
    Friend WithEvents urlget As TextBox
    Friend WithEvents go_btn As Button
    Friend WithEvents refresh_btn As Button
    Friend WithEvents SearchByToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IDToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TagsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tabname As TabControl
    Friend WithEvents bodytab As TabPage
    Friend WithEvents newtab_btn As Button
    Friend WithEvents CloseTabToolStripMenuItem As ToolStripMenuItem
End Class
