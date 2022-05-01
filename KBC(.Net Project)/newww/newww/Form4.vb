Public Class Form4

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 30 Then
            Label1.Text = "Questions are Building up for you"
        End If
        If ProgressBar1.Value = 60 Then
            Label1.Text = "Additional features are adding"
        End If
        If ProgressBar1.Value = 80 Then
            Label1.Text = "it's Almost done"
        End If
        If ProgressBar1.Value = 90 Then
            Label1.Text = "Welcome  " + Form2.TextBox2.Text + "  Let's Play..!"
        End If

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            Form5.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class