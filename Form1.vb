Public Class Form1
    Private Sub btnWelcome_Click(sender As Object, e As EventArgs) Handles btnWelcome.Click
        MessageBox.Show("Welcome to WinForm Design!", Me.Text)
    End Sub


    Private Sub btnWelcome_MouseEnter(sender As Object, e As EventArgs) Handles btnWelcome.MouseEnter
        btnWelcome.Text = "Okaeri!"

    End Sub

    Private Sub btnWelcome_MouseLeave(sender As Object, e As EventArgs) Handles btnWelcome.MouseLeave
        btnWelcome.Text = "Itterashai!"
    End Sub
End Class
