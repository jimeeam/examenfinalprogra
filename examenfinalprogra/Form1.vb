Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "Ilsy Ortíz" And TextBox2.Text = "123" Then
            Form2.Show()
            Hide()
        End If
        If TextBox1.Text = "Waldir Castillo" And TextBox2.Text = "456" Then
            Form2.Show()
            Hide()
        End If
    End Sub
End Class
