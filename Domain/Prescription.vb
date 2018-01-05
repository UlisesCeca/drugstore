Public Class Prescription

    Private _PrescriptionID As Integer
    Private _Patient As Patient
    Private _Medicine As New Collection
    Private _PresDate As Date
    Private _ToPayAmount As Double
    Private _DiscountedAmount As Double
    Private _dao As DAOPrescription

    ' Getter and setter for PrescriptionID attribute
    Property PrescriptionID As Integer
        Get
            Return Me._PrescriptionID
        End Get
        Set(value As Integer)
            Me._PrescriptionID = value
        End Set
    End Property

    ' Getter and setter for Patient attribute
    Property Patient As Patient
        Get
            Return Me._Patient
        End Get
        Set(value As Patient)
            Me._Patient = value
        End Set
    End Property

    ' Getter and setter for Medicine attribute
    Property Medicine As Collection
        Get
            Return Me._Medicine
        End Get
        Set(value As Collection)
            Me._Medicine = value
        End Set
    End Property

    ' Getter and setter for PresDate attribute
    Property PresDate As Date
        Get
            Return Me._PresDate
        End Get
        Set(value As Date)
            Me._PresDate = value
        End Set
    End Property

    ' Getter and setter for ToPayAmount attribute
    Property ToPayAmount As Double
        Get
            Return Me._ToPayAmount
        End Get
        Set(value As Double)
            Me._ToPayAmount = value
        End Set
    End Property

    ' Getter and setter for DiscountedAmount attribute
    Property DiscountedAmount As Double
        Get
            Return Me._DiscountedAmount
        End Get
        Set(value As Double)
            Me._DiscountedAmount = value
        End Set
    End Property

    ' Getter and setter for dao attribute
    Property dao As DAOPrescription
        Get
            Return Me._dao
        End Get
        Set(value As DAOPrescription)
            Me._dao = value
        End Set
    End Property

    ' Class constructor
    Public Sub New()
        Me._dao = New DAOPrescription
    End Sub

    ' Class constructor 2
    Public Sub New(id As Integer)
        Me._dao = New DAOPrescription
        Me._PrescriptionID = id
    End Sub

    ' Function that inserts a prescription in the database
    Public Function insertPrescription() As Integer
        Return _dao.insert(Me)
    End Function

    ' Function that updates the info of a prescription in the database
    Public Function updatePrescription() As Integer
        Return _dao.update(Me)
    End Function

    'Function that removes a prescription from the database
    Public Function deletePrescription() As Integer
        Return _dao.delete(Me)
    End Function

    ' Subroutine that is used to read all the prescriptions in the database
    Public Sub readAllPrescriptions()
        _dao.readAll()
    End Sub

    ' Subroutine to read a specific prescription from the database
    Public Sub readPrescription()
        _dao.read(Me)
    End Sub

    ' Function to calculate the cost of a prescription
    Public Sub calculateCost()
        _dao.calculateCost(Me)
    End Sub

    ' Function to calculate the discount of a prescription
    Public Sub calculateDiscount()
        _dao.calculateDiscount(Me)
    End Sub

    ' Subroutine to get the prescriptions between two dates
    Public Sub getPrescriptionBetweenDates(ByVal pa As Patient, ByVal date1 As String, ByVal date2 As String)
        _dao.getPrescriptionBetweenDates(pa, date1, date2)
    End Sub

    ' Subroutine to get the most expensive prescriptions
    Public Sub mostExpensivePrescriptions()
        _dao.mostExpensivePrescriptions()
    End Sub

End Class
