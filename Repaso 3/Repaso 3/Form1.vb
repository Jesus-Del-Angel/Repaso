Public Class Form1
    Dim contador = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        contador += 1
        Label2.Text = contador
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label2.Text = "0"
        contador = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        contador += 2
        Label2.Text = contador
    End Sub
End Class
