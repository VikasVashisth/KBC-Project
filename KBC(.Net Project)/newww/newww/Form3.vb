Public Class Form3

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form2.Show()
        Me.Hide()

    End Sub
    'recover
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("E-MAIL ID :  " + Form2.TextBox1.Text + "  PASSWORD :  " + Form2.MaskedTextBox1.Text)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text = Form2.TextBox1.Text) And (MaskedTextBox1.Text = Form2.MaskedTextBox1.Text) Then
            form4.show()
            Me.Hide()
            Form4.Timer1.Start()


            My.Computer.Audio.Play(My.Resources.KBC, AudioPlayMode.Background)
        Else
            MessageBox.Show("Please Fill Correct Details to Play the game")
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

End Class