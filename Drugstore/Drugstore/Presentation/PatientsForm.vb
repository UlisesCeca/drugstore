Public Class PatientsForm

    ' Fills the fields with the info from the selected patient
    Private Sub patientsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles patientsList.SelectedIndexChanged
        Dim pa As Patient

        Try
            pa = New Patient(Convert.ToInt32(patientsList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            pa.readPatient()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If Not pa.PatName Is Nothing Then
            categoryList.SelectedItem = pa.PatCategory.CategoryID & " - " & pa.PatCategory.CatDescription
            idBox.Text = pa.PatientID.ToString
            nameBox.Text = pa.PatName
            descLabel.Text = pa.PatCategory.CatDescription
            bdayBox.Text = pa.BirthDate.ToString("d")
            genderBox.Text = pa.Gender
            discountLabel.Text = pa.PatCategory.Discount.ToString
        End If
    End Sub

    ' Adds a new patient
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim pa As Patient

        If checkFields() = False Then
            Exit Sub
        End If

        Try
            pa = New Patient(Convert.ToInt32(idBox.Text))
            pa.BirthDate = Convert.ToDateTime(bdayBox.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        pa.PatName = nameBox.Text
        pa.Gender = genderBox.Text
        pa.PatCategory = New Category(Convert.ToInt32(categoryList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))

        Try
            If (pa.insertPatient() <> 1) Then
                MessageBox.Show("The patient wasn't inserted due to an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            pa.PatCategory.readCategory()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        descLabel.Text = pa.PatCategory.CatDescription
        discountLabel.Text = pa.PatCategory.Discount.ToString

        If fillPatientListBox() = False Then
            Exit Sub
        End If

        patientsList.SelectedItem = pa.PatientID & " - " & pa.PatName
    End Sub

    ' Modifies a patient's info
    Private Sub modifyBtn_Click(sender As Object, e As EventArgs) Handles modifyBtn.Click
        Dim pa As Patient

        If checkFields() = False Then
            Exit Sub
        End If

        Try
            pa = New Patient(Convert.ToInt32(patientsList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            pa.BirthDate = Convert.ToDateTime(bdayBox.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        pa.PatName = nameBox.Text
        pa.Gender = genderBox.Text
        pa.PatCategory = New Category(Convert.ToInt32(categoryList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))

        Try
            If (pa.updatePatient() <> 1) Then
                MessageBox.Show("The patient wasn't modified due to an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            pa.PatCategory.readCategory()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        descLabel.Text = pa.PatCategory.CatDescription
        discountLabel.Text = pa.PatCategory.Discount.ToString

        If fillPatientListBox() = False Then
            Exit Sub
        End If

        patientsList.SelectedItem = pa.PatientID & " - " & pa.PatName
    End Sub

    ' Deletes a patient
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim pa As Patient

        Try
            pa = New Patient(Convert.ToInt32(patientsList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            If (pa.deletePatient() <> 1) Then
                MessageBox.Show("The patient wasn't deleted due to an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If fillPatientListBox() = False Then
            Exit Sub
        End If

        patientsList.SelectedIndex = patientsList.Items.Count - 1
        clearFields()
    End Sub

    ' Clear the fields from the form
    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearFields()
    End Sub

    ' Adds all the existing patients to a listbox
    Public Function fillPatientListBox() As Boolean
        Dim pa As Patient = New Patient()

        If Not patientsList Is Nothing Then
            patientsList.Items.Clear()
        End If

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

    ' Checks that the fields are not empty
    Private Function checkFields() As Boolean
        If idBox.Text = "" Or nameBox.Text = "" Or bdayBox.Text = "" Or categoryList.SelectedItem Is Nothing Or genderBox.Text = "" Then
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        If (genderBox.Text <> "F") And (genderBox.Text <> "M") Then
            MessageBox.Show("Gender must be M (Male) or F (Female)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    ' Clears the fields from the form
    Private Sub clearFields()
        idBox.Text = ""
        nameBox.Text = ""
        bdayBox.Text = ""
        descLabel.Text = ""
        discountLabel.Text = ""
        genderBox.Text = ""
    End Sub

    ' Adds all the existing categories to a listbox
    Public Function fillCategoryListBox() As Boolean
        Dim c As Category = New Category

        Try
            c.readAllCategories()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        For Each c In c.dao.categoriesList
            categoryList.Items.Add(c.CategoryID & " - " & c.CatDescription)
        Next

        Return True
    End Function

    ' Fills the fields with the info from the selected category
    Private Sub categoryList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles categoryList.SelectedIndexChanged
        Dim c As Category

        Try
            c = New Category(Convert.ToInt32(categoryList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            c.readCategory()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try
        descLabel.Text = c.CatDescription
        discountLabel.Text = c.Discount.ToString
    End Sub

End Class