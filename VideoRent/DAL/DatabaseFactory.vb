Public Class DatabaseFactory
    Public Shared Function CreateDatabase(dbConnType As DatabaseConnectionType) As IRepository
        Select Case dbConnType
            Case DatabaseConnectionType.MySql
                Return New MySqlDatabaseBuilder
            Case Else
                Return New MySqlDatabaseBuilder
        End Select
    End Function
End Class
'http://www.dofactory.com/net/adapter-design-pattern
'Use Adapter pattern to solve the problem when one Interface
'doesn't fit all implementations. Basically override methods in one class 
'to line up exactly with needs.
