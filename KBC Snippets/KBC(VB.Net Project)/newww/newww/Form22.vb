' Question 3 form 12  3,00,000
Public Class Form22

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBox1.Text = Form2.TextBox1.Text) And (MaskedTextBox1.Text = Form2.MaskedTextBox1.Text) Then
            Label6.Text = Form2.TextBox2.Text
            Me.Label7.Text = "2,00,000"
            My.Computer.Audio.Play(My.Resources.applause, AudioPlayMode.Background)
        Else
            MessageBox.Show("Details are not correct")
        End If
    End Sub
End Class