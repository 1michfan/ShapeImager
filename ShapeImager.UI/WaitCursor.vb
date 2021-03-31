Imports System.Windows.Forms
Imports System.Runtime.InteropServices

Public NotInheritable Class WaitCursor
    Implements IDisposable

    Public Sub New()
        Enabled = True
    End Sub

    Public Shared Property Enabled As Boolean
        Get
            Return Application.UseWaitCursor
        End Get
        Set(ByVal value As Boolean)
            If value = Application.UseWaitCursor Then Return
            Application.UseWaitCursor = value
            Dim f As Form = Form.ActiveForm
            If f IsNot Nothing AndAlso f.Handle <> IntPtr.Zero Then SendMessage(f.Handle, &H20, f.Handle, CType(1, IntPtr))
        End Set
    End Property

    Public Sub Dispose() Implements IDisposable.Dispose
        Enabled = False
    End Sub
End Class

Friend Module NativeMethods
    <DllImport("user32.dll")>
    Friend Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr) As IntPtr

    End Function
End Module

