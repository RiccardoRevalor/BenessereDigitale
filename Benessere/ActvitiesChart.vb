Imports System.Windows.Forms.DataVisualization.Charting
Imports ScottPlot
Public Class ActvitiesChart
    Private Sub ActvitiesChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        plottaDati()

    End Sub

    Private Sub plottaDati()
        'Dim giorniSettimana() As String = {"Lunedì", "Martedì", "Mercoledì", "Giovedì", "Venerdì", "Sabato", "Domenica"}
        Dim oreDiGioco() As Double = {2, 4, 1, 3, 5, 2, 6}
        Dim giorni() As Double = {1, 2, 3, 4, 5, 6, 7}
        FormsPlot1.Plot.XLabel("Giorni")
        FormsPlot1.Plot.YLabel("Ore/giorno")
        FormsPlot1.Plot.Title("Grafico Attività settimanale")
        Dim myDates As DateTime() = New DateTime(6) {}
        For i As Integer = 0 To myDates.Length - 1
            myDates(i) = New DateTime(2023, 5, 24).AddDays(1 * i)
        Next

        ' Convert DateTime() to Double() before plotting
        Dim xs As Double() = myDates.[Select](Function(x) x.ToOADate()).ToArray()
        FormsPlot1.Plot.PlotBar(xs, oreDiGioco)
        FormsPlot1.Plot.XAxis.DateTimeFormat(True)
        Dim media As Double = oreDiGioco.Average()
        FormsPlot1.Plot.AddScatter(xs, Enumerable.Repeat(media, xs.Length).ToArray())
        'FormsPlot1.Plot.AddScatter(giorni, oreDiGioco)
        FormsPlot1.Refresh()
        FirefoxH21.Text = "Hai giocato in media " + Math.Floor(media).ToString + " ore al giorno!"
    End Sub

    Private Function double2Day(ByVal n As Double)

    End Function
End Class
Public Class GiornoGioco
    Public Property Giorno As String
    Public Property OreGioco As Integer

    Public Sub New(ByVal giorno As String, ByVal oreGioco As Integer)
        Me.Giorno = giorno
        Me.OreGioco = oreGioco
    End Sub
End Class