Public Class Form1
    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        Dim numero1 = Val(num1.Text)
        Dim numero2 = Val(num2.Text)
        Dim resultado = numero1 + numero2
        Label2.Text = resultado
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        Dim numero1 = Val(num1.Text)
        Dim numero2 = Val(num2.Text)
        Dim resultado = numero1 - numero2
        Label2.Text = resultado
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        Dim numero1 = Val(num1.Text)
        Dim numero2 = Val(num2.Text)
        Dim resultado = numero1 * numero2
        Label2.Text = resultado
    End Sub

    Private Sub btndividir_Click(sender As Object, e As EventArgs) Handles btndividir.Click
        If num2.Text = 0 Then
            Label2.Text = "Error"

        Else
            Dim numero1 = Val(num1.Text)
            Dim numero2 = Val(num2.Text)
            Dim resultado = numero1 / numero2
            Label2.Text = resultado
        End If

    End Sub
    'Private Sub accion_Click(sender As Object, e As EventArgs) Handles accion.Click
    'Dim num = num1.Text
    'Dim entero = Val(num)
    ' operacion = entero * 2
    'Label2.Text = operacion.ToString()
    'End Sub
End Class
