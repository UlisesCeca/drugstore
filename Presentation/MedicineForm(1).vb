Public Class MedicineForm

    ' Adds a new medicine
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim m As Medicine = New Medicine()

        If checkFields() = False Then
            Exit Sub
        End If

        m.MedDescription = descBox.Text

        Try
            m.UnitPrice = Convert.ToDouble(priceBox.Text)
            If (m.insertMedicine <> 1) Then
                MessageBox.Show("The medicine wasn't inserted due to an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If fillMedicineListBox() = False Then
            Exit Sub
        End If

        medicineList.SelectedIndex = medicineList.Items.Count - 1
    End Sub

    ' Fills the fields with the info from the selected medicine
    Private Sub medicineList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles medicineList.SelectedIndexChanged
        Dim m As Medicine

        Try
            m = New Medicine(Convert.ToInt32(medicineList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            m.readMedicine()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        descBox.Text = m.MedDescription
        priceBox.Text = m.UnitPrice.ToString
    End Sub

    ' Modifies a the info of the medicine
    Private Sub modifyBtn_Click(sender As Object, e As EventArgs) Handles modifyBtn.Click
        Dim m As Medicine

        If checkFields() = False Then
            Exit Sub
        End If

        Try
            m = New Medicine(Convert.ToInt32(medicineList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            m.UnitPrice = Convert.ToDouble(priceBox.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        m.MedDescription = descBox.Text

        Try
            If (m.updateMedicine() <> 1) Then
                MessageBox.Show("The medicine wasn't modified due to an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If fillMedicineListBox() = False Then
            Exit Sub
        End If

        medicineList.SelectedItem = m.MedicineID & " - " & m.MedDescription
    End Sub

    ' Deletes a medicine
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim m As Medicine

        Try
            m = New Medicine(Convert.ToInt32(medicineList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            If (m.deleteMedicine() <> 1) Then
                MessageBox.Show("The medicine wasn't deleted due to an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If fillMedicineListBox() = False Then
            Exit Sub
        End If

        medicineList.SelectedIndex = medicineList.Items.Count - 1
        clearFields()
    End Sub

    ' Clears the fields from the form
    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearFields()
    End Sub

    ' Adds all the existing medicines to a listbox
    Public Function fillMedicineListBox() As Boolean
        Dim m As Medicine = New Medicine()

        If Not medicineList Is Nothing Then
            medicineList.Items.Clear()
        End If

        Try
            m.readAllMedicines()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try

        For Each m In m.dao.medicinesList
            medicineList.Items.Add(m.MedicineID & " - " & m.MedDescription)
        Next

        Return True
    End Function

    ' Checks if the fields are not empty
    Private Function checkFields() As Boolean
        If descBox.Text = "" Or priceBox.Text = "" Then
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    ' Clears all the fields
    Private Sub clearFields()
        descBox.Text = ""
        priceBox.Text = ""
    End Sub
End Class