'respect to https://larrysteinle.com/2011/02/20/use-regular-expressions-to-detect-sql-code-injection/
Imports System.Text.RegularExpressions
Imports VideoRent.MainForm
'Stores all validation actions
Public Class CommandTextValidator
    'Permitted actions
    Public Enum TypeOfcommand
        Fetch
        Update
        Insert
        Delete
    End Enum

    Public Shared Function ValidateQuery(ByVal dbQuery As String, commType As TypeOfcommand) As Boolean
        'Unsupported behavior
        Dim unauthorizedActions() As String = {"DROP", "MERGE", "UNION", "ALTER", "DELETETREE",
            "DELETE"}
        'Unsupported behavior
        Dim unauthorizedActions2() As String = {"DROP", "MERGE", "UNION", "ALTER", "DELETETREE"}

        'Dim regExpression As Regex = New Regex("^[a-zA-Z0-9]$")
        Dim regExpression As Regex = New Regex("/exec(\s|\+)+(s|x)p\w+/ix") 'Regex for detecting SQL Injection attacks on a MS SQL Server
        Try
            If Not regExpression.IsMatch(dbQuery) Then
                'Check if behavior complies with Command Type
                Select Case commType
                    Case TypeOfcommand.Delete
                        'check if query contains any unauthorized statement from an array
                        If Not unauthorizedActions2.Any(Function(b) dbQuery.ToUpper.Contains(b)) Then
                            Return True
                        Else
                            Return False
                        End If
                    Case Else
                        'check if query contains any unauthorized statement from an array
                        If Not unauthorizedActions.Any(Function(b) dbQuery.ToUpper.Contains(b)) Then
                            Return True
                        Else
                            Return False
                        End If
                End Select
            End If
        Catch ex As Exception
            Throw
        End Try
        Return False
    End Function

    Private Shared ReadOnly Property User() As String
        Get
            Return MainForm.userLog
        End Get
    End Property

    Public Shared Function UserPrivilege() As Boolean
        'Normally a list of authorized users would come from database 
        If User = "Aldo" Then
            Return True
        Else
            Return False
        End If
    End Function

End Class
