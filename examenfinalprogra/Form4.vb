Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, b, resultado As Double
        a = TextBox1.Text
        b = TextBox2.Text
        resultado = a - b
        TextBox3.Text = resultado
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Show()
    End Sub
End Class