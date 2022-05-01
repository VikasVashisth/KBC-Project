'QUESTION 3 PUBLIC VOTE HELPLINE
Public Class Form17

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
        Timer2.Start()
        Timer3.Start()
        Timer4.Start()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(2)

        If ProgressBar1.Value = 20 Then
            Label6.Text = "20 %"
            Timer1.Stop()

        End If

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ProgressBar2.Increment(2)

        If ProgressBar2.Value = 28 Then
            Label7.Text = "28 %"
            Timer2.Stop()

        End If

    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        ProgressBar3.Increment(2)

        If ProgressBar3.Value = 80 Then
            Label8.Text = "80 %"
            Timer3.Stop()


        End If
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        ProgressBar4.Increment(2)

        If ProgressBar4.Value = 92 Then
            Label9.Text = "92 %"
            Timer4.Stop()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form15.Show()
        Me.Hide()

    End Sub
End Class