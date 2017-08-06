Imports System.Data.Common
Public Class ADatabase
    Public Overridable Property Connection As DbConnection
    Public Overridable Property Command As DbCommand
    Public Overridable Property Adapter As DbDataAdapter
    Public Overridable Property Reader As DbDataReader
End Class
