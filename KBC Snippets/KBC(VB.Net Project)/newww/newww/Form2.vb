Imports System.Data.OleDb

Public Class Form2

    Dim provider As String
    Dim datafile As String
    Dim connString As String
    Dim myConnection As OleDbConnection = New OleDbConnection

    Dim MyDocumentsFolder As String
    Dim TheDatabase As String
    Dim FullDatabasePath As String
    Dim sql As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click




        If (TextBox1.Text = "") Or (MaskedTextBox1.Text = "") Or (TextBox2.Text = "") Or (TextBox4.Text = "") Then
            Label9.ForeColor = Color.Red
            Label9.Text = "Mandatory"
            Label10.ForeColor = Color.Red
            Label10.Text = "Mandatory"
            Label11.ForeColor = Color.Red
            Label11.Text = "Mandatory"
            Label13.ForeColor = Color.Red
            Label13.Text = "Mandatory"

        Else

            provider = " Provider=Microsoft.ACE.OLEDB.12.0;Data Source="
            datafile = "C:\Users\acer\Documents\Database1.accdb"
            connString = provider & datafile
            myConnection.ConnectionString = connString

            myConnection.Open()

            Dim str As String
            str = "Insert into KBCdata([Phone Number],[E-mail Id],[Password],[Name]) Values(?,?,?,?)"
            Dim cmd As OleDbCommand = New OleDbCommand(str, myConnection)
            cmd.Parameters.Add(New OleDbParameter("Phone Number", CType(TextBox4.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("E-mail Id", CType(TextBox1.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Password", CType(MaskedTextBox1.Text, String)))
            cmd.Parameters.Add(New OleDbParameter("Name", CType(TextBox2.Text, String)))

            Try
                cmd.ExecuteNonQuery()
                cmd.Dispose()
                myConnection.Close()

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            Dim cb As New OleDb.OleDbCommandBuilder(da)


            Label9.Text = " "
            Label10.Text = " "
            Label11.Text = " "
            Label13.Text = " "
            MessageBox.Show("Remember your E-Mail Id and Password.")
            Form3.Show()
            Me.Hide()
        End If



    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class