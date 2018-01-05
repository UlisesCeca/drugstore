Public Class medicineRankingForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles searchbt.Click
        Dim m As Medicine = New Medicine

        DataGridView1.Rows.Clear()

        Try
            m.medicineRanking(date1Box.Text, date2Box.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        For Each m In m.dao.medicinesList
            DataGridView1.Rows.Add(New String() {m.MedDescription, m.Quantity.ToString})
        Next
    End Sub
End Class