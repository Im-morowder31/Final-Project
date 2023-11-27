Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.Windows.Forms
Imports Mysqlx
Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class SignupForm
    Dim conn As MySqlConnection

    Dim gender As String
    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click
        conn = openCon()

        ' Example of using the IsAnyTextFieldEmpty function
        Dim textFields As System.Windows.Forms.TextBox() = {txtConfirm, txtContact, txtEmail, txtFirstname, txtLastname, txtMiddle, txtPassword, txtUsername}

        If IsAnyTextFieldEmpty(textFields) Then
            MessageBox.Show("One or more text fields are empty!")

        ElseIf Not txtPassword.Text.Equals(txtConfirm.Text) Then
            MessageBox.Show("Your Password doest not match!")
        ElseIf CheckUsername(txtUsername.Text) Then
            MessageBox.Show("Your Username already taken!")
        Else
            Dim query As String = "INSERT INTO tblaccounts (fname, lname, mdlname, email, contact, username, password, gender) VALUES (@value1, @value2, @value3, @value4, @value5, @value6, @value7, @value8)"
            Dim command As New MySqlCommand(query, conn)

            ' Replace @value1, @value2, @value3 with actual values
            command.Parameters.AddWithValue("@value1", txtFirstname.Text)
            command.Parameters.AddWithValue("@value2", txtLastname.Text)
            command.Parameters.AddWithValue("@value3", txtMiddle.Text)
            command.Parameters.AddWithValue("@value4", txtEmail.Text)
            command.Parameters.AddWithValue("@value5", txtContact.Text)
            command.Parameters.AddWithValue("@value6", txtUsername.Text)
            command.Parameters.AddWithValue("@value7", txtPassword.Text)
            command.Parameters.AddWithValue("@value8", Me.gender)

            command.ExecuteNonQuery()
            MessageBox.Show("You are now Registed!")
            ClearAllText(textFields)
            Dim Login As New Form1
            Login.Show()
            Me.Hide()
        End If



    End Sub

    Private Sub rdGMale_CheckedChanged(sender As Object, e As EventArgs) Handles rdGMale.CheckedChanged
        Me.gender = "Male"
    End Sub

    Private Sub rdGFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rdGFemale.CheckedChanged
        Me.gender = "Female"
    End Sub

    Function CheckUsername(username As String)
        Dim conn As MySqlConnection
        Dim reader As MySqlDataReader
        Dim isSame As Boolean = False
        conn = openCon()
        Dim query As String = "SELECT * FROM tblaccounts WHERE username = @username"
        Dim command As New MySqlCommand(query, conn)
        command.Parameters.AddWithValue("@username", username)
        Try
            reader = command.ExecuteReader()
            If reader.HasRows Then
                isSame = True
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
        Return isSame
    End Function
End Class