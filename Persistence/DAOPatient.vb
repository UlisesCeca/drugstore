Imports System.Data.OleDb

Public Class DAOPatient

    Private _patientsList As New Collection
    Private pa As Patient

    ' Getter and setter for the collection attribute
    Property patientsList As Collection
        Get
            Return Me._patientsList
        End Get
        Set(value As Collection)
            Me._patientsList = value
        End Set
    End Property

    ' Function to update the patients values in the db
    Public Function update(ByRef pa As Patient) As Integer
        Return DBBroker.getInstance.change("UPDATE PATIENTS SET PatName = '" & pa.PatName & "', PatCategory = " & pa.PatCategory.CategoryID & ", BirthDate = '" & pa.BirthDate & "', Gender = '" & pa.Gender & "' WHERE PatientID = " & pa.PatientID & ";")
    End Function

    ' Function to delete a patient from the db
    Public Function delete(ByVal pa As Patient) As Integer
        Return DBBroker.getInstance.change("DELETE FROM PATIENTS WHERE PatientID = " & pa.PatientID & ";")
    End Function

    ' Function to insert a new patient in the db
    Public Function insert(ByVal pa As Patient) As Integer
        Return DBBroker.getInstance.change("INSERT INTO PATIENTS VALUES(" & pa.PatientID & ",'" & pa.PatName & "'," & pa.PatCategory.CategoryID & ",'" & pa.BirthDate & "','" & pa.Gender & "');")
    End Function

    ' Subroutine to read the info of a patient
    Public Sub read(ByRef pa As Patient)
        Dim data As OleDbDataReader
        data = DBBroker.getInstance.read("SELECT PatName, PatCategory, BirthDate, Gender FROM PATIENTS WHERE PatientID = " & pa.PatientID & ";")

        While data.Read()
            pa.PatName = data(0).ToString
            pa.PatCategory = New Category(Convert.ToInt32(data(1)))
            pa.PatCategory.readCategory()
            pa.BirthDate = Convert.ToDateTime(data(2))
            pa.Gender = data(3).ToString
        End While

    End Sub

    ' Subroutine to read and load all the patients from the db into the collection
    Public Sub readAll()
        Dim data As OleDbDataReader
        data = DBBroker.getInstance.read("SELECT PatientID,PatName FROM PATIENTS ORDER BY PatientID;")

        While data.Read()
            pa = New Patient(Convert.ToInt32(data(0)))
            pa.PatName = data(1).ToString
            _patientsList.Add(pa)
        End While

    End Sub

    ' Subroutine to GET THE FEMALES THAT HAVE BOUGHT a bigger amount of medicines
    Public Sub femaleRanking(ByVal date1 As String, ByVal date2 As String)
        Dim data As OleDbDataReader
        data = DBBroker.getInstance.read("SELECT pa.PatientID, pa.PatName, SUM(pe.Quantity) FROM ((PATIENTS pa INNER JOIN PRECRIPTIONS p ON (pa.PatientID = p.Patient)) INNER JOIN PRESCRIPTION_DETAILS pe ON (p.PrecriptionID = pe.Precription)) WHERE pa.Gender = 'F' AND pa.BirthDate BETWEEN " & "#" & date1 & "#" & " AND " & "#" & date2 & "#" & " GROUP BY pa.PatientID, pa.PatName ORDER BY SUM(pe.Quantity) DESC;")

        While data.Read()
            pa = New Patient(Convert.ToInt32(data(0)))
            pa.PatName = data(1).ToString
            pa.boughtMedicines = Convert.ToInt32(data(2))
            _patientsList.Add(pa)
        End While

    End Sub

End Class
