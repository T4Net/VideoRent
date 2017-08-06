Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class RegistrationForm
    'Dim salt As String = ""
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim reader As MySqlDataReader
    Dim user As String
    Dim query As String

    Private Sub Ok_Button_Click(sender As Object, e As EventArgs) Handles Ok_Button.Click
        If validInput(Name_TextBox.Text) And validInput(Surname_TextBox.Text) _
           And validInput(Username_TextBox.Text) And validInput(Pass_TextBox.Text) Then
            If ValidateUserInput(Name_TextBox.Text) And ValidateUserInput(Surname_TextBox.Text) _
                And ValidateUserInput(Username_TextBox.Text) And ValidateUserInput(Pass_TextBox.Text) Then
                RegisterUser()
            Else
                Name_TextBox.Text = ""
                Surname_TextBox.Text = ""
                Username_TextBox.Text = ""
                Pass_TextBox.Text = ""
                Name_TextBox.BackColor = Color.Red
                Surname_TextBox.BackColor = Color.Red
                Username_TextBox.BackColor = Color.Red
                Pass_TextBox.BackColor = Color.Red
                With FrmReg_mainLabel
                    .Text = "Invalid characters!"
                    .ForeColor = Color.Red
                    .Font = New Font(.Font, FontStyle.Bold)
                End With
            End If
        End If
    End Sub

    Private Sub RegisterUser()
        Dim myconn As String = System.Configuration.ConfigurationManager.ConnectionStrings("dbCon").ToString()
        conn = New MySqlConnection(myconn)
        conn.Open()
        query = "INSERT INTO video_db.employee (employee_name, employee_surname, username, password, salt) VALUES(@name, @surname, @user, @pass, @salto)"
        cmd = New MySqlCommand(query, conn)

        Try
            cmd.Parameters.AddWithValue("@name", Name_TextBox.Text)
            cmd.Parameters.AddWithValue("@surname", Surname_TextBox.Text)
            cmd.Parameters.AddWithValue("@user", Username_TextBox.Text)
            cmd.Parameters.AddWithValue("@pass", Hash512(Pass_TextBox.Text, CreateRandomSalt))
            cmd.Parameters.AddWithValue("@salto", salt)
            reader = cmd.ExecuteReader()
            reader.Close()
            conn.Close()
            MsgBox("Register successfully!")
            Me.Close()
            'validCred = Hash512(Password, salt)
        Catch 'You probably want to do more here, but "Return False" was enough for this quick example
            MsgBox(Err.Description)
        End Try
    End Sub

    Private Sub Cancel_Button_Click(sender As Object, e As EventArgs) Handles Cancel_Button.Click
        Me.Close()
    End Sub

    Private Sub Name_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Name_TextBox.TextChanged, Surname_TextBox.TextChanged, Username_TextBox.TextChanged, Pass_TextBox.TextChanged
        Dim ctrl As Control = sender
        'MsgBox(ctrl.Name)
        Select Case ctrl.Name
            Case "Name_TextBox"
                If Name_TextBox.BackColor = Color.Red Then
                    Name_TextBox.BackColor = Color.White
                End If
            Case "Surname_TextBox"
                If Surname_TextBox.BackColor = Color.Red Then
                    Surname_TextBox.BackColor = Color.White
                End If
            Case "Username_TextBox"
                If Username_TextBox.BackColor = Color.Red Then
                    Username_TextBox.BackColor = Color.White
                End If
            Case "Pass_TextBox"
                If Pass_TextBox.BackColor = Color.Red Then
                    Pass_TextBox.BackColor = Color.White
                End If
        End Select
        If Name_TextBox.BackColor = Color.White And Surname_TextBox.BackColor = Color.White And _
            Username_TextBox.BackColor = Color.White And Pass_TextBox.BackColor = Color.White Then
            FrmReg_mainLabel.Text = "Please enter information to register new user." & vbCrLf & _
                "Min. 4 characters required in each field below."
            FrmReg_mainLabel.ForeColor = Color.White
        End If

    End Sub

    'Private Sub Surname_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Surname_TextBox.TextChanged
    '    If Name_TextBox.BackColor = Color.Red Or Surname_TextBox.BackColor = Color.Red Or _
    '        Username_TextBox.BackColor = Color.Red Or Pass_TextBox.BackColor = Color.Red Then
    '        Surname_TextBox.BackColor = Color.White
    '    Else
    '        FrmReg_mainLabel.Text = "Please enter information to register new user." & vbCrLf & _
    '            "Min. 4 characters required in each field below."
    '        FrmReg_mainLabel.ForeColor = Color.White
    '    End If
    'End Sub

    'Private Sub Username_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Username_TextBox.TextChanged
    '    If Name_TextBox.BackColor = Color.Red Or Surname_TextBox.BackColor = Color.Red Or _
    '        Username_TextBox.BackColor = Color.Red Or Pass_TextBox.BackColor = Color.Red Then
    '        Username_TextBox.BackColor = Color.White
    '    Else
    '        FrmReg_mainLabel.Text = "Please enter information to register new user." & vbCrLf & _
    '            "Min. 4 characters required in each field below."
    '        FrmReg_mainLabel.ForeColor = Color.White
    '    End If
    'End Sub

    'Private Sub Pass_TextBox_TextChanged(sender As Object, e As EventArgs) Handles Pass_TextBox.TextChanged
    '    If Name_TextBox.BackColor = Color.Red Or Surname_TextBox.BackColor = Color.Red Or _
    '        Username_TextBox.BackColor = Color.Red Or Pass_TextBox.BackColor = Color.Red Then
    '        Pass_TextBox.BackColor = Color.White
    '    Else
    '        FrmReg_mainLabel.Text = "Please enter information to register new user." & vbCrLf & _
    '            "Min. 4 characters required in each field below."
    '        FrmReg_mainLabel.ForeColor = Color.White
    '    End If
    'End Sub

End Class