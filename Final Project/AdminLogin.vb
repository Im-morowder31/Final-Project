Imports MySql.Data.MySqlClient

Public Class AdminLogin
    Dim conn As MySqlConnection
    Dim reader As MySqlDataReader
    Private Sub lblSignup_Click(sender As Object, e As EventArgs) Handles lblSignup.Click
        Dim Login As New Form1
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        conn = openCon()
        Dim query As String = "SELECT * FROM tblssystems WHERE username = @username AND password = @password"
        Dim command As New MySqlCommand(query, conn)

        command.Parameters.AddWithValue("@username", txtUserLog.Text)
        command.Parameters.AddWithValue("@password", txtPassLog.Text)
        Try
            reader = command.ExecuteReader()
            If reader.HasRows Then
                MessageBox.Show("Login successful!")
                ' Navigate to the next form or perform other actions after successful login
                Dim frmMainAdmin As New AdminMain
                frmMainAdmin.Show()
                Me.Hide()
            Else
                ' User not found or incorrect credentials
                MessageBox.Show("Invalid username or password. Please try again.")

            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

End Class