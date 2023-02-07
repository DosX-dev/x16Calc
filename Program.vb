Imports System.Runtime.CompilerServices
Imports System.Windows.Forms

Module Program
    Dim MainWindow As New Calculator
    <STAThread()>
    Public Sub Main()
        Try

            ' При подключении системных визуальных стилей после объявления формы
            ' все элементы управления сохраняют свой первоначальный "сырой" вид.
            ' Но при этом, текстовые поля стилизуются только при открытии окна,
            ' а потому стили активируются сразу, без надобности перезапускать
            ' приложение. Остальные части интерфейса останутся нетронутыми
            '
            ' [Использование Watermark в текстовых полях
            ' возможно только с визуальными стилями]
            Application.EnableVisualStyles()

            ' Именно ради этих строчек кода и следовало тянуть рендеринг
            ' системных стилей
            MainWindow.Src.SetWatermark("Decimal")
            MainWindow.Out.SetWatermark("Hexadecimal")

            Call Command.API

        Catch ex As Exception
            MsgBox("Invalid data.", &H10) : End
        End Try

        Application.Run(MainWindow)
    End Sub
    Public Sub HelpMsg()
        MsgBox($"Arguments:{vbLf}--about — show program information{vbLf}--int {{NUM}} — insert number into INT32 field{vbLf}--hex {{HEX}} — insert hex value into HEX field{vbLf & vbLf}Examples:{vbLf}x16Calc --int 2147483647{vbLf}x16Calc --hex 0x7FFFFFFF", &H0, $"{Application.ProductName} [ --help ]")
    End Sub

    <Extension>
    Sub API(Cmd As String)
        Dim HelpTag = "--help",
            AboutTag = "--about",
            HexTag = "--hex",
            IntTag = "--int"

        If Cmd.Contains(HelpTag) Then
            HelpMsg() : End
        End If

        If Cmd.Contains(AboutTag) Then ' [About]
            Dim AboutMessage As New AboutWin
            AboutMessage.StartPosition = FormStartPosition.CenterScreen
            AboutMessage.ShowDialog()
            End
        End If

        If Cmd.Contains(HexTag) Then ' [Insert HEX]
            Cmd = Cmd.Replace(HexTag, String.Empty)
            Try
                MainWindow.Out.Text = Cmd.Trim.Split(" ")(0)
            Catch ex As Exception
                Exit Sub
            End Try
            MainWindow.DoCalc_ToInt()
            Exit Sub
        End If

        If Cmd.Contains(IntTag) Then ' [Insert DEC]
            Cmd = Cmd.Replace(IntTag, String.Empty)
            Try
                MainWindow.Src.Text = CInt(Cmd.Trim.Split(" ")(0))
            Catch ex As Exception
                Exit Sub
            End Try
            MainWindow.DoCalc_ToHex()
            Exit Sub
        End If
    End Sub
End Module
