<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Calculator
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
        Me.Src = New System.Windows.Forms.TextBox()
        Me.Out = New System.Windows.Forms.TextBox()
        Me.Lbl1 = New System.Windows.Forms.Label()
        Me.Lbl2 = New System.Windows.Forms.Label()
        Me.Lbl3 = New System.Windows.Forms.Label()
        Me.Mask = New System.Windows.Forms.TextBox()
        Me._0x = New System.Windows.Forms.Button()
        Me._AMPH = New System.Windows.Forms.Button()
        Me._H = New System.Windows.Forms.Button()
        Me.Cls = New System.Windows.Forms.Button()
        Me.UpperMode = New System.Windows.Forms.CheckBox()
        Me.ShortFormat = New System.Windows.Forms.CheckBox()
        Me.ErrLbl = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Src
        '
        Me.Src.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Src.Cursor = System.Windows.Forms.Cursors.Default
        Me.Src.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Src.Location = New System.Drawing.Point(112, 5)
        Me.Src.MaxLength = 20
        Me.Src.Name = "Src"
        Me.Src.Size = New System.Drawing.Size(127, 19)
        Me.Src.TabIndex = 1
        '
        'Out
        '
        Me.Out.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Out.Cursor = System.Windows.Forms.Cursors.Default
        Me.Out.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Out.Location = New System.Drawing.Point(112, 26)
        Me.Out.MaxLength = 70
        Me.Out.Name = "Out"
        Me.Out.Size = New System.Drawing.Size(127, 19)
        Me.Out.TabIndex = 2
        '
        'Lbl1
        '
        Me.Lbl1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lbl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl1.Location = New System.Drawing.Point(9, 5)
        Me.Lbl1.Name = "Lbl1"
        Me.Lbl1.Size = New System.Drawing.Size(100, 19)
        Me.Lbl1.TabIndex = 3
        Me.Lbl1.Text = "INT32"
        Me.Lbl1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl2
        '
        Me.Lbl2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lbl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl2.Location = New System.Drawing.Point(9, 26)
        Me.Lbl2.Name = "Lbl2"
        Me.Lbl2.Size = New System.Drawing.Size(100, 19)
        Me.Lbl2.TabIndex = 4
        Me.Lbl2.Text = "[X16] HEX"
        Me.Lbl2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Lbl3
        '
        Me.Lbl3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Lbl3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Lbl3.Location = New System.Drawing.Point(9, 47)
        Me.Lbl3.Name = "Lbl3"
        Me.Lbl3.Size = New System.Drawing.Size(100, 19)
        Me.Lbl3.TabIndex = 6
        Me.Lbl3.Text = "Format mask"
        Me.Lbl3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Mask
        '
        Me.Mask.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mask.Cursor = System.Windows.Forms.Cursors.Default
        Me.Mask.Font = New System.Drawing.Font("Lucida Console", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Mask.Location = New System.Drawing.Point(112, 47)
        Me.Mask.MaxLength = 70
        Me.Mask.Name = "Mask"
        Me.Mask.Size = New System.Drawing.Size(127, 19)
        Me.Mask.TabIndex = 5
        Me.Mask.Text = "0x{*}"
        '
        '_0x
        '
        Me._0x.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me._0x.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._0x.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me._0x.Location = New System.Drawing.Point(9, 70)
        Me._0x.Name = "_0x"
        Me._0x.Size = New System.Drawing.Size(50, 20)
        Me._0x.TabIndex = 7
        Me._0x.Text = "0x*"
        Me._0x.UseMnemonic = False
        Me._0x.UseVisualStyleBackColor = False
        '
        '_AMPH
        '
        Me._AMPH.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me._AMPH.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._AMPH.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me._AMPH.Location = New System.Drawing.Point(58, 70)
        Me._AMPH.Name = "_AMPH"
        Me._AMPH.Size = New System.Drawing.Size(50, 20)
        Me._AMPH.TabIndex = 8
        Me._AMPH.Text = "&H*"
        Me._AMPH.UseMnemonic = False
        Me._AMPH.UseVisualStyleBackColor = False
        '
        '_H
        '
        Me._H.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me._H.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._H.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me._H.Location = New System.Drawing.Point(9, 89)
        Me._H.Name = "_H"
        Me._H.Size = New System.Drawing.Size(50, 20)
        Me._H.TabIndex = 9
        Me._H.Text = "*H"
        Me._H.UseMnemonic = False
        Me._H.UseVisualStyleBackColor = False
        '
        'Cls
        '
        Me.Cls.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Cls.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(222, Byte), Integer))
        Me.Cls.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Cls.Location = New System.Drawing.Point(58, 89)
        Me.Cls.Name = "Cls"
        Me.Cls.Size = New System.Drawing.Size(50, 20)
        Me.Cls.TabIndex = 10
        Me.Cls.Text = "CLS"
        Me.Cls.UseMnemonic = False
        Me.Cls.UseVisualStyleBackColor = False
        '
        'UpperMode
        '
        Me.UpperMode.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.UpperMode.AutoSize = True
        Me.UpperMode.Location = New System.Drawing.Point(114, 91)
        Me.UpperMode.Name = "UpperMode"
        Me.UpperMode.Size = New System.Drawing.Size(41, 17)
        Me.UpperMode.TabIndex = 11
        Me.UpperMode.Text = "UP"
        Me.UpperMode.UseVisualStyleBackColor = True
        '
        'ShortFormat
        '
        Me.ShortFormat.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ShortFormat.AutoSize = True
        Me.ShortFormat.Checked = True
        Me.ShortFormat.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ShortFormat.Location = New System.Drawing.Point(114, 72)
        Me.ShortFormat.Name = "ShortFormat"
        Me.ShortFormat.Size = New System.Drawing.Size(64, 17)
        Me.ShortFormat.TabIndex = 12
        Me.ShortFormat.Text = "SHORT"
        Me.ShortFormat.UseVisualStyleBackColor = True
        '
        'ErrLbl
        '
        Me.ErrLbl.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.ErrLbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ErrLbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ErrLbl.ForeColor = System.Drawing.Color.Red
        Me.ErrLbl.Location = New System.Drawing.Point(184, 72)
        Me.ErrLbl.Name = "ErrLbl"
        Me.ErrLbl.Size = New System.Drawing.Size(52, 34)
        Me.ErrLbl.TabIndex = 13
        Me.ErrLbl.Text = "ERR"
        Me.ErrLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ErrLbl.Visible = False
        '
        'Calculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(247, 119)
        Me.Controls.Add(Me.ErrLbl)
        Me.Controls.Add(Me.ShortFormat)
        Me.Controls.Add(Me.UpperMode)
        Me.Controls.Add(Me.Cls)
        Me.Controls.Add(Me._H)
        Me.Controls.Add(Me._AMPH)
        Me.Controls.Add(Me._0x)
        Me.Controls.Add(Me.Lbl3)
        Me.Controls.Add(Me.Mask)
        Me.Controls.Add(Me.Lbl2)
        Me.Controls.Add(Me.Lbl1)
        Me.Controls.Add(Me.Out)
        Me.Controls.Add(Me.Src)
        Me.HelpButton = True
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(263, 158)
        Me.Name = "Calculator"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "x16Calc"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Src As Windows.Forms.TextBox
    Friend WithEvents Out As Windows.Forms.TextBox
    Friend WithEvents Lbl1 As Windows.Forms.Label
    Friend WithEvents Lbl2 As Windows.Forms.Label
    Friend WithEvents Lbl3 As Windows.Forms.Label
    Friend WithEvents Mask As Windows.Forms.TextBox
    Friend WithEvents _0x As Windows.Forms.Button
    Friend WithEvents _AMPH As Windows.Forms.Button
    Friend WithEvents _H As Windows.Forms.Button
    Friend WithEvents Cls As Windows.Forms.Button
    Friend WithEvents UpperMode As Windows.Forms.CheckBox
    Friend WithEvents ShortFormat As Windows.Forms.CheckBox
    Friend WithEvents ErrLbl As Windows.Forms.Label
End Class
