Option Strict On

Public Class Form1

    Private Sub btnPopulation_Click(sender As System.Object, e As System.EventArgs) Handles btnPopulation.Click

        Dim curyear As Integer
        Dim curpop As Double

        curyear = 2012
        curpop = 7000

        Do While (curpop > 6)
            curpop = curpop / 2
            curyear = curyear - 50
        Loop
        MessageBox.Show("The year is " & curyear, "Error")

    End Sub
End Class
