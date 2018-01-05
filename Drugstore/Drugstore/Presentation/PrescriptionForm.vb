Public Class PrescriptionForm

    ' Fills the fields with the info from the selected prescription
    Private Sub prescriptionList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles prescriptionList.SelectedIndexChanged
        Dim p As Prescription

        Try
            p = New Prescription(Convert.ToInt32(prescriptionList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            p.readPrescription()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        patientList.SelectedItem = p.Patient.PatientID & " - " & p.Patient.PatName
        dateBox.Text = p.PresDate.ToString("d")
        costBox.Text = p.ToPayAmount.ToString
        disccountBox.Text = p.DiscountedAmount.ToString
        patientBox.Text = p.Patient.PatientID.ToString
        nameLabel.Text = p.Patient.PatName
        categoryLabel.Text = p.Patient.PatCategory.CatDescription
        disscountLabel.Text = p.Patient.PatCategory.Discount.ToString

        fillPrescriptionMedicines(p)
    End Sub

    ' Adds a new prescription
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim p As Prescription = New Prescription

        If checkFieldsDetails() = False Then
            Exit Sub
        End If

        If checkFieldsPresc() = False Then
            Exit Sub
        End If

        Try
            p.Patient = New Patient(Convert.ToInt32(patientList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            p.PresDate = Convert.ToDateTime(dateBox.Text)
            If (p.insertPrescription <> 1) Then
                MessageBox.Show("The prescription wasn't inserted due to an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If fillPrescriptionsListBox() = False Then
            Exit Sub
        End If

        prescriptionList.SelectedIndex = prescriptionList.Items.Count - 1
        insertMedicine()
    End Sub

    ' Modifies a prescription
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles modifyBtn.Click
        Dim p As Prescription

        If checkFieldsPresc() = False Then
            Exit Sub
        End If

        Try
            p = New Prescription(Convert.ToInt32(prescriptionList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            p.PresDate = Convert.ToDateTime(dateBox.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        p.ToPayAmount = Convert.ToDouble(costBox.Text)
        p.Patient = New Patient(Convert.ToInt32(patientList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))

        Try
            If (p.updatePrescription() <> 1) Then
                MessageBox.Show("The prescription wasn't modified due to an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            p.Patient.readPatient()
            p.calculateDiscount()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If fillPrescriptionsListBox() = False Then
            Exit Sub
        End If

        prescriptionList.SelectedItem = p.PrescriptionID & " - " & p.Patient.PatName & " - " & p.PresDate
        medicineList.SelectedIndex = medicineList.Items.Count - 1

        disccountBox.Text = p.DiscountedAmount.ToString
    End Sub

    ' Deletes a prescription
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim p As Prescription

        Try
            p = New Prescription(Convert.ToInt32(prescriptionList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            If (p.deletePrescription() <> 1) Then
                MessageBox.Show("The prescription wasn't deleted due to an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If fillPrescriptionsListBox() = False Then
            Exit Sub
        End If

        prescriptionList.SelectedIndex = prescriptionList.Items.Count - 1
        clearFieldsPresc()
        clearFieldsDetails()
        medicineList.Items.Clear()
    End Sub

    ' Clears the fields from the form
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearFieldsPresc()
        clearFieldsDetails()
    End Sub

    ' Adds a medicine to the selected prescription
    Private Sub addMBtn_Click(sender As Object, e As EventArgs) Handles addMBtn.Click
        insertMedicine()
    End Sub

    ' Modifies a medicine from a prescription
    Private Sub modifyMBtn_Click(sender As Object, e As EventArgs) Handles modifyMBtn.Click
        Dim p As Prescription
        Dim m As Medicine

        If checkFieldsDetails() = False Then
            Exit Sub
        End If

        Try
            p = New Prescription(Convert.ToInt32(prescriptionList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            m = New Medicine(Convert.ToInt32(availableMedicineList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            m.Quantity = Convert.ToInt32(quantity.Text)
            If (m.updateDetails(p) <> 1) Then
                MessageBox.Show("The medicine wasn't modified due to an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            p.readPrescription()
            m.readMedicine()
            p.calculateCost()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If fillPrescriptionMedicines(p) = False Then
            Exit Sub
        End If

        medicineList.SelectedItem = m.MedicineID & " - " & m.MedDescription

        costBox.Text = p.ToPayAmount.ToString
        disccountBox.Text = p.DiscountedAmount.ToString
    End Sub

    ' Deletes a medicine from a prescription
    Private Sub deleteMBtn_Click(sender As Object, e As EventArgs) Handles deleteMBtn.Click
        Dim p As Prescription
        Dim m As Medicine

        Try
            p = New Prescription(Convert.ToInt32(prescriptionList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            m = New Medicine(Convert.ToInt32(availableMedicineList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            If (m.deleteDetails(p) <> 1) Then
                MessageBox.Show("The prescription details weren't deleted due to an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            p.readPrescription()
            p.calculateCost()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If fillPrescriptionMedicines(p) = False Then
            Exit Sub
        End If

        costBox.Text = p.ToPayAmount.ToString
        disccountBox.Text = p.DiscountedAmount.ToString

        medicineList.SelectedIndex = medicineList.Items.Count - 1
        clearFieldsDetails()
    End Sub

    ' Clears the fields from the prescription's medicine
    Private Sub clearMBtn_Click(sender As Object, e As EventArgs) Handles clearMBtn.Click
        clearFieldsDetails()
    End Sub

    ' Adds all the existing prescriptions to a listbox
    Public Function fillPrescriptionsListBox() As Boolean
        Dim p As Prescription = New Prescription()

        If Not prescriptionList Is Nothing Then
            prescriptionList.Items.Clear()
        End If

        Try
            p.readAllPrescriptions()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        For Each p In p.dao.prescriptionList
            prescriptionList.Items.Add(p.PrescriptionID & " - " & p.Patient.PatName & " - " & p.PresDate)
        Next

        Return True
    End Function

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
            patientList.Items.Add(pa.PatientID & " - " & pa.PatName)
        Next

        Return True
    End Function

    ' Checks if all the fields from the prescription are not empty
    Private Function checkFieldsPresc() As Boolean
        If dateBox.Text = "" Or patientList.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    ' Checks if all the fields from a prescription's medicine are not empty
    Private Function checkFieldsDetails() As Boolean
        Try
            If Convert.ToInt32(quantity.Text) < 1 Or availableMedicineList.SelectedItem Is Nothing Then
                MessageBox.Show("Please fill all fields properly", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
        Return True
    End Function

    ' Clears all the fields from the prescription
    Private Sub clearFieldsPresc()
        dateBox.Text = ""
        costBox.Text = ""
        disccountBox.Text = ""
        patientBox.Text = ""
        nameLabel.Text = ""
        disscountLabel.Text = ""
        categoryLabel.Text = ""
        descLabel2.Text = ""
        descLabel.Text = ""
    End Sub

    'Clears all the fields from a prescription's medicine
    Private Sub clearFieldsDetails()
        quantity.Text = ""
        piceLabel.Text = ""
        descLabel2.Text = ""
        descLabel.Text = ""
    End Sub

    ' Fills the fields with the info from the selected prescription's medicine
    Private Sub patientList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles patientList.SelectedIndexChanged
        Dim pa As Patient

        Try
            pa = New Patient(Convert.ToInt32(patientList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            pa.readPatient()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        patientBox.Text = pa.PatientID.ToString
        nameLabel.Text = pa.PatName
        categoryLabel.Text = pa.PatCategory.CatDescription
        disscountLabel.Text = pa.PatCategory.Discount.ToString
    End Sub

    ' Adds all the exiting medicines to a listbox
    Public Function fillAvailableMedicineListBox() As Boolean
        Dim m As Medicine = New Medicine()

        Try
            m.readAllMedicines()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        For Each m In m.dao.medicinesList
            availableMedicineList.Items.Add(m.MedicineID & " - " & m.MedDescription)
        Next

        Return True
    End Function

    ' Fills the fields with the info from the selected medicine
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

        availableMedicineList.SelectedItem = m.MedicineID & " - " & m.MedDescription
        descLabel.Text = m.MedDescription
        quantity.Text = m.Quantity.ToString
    End Sub

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

    ' Fills the fields with the info from the selected medicine
    Private Sub availableMedicineList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles availableMedicineList.SelectedIndexChanged
        Dim m As Medicine

        Try
            m = New Medicine(Convert.ToInt32(availableMedicineList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            m.readMedicine()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        descLabel2.Text = m.MedDescription.ToString
        piceLabel.Text = m.UnitPrice.ToString
    End Sub

    ' Inserts a new medicine to the chosen prescription
    Private Sub insertMedicine()
        Dim p As Prescription
        Dim m As Medicine

        If checkFieldsDetails() = False Then
            Exit Sub
        End If

        Try
            p = New Prescription(Convert.ToInt32(prescriptionList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            m = New Medicine(Convert.ToInt32(availableMedicineList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            m.Quantity = Convert.ToInt32(quantity.Text)
            If (m.insertDetails(p) <> 1) Then
                MessageBox.Show("The medicine wasn't inserted due to an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            p.readPrescription()
            p.calculateCost()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If fillPrescriptionMedicines(p) = False Then
            Exit Sub
        End If

        medicineList.SelectedIndex = medicineList.Items.Count - 1

        costBox.Text = p.ToPayAmount.ToString
        disccountBox.Text = p.DiscountedAmount.ToString
    End Sub
End Class