Module Program
    Sub Main()
        ' Show the console window
        ConsoleHelper.ShowConsole()

        ' Run the main form
        Application.EnableVisualStyles()
        Application.SetCompatibleTextRenderingDefault(False)
        Application.Run(New Form1())
    End Sub
End Module
