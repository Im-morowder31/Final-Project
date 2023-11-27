Imports MySql.Data.MySqlClient

Module MyFunction

    Dim conn As MySqlConnection
    Public Function openCon()

        'conn = New MySqlConnection("server=localhost;port=3306;userid=root;password=Goh@ancute3131;database=ecommence")
        conn = New MySqlConnection("server=localhost;port=3306;userid=root;database=ecommence")

        If (conn.State = ConnectionState.Closed) Then
            conn.Open()
        Else
            conn.Close()
        End If
        Return conn
    End Function

    Function IsAnyTextFieldEmpty(textFields() As TextBox) As Boolean
        For Each textField As TextBox In textFields
            If String.IsNullOrEmpty(textField.Text) Then
                Return True ' At least one text field is empty
            End If
        Next
        Return False ' No text fields are empty
    End Function
    Function ClearAllText(textFields() As TextBox) As Boolean
        For Each textField As TextBox In textFields
            textField.Text = ""
        Next
        Return False ' No text fields are empty
    End Function
    Function SQLInsert(table As String, columns As Dictionary(Of String, String))
        Dim query As String = $"INSERT INTO {table} ({String.Join(", ", columns.Keys)}) VALUES ({String.Join(", ", columns.Keys.Select(Function(key) "@key" & key))})"
        Dim command As New MySqlCommand(query, conn)

        For Each item As KeyValuePair(Of String, String) In columns
            command.Parameters.AddWithValue($"@key{item.Key}", $"{item.Value}")
        Next
        command.ExecuteNonQuery()
        Return True
    End Function
End Module
