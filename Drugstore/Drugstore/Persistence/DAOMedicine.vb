Imports System.Data.OleDb

Public Class DAOMedicine

    Private _medicinesList As New Collection
    Private m As Medicine

    ' Getter and setter for the collection attribute
    Property medicinesList As Collection
        Get
            Return Me._medicinesList
        End Get
        Set(value As Collection)
            Me._medicinesList = value
        End Set
    End Property

    ' Function to update the medicines values in the db
    Public Function update(ByRef m As Medicine) As Integer
        Return DBBroker.getInstance.change("UPDATE MEDICINES SET MedDescription = '" & m.MedDescription & "', UnitPrice = " & m.UnitPrice & " WHERE MedicineID = " & m.MedicineID & ";")
    End Function

    ' Function to delete a medicine from the db
    Public Function delete(ByVal m As Medicine) As Integer
        Return DBBroker.getInstance.change("DELETE FROM MEDICINES WHERE MedicineID = " & m.MedicineID & ";")
    End Function

    ' Function to insert a new medicine in the db
    Public Function insert(ByVal m As Medicine) As Integer
        Return DBBroker.getInstance.change("INSERT INTO MEDICINES (MedDescription,UnitPrice) VALUES('" & m.MedDescription & "'," & m.UnitPrice & ");")
    End Function

    ' Function to update the prescription details values in the db
    Public Function updateDetails(ByVal p As Prescription, ByRef m As Medicine) As Integer
        Return DBBroker.getInstance.change("UPDATE PRESCRIPTION_DETAILS SET Quantity = " & m.Quantity & " WHERE Precription = " & p.PrescriptionID & " AND Medicine = " & m.MedicineID & ";")
    End Function

    ' Function to delete a prescription details from the db
    Public Function deleteDetails(ByVal p As Prescription, ByVal m As Medicine) As Integer
        Return DBBroker.getInstance.change("DELETE FROM PRESCRIPTION_DETAILS WHERE Precription = " & p.PrescriptionID & " AND Medicine = " & m.MedicineID & ";")
    End Function

    ' Function to insert a new prescription details in the db
    Public Function insertDetails(ByVal p As Prescription, ByVal m As Medicine) As Integer
        Return DBBroker.getInstance.change("INSERT INTO PRESCRIPTION_DETAILS VALUES(" & p.PrescriptionID & "," & m.MedicineID & "," & m.Quantity & ");")
    End Function

    ' Subroutine to read the quantity of a medicine
    Public Sub readQuantity(ByRef m As Medicine, ByVal p As Prescription)
        Dim data As OleDbDataReader
        data = DBBroker.getInstance.read("SELECT Quantity FROM PRESCRIPTION_DETAILS WHERE Precription = " & p.PrescriptionID & " AND Medicine = " & m.MedicineID & ";")

        While data.Read()
            m.Quantity = Convert.ToInt32(data(0).ToString)
            m.readMedicine()
        End While

    End Sub

    ' Subroutine to read the info of a medicine
    Public Sub read(ByRef m As Medicine)
        Dim data As OleDbDataReader
        data = DBBroker.getInstance.read("SELECT MedDescription,UnitPrice FROM MEDICINES WHERE MedicineID = " & m.MedicineID & ";")

        While data.Read()
            m.MedDescription = data(0).ToString
            m.UnitPrice = Convert.ToDecimal(data(1))
        End While

    End Sub

    ' Subroutine to read and load all the medicines from the db into the collection
    Public Sub readAll()
        Dim data As OleDbDataReader
        data = DBBroker.getInstance.read("SELECT MedicineID,MedDescription FROM MEDICINES ORDER BY MedicineID;")

        While data.Read()
            m = New Medicine(Convert.ToInt32(data(0)))
            m.MedDescription = data(1).ToString
            _medicinesList.Add(m)
        End While

    End Sub

    ' Subroutine to get the most sold medicines between two dates
    Public Sub medicineRanking(ByVal date1 As String, ByVal date2 As String)
        Dim data As OleDbDataReader
        data = DBBroker.getInstance.read("SELECT DISTINCT m.MedicineID, m.MedDescription, SUM(p.Quantity) FROM ((MEDICINES m INNER JOIN PRESCRIPTION_DETAILS p ON (m.MedicineID = p.Medicine)) INNER JOIN PRECRIPTIONS pe ON (p.Precription = pe.PrecriptionID)) WHERE pe.PresDate BETWEEN " & "#" & date1 & "#" & " AND " & "#" & date2 & "#" & " GROUP BY m.MedicineID,MedDescription ORDER BY SUM(p.Quantity) DESC;")

        While data.Read()
            m = New Medicine(Convert.ToInt32(data(0)))
            m.MedDescription = data(1).ToString
            m.Quantity = Convert.ToInt32(data(2))
            _medicinesList.Add(m)
        End While
    End Sub

    ' Subroutine to get the most sold medicines between two dates
    Public Sub calculateIncome()
        Dim data As OleDbDataReader
        data = DBBroker.getInstance.read("SELECT DISTINCT m.MedicineID, m.MedDescription, SUM((p.Quantity * m.UnitPrice) - ((p.Quantity * m.UnitPrice)) * c.Disccount / 100) FROM ((((MEDICINES m INNER JOIN PRESCRIPTION_DETAILS p ON (m.MedicineID = p.Medicine)) INNER JOIN PRECRIPTIONS pe ON (p.Precription = pe.PrecriptionID)) INNER JOIN PATIENTS pa ON (pe.Patient = pa.PatientID)) INNER JOIN CATEGORIES c ON (pa.PatCategory = c.CategoryID)) WHERE c.CatDescription = 'Under Age' GROUP BY m.MedicineID, m.MedDescription ORDER BY SUM((p.Quantity * m.UnitPrice) - (p.Quantity * m.UnitPrice) * c.Disccount / 100) DESC;")

        While data.Read()
            m = New Medicine(Convert.ToInt32(data(0)))
            m.MedDescription = data(1).ToString
            m.income = Convert.ToDecimal(data(2))
            _medicinesList.Add(m)
        End While
    End Sub

End Class
