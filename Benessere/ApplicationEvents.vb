Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    ' **NEW** ApplyHighDpiMode: Raised when the application queries the HighDpiMode to set it for the application.

    ' Example:

    ' Private Sub MyApplication_ApplyHighDpiMode(sender As Object, e As ApplyHighDpiModeEventArgs) Handles Me.ApplyHighDpiMode
    '     e.HighDpiMode = HighDpiMode.PerMonitorV2
    ' End Sub
    Partial Friend Class MyApplication
        Public settingsFile As String = "Settings.stx"
        Public gamesFile As String = "GamesList.stx"
        Public pinFile As String = "PIN.stx"
        Public shaMacFile As String = "sM.stx"
        Public PtsFile As String = "pts.stx"
        Public numFilters = 5
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            If Not IO.File.Exists(settingsFile) Then
                Dim writer As New IO.StreamWriter(settingsFile)
                For i As Integer = 0 To numFilters
                    writer.WriteLine("0")
                Next
                writer.Close()
            End If
        End Sub
    End Class
End Namespace
