Public Class femaleRankingForm
    Private Sub searchbt_Click(sender As Object, e As EventArgs) Handles searchbt.Click
        Dim pa As Patient = New Patient

        DataGridView1.Rows.Clear()

        Try
            pa.femaleRanking(date1Box.Text, date2Box.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        For Each pa In pa.dao.patientsList
            DataGridView1.Rows.Add(New String() {pa.PatientID.ToString, pa.PatName, pa.boughtMedicines.ToString})
        Next

    End Sub
End Class