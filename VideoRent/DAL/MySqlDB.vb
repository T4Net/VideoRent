Imports System.Data.Common
Imports MySql.Data.MySqlClient

Public Class MySqlDB
    Inherits ADatabase

    Private _connection As MySqlConnection = Nothing
    Private _command As MySqlCommand = Nothing
    Private _adapter As MySqlDataAdapter = Nothing
    Private _reader As MySqlDataReader = Nothing

    Public Overrides Property Connection() As DbConnection
        Get
            Return _connection
        End Get

        Set(value As DbConnection)
            _connection = value
        End Set
    End Property

    Public Overrides Property Command As DbCommand
        Get
            Return _command
        End Get
        Set(value As DbCommand)
            _command = value
        End Set
    End Property

    Public Overrides Property Adapter As DbDataAdapter
        Get
            Return _adapter
        End Get
        Set(value As DbDataAdapter)
            _adapter = value
        End Set
    End Property

    Public Overrides Property Reader As DbDataReader
        Get
            Return _reader
        End Get
        Set(value As DbDataReader)
            _reader = value
        End Set
    End Property
End Class
