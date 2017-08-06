Imports MySql.Data.MySqlClient


Module StandardFunctions
    Dim conn As New MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim connectionString As String
    Dim ds As DataSet

    Public Sub Connect(query As String, dbVariable As String, lookUp As String)

        Try
            connectionString = System.Configuration.ConfigurationManager.ConnectionStrings("dbCon").ToString()
            conn = New MySqlConnection(connectionString)
            If Not conn Is Nothing Then conn.Close()
            conn.Open()

            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.Add(Chr(34) & Chr(64) & dbVariable & Chr(34), MySqlDbType.VarChar).Value = lookUp
            reader = cmd.ExecuteReader()
            ds = New DataSet()
            If reader.HasRows Then
                Do While reader.Read()

                    MainForm.SearchedMovieDataGridView.DataSource = ds

                    'ds.Load(reader, LoadOption.OverwriteChanges, )
                Loop
            Else
                MainForm.SearchTextBox.Text = lookUp & " movie was not found"
            End If
           
            reader.Close()
            conn.Close()
            Exit Sub
        Catch ex As Exception
            If Err.Number = 5 Then
                MsgBox(Err.Description)
                End
            End If
            MsgBox(ex.Message)
        End Try
        conn.Close()
    End Sub

End Module
