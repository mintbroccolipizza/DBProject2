Imports MySql.Data.MySqlClient

Public Class Form2
    Dim Gender As String
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;database=DBProject"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO DBProject.edata (EID,Name,Surname,Age,Gender,DOB) VALUES ('" & TextBox_EID.Text & "', '" & TextBox_Name.Text & "', '" & TextBox_Surname.Text & "', '" & TextBox_Age.Text & "','" & Gender & "', '" & DateTimePicker_DOB.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data saved")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles UpdateBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;database=DBProject"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE DBProject.edata SET EID='" & TextBox_EID.Text & "',Name='" & TextBox_Name.Text & "',Surname='" & TextBox_Surname.Text & "',Age='" & TextBox_Age.Text & "' WHERE EID='" & TextBox_EID.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data updated")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub Delete_Btn_Click(sender As Object, e As EventArgs) Handles Delete_Btn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;database=DBProject"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "DELETE FROM DBProject.edata WHERE EID = '" & TextBox_EID.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data deleted")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;database=DBProject"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM DBProject.edata"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim sName = READER.GetString("Name")
                ComboBox1.Items.Add(sName)
                ListBox1.Items.Add(sName)

            End While

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;database=DBProject"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM DBProject.edata WHERE Name='" & ComboBox1.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                TextBox_EID.Text = READER.GetInt32("Eid")
                TextBox_Name.Text = READER.GetString("Name")
                TextBox_Surname.Text = READER.GetString("Surname")
                TextBox_Age.Text = READER.GetInt32("Age")

            End While

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;database=DBProject"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM DBProject.edata WHERE Name='" & ListBox1.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                TextBox_EID.Text = READER.GetInt32("Eid")
                TextBox_Name.Text = READER.GetString("Name")
                TextBox_Surname.Text = READER.GetString("Surname")
                TextBox_Age.Text = READER.GetInt32("Age")
            End While

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub load_table()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;database=DBProject"
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM DBProject.edata"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub
    Private Sub TblButton_Click(sender As Object, e As EventArgs) Handles TblButton.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;database=DBProject"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM DBProject.edata"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            TextBox_EID.Text = row.Cells("Eid").Value.ToString
            TextBox_Name.Text = row.Cells("Name").Value.ToString
            TextBox_Surname.Text = row.Cells("Surname").Value.ToString
            TextBox_Age.Text = row.Cells("Age").Value.ToString

        End If

    End Sub

    Private Sub Search_Text_TextChanged(sender As Object, e As EventArgs) Handles Search_Text.TextChanged
        Dim DV As New DataView(dbDataSet)
        DV.RowFilter = String.Format("Name like '%{0}%'", Search_Text.Text)
        DataGridView1.DataSource = DV

    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Do you really want to close the app.", "Exit", MessageBoxButtons.YesNo)

        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()

        End If

    End Sub

    Private Sub RadioButton_Male_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Male.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub RadioButton_Female_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Female.CheckedChanged
        Gender = "Female"
    End Sub

    Private Sub LoadChart_Btn_Click(sender As Object, e As EventArgs) Handles LoadChart_Btn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;database=DBProject"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM DBProject.edata"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Chart1.Series("Name_VS_Age").Points.AddXY(READER.GetString("Name"), READER.GetInt32("Age"))

            End While

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

End Class