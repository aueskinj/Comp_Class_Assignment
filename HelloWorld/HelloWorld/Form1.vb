Public Class Form1

    Dim Message As String = "This is a message string"
    Dim intvar As Integer = 25

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MessageBox.Show(intvar)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        If TextBox1.Text = "1" Then
            Label1.Text = "message 1"
        End If
        If TextBox1.Text = "2" Then
            Label1.Text = "message 2"
        End If
        If TextBox1.Text = "3" Then
            Label1.Text = "message 3"
        End If
    End Sub

End Class
