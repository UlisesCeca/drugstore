Public Class Category

    Private _CategoryID As Integer
    Private _CatDescription As String
    Private _Discount As Double
    Private _dao As DAOCategory

    ' Getter and setter for CategoryID attribute
    Property CategoryID As Integer
        Get
            Return Me._CategoryID
        End Get
        Set(value As Integer)
            Me._CategoryID = value
        End Set
    End Property

    ' Getter and setter for CatDescription attribute
    Property CatDescription As String
        Get
            Return Me._CatDescription
        End Get
        Set(value As String)
            Me._CatDescription = value
        End Set
    End Property

    ' Getter and setter for Discount attribute
    Property Discount As Double
        Get
            Return Me._Discount
        End Get
        Set(value As Double)
            Me._Discount = value
        End Set
    End Property

    ' Getter and setter for dao attribute
    Property dao As DAOCategory
        Get
            Return Me._dao
        End Get
        Set(value As DAOCategory)
            Me._dao = value
        End Set
    End Property

    ' Class constructor
    Public Sub New()
        Me._dao = New DAOCategory()
    End Sub

    ' Class constructor 2
    Public Sub New(catID As Integer)
        Me._dao = New DAOCategory()
        Me._CategoryID = catID
    End Sub

    ' Function that inserts a category in the database
    Public Function insertCategory() As Integer
        Return _dao.insert(Me)
    End Function

    ' Function that updates the info of a category in the database
    Public Function updateCategory() As Integer
        Return _dao.update(Me)
    End Function

    'Function that removes a category from the database
    Public Function deleteCategory() As Integer
        Return _dao.delete(Me)
    End Function

    ' Subroutine that is used to read all the catogires in the database
    Public Sub readAllCategories()
        _dao.readAll()
    End Sub

    ' Subroutine to read info of a specific category from the database
    Public Sub readCategory()
        _dao.read(Me)
    End Sub

End Class
