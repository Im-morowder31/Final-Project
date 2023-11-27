Public Class AdminMain
    Private Sub btbnAddProd_Click(sender As Object, e As EventArgs) Handles btbnAddProd.Click
        Dim addProd As New AddProd

        addProd.Show()
        Me.Hide()
    End Sub
End Class