'QUESTION 5

Public Class Form18

    'Clock

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "Q.5. .Net is a collection of what ? "
        Label1.ForeColor = Color.DarkGoldenrod

        Button2.Text = ("A. Multiple languages")
        Button2.ForeColor = Color.PeachPuff
        Button3.Text = ("B. Multiple Technologies")
        Button3.ForeColor = Color.PeachPuff
        Button4.Text = ("C. Multiple Programs")
        Button4.ForeColor = Color.PeachPuff
        Button5.Text = ("D. Multiple Software ")
        Button5.ForeColor = Color.PeachPuff

        Timer1.Start()
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
       

    End Sub
 
    'Option B'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Button3.ForeColor = Color.Red
        Button2.BackColor = Color.LimeGreen
        Button2.ForeColor = Color.Bisque
        Timer1.Stop()


        If Button3.Enabled Then
            Button2.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False

        End If
        Timer1.Stop()
        MessageBox.Show("Your Answer is Wrong")
        Form19.Show()
        Me.Hide()

    End Sub
    'Option C'
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Button2.BackColor = Color.LimeGreen
        Button4.ForeColor = Color.Red
        Button2.ForeColor = Color.Bisque
        Timer1.Stop()


        If Button4.Enabled Then
            Button3.Enabled = False
            Button2.Enabled = False
            Button5.Enabled = False

        End If
        Timer1.Stop()
        MessageBox.Show("Your Answer is Wrong")
        Form19.Show()
        Me.Hide()

    End Sub
    'Option D'
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Button5.ForeColor = Color.Red
        Button2.BackColor = Color.LimeGreen
        Button2.ForeColor = Color.Bisque
        Timer1.Stop()

        If Button5.Enabled Then
            Button3.Enabled = False
            Button4.Enabled = False
            Button2.Enabled = False

        End If
        Timer1.Stop()
        MessageBox.Show("Your Answer is Wrong")
        Form19.Show()
        Me.Hide()

    End Sub
    'Option A'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Button2.BackColor = Color.LimeGreen

        Label2.BackColor = Color.LimeGreen
        Label4.BackColor = Color.LightGray
        Label3.BackColor = Color.LightGray
        Label5.BackColor = Color.LightGray
        Label6.BackColor = Color.LightGray
        'Forward
        Timer1.Stop()
        MessageBox.Show("Congratulations... You Win..!")
        Form24.Show()
        Me.Hide()

    End Sub
   
    'Main Timer 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = Label7.Text - 1

        If Label7.Text = 0 Then
            Timer1.Stop()
            MessageBox.Show("Time Up.")
            Form19.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form19.Show()
        Me.Hide()
    End Sub
End Class
