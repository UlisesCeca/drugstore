Imports System.Data.OleDb

Public Class DAOCategory

    Private _categoriesList As New Collection()
    Private c As Category

    ' Getter and setter for the collection attribute
    Property categoriesList As Collection
        Get
            Return Me._categoriesList
        End Get
        Set(value As Collection)
            Me._categoriesList = value
        End Set
    End Property

    ' Function to update the category values in the db
    Public Function update(ByRef c As Category) As Integer
        Return DBBroker.getInstance.change("UPDATE CATEGORIES SET CatDescription = '" & c.CatDescription & "', Disccount = " & c.Discount & " WHERE CategoryID = " & c.CategoryID & ";")
    End Function

    ' Function to delete a category from the db
    Public Function delete(ByVal c As Category) As Integer
        Return DBBroker.getInstance.change("DELETE FROM CATEGORIES WHERE CategoryID = " & c.CategoryID & ";")
    End Function

    ' Function to insert a new category in the db
    Public Function insert(ByVal c As Category) As Integer
        Return DBBroker.getInstance.change("INSERT INTO CATEGORIES (CatDescription,Disccount) VALUES('" & c.CatDescription & "'," & c.Discount & ");")
    End Function

    ' Subroutine to read the info of a category
    Public Sub read(ByRef c As Category)
        Dim data As OleDbDataReader
        data = DBBroker.getInstance.read("SELECT CatDescription, Disccount FROM CATEGORIES WHERE CategoryID = " & c.CategoryID & ";")

        While data.Read()
            c.CatDescription = data(0).ToString()
            c.Discount = Convert.ToDecimal(data(1))
        End While

    End Sub

    ' Subroutine to read and load all the categories from the db into the collection
    Public Sub readAll()
        Dim data As OleDbDataReader
        data = DBBroker.getInstance.read("SELECT CategoryID, CatDescription FROM CATEGORIES ORDER BY CategoryID;")

        While data.Read()
            c = New Category(Convert.ToInt32(data(0)))
            c.CatDescription = data(1).ToString()
            _categoriesList.Add(c)
        End While

    End Sub

End Class
