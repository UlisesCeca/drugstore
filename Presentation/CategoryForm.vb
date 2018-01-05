Public Class CategoryForm

    ' Adds a new category
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim c As Category = New Category()

        If checkFields() = False Then
            Exit Sub
        End If

        c.CatDescription = descriptionBox.Text

        Try
            c.Discount = Convert.ToDouble(disccountBox.Text)
            If (c.insertCategory() <> 1) Then
                MessageBox.Show("The category wasn't inserted due to an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If fillCategoryListBox() = False Then
            Exit Sub
        End If

        categoryList.SelectedIndex = (categoryList.Items.Count - 1)

    End Sub

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

        descriptionBox.Text = c.CatDescription
        disccountBox.Text = c.Discount.ToString
    End Sub

    ' Modifies a category info
    Private Sub modifyBtn_Click(sender As Object, e As EventArgs) Handles modifyBtn.Click
        Dim c As Category

        If checkFields() = False Then
            Exit Sub
        End If

        Try
            c = New Category(Convert.ToInt32(categoryList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            c.Discount = Convert.ToDouble(disccountBox.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        c.CatDescription = descriptionBox.Text

        Try
            If (c.updateCategory() <> 1) Then
                MessageBox.Show("The category wasn't modified due to an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If fillCategoryListBox() = False Then
            Exit Sub
        End If

        categoryList.SelectedItem = c.CategoryID & " - " & c.CatDescription

    End Sub

    ' Deletes a category
    Private Sub deleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        Dim c As Category

        Try
            c = New Category(Convert.ToInt32(categoryList.SelectedItem.ToString.Split(Convert.ToChar(" "))(0)))
            If (c.deleteCategory() <> 1) Then
                MessageBox.Show("The category wasn't deleted due to an error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        If fillCategoryListBox() = False Then
            Exit Sub
        End If

        categoryList.SelectedIndex = categoryList.Items.Count - 1
        clearFields()
    End Sub

    ' Clears all the form fields
    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        clearFields()
    End Sub

    ' Adds all the existing categories to a listbox
    Public Function fillCategoryListBox() As Boolean
        Dim c As Category = New Category

        If Not categoryList Is Nothing Then
            categoryList.Items.Clear()
        End If

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

    ' Checks if all fields are not empty
    Private Function checkFields() As Boolean
        If descriptionBox.Text = "" Or disccountBox.Text = "" Then
            MessageBox.Show("Please fill all fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    ' Clears all fields
    Private Sub clearFields()
        descriptionBox.Text = ""
        disccountBox.Text = ""
    End Sub

End Class