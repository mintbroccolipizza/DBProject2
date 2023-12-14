Imports System.Net.Security
Imports MySql.Data.MySqlClient

Public Class Form1
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;database=DBProject"

        Try
            MysqlConn.Open()
            MessageBox.Show("Connection Successful")
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try

    End Sub

    Private Sub Login_Btn_Click(sender As Object, e As EventArgs) Handles Login_Btn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost;userid=root;database=DBProject"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM DBProject.edata WHERE user_name='" & TextBox_UN.Text & "' and password='" & TextBox_PW.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0

            While READER.Read
                count = count + 1

            End While

            If count = 1 Then
                MessageBox.Show("Username and Password are correct")
                Form2.Show()
                Me.Hide()

            ElseIf count > 1 Then
                MessageBox.Show("Username and Password are duplicate")
            Else
                MessageBox.Show("Username and Password are not correct")
            End If

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()

        End Try

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox_UN_TextChanged(sender As Object, e As EventArgs) Handles TextBox_UN.TextChanged

    End Sub
End Class
