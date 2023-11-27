Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Form1
    Dim conn As MySqlConnection
    Dim reader As MySqlDataReader
    Private Sub lblSignup_Click(sender As Object, e As EventArgs) Handles lblSignup.Click
        Dim frmSigup As New SignupForm
        frmSigup.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        conn = openCon()
        Dim query As String = "SELECT * FROM tblaccounts WHERE username = @username AND password = @password"
        Dim command As New MySqlCommand(query, conn)

        command.Parameters.AddWithValue("@username", txtUserLog.Text)
        command.Parameters.AddWithValue("@password", txtPassLog.Text)
        Try
            reader = command.ExecuteReader()
            If reader.HasRows Then
                MessageBox.Show("Login successful!")
                ' Navigate to the next form or perform other actions after successful login
            Else
                ' User not found or incorrect credentials
                MessageBox.Show("Invalid username or password. Please try again.")

            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblAdminLog.Click
        Dim adminLogin As New AdminLogin
        adminLogin.Show()
        Me.Hide()
    End Sub
End Class
