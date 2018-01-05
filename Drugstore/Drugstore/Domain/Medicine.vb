Public Class Medicine

    Private _MedicineID As Integer
    Private _MedDescription As String
    Private _UnitPrice As Double
    Private _Quantity As Integer
    Private _income As Double
    Private _dao As DAOMedicine

    ' Getter and setter for income attribute
    Property income As Double
        Get
            Return Me._income
        End Get
        Set(value As Double)
            Me._income = value
        End Set
    End Property

    ' Getter and setter for MedicineID attribute
    Property MedicineID As Integer
        Get
            Return Me._MedicineID
        End Get
        Set(value As Integer)
            Me._MedicineID = value
        End Set
    End Property

    ' Getter and setter for MedDescription attribute
    Property MedDescription As String
        Get
            Return Me._MedDescription
        End Get
        Set(value As String)
            Me._MedDescription = value
        End Set
    End Property

    ' Getter and setter for UnitPrice attribute
    Property UnitPrice As Double
        Get
            Return Me._UnitPrice
        End Get
        Set(value As Double)
            Me._UnitPrice = value
        End Set
    End Property

    ' Getter and setter for Quantity attribute
    Property Quantity As Integer
        Get
            Return Me._Quantity
        End Get
        Set(value As Integer)
            Me._Quantity = value
        End Set
    End Property

    ' Getter and setter for dao attribute
    Property dao As DAOMedicine
        Get
            Return Me._dao
        End Get
        Set(value As DAOMedicine)
            Me._dao = value
        End Set
    End Property

    ' Class constructor
    Public Sub New()
        Me._dao = New DAOMedicine
    End Sub

    ' Class constructor
    Public Sub New(medID As Integer)
        Me._dao = New DAOMedicine
        Me._MedicineID = medID
    End Sub

    ' Function that inserts a medicine in the database
    Public Function insertMedicine() As Integer
        Return _dao.insert(Me)
    End Function

    ' Function to insert a new prescription detail
    Public Function insertDetails(ByVal p As Prescription) As Integer
        Return _dao.insertDetails(p, Me)
    End Function

    ' Function that updates the info of a medicine in the database
    Public Function updateMedicine() As Integer
        Return _dao.update(Me)
    End Function

    ' Function that updates the info of a prescription details in the database
    Public Function updateDetails(ByRef p As Prescription) As Integer
        Return _dao.updateDetails(p, Me)
    End Function

    ' Function that removes a medicine from the database
    Public Function deleteMedicine() As Integer
        Return _dao.delete(Me)
    End Function

    'Function that removes a medicine from a prescription from the database
    Public Function deleteDetails(ByVal p As Prescription) As Integer
        Return _dao.deleteDetails(p, Me)
    End Function

    ' Subroutine that is used to read all the medicines in the database
    Public Sub readAllMedicines()
        _dao.readAll()
    End Sub

    ' Subroutine to read a specific medicine from the database
    Public Sub readMedicine()
        _dao.read(Me)
    End Sub

    ' Subroutine to read a specific medicine quanity from a prescription from the database
    Public Sub readQuantity(ByRef p As Prescription)
        _dao.readQuantity(Me, p)
    End Sub

    ' Subroutine to get the most sold medicines between two dates
    Public Sub medicineRanking(ByVal date1 As String, ByVal date2 As String)
        _dao.medicineRanking(date1, date2)
    End Sub

    Public Sub calculateIncome()
        _dao.calculateIncome()
    End Sub

End Class
