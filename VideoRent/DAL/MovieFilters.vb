
Public Class MovieFilters
    Private Function FilterByYear(movieCatalog As IEnumerable(Of movy),
                              filterValue As String) As List(Of movy)
        Dim result As New List(Of movy)
        Dim yearValue As Short = Convert.ToInt16(filterValue) ' String to Short OR CShort(filterValue)
        For Each movie In movieCatalog
            If movie.year = yearValue Then result.Add(movie)
        Next
        Return result
    End Function

    Private Function FilterByCountry(movieCatalog As IEnumerable(Of movy),
                               filterValue As String) As List(Of movy)
        Dim result As New List(Of movy)
        For Each movie In movieCatalog
            If movie.country = filterValue Then result.Add(movie)
        Next
        Return result
    End Function

    Private Function FilterByLanguage(movieCatalog As IEnumerable(Of movy),
                               filterValue As String) As List(Of movy)
        Dim result As New List(Of movy)
        For Each movie In movieCatalog
            If movie.language = filterValue Then result.Add(movie)
        Next
        Return result
    End Function

    Private Function FilterByCategory(movieCatalog As IEnumerable(Of movy),
                               filterValue As String) As List(Of movy)
        Dim result As New List(Of movy)
        For Each movie In movieCatalog
            If movie.genre = filterValue Then result.Add(movie)
        Next
        Return result
    End Function

    Public Function FilterMovies(ByRef movies As List(Of movy),
                                 ByVal repo As IGenRepository(Of movy),
                                 filterBy As FilterType, ByVal filter As String) As List(Of movy)

        Dim movieList As List(Of movy) = Nothing
        Try
            Dim filterCatalog As Func(Of IEnumerable(Of movy), String, List(Of movy)) = Nothing

            Select Case filterBy
                Case FilterType.Year
                    filterCatalog = AddressOf FilterByYear
                Case FilterType.Country
                    filterCatalog = AddressOf FilterByCountry
                Case FilterType.Language
                    filterCatalog = AddressOf FilterByLanguage
                Case FilterType.Category
                    filterCatalog = AddressOf FilterByCategory
            End Select

            If movies Is Nothing Then
                movieList = filterCatalog(repo.GetAll, filter)
            Else
                movieList = filterCatalog(movies, filter)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.ToString)
        End Try
        Return movieList
    End Function
End Class
