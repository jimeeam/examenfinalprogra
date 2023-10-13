Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, resultado As Double
        a = TextBox1.Text
        b = TextBox2.Text
        resultado = a + b
        TextBox3.Text = resultado
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub
End Class