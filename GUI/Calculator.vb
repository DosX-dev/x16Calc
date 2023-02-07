Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Drawing
Imports System
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms
Imports Microsoft.Win32

Public Class Calculator
    Dim ErrWarning As Thread,
        ErrMutex As Boolean
    Dim HexVar = "{*}"
    Private Sub Src_TextChanged(sender As Object, e As EventArgs) Handles Src.TextChanged
        For Each Rpl In "!@#$%^&*()_~QWERTYUIOPASDFGHJKLZXCVBNM "
            Src.Text = Replace(Src.Text.ToUpper, Rpl, String.Empty)
        Next

        If Src.Focused Then
            If Not Mask.Text.Contains(HexVar) Then
                Mask.Text &= HexVar
            End If
            DoCalc_ToHex()
        End If
    End Sub

    Public Sub DoCalc_ToHex()
        Try
            If Src.Text = String.Empty OrElse Src.Text = "-" Then
                Out.Text = String.Empty
                Exit Sub
            End If
            Out.Text = Mask.Text.Replace(HexVar,
                                         IIf(UpperMode.Checked,
                                             ToX16(Src.Text).ToUpper,
                                             ToX16(Src.Text)))

        Catch ex As Exception
            VisualError()
            Out.Text = String.Empty
        End Try
    End Sub

    Public Sub DoCalc_ToInt()
        If Out.Text = String.Empty Then
            Src.Text = String.Empty
            Exit Sub
        End If
        Dim Calc = Out.Text
        For Each Rpl In "!@#$%^&*()QWRTYUIOPSGHJKLZXVBNM\/?|[]{}~"
            Calc = Replace(Calc.ToUpper, Rpl, "")
        Next

        Src.Text = Convert.ToInt32(Calc, 16)

    End Sub

    Function ToX16(Num As Integer)
        Dim Result As String = Num.ToString("x16")
        If ShortFormat.Checked Then

            For Each MIN In Result '0x001 => 0x1   [&H..]
                If MIN = "0" AndAlso Result.Length > 1 Then
                    Result = Result.Substring(1) ' 0x..1 => 0x1
                Else
                    Exit For
                End If
            Next

        End If
        Return Result
    End Function

    Private Sub Out_TextChanged(sender As Object, e As EventArgs) Handles Out.TextChanged

        If Out.Focused Then
            Try
                DoCalc_ToInt()
            Catch ex As Exception
                VisualError()
                Src.Text = String.Empty
            End Try
        End If
    End Sub
    Private Sub Mask_TextChanged(sender As Object, e As EventArgs) Handles Mask.TextChanged
        DoCalc_ToHex()
        _0x.Enabled = True
        _AMPH.Enabled = True
        _H.Enabled = True
        Cls.Enabled = True
        If Mask.Text = $"0x{HexVar}" Then
            _0x.Enabled = False
        ElseIf Mask.Text = $"&H{HexVar}" Then
            _AMPH.Enabled = False
        ElseIf Mask.Text = $"{HexVar}H" Then
            _H.Enabled = False
        ElseIf Mask.Text = HexVar Then
            Cls.Enabled = False
        End If

        If Not Mask.Text.Contains(HexVar) Then
            Mask.BackColor = Color.Red
            Mask.ForeColor = Color.White
        Else
            Mask.BackColor = Color.White
            Mask.ForeColor = Color.Black
        End If
    End Sub

    Private Sub _0x_Click(sender As Object, e As EventArgs) Handles _0x.Click
        Mask.Text = $"0x{HexVar}"
        UpperMode.Checked = False
        ShortFormat.Checked = True
        Src.Focus()
    End Sub
    Private Sub _AMPH_Click(sender As Object, e As EventArgs) Handles _AMPH.Click
        Mask.Text = $"&H{HexVar}"
        UpperMode.Checked = True
        ShortFormat.Checked = True
        Src.Focus()
    End Sub
    Private Sub _H_Click(sender As Object, e As EventArgs) Handles _H.Click
        Mask.Text = $"{HexVar}H"
        UpperMode.Checked = True
        ShortFormat.Checked = True
        Src.Focus()
    End Sub

    Private Sub Cls_Click(sender As Object, e As EventArgs) Handles Cls.Click
        Mask.Text = HexVar
        ShortFormat.Checked = False
        UpperMode.Checked = False
        Src.Focus()
    End Sub

    Private Sub CheckedChanged_1(sender As Object, e As EventArgs) Handles UpperMode.CheckedChanged, ShortFormat.CheckedChanged
        DoCalc_ToHex()
    End Sub

    Private Sub Src_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles Src.KeyPress
        e.Handled = Not e.KeyChar Like $"[-,0-9,{ChrW(8)}]"
    End Sub

    Private Sub Mask_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles Mask.KeyPress
        If "EADFC".Contains(CStr(e.KeyChar).ToUpper) Then
            VisualError()
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub Out_KeyPress(sender As Object, e As Windows.Forms.KeyPressEventArgs) Handles Out.KeyPress
        If Convert.ToInt32(e.KeyChar) = 22 Then
            Out.Text = String.Empty
            Exit Sub ' Ctrl V ?=> replace all text
        ElseIf Convert.ToInt32(e.KeyChar) = 3 Then
            If Not Out.Text = String.Empty Then Clipboard.SetText(Out.Text) ' Ctrl C ?=> copy all text
            Exit Sub
        End If

        If Not $"!@#$%^&*()/\|~EADFC1234567890-_{ChrW(8)}".Contains(CStr(e.KeyChar).ToUpper) AndAlso
           Not Mask.Text.Contains(e.KeyChar) Then ' If KEYCHAR does not contain a character from the mask
            VisualError()
            e.Handled = True
        Else
            e.Handled = False
        End If
    End Sub

    Private Sub VisualError()
        ErrLbl.Visible = True
        If ErrMutex Then
            Exit Sub
        End If
        ErrMutex = True
        ErrWarning = New Thread(Sub()
                                    For fErr = 0 To 2
                                        ErrLbl.ForeColor = Color.White
                                        ErrLbl.BackColor = Color.Red
                                        Thread.Sleep(100)
                                        ErrLbl.ForeColor = Color.Red
                                        ErrLbl.BackColor = Color.White
                                        Thread.Sleep(100)
                                    Next
                                    ErrLbl.Visible = False
                                    ErrMutex = False
                                End Sub)
        ErrWarning.Start()
    End Sub

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Text &= $" (v{Application.ProductVersion})"

    End Sub

    Private Sub Src_KeyDown(sender As Object, e As KeyEventArgs) Handles Src.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.V Then
            Src.Text = Clipboard.GetText
        ElseIf e.Control AndAlso e.KeyCode = Keys.C Then
            If Not Src.Text = String.Empty Then Clipboard.SetText(Src.Text)
        End If
    End Sub

    Private Sub Calculator_HelpButtonClicked(sender As Object, e As CancelEventArgs) Handles MyBase.HelpButtonClicked
        Dim AboutMessage As New AboutWin
        AboutMessage.ShowDialog(Me)
        e.Cancel = True
    End Sub
    Private Sub Calculator_FormClosing(sender As Object, e As Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Process.GetCurrentProcess().Kill()
    End Sub

    Private Sub Calculator_Shown(sender As Object, e As EventArgs) Handles Me.Shown ' AutoFocus (Args mode)
        If Command.Contains("--hex") Then
            Out.Focus()
            Out.Select(Out.Text.Length, &H0)
        Else
            Src.Select(Src.Text.Length, &H0)
        End If
    End Sub
End Class