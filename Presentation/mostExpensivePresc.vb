Public Class mostExpensivePresc

    Private Sub prescriptionList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles prescriptionList.SelectedIndexChanged
        Dim p As Prescription

        Try
            p = New Prescription(Convert.ToInt32(prescriptionList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            p.readPrescription()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        dateLabel.Text = p.PresDate.ToString("d")
        costLabel.Text = p.ToPayAmount.ToString
        discountLabel.Text = p.DiscountedAmount.ToString
        patientLabel.Text = p.Patient.PatName

        fillPrescriptionMedicines(p)
    End Sub

    ' Subroutine to get the most expensive prescriptions
    Public Function calculateMostExpensive() As Boolean
        Dim p As Prescription = New Prescription
        Try
            p.mostExpensivePrescriptions()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        For Each p In p.dao.prescriptionList
            prescriptionList.Items.Add(p.PrescriptionID & " - " & p.Patient.PatName & " - " & p.PresDate)
        Next

        Return True
    End Function

    ' Adds all the exisiting prescription's medicines to a listbox
    Private Function fillPrescriptionMedicines(ByVal p As Prescription) As Boolean
        Dim m As Medicine

        If Not medicineList Is Nothing Then
            medicineList.Items.Clear()
        End If

        Try
            For Each m In p.Medicine
                m.readMedicine()
                medicineList.Items.Add(m.MedicineID & " - " & m.MedDescription)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        If Not medicineList Is Nothing Then
            medicineList.SelectedItem = 0
        End If

        p.Medicine.Clear()

        Return True
    End Function

    Private Sub medicineList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles medicineList.SelectedIndexChanged
        Dim p As Prescription = New Prescription(Convert.ToInt32(prescriptionList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
        Dim m As Medicine

        Try
            m = New Medicine(Convert.ToInt32(medicineList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            m.readQuantity(p)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        descLabel.Text = m.MedDescription
        quantityLabel.Text = m.Quantity.ToString
    End Sub
End Class