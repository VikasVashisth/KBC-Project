﻿'QUESTION 3
Public Class Form12

    'Clock

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "Q.3. What is the Full Form of .mscoee in .net ? "
        Label1.ForeColor = Color.DarkGoldenrod

        Button2.Text = ("A. Microsoft Compile Object Execuation Engine")
        Button2.ForeColor = Color.PeachPuff
        Button3.Text = ("B. Microsoft Component Object Exercise Engine")
        Button3.ForeColor = Color.PeachPuff
        Button4.Text = ("C. Microsoft Component Oriented Execuation Engine")
        Button4.ForeColor = Color.PeachPuff
        Button5.Text = ("D. Microsoft Component Object Execuation Engine")
        Button5.ForeColor = Color.PeachPuff

        Timer1.Start()
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Button5.Enabled = True
        Button6.Enabled = True
        Button7.Enabled = True
        Button8.Enabled = True

    End Sub
    '50-50 lifeline'
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Button2.BackColor = Color.Red
        Button4.BackColor = Color.Red
        Button2.Enabled = False
        Button4.Enabled = False
        My.Computer.Audio.Play(My.Resources.drum, AudioPlayMode.Background)
        Button7.Enabled = False
        Button8.Enabled = False
        Timer1.Stop()

    End Sub
    'Phone a friend lifeline'
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        MessageBox.Show("You will have to choose one option after using this lifeline ,clock will be stoppped and you can't quit. But you can use another lifeline.")
        form14.Show()
        If Button8.Enabled Then
            Button8.Enabled = False

            Timer1.Stop()

        End If

    End Sub
    'Option B'
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button3.ForeColor = Color.Red
        Button5.ForeColor = Color.Bisque
        Button5.BackColor = Color.LimeGreen

        Timer1.Stop()


        If Button3.Enabled Then
            Button2.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False

        End If
        MessageBox.Show("Your Answer is Wrong")
        Form22.Show()
        Me.Hide()
    End Sub
    'Option C'
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Button4.ForeColor = Color.Red
        Button5.ForeColor = Color.Bisque
        Button5.BackColor = Color.LimeGreen
        Timer1.Stop()

        If Button4.Enabled Then
            Button3.Enabled = False
            Button2.Enabled = False
            Button5.Enabled = False

        End If
        MessageBox.Show("Your Answer is Wrong")
        Form22.Show()
        Me.Hide()
    End Sub
    'Option D'
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Button5.BackColor = Color.LimeGreen
        Label4.BackColor = Color.LimeGreen
        Timer1.Stop()
        'move forward
        MessageBox.Show("you can move forward")
        Button10.Enabled = True

        If Button5.Enabled Then
            Button3.Enabled = False
            Button4.Enabled = False
            Button2.Enabled = False

        End If
    End Sub
    'Option A'
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.ForeColor = Color.Red
        Button5.ForeColor = Color.Bisque
        Button5.BackColor = Color.LimeGreen

        Timer1.Stop()
        MessageBox.Show("Your Answer is Wrong")
        Form22.Show()
        Me.Hide()
    End Sub
    'Public Poll lifeline'
    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        MessageBox.Show("You will have to choose one option after using this lifeline , clock will be stopped and you can't quit. But you can choose another lifeline.")
        Form13.Show()

        Timer1.Stop()
    End Sub
    'Main Timer 
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label7.Text = Label7.Text - 1

        If Label7.Text = 0 Then
            Timer1.Stop()
            MessageBox.Show("Time Up.")
            Form22.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Form15.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Form22.Show()
        Me.Hide()
    End Sub
End Class
