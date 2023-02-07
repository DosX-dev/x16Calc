<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AboutWin
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.AboutCaption = New System.Windows.Forms.Label()
        Me.AboutTitle = New System.Windows.Forms.Label()
        Me.CloseBtn = New System.Windows.Forms.Button()
        Me.Ver = New System.Windows.Forms.Label()
        Me.AuthorSite = New System.Windows.Forms.LinkLabel()
        Me.AboutPanel = New System.Windows.Forms.Panel()
        Me.AboutPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'AboutCaption
        '
        Me.AboutCaption.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AboutCaption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AboutCaption.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AboutCaption.Location = New System.Drawing.Point(7, 28)
        Me.AboutCaption.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AboutCaption.Name = "AboutCaption"
        Me.AboutCaption.Size = New System.Drawing.Size(249, 45)
        Me.AboutCaption.TabIndex = 0
        Me.AboutCaption.Text = "A portable program for working with HEX numbers"
        Me.AboutCaption.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AboutTitle
        '
        Me.AboutTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AboutTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.AboutTitle.Location = New System.Drawing.Point(7, 5)
        Me.AboutTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AboutTitle.Name = "AboutTitle"
        Me.AboutTitle.Size = New System.Drawing.Size(249, 18)
        Me.AboutTitle.TabIndex = 1
        Me.AboutTitle.Text = "x16Calc"
        Me.AboutTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CloseBtn
        '
        Me.CloseBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CloseBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.CloseBtn.Location = New System.Drawing.Point(156, 15)
        Me.CloseBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CloseBtn.Name = "CloseBtn"
        Me.CloseBtn.Size = New System.Drawing.Size(100, 28)
        Me.CloseBtn.TabIndex = 2
        Me.CloseBtn.Text = "Close"
        Me.CloseBtn.UseVisualStyleBackColor = True
        '
        'Ver
        '
        Me.Ver.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Ver.AutoSize = True
        Me.Ver.Cursor = System.Windows.Forms.Cursors.Help
        Me.Ver.ForeColor = System.Drawing.Color.Gray
        Me.Ver.Location = New System.Drawing.Point(5, 25)
        Me.Ver.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Ver.Name = "Ver"
        Me.Ver.Size = New System.Drawing.Size(91, 16)
        Me.Ver.TabIndex = 3
        Me.Ver.Text = "%VERSION%"
        '
        'AuthorSite
        '
        Me.AuthorSite.ActiveLinkColor = System.Drawing.Color.DarkCyan
        Me.AuthorSite.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.AuthorSite.AutoSize = True
        Me.AuthorSite.LinkColor = System.Drawing.Color.CadetBlue
        Me.AuthorSite.Location = New System.Drawing.Point(4, 5)
        Me.AuthorSite.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AuthorSite.Name = "AuthorSite"
        Me.AuthorSite.Size = New System.Drawing.Size(102, 16)
        Me.AuthorSite.TabIndex = 4
        Me.AuthorSite.TabStop = True
        Me.AuthorSite.Text = "Coded by DosX"
        '
        'AboutPanel
        '
        Me.AboutPanel.Controls.Add(Me.AuthorSite)
        Me.AboutPanel.Controls.Add(Me.CloseBtn)
        Me.AboutPanel.Controls.Add(Me.Ver)
        Me.AboutPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.AboutPanel.Location = New System.Drawing.Point(0, 76)
        Me.AboutPanel.Name = "AboutPanel"
        Me.AboutPanel.Size = New System.Drawing.Size(261, 48)
        Me.AboutPanel.TabIndex = 5
        '
        'AboutWin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.CloseBtn
        Me.ClientSize = New System.Drawing.Size(261, 124)
        Me.Controls.Add(Me.AboutPanel)
        Me.Controls.Add(Me.AboutCaption)
        Me.Controls.Add(Me.AboutTitle)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(558, 342)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(279, 171)
        Me.Name = "AboutWin"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "About"
        Me.AboutPanel.ResumeLayout(False)
        Me.AboutPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AboutCaption As Windows.Forms.Label
    Friend WithEvents AboutTitle As Windows.Forms.Label
    Friend WithEvents CloseBtn As Windows.Forms.Button
    Friend WithEvents Ver As Windows.Forms.Label
    Friend WithEvents AuthorSite As Windows.Forms.LinkLabel
    Friend WithEvents AboutPanel As Windows.Forms.Panel
End Class
