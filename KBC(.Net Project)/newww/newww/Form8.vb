'QUESTION 1 PHONE A FRIEND HELPLINE

Public Class Form8

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        My.Computer.Audio.Play(My.Resources._30secs, AudioPlayMode.Background)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text = Label3.Text - 1
        If Label3.Text = 0 Then
            Timer1.Stop()
            Form6.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class