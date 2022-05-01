Public Class Form25
    'recovering form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If (TextBox1.Text = Form2.TextBox4.Text) Then
            MessageBox.Show(" Phone Number Correct ... You retrieved your Information")

            MessageBox.Show("E-MAIL ID :  " + Form2.TextBox1.Text + "  PASSWORD :  " + Form2.MaskedTextBox1.Text)
        Else
            MessageBox.Show("Please Enter the Correct Phone Number")
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form3.Show()
        Me.Close()
    End Sub

End Class