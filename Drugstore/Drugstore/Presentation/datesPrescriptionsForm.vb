Public Class datesPrescriptionsForm

    ' Adds all the existing patients to a listbox
    Public Function fillPatientListBox() As Boolean
        Dim pa As Patient = New Patient()

        Try
            pa.readAllPatients()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        For Each pa In pa.dao.patientsList
            patientsList.Items.Add(pa.PatientID & " - " & pa.PatName)
        Next

        Return True
    End Function

    ' Gets a list of the purchashed prescriptions between two dates
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pa As Patient
        Dim p As Prescription = New Prescription

        clearFields()

        Try
            pa = New Patient(Convert.ToInt32(patientsList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            p.getPrescriptionBetweenDates(pa, date1Box.Text, date2Box.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If Not prescriptionsList Is Nothing Then
            prescriptionsList.Items.Clear()
        End If

        For Each p In p.dao.prescriptionList
            prescriptionsList.Items.Add(p.PrescriptionID & " - " & p.Patient.PatName & " - " & p.PresDate)
        Next
    End Sub

    ' Adds all the exisiting prescription's medicines to a listbox
    Private Sub fillPrescriptionMedicines(ByVal p As Prescription)
        Dim m As Medicine

        If Not medicinesList Is Nothing Then
            medicinesList.Items.Clear()
        End If

        Try
            For Each m In p.Medicine
                m.readMedicine()
                medicinesList.Items.Add(m.MedicineID & " - " & m.MedDescription)
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        p.Medicine.Clear()
    End Sub

    ' Fills the date of prescription field
    Private Sub prescriptionsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles prescriptionsList.SelectedIndexChanged
        Dim p As Prescription

        Try
            p = New Prescription(Convert.ToInt32(prescriptionsList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            p.readPrescription()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        pDateLabel.Text = p.PresDate.ToString("d")
        costLabel.Text = p.ToPayAmount.ToString
        discountLabel.Text = p.DiscountedAmount.ToString
        patientLabel.Text = p.Patient.PatName
        fillPrescriptionMedicines(p)
    End Sub

    ' Fills the fields with the info of o the medicine
    Private Sub medicinesList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles medicinesList.SelectedIndexChanged
        Dim m As Medicine
        Dim p As Prescription

        Try
            p = New Prescription(Convert.ToInt32(prescriptionsList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            m = New Medicine(Convert.ToInt32(medicinesList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            m.readMedicine()
            m.readQuantity(p)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        descLabel.Text = m.MedDescription
        quantityLabel.Text = m.Quantity.ToString
    End Sub

    Private Sub patientsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles patientsList.SelectedIndexChanged
        clearFields()
    End Sub

    Public Sub clearFields()
        pDateLabel.Text = ""
        quantityLabel.Text = ""
        descLabel.Text = ""
        patientLabel.Text = ""
        costLabel.Text = ""
        discountLabel.Text = ""
        medicinesList.Items.Clear()
        prescriptionsList.Items.Clear()
    End Sub
End Class