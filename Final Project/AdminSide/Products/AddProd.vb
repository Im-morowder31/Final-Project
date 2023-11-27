Imports MySql.Data.MySqlClient
Imports System.IO
Imports System.Security.Cryptography

Public Class AddProd
    Dim conn As MySqlConnection
    Dim imagePath As String = Path.GetFullPath("..\..") & "\Images"
    Dim haveIMG As String = False

    Private Sub btnAddProd_Click(sender As Object, e As EventArgs) Handles btnAddProd.Click
        ' Example of using the IsAnyTextFieldEmpty function
        Dim textFields As System.Windows.Forms.TextBox() = {txtItem, txtPrice, txtQTY, txtCategory}

        MessageBox.Show(imagePath)

        If IsAnyTextFieldEmpty(textFields) Then
            MessageBox.Show("One or more text fields are empty!")
        ElseIf String.IsNullOrEmpty(cbSize.Text) Then
            MessageBox.Show("Your Size doest not selected!")
        ElseIf haveIMG = False Then
            MessageBox.Show("Image path is not valid.")
        Else
            conn = openCon()
            Dim addProds As New Dictionary(Of String, String) From {
                {"item", txtItem.Text},
                {"category", txtCategory.Text},
                {"size", cbSize.Text},
                {"stock", txtQTY.Text},
                {"image", imagePath & "\" & Path.GetFileName(fdImg.FileName)}
            }
            If haveIMG = True Then
                File.Copy(fdImg.FileName, imagePath & "\" & Path.GetFileName(fdImg.FileName), True)
            End If

            SQLInsert("tblproducts", addProds)
            MessageBox.Show($"{txtItem.Text} are now Added!")
            ClearAllText(textFields)
            Dim Login As New Form1
            Login.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub btnSelectIImg_Click(sender As Object, e As EventArgs) Handles btnSelectIImg.Click
        If fdImg.ShowDialog <> System.Windows.Forms.DialogResult.Cancel Then
            pbPic.Image = Image.FromFile(fdImg.FileName)
            pbPic.SizeMode = PictureBoxSizeMode.StretchImage
            haveIMG = True
        Else
            haveIMG = False

        End If
    End Sub

    Private Sub AddProd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fdImg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
    End Sub

    Private Sub txtQTY_TextChanged(sender As Object, e As KeyPressEventArgs) Handles txtQTY.KeyPress
        ' Check if the pressed key is a control key (e.g., Backspace) or a numeric character
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            ' If it's not a control key or a numeric character, suppress the key press
            e.Handled = True
        End If
    End Sub

    Private Sub txtPrice_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPrice.KeyPress
        ' Check if the pressed key is a control key (e.g., Backspace) or a numeric character
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            ' If it's not a control key or a numeric character, suppress the key press
            e.Handled = True
        End If
    End Sub

End Class