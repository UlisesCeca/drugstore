Imports System.Data.OleDb

Public Class DBBroker
    Private Shared connectionString As String = “Provider=Microsoft.ACE.OLEDB.12.0; Data Source=“
    Private Shared connection As OleDbConnection
    Private Shared instance As DBBroker
    Private Shared dbPath As String

    Public Shared WriteOnly Property path As String
        Set(value As String)
            DBBroker.dbPath = value
        End Set
    End Property


    Private Sub New()
        DBBroker.connection = New OleDbConnection(connectionString & dbPath)
        DBBroker.connection.Open()
    End Sub
    ' Constructor of the class

    Public Shared Function getInstance() As DBBroker
        If instance Is Nothing Then
            instance = New DBBroker()
        End If
        Return instance
    End Function
    ' Function used to get the instance of the dbbroker because it is a Singleton

    Public Function read(ByVal sql As String) As OleDbDataReader
        Dim com As New OleDbCommand(sql, connection)
        Return com.ExecuteReader()
    End Function
    ' Function used to retrieve information from the db

    Public Function change(ByVal sql As String) As Integer
        Dim com As New OleDbCommand(sql, connection)
        Return com.ExecuteNonQuery()
    End Function
    ' Function used to make change actions in the db as deleting, inserting and updating

End Class
