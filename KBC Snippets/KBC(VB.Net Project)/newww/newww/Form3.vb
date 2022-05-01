Public Class Form3

    'recover
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Form25.Show()
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text = Form2.TextBox1.Text) And (MaskedTextBox1.Text = Form2.MaskedTextBox1.Text) Then
            Form4.Show()
            Me.Hide()
            Form4.Timer1.Start()


            My.Computer.Audio.Play(My.Resources.KBC, AudioPlayMode.Background)
        Else
            MessageBox.Show("Please Fill Correct Details to Play the game")
        End If
    End Sub

End Class