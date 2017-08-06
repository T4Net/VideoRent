Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class DeleteForm
    Dim counter As Integer = 3
    Dim isValid As Boolean = False
    Dim myconn As String = System.Configuration.ConfigurationManager.ConnectionStrings("dbCon").ToString()
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim dt As DataTable
    Dim da As MySqlDataAdapter
    Dim reader As MySqlDataReader
    Dim query As String
    Protected Friend user As String
    'Public Property user As MainForm1

    Private Sub DeleteForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        user = MainForm.userLog
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click

        Try
            If validInput(passTextBox.Text) Then
                If ValidateUserInput(passTextBox.Text) Then
                    conn = New MySqlConnection(myconn)
                    conn.Open()
                    query = "SELECT passcode FROM employee WHERE BINARY username = @user"
                    cmd = New MySqlCommand(query, conn)
                    cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = user
                    reader = cmd.ExecuteReader()
                Else
                    MsgBox("Password must be at least 4 characters long and cannot contain" & _
                           vbCrLf & "invalid characters.")
                    passTextBox.BackColor = Color.Red
                    'reader.Close()
                    'conn.Close()
                    passTextBox.Focus()
                    Exit Sub
                End If
            Else
                MsgBox("Passcode is empty.")
                passTextBox.BackColor = Color.Red
                passTextBox.Focus()
                Exit Sub
            End If

            While reader.HasRows And reader.Read
                Do Until isValid
                    If reader("passcode").Equals(passTextBox.Text) Then
                        reader.Close()
                        ShowTable()
                        isValid = True
                        Exit While
                    Else
                        MsgBox("Passcode is not correct!")
                        passTextBox.BackColor = Color.Red
                        counter -= 1
                        If counter <= 0 Then
                            isValid = True
                            MsgBox("You have reached the maximum number of attempts.")
                            reader.Close()
                            conn.Close()
                            Me.Close()
                        End If
                        MsgBox("Try again!" & vbNewLine & counter & " attempts remain.")
                        reader.Close()
                        conn.Close()
                        passTextBox.Focus()
                        Exit Sub
                    End If
                Loop
            End While

        Catch 'You probably want to do more here, but "Return False" was enough for this quick example
            conn.Close()
            MsgBox(Err.Description)
            'If Err.Number = 5 Then
            '    MsgBox(Err.Description)
            '    End
            'End If

        End Try
    End Sub
    Private Sub ShowTable()
        Try
            'reader.Close()
            If conn Is Nothing Then
                conn = New MySqlConnection(myconn)
                conn.Open()
            ElseIf conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            DataGridView1.Update()
            DataGridView1.Refresh()
            cmd.Dispose()
            query = "SELECT idemployee, employee_name, employee_surname, username FROM employee"
            cmd = New MySqlCommand(query, conn)
            reader = cmd.ExecuteReader()
            dt = New DataTable
            dt.Load(reader)
            'da = New MySqlDataAdapter(cmd)
            'dt.Load(reader)
            'da.Fill(dt)

            DataGridView1.Visible = True
            DataGridView1.DataSource = dt
            Dim x As Integer
            For x = 0 To DataGridView1.ColumnCount
                If x < DataGridView1.ColumnCount Then
                    DataGridView1.Columns(x).ReadOnly = True
                End If
            Next
            DeleteButton.Visible = True
            'DataGridView1.ColumnCount = 4
            With DataGridView1
                .Columns("idemployee").HeaderText = "Employee ID"
                .Columns("idemployee").DisplayIndex = 0
                .Columns("employee_name").HeaderText = "Employee Name"
                .Columns("employee_name").DisplayIndex = 1
                .Columns("employee_surname").HeaderText = "Employee Surname"
                .Columns("employee_surname").DisplayIndex = 2
                .Columns("username").HeaderText = "Employee Username"
                .Columns("username").DisplayIndex = 3
                If Not DataGridView1.Columns.Contains("chk") = True Then
                    Dim chk As New DataGridViewCheckBoxColumn()
                    .Columns.Add(chk)
                    chk.HeaderText = "Delete Account"
                    chk.Name = "chk"
                Else
                    .Columns("chk").DisplayIndex = 4
                End If
            End With
            DataGridView1.AllowUserToAddRows = False
            DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
            'DataGridView1.Rows(DataGridView1.RowCount - 1).Height = 0
            'DataGridView1.Rows.RemoveAt(DataGridView1.RowCount - 1)
            'Dim totalHeight As Integer = DataGridView1.ColumnHeadersHeight
            'Dim row As DataGridViewRow
            'For Each row In DataGridView1.Rows
            '    totalHeight += row.Height
            'Next
            'DataGridView1.Height = totalHeight
            'DataGridView1.ScrollBars = ScrollBars.None
            'Dim row As String() = New String() {"1", "Product 1", "1000"}
            'DataGridView1.Rows.Add(row)
            'row = New String() {"2", "Product 2", "2000"}
            'DataGridView1.Rows.Add(row)
            'row = New String() {"3", "Product 3", "3000"}
            'DataGridView1.Rows.Add(row)
            'row = New String() {"4", "Product 4", "4000"}
            'DataGridView1.Rows.Add(row)


            'DataGridView1.Rows(2).Cells(3).Value = True

            'da.Dispose()
        Catch 'You probably want to do more here, but "Return False" was enough for this quick example
            conn.Close()
            cmd.Dispose()
            'da.Dispose()
            MsgBox(Err.Description)
            End
        End Try
    End Sub

    Private Sub passTextBox_TextChanged(sender As System.Object, e As EventArgs) Handles passTextBox.TextChanged
        If passTextBox.BackColor = Color.Red Then
            passTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Dim row As DataGridViewRow
        Dim users(1) As Integer ' = New Integer() {}
        For Each row In DataGridView1.Rows

            If row.Cells("chk").Value = True Then
                users(UBound(users) - 1) = row.Cells(0).Value
                ReDim Preserve users(UBound(users) + 1)
            End If
        Next
        If users IsNot Nothing AndAlso users.Count > 0 _
            AndAlso users(LBound(users)) > 0 Then 'String.IsNullOrEmpty(CStr(users(LBound(users)))) Then

            Dim userAnswer = MsgBox("Do you really want to remove selected user?", MsgBoxStyle.YesNo, _
                  "Confirm")
            If userAnswer = MsgBoxResult.Yes Then DeleteUser(users) '(row.Cells(0).Value)
            DataGridView1.DataSource = vbNull
            ShowTable()
        End If
    End Sub

    Private Sub DeleteUser(ByVal usersID() As Integer) '(userID As Integer)
        Dim number As Integer
        If reader.IsClosed = False Then reader.Close()
        If conn Is Nothing Then
            conn = New MySqlConnection(myconn)
            conn.Open()
        ElseIf conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
        cmd.Dispose()
        query = "DELETE FROM employee WHERE idemployee = @user"
        cmd = New MySqlCommand(query, conn)
        cmd.Parameters.Add("@user", MySqlDbType.Int16)
        For Each number In usersID
            If number > 0 Then
                cmd.Parameters("@user").Value = number
                reader = cmd.ExecuteReader()
                reader.Close()
            End If
            
            'cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = number
        Next

        conn.Close()
        cmd.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class