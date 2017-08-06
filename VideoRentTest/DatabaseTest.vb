Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports VideoRent
Imports System.Data.Entity
Imports System.Windows.Forms
Imports VideoRent.MainForm

<TestClass()> Public Class DatabaseTest

    <TestMethod()> Public Sub EntityTypes()
        Try
            Dim form As MainForm
            form = New MainForm
            'Dim queryString, queryParam As String
            'queryString = "Select mov.movieID, mov.title, mov.year, mov.language, mov.country," &
            '    " mov.availableCopies, mov.genre,  mov.rentalRate, mov.category, im.image FROM movies mov INNER JOIN cover_images im" &
            '    " On im.title = mov.title WHERE mov.title Like @param"
            'queryParam = "the"
            'form.OpenConnectionQuery(queryString, queryParam)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub


End Class