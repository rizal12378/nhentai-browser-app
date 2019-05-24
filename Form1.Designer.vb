<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.out_text = New System.Windows.Forms.Label()
        Me.read_btn = New System.Windows.Forms.Button()
        Me.openBrowser_btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.down_text = New System.Windows.Forms.TextBox()
        Me.pro_btn = New System.Windows.Forms.Button()
        Me.quit_btn = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.rand_btn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'out_text
        '
        Me.out_text.AutoSize = True
        Me.out_text.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.out_text.Location = New System.Drawing.Point(127, 9)
        Me.out_text.Name = "out_text"
        Me.out_text.Size = New System.Drawing.Size(120, 39)
        Me.out_text.TabIndex = 0
        Me.out_text.Text = "Label1"
        '
        'read_btn
        '
        Me.read_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.read_btn.Location = New System.Drawing.Point(131, 95)
        Me.read_btn.Name = "read_btn"
        Me.read_btn.Size = New System.Drawing.Size(97, 52)
        Me.read_btn.TabIndex = 3
        Me.read_btn.Text = "Read Online"
        Me.read_btn.UseVisualStyleBackColor = True
        '
        'openBrowser_btn
        '
        Me.openBrowser_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.openBrowser_btn.Location = New System.Drawing.Point(234, 95)
        Me.openBrowser_btn.Name = "openBrowser_btn"
        Me.openBrowser_btn.Size = New System.Drawing.Size(204, 52)
        Me.openBrowser_btn.TabIndex = 4
        Me.openBrowser_btn.Text = "Open in Browser"
        Me.openBrowser_btn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 176)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Or, Write down here:"
        '
        'down_text
        '
        Me.down_text.Location = New System.Drawing.Point(19, 192)
        Me.down_text.Name = "down_text"
        Me.down_text.Size = New System.Drawing.Size(419, 20)
        Me.down_text.TabIndex = 7
        '
        'pro_btn
        '
        Me.pro_btn.Location = New System.Drawing.Point(19, 218)
        Me.pro_btn.Name = "pro_btn"
        Me.pro_btn.Size = New System.Drawing.Size(75, 23)
        Me.pro_btn.TabIndex = 8
        Me.pro_btn.Text = "Process"
        Me.pro_btn.UseVisualStyleBackColor = True
        '
        'quit_btn
        '
        Me.quit_btn.Location = New System.Drawing.Point(363, 282)
        Me.quit_btn.Name = "quit_btn"
        Me.quit_btn.Size = New System.Drawing.Size(75, 23)
        Me.quit_btn.TabIndex = 9
        Me.quit_btn.Text = "Exit"
        Me.quit_btn.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 39)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Code:"
        '
        'rand_btn
        '
        Me.rand_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rand_btn.Location = New System.Drawing.Point(12, 95)
        Me.rand_btn.Name = "rand_btn"
        Me.rand_btn.Size = New System.Drawing.Size(113, 52)
        Me.rand_btn.TabIndex = 11
        Me.rand_btn.Text = "GO!"
        Me.rand_btn.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.ClientSize = New System.Drawing.Size(450, 317)
        Me.Controls.Add(Me.rand_btn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.quit_btn)
        Me.Controls.Add(Me.pro_btn)
        Me.Controls.Add(Me.down_text)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.openBrowser_btn)
        Me.Controls.Add(Me.read_btn)
        Me.Controls.Add(Me.out_text)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Random Kode nhentai"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents out_text As Label
    Friend WithEvents read_btn As Button
    Friend WithEvents openBrowser_btn As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents down_text As TextBox
    Friend WithEvents pro_btn As Button
    Friend WithEvents quit_btn As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents rand_btn As Button
End Class
