Imports VideoRent.CommandTextValidator


Public Class DataSetCrud
    Private _database As ADatabase

    Public Sub New(database As ADatabase)
        _database = database
    End Sub

    Public Function SelectData() As DataSet
        Dim dSet As New DataSet
        _database.Adapter.Fill(dSet)
        Return dSet
    End Function

    Public Sub CrudAction(table As String, rowId As Integer, colName As String,
                     newValue As Object, queryType As TypeOfcommand)
        Dim dSet As New DataSet
        Dim rowRec As DataRow
        Dim authorizedUser As Boolean = UserPrivilege()
        Try
            _database.Adapter.Fill(dSet)
            Select Case queryType
                Case TypeOfcommand.Update
                    rowRec = dSet.Tables(table).Rows.Find(rowId)
                    If Not rowRec Is Nothing Then rowRec.Item(colName) = newValue
                Case TypeOfcommand.Delete
                    If authorizedUser Then
                        rowRec = dSet.Tables(table).Rows.Find(rowId)
                        If Not rowRec Is Nothing Then rowRec.Delete()
                    Else
                        Throw New System.UnauthorizedAccessException(
                            "User is not authorized to Delete records.")
                    End If
                Case TypeOfcommand.Insert
                    rowRec = dSet.Tables(table).NewRow()
                    SetRowValues(rowRec)
            End Select
            _database.Command.UpdatedRowSource() = UpdateRowSource.Both
            'Update the data source.
            _database.Adapter.Update(dSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            dSet.Dispose()
            rowRec = Nothing
        End Try

    End Sub

    Private Sub SetRowValues(row As DataRow)
        Dim message, title, defaultValue, column As String
        Dim value As Object
        Dim dType As Type
        ' Set prompt.
        message = "Enter new value for column named: " & vbCrLf &
            "If first column is empty, leave empty value and hit OK."
        ' Set title.
        title = "Create new record"
        defaultValue = ""   ' Set default value.

        Try
            For i As Integer = 0 To row.ItemArray.Count
                column = row(i).ToString()
                ' Display message, title, and default value.
                value = InputBox(message & column, title, defaultValue)
                ' If user has clicked Cancel, set myValue to defaultValue 
                If value Is "" Then value = defaultValue
                dType = row(i).GetType()
                Try
                    value = CTypeDynamic(value, dType)
                Catch ex As Exception
                    value = defaultValue
                End Try
                row.Item(i) = value
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

End Class
