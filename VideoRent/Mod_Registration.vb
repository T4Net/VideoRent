Imports System.Security.Cryptography
Imports System.Text
Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Text.RegularExpressions

Module Mod_Registration

    Public salt As String = ""

    Public Function CreateRandomSalt() As String
        'the following is the string that will hold the salt charachters
        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=][}{<>"

        Dim rnd As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 10 'Length of the salt
            Dim x As Integer = rnd.Next(0, mix.Length - 1)
            salt &= (mix.Substring(x, 1))
        Next
        Return salt
    End Function

    Public Function Hash512(password As String, salt As String) As String
        Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
        Dim hashType As HashAlgorithm = New SHA512Managed()
        Dim hashBytes As Byte() = hashType.ComputeHash(convertedToBytes)
        Dim hashedResult As String = Convert.ToBase64String(hashBytes)
        Return hashedResult
    End Function

    Public Function validInput(ByVal input As String) As Boolean
        If input = "" Then
            'MessageBox.Show("Please enter all data")
            Return False
        Else
            Return True
        End If
    End Function

    Public Function ValidateUserInput(ByVal userInput As String) As Boolean

        Dim regExpression As Regex = New System.Text.RegularExpressions.Regex("^[a-zA-Z0-9]{4,12}$")
        If regExpression.IsMatch(userInput) Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub OpenConfigEncryption(ByVal exeConfigName As String)
        ' Takes the executable file name without the
        ' .config extension.
        Try
            ' Open the configuration file and retrieve 
            ' the connectionStrings section.
            Dim config As Configuration = ConfigurationManager. _
                OpenExeConfiguration(exeConfigName)

            Dim section As ConnectionStringsSection = DirectCast( _
                config.GetSection("connectionStrings"),  _
                ConnectionStringsSection)

            If section.SectionInformation.IsProtected Then
                ' Remove encryption.
                section.SectionInformation.UnprotectSection()
            End If

            ' Save the current configuration.
            config.Save()

            ConfigurationManager.RefreshSection("connectionStrings")
            'Console.WriteLine("Protected={0}", _
            'section.SectionInformation.IsProtected)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Sub CloseConfigEncryption(ByVal exeConfigName As String)
        ' Takes the executable file name without the
        ' .config extension.
        Try
            ' Open the configuration file and retrieve 
            ' the connectionStrings section.
            Dim config As Configuration = ConfigurationManager. _
                OpenExeConfiguration(exeConfigName)

            Dim section As ConnectionStringsSection = DirectCast( _
                config.GetSection("connectionStrings"),  _
                ConnectionStringsSection)

            If Not section.SectionInformation.IsProtected Then
                ' Encrypt the section.
                section.SectionInformation.ProtectSection( _
                  "DataProtectionConfigurationProvider")
            End If

            ' Save the current configuration.
            config.Save()

            ConfigurationManager.RefreshSection("connectionStrings")
            'Console.WriteLine("Protected={0}", _
            'section.SectionInformation.IsProtected)

        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

End Module
