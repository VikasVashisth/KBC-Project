Public Class Form2

    Dim inc As Integer
    Dim MaxRows As Integer
    Dim con As New OleDb.OleDbConnection
    Dim dbProvider As String
    Dim dbSource As String
    Dim MyDocumentsFolder As String
    Dim TheDatabase As String
    Dim FullDatabasePath As String
    Dim sql As String
    Dim ds As New DataSet
    Dim da As OleDb.OleDbDataAdapter


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text = "") And (MaskedTextBox1.Text = "") And (TextBox2.Text = "") Then
            Label9.ForeColor = Color.Red
            Label9.Text = "Mandatory"
            Label10.ForeColor = Color.Red
            Label10.Text = "Mandatory"
            Label11.ForeColor = Color.Red
            Label11.Text = "Mandatory"

        Else
            Label9.Text = " "
            Label10.Text = " "
            Label11.Text = " "
            MessageBox.Show("Remenber your E-Mail Id and Password.")
            Form3.Show()
            Me.Hide()
        End If




        Dim cb As New OleDb.OleDbCommandBuilder(da)

        ds.Tables("KBC data").Rows(inc).Item(1) = MaskedTextBox2.Text  'Phone Number
        ds.Tables("KBC data").Rows(inc).Item(2) = TextBox2.Text         'Name 
        ds.Tables("KBC data").Rows(inc).Item(3) = MaskedTextBox1.Text    'Password
        ds.Tables("KBC data").Rows(inc).Item(4) = TextBox1.Text          'E-mail Id

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        sql = "SELECT * FROM KBC data"
        da = New OleDb.OleDbDataAdapter(sql, con)

        dbProvider = "PROVIDER=Microsoft.Jet.OLEDB.4.0;"
        TheDatabase = "\Database1.mdb"
        MyDocumentsFolder = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        FullDatabasePath = MyDocumentsFolder & TheDatabase
        dbSource = "Data Source = " & FullDatabasePath
        con.ConnectionString = dbProvider & dbSource
        con.Open()
        MessageBox.Show("Database is now open")
        sql = "SELECT * FROM KBC data"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Database KBC")
        MessageBox.Show("Database is now open")

        con.Close()
        MessageBox.Show("Database is now Closed")

    End Sub


End Class