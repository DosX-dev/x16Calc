Imports System.Runtime.CompilerServices
Imports System.Runtime.InteropServices

Module TextBoxWatermarkExtensionMethod ' WinAPI (Only for Windows)
    Private Const ECM_FIRST As UInteger = &H1500
    Private Const EM_SETCUEBANNER As UInteger = ECM_FIRST + 1
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=False)>
    Private Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As UInteger, ByVal wParam As UInteger,
    <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As IntPtr
    End Function
    <Extension()>
    Sub SetWatermark(ByVal TXT As System.Windows.Forms.TextBox, ByVal WaterMarkTextString As String)
        SendMessage(TXT.Handle, EM_SETCUEBANNER, 0, WaterMarkTextString)
    End Sub
End Module
