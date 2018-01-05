Public Class Patient

    Private _PatientID As Integer
    Private _PatName As String
    Private _PatCategory As Category
    Private _BirthDate As Date
    Private _Gender As String
    Private _boughtMedicines As Integer
    Private _dao As DAOPatient

    ' Getter and setter for boughtmedicines attribute
    Property boughtMedicines As Integer
        Get
            Return Me._boughtMedicines
        End Get
        Set(value As Integer)
            Me._boughtMedicines = value
        End Set
    End Property

    ' Getter and setter for PatientID attribute
    Property PatientID As Integer
        Get
            Return Me._PatientID
        End Get
        Set(value As Integer)
            Me._PatientID = value
        End Set
    End Property

    ' Getter and setter for PatName attribute
    Property PatName As String
        Get
            Return Me._PatName
        End Get
        Set(value As String)
            Me._PatName = value
        End Set
    End Property

    ' Getter and setter for PatCategory attribute
    Property PatCategory As Category
        Get
            Return Me._PatCategory
        End Get
        Set(value As Category)
            Me._PatCategory = value
        End Set
    End Property


    ' Getter and setter for BirthDate attribute
    Property BirthDate As Date
        Get
            Return Me._BirthDate
        End Get
        Set(value As Date)
            Me._BirthDate = value
        End Set
    End Property

    ' Getter and setter for Gender attribute
    Property Gender As String
        Get
            Return _Gender
        End Get
        Set(value As String)
            Me._Gender = value
        End Set
    End Property

    ' Getter and setter for dao attribute
    Property dao As DAOPatient
        Get
            Return Me._dao
        End Get
        Set(value As DAOPatient)
            Me._dao = value
        End Set
    End Property

    ' Class constructor
    Public Sub New()
        Me._dao = New DAOPatient
    End Sub

    ' Class constructor 2
    Public Sub New(patID As Integer)
        Me._dao = New DAOPatient
        Me._PatientID = patID
    End Sub

    ' Function that inserts a patient in the database
    Public Function insertPatient() As Integer
        Return _dao.insert(Me)
    End Function

    ' Function that updates the info of a patient in the database
    Public Function updatePatient() As Integer
        Return _dao.update(Me)
    End Function

    'Function that removes a patient from the database
    Public Function deletePatient() As Integer
        Return _dao.delete(Me)
    End Function

    ' Subroutine that is used to read all the patient in the database
    Public Sub readAllPatients()
        _dao.readAll()
    End Sub

    ' Subroutine to read a specific patient from the database
    Public Sub readPatient()
        _dao.read(Me)
    End Sub

    ' Subroutine to GET THE FEMALES THAT HAVE BOUGHT a bigger amount of medicines
    Public Sub femaleRanking(ByVal date1 As String, ByVal date2 As String)
        dao.femaleRanking(date1, date2)
    End Sub

End Class
