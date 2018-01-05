Imports System.Data.OleDb

Public Class DAOPrescription

    Private _prescriptionsList As New Collection
    Private p As Prescription

    ' Getter and setter for the collection attribute
    Property prescriptionList As Collection
        Get
            Return Me._prescriptionsList
        End Get
        Set(value As Collection)
            Me._prescriptionsList = value
        End Set
    End Property

    ' Function to update the prescription values in the db
    Public Function update(ByRef p As Prescription) As Integer
        Return DBBroker.getInstance.change("UPDATE PRECRIPTIONS SET Patient = " & p.Patient.PatientID & ", PresDate = '" & p.PresDate & "', ToPayAmount = ROUND('" & p.ToPayAmount & "',2), DisccountedAmount = ROUND('" & p.DiscountedAmount & "',2) WHERE PrecriptionID = " & p.PrescriptionID & ";")
    End Function

    ' Function to delete a prescription from the db
    Public Function delete(ByVal p As Prescription) As Integer
        Return DBBroker.getInstance.change("DELETE FROM PRECRIPTIONS WHERE PrecriptionID = " & p.PrescriptionID & ";")
    End Function

    ' Function to insert a new prescription in the db
    Public Function insert(ByVal p As Prescription) As Integer
        Return DBBroker.getInstance.change("INSERT INTO PRECRIPTIONS (Patient,PresDate,ToPayAmount,DisccountedAmount) VALUES(" & p.Patient.PatientID & ",'" & p.PresDate & "',ROUND(" & p.ToPayAmount & ",2),ROUND(" & p.DiscountedAmount & ",2));")
    End Function

    ' Subroutine to read the info of a prescription
    Public Sub read(ByRef p As Prescription)
        Dim data As OleDbDataReader
        data = DBBroker.getInstance.read("SELECT Patient, PresDate, ToPayAmount, DisccountedAmount FROM PRECRIPTIONS WHERE PrecriptionID = " & p.PrescriptionID & ";")

        While data.Read()
            p.Patient = New Patient(Convert.ToInt32(data(0)))
            p.Patient.readPatient()
            p.PresDate = Convert.ToDateTime(data(1))
            p.ToPayAmount = Convert.ToDecimal(data(2))
            p.DiscountedAmount = Convert.ToDecimal(data(3))
        End While

        readMedicines(p)
    End Sub

    ' Subrutine to read the medicines a prescription has
    Public Sub readMedicines(ByRef p As Prescription)
        Dim data As OleDbDataReader
        data = DBBroker.getInstance.read("SELECT Medicine FROM PRESCRIPTION_DETAILS WHERE Precription = " & p.PrescriptionID & " ;")

        While data.Read()
            p.Medicine.Add(New Medicine(Convert.ToInt32(data(0))))
        End While

    End Sub

    ' Subroutine to read and load all the prescriptions from the db into the collection
    Public Sub readAll()
        Dim data As OleDbDataReader
        data = DBBroker.getInstance.read("SELECT PrecriptionID,Patient,PresDate FROM PRECRIPTIONS ORDER BY PrecriptionID;")

        While data.Read()
            p = New Prescription(Convert.ToInt32(data(0)))
            p.Patient = New Patient(Convert.ToInt32(data(1)))
            p.Patient.readPatient()
            p.PresDate = Convert.ToDateTime(data(2))
            _prescriptionsList.Add(p)
        End While

    End Sub

    ' Function to calculate the cost of a prescription
    Public Sub calculateCost(ByRef p As Prescription)
        Dim data As OleDbDataReader
        p.ToPayAmount = 0
        data = DBBroker.getInstance.read("SELECT SUM((p.Quantity * m.UnitPrice) - ((p.Quantity * m.UnitPrice) * c.Disccount / 100)) FROM ((((medicines m INNER JOIN prescription_details p ON (p.Medicine = m.MedicineID)) INNER JOIN PRECRIPTIONS pe ON (p.Precription = pe.PrecriptionID)) INNER JOIN PATIENTS pa ON (pe.Patient = pa.PatientID)) INNER JOIN CATEGORIES c ON (pa.PatCategory = c.CategoryID)) WHERE p.Precription = " & p.PrescriptionID & ";")

        While data.Read()
            p.ToPayAmount = Convert.ToDecimal(data(0))
        End While
        p.updatePrescription()
        p.calculateDiscount()
    End Sub

    ' Function to calculate the discount of a prescription
    Public Sub calculateDiscount(ByRef p As Prescription)
        Dim data As OleDbDataReader
        data = DBBroker.getInstance.read("SELECT SUM((p.Quantity * m.UnitPrice) * c.Disccount / 100) FROM ((((medicines m INNER JOIN prescription_details p ON (p.Medicine = m.MedicineID)) INNER JOIN PRECRIPTIONS pe ON (p.Precription = pe.PrecriptionID)) INNER JOIN PATIENTS pa ON (pe.Patient = pa.PatientID)) INNER JOIN CATEGORIES c ON (pa.PatCategory = c.CategoryID)) WHERE p.Precription = " & p.PrescriptionID & ";")

        While data.Read()
            p.DiscountedAmount = Convert.ToDecimal(data(0))
        End While
        p.updatePrescription()
    End Sub

    ' Subroutine to get the prescriptions between two dates
    Public Sub getPrescriptionBetweenDates(ByVal pa As Patient, ByVal date1 As String, ByVal date2 As String)
        Dim data As OleDbDataReader
        data = DBBroker.getInstance.read("SELECT PrecriptionID,Patient,PresDate FROM PRECRIPTIONS WHERE Patient = " & pa.PatientID & " AND PresDate BETWEEN " & "#" & date1 & "#" & " AND " & "#" & date2 & "#" & " ORDER BY PresDate;")

        While data.Read()
            p = New Prescription(Convert.ToInt32(data(0)))
            p.Patient = New Patient(Convert.ToInt32(data(1)))
            p.Patient.readPatient()
            p.PresDate = Convert.ToDateTime(data(2))
            _prescriptionsList.Add(p)
        End While
    End Sub

    ' Subroutine to get the most expensive prescriptions
    Public Sub mostExpensivePrescriptions()
        Dim data As OleDbDataReader
        data = DBBroker.getInstance.read("SELECT PrecriptionID, Patient, PresDate FROM PRECRIPTIONS WHERE (ToPayAmount + DisccountedAmount) = (SELECT MAX(ToPayAmount + DisccountedAmount) FROM PRECRIPTIONS);")

        While data.Read()
            p = New Prescription(Convert.ToInt32(data(0)))
            p.Patient = New Patient(Convert.ToInt32(data(1)))
            p.Patient.readPatient()
            p.PresDate = Convert.ToDateTime(data(2))
            _prescriptionsList.Add(p)
        End While
    End Sub

End Class
