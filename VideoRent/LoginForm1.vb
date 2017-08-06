Imports System.Security.Cryptography
Imports System.Text
Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

' http://www.visual-basic-tutorials.com/hasing-password-with-salt-in-visual-basic.htm#sthash.4pgSyWw3.dpuf

Public Class LoginForm

    Dim salt As String = ""
    'Dim conn As MySqlConnection
    'Dim cmd As MySqlCommand
    'Dim reader As MySqlDataReader
    Dim user As String
    Dim query As String
    Dim isValid As Boolean = False
    Dim counter As Integer = 3
    'Public Shared uName As String = LoginForm1.UsernameTextBox.Text
    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click

        Try
            Do Until isValid
                If validInput(UsernameTextBox.Text) And validInput(PasswordTextBox.Text) Then
                    If ValidateUserInput(UsernameTextBox.Text) And ValidateUserInput(PasswordTextBox.Text) Then
                        If AuthenticateUser(UsernameTextBox.Text, PasswordTextBox.Text) Then
                            MsgBox("Welcome " & UsernameTextBox.Text)
                            isValid = True
                            MainForm.Show()
                            Me.Hide() 'Me.Close()
                            Exit Sub
                        Else
                            'UsernameTextBox.Text = ""
                            'PasswordTextBox.Text = ""
                            'UsernameTextBox.BackColor = Color.Red
                            'PasswordTextBox.BackColor = Color.Red
                        End If
                    Else
                        MsgBox("Username and/or password contain invalid characters.")
                        'UsernameTextBox.Text = ""
                        'PasswordTextBox.Text = ""
                        'UsernameTextBox.BackColor = Color.Red
                        'PasswordTextBox.BackColor = Color.Red
                    End If
                Else
                    MsgBox("Username and/or password is empty.")
                End If
                UsernameTextBox.Text = ""
                PasswordTextBox.Text = ""
                UsernameTextBox.BackColor = Color.Red
                PasswordTextBox.BackColor = Color.Red
                counter -= 1
                If counter <= 0 Then
                    isValid = True
                    YouShallNotPicture.Visible = True
                    MsgBox("You have reached the maximum number of attempts. Bye Bye")
                    Close()
                End If
                MsgBox("Try again!" & vbNewLine & counter & " attempts remain.")
                UsernameTextBox.Focus()
                Exit Sub
            Loop

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

    Private Sub LoginForm1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenConfigEncryption("VideoRent.exe")

        'config.ConnectionStrings.SectionInformation.ProtectSection(Nothing)
        '' We must save the changes to the configuration file.
        'config.Save(ConfigurationSaveMode.Full, True)
        'Dim sectionXml As String =
        'section.SectionInformation.GetRawXml()
        'Console.WriteLine(sectionXml)
    End Sub

    Private Sub LoginForm1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        YouShallNotPicture.Visible = False
        CloseConfigEncryption("VideoRent.exe")
    End Sub

    'https://stackoverflow.com/questions/29183301/unable-to-verify-bcrypt-hashed-password-from-mysql-with-vb-net
    Private Function AuthenticateUser(ByVal Username As String, ByVal Password As String) As Boolean

        Dim salt As String
        Dim tempPass As String
        'Dim myconn As String = System.Configuration.ConfigurationManager.ConnectionStrings("dbCon").ToString()
        Dim connName As String = "dbCon"
        query = "SELECT username, password, salt FROM employee WHERE BINARY username = @param1"
        Dim database As IRepository = Nothing
        Try
            Dim params(0) As String
            params(0) = Username
            database = DatabaseFactory.CreateDatabase(DatabaseConnectionType.MySql)
            database.CreateConnection(connName)

            database.CreateCommand(query, CommandTextValidator.TypeOfcommand.Fetch)
            database.BuildParameters(params)
            database.CreateReader()

            With database.DatabaseType
                While .Reader.HasRows And .Reader.Read
                    salt = .Reader.GetString(.Reader.GetOrdinal("salt"))
                    tempPass = .Reader.GetString(.Reader.GetOrdinal("password"))
                    If Hash512(Password, .Reader("salt")).Equals(.Reader("password")) Then
                        database.CloseConnection()
                        Return True
                    Else
                        MsgBox("Credentials incorrect")
                        database.CloseConnection()
                        Return False
                    End If
                End While
            End With
            MsgBox("User doesn't exist!")
            database.CloseConnection()
            Return False
        Catch 'You probably want to do more here, but "Return False" was enough for this quick example
            database.CloseConnection()
            If Err.Number = 5 Then
                MsgBox(Err.Description)
                'Exit Function
            End If
            Return False
        End Try
        Return False
        'conn = New MySqlConnection(myconn)
        'conn.Open()
        'query = "SELECT username, password, salt FROM employee WHERE BINARY username = @user"
        'cmd = New MySqlCommand(query, conn)

        'cmd.Parameters.Add("@user", MySqlDbType.VarChar).Value = Username
        '    reader = cmd.ExecuteReader()
        '    While reader.HasRows And reader.Read
        '        salt = reader.GetString(reader.GetOrdinal("salt"))
        '        tempPass = reader.GetString(reader.GetOrdinal("password"))
        '        'Return Hash512(Password, reader("salt")).Equals(reader("password"))
        '        If Hash512(Password, reader("salt")).Equals(reader("password")) Then
        '            'MsgBox("Credentials correct")
        '            'TextBox1.Text = tempPass
        '            'TextBox2.Text = (Hash512(Password, salt))
        '            'If TextBox1.Text = TextBox2.Text Then
        '            'MsgBox("Second level of security checked. Confirming credentials are correct!!!")
        '            'End If
        '            conn.Close()
        '            Return True
        '        Else
        '            MsgBox("Credentials incorrect")
        '            conn.Close()
        '            Return False
        '        End If
        '    End While
        '    MsgBox("User doesn't exist!")
        '    conn.Close()
        '    Return False
        '    'validCred = Hash512(Password, salt)
        'Catch 'You probably want to do more here, but "Return False" was enough for this quick example
        '    conn.Close()
        '    If Err.Number = 5 Then
        '        MsgBox(Err.Description)
        '        Exit Function 'End
        '    End If
        '    Return False
        'End Try
    End Function

    Private Sub UsernameTextBox_TextChanged(sender As Object, e As EventArgs) Handles UsernameTextBox.TextChanged
        If UsernameTextBox.BackColor = Color.Red Or PasswordTextBox.BackColor = Color.Red Then
            UsernameTextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub PasswordTextBox_TextChanged(sender As Object, e As EventArgs) Handles PasswordTextBox.TextChanged
        If PasswordTextBox.BackColor = Color.Red Or UsernameTextBox.BackColor = Color.Red Then
            PasswordTextBox.BackColor = Color.White
        End If
    End Sub


End Class
