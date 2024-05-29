Imports System.Runtime.InteropServices

Module ConsoleHelper
    <DllImport("kernel32.dll")>
    Private Function AllocConsole() As Boolean
    End Function

    Public Sub ShowConsole()
        AllocConsole()
    End Sub
End Module