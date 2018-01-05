Public Class underAgeMedicineIncome

    Public Function calculateIncome() As Boolean
        Dim m As Medicine = New Medicine
        Try
            m.calculateIncome()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        For Each m In m.dao.medicinesList
            DataGridView1.Rows.Add(New String() {m.MedDescription, m.income.ToString})
        Next
        Return True
    End Function

End Class