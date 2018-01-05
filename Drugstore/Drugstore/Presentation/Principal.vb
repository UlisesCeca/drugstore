Public Class Principal

    ' Button to open patients form
    Private Sub patientsBtn_Click(sender As Object, e As EventArgs) Handles patientsBtn.Click
        Dim paForm As New PatientsForm
        If paForm.fillPatientListBox = False Or paForm.fillCategoryListBox() = False Then
            Exit Sub
        End If
        paForm.Show()
    End Sub

    ' Button to open categories form 
    Private Sub categoryBtn_Click(sender As Object, e As EventArgs) Handles categoryBtn.Click
        Dim cForm As New CategoryForm
        If cForm.fillCategoryListBox = False Then
            Exit Sub
        End If
        cForm.Show()
    End Sub

    ' Button to open medicines form 
    Private Sub medicineBtn_Click(sender As Object, e As EventArgs) Handles medicineBtn.Click
        Dim mForm As New MedicineForm
        If mForm.fillMedicineListBox = False Then
            Exit Sub
        End If
        mForm.Show()
    End Sub

    ' Button to open prescriptions form 
    Private Sub prescriptionBtn_Click(sender As Object, e As EventArgs) Handles prescriptionBtn.Click
        Dim pForm As New PrescriptionForm
        If pForm.fillPrescriptionsListBox = False Or pForm.fillPatientListBox = False Or pForm.fillAvailableMedicineListBox = False Then
            Exit Sub
        End If
        pForm.Show()
    End Sub

    ' Button to open the db
    Private Sub dbBtn_Click(sender As Object, e As EventArgs) Handles dbBtn.Click
        Dim openFileDialog1 As New OpenFileDialog()

        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Access Files (*.accdb)|*.accdb|All files (*.*)|*.*"

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            DBBroker.path = openFileDialog1.FileName
            databaseLabel.Text = openFileDialog1.FileName
            managementGroup.Enabled = True
            consultsGroup.Enabled = True
        End If
    End Sub

    ' Button to open the form which gives prescriptions from patients between two dates
    Private Sub purchasedBtn_Click(sender As Object, e As EventArgs) Handles purchasedBtn.Click
        Dim datesForm As New datesPrescriptionsForm
        If datesForm.fillPatientListBox = False Then
            Exit Sub
        End If
        datesForm.Show()
    End Sub

    ' Button to open the form for the medicines ranking
    Private Sub medRankBtn_Click(sender As Object, e As EventArgs) Handles medRankBtn.Click
        Dim medRankForm As New medicineRankingForm
        medRankForm.Show()
    End Sub

    ' Button to open the form for the females ranking
    Private Sub femRankBtn_Click(sender As Object, e As EventArgs) Handles femRankBtn.Click
        Dim femRankForm As New femaleRankingForm
        femRankForm.Show()
    End Sub

    Private Sub medIncomeBtn_Click(sender As Object, e As EventArgs) Handles medIncomeBtn.Click
        Dim medIncomeForm As New underAgeMedicineIncome
        If medIncomeForm.calculateIncome() = False Then
            Exit Sub
        End If
        medIncomeForm.Show()
    End Sub

    ' Opens the form for the most expensive prescriptions
    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim mostExpensiveForm As New mostExpensivePresc
        If mostExpensiveForm.calculateMostExpensive() = False Then
            Exit Sub
        End If
        mostExpensiveForm.Show()
    End Sub
End Class
