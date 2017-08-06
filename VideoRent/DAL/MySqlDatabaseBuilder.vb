Imports System.Data.Common
Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions
Imports VideoRent.CommandTextValidator
Imports VideoRent

Public Class MySqlDatabaseBuilder
    'Inherits ADatabase
    Implements IRepository

    Private _database As ADatabase

    'Public Sub MysqlDatabaseBuilder()
    '    _database = New MySqlDB
    'End Sub
    Public Sub New()
        _database = New MySqlDB
    End Sub

    Public Sub CreateConnection(connName As String) Implements IRepository.CreateConnection
        'retrieve connection string by 'Name' from a configuration file. 
        Dim connectionString As String = ConfigurationManager.ConnectionStrings(connName).ConnectionString
        If IsNothing(_database.Connection) Then
            _database.Connection = New MySqlConnection(connectionString)
        End If
        _database.Connection.Open()
    End Sub

    Public Sub CreateCommand(query As String, queryType As TypeOfcommand) Implements IRepository.CreateCommand
        Dim authorizedQuery As Boolean
        If Not String.IsNullOrWhiteSpace(query) Then
            authorizedQuery = CommandTextValidator.ValidateQuery(query, queryType)
            If authorizedQuery Then
                _database.Command = New MySqlCommand(query, _database.Connection)
            Else
                Throw New System.UnauthorizedAccessException("Batch statements not authorized:" & vbCrLf & query)
            End If
        End If
    End Sub

    Public Sub BuildParameters(params() As String) Implements IRepository.BuildParameters
        Dim parameter As MySqlParameter
        For i As Integer = 0 To params.Count - 1
            parameter = New MySqlParameter()
            parameter.Direction = ParameterDirection.Output
            parameter.MySqlDbType = MySqlDbType.VarChar
            parameter.Value = params.ElementAt(i)
            parameter.ParameterName = "@param" & i + 1
            _database.Command.Parameters.Add(parameter)
        Next
    End Sub

    Public Sub CreateAdapter() Implements IRepository.CreateAdapter
        _database.Adapter = New MySqlDataAdapter(_database.Command)
    End Sub

    Public Sub CreateReader() Implements IRepository.CreateReader
        Try
            Dim reader As MySqlDataReader
            reader = _database.Command.ExecuteReader
            _database.Reader = reader
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.ToString)
        End Try
    End Sub

    Public Sub CloseConnection() Implements IRepository.CloseConnection
        _database.Connection.Close()
    End Sub

    Public Function Execute() As Integer Implements IRepository.Execute
        'ExecuteNonQuery returns the number of rows that were updated
        Return _database.Command.ExecuteNonQuery()
    End Function

    Public ReadOnly Property DatabaseType As ADatabase Implements IRepository.DatabaseType
        Get
            Return _database
        End Get
    End Property

End Class
