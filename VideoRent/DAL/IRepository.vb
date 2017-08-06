Imports VideoRent.CommandTextValidator

Public Interface IRepository
    ReadOnly Property DatabaseType() As ADatabase
    Sub CreateConnection(connectionName As String)
    Sub CloseConnection()
    Sub CreateCommand(query As String, queryType As TypeOfcommand)
    Sub CreateAdapter()
    Sub CreateReader()
    Sub BuildParameters(params() As String)
    Function Execute() As Integer
End Interface

