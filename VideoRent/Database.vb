Option Explicit On
Option Strict On
Imports System.Linq
'Imports VideoRent.Ms.Linq.Dynamic

'Issue with importing namespace: http://stackoverflow.com/questions/7030685/vb-net-and-the-system-linq-dynamic-namespace
'How to update Data Model - http://www.c-sharpcorner.com/article/create-and-update-an-edmx-file-using-entity-framework-data-model-in-visual-stud/
'How to fix System.Data.StrongTypingException: _ 
'The value For column 'IsPrimaryKey' in table 'TableDetails' is DBNull. _
'---> System.InvalidCastException: Specified cast Is Not valid.
'https://bugs.mysql.com/bug.php?id=79163

Public Enum RepoType
    Rent
    Movie
    Payment
    MovieCopies
    Member
End Enum

'WRAPPER TO GENERIC REPOSITORIUM FOR IMPORTANT ACTIONS ON ENTITY FRAMEWORK
Public Class Database
    'Uncomment only if you go for Dynamic Linq Methods included in comments below
    'Inherits video_dbEntities
    'Private pDtBase As video_dbEntities

    Private _memberRepo As IGenRepository(Of member)
    Private _movieRepo As IGenRepository(Of movy)
    Private _movieCopiesRepo As IGenRepository(Of movie_copies)
    Private _paymentRepo As IGenRepository(Of payment)
    Private _rentalRepo As IGenRepository(Of rental)

    Public Sub New(repo As RepoType)
        Select Case repo
            Case RepoType.Member
                _memberRepo = New GenEnRepository(Of member)
            Case RepoType.Movie
                _movieRepo = New GenEnRepository(Of movy)
            Case RepoType.MovieCopies
                _movieCopiesRepo = New GenEnRepository(Of movie_copies)
            Case RepoType.Payment
                _paymentRepo = New GenEnRepository(Of payment)
            Case RepoType.Rent
                _rentalRepo = New GenEnRepository(Of rental)
        End Select
    End Sub

    Public Sub New()
        'If pDtBase Is Nothing Then
        '    pDtBase = New video_dbEntities()
        'End If
    End Sub
    Friend Function GetRentByCopyID(copyID As Integer, hired As Byte) As rental
        Dim rentals As IGenRepository(Of rental) = New GenEnRepository(Of rental)
        Dim rents As List(Of rental)

        rents = rentals.GetAll.ToList
        Dim customerRent As rental = (From rent In rents
                                      Where (rent.CopyID.Equals(copyID) And rent.currentlyHiring = hired)
                                      Select rent).FirstOrDefault()
        Return customerRent
    End Function

    Friend Function GetFineByTitle(title As String) As Double
        Dim movies As IGenRepository(Of movy) = New GenEnRepository(Of movy)
        Return CDbl(movies.GetAll.Where(Function(c) c.title = title).Select(Function(c) c.penalty).FirstOrDefault)
        'Standard LINQ in this case
        'CDbl((From movies In Database.movies
        '      Where movies.title.Equals(title)
        '      Select movies.penalty).FirstOrDefault)
    End Function

    Friend Function GetRentByRentID(id As Integer) As rental
        'Dim rentals As IGenRepository(Of rental) = New GenEnRepository(Of rental)
        'Return rentals.GetById(id)
        Return _rentalRepo.GetById(id)
        'Standard LINQ in this case
        'Return (From rent In Database.rentals
        '        Where (rent.rentID.Equals(id))
        '        Select rent).FirstOrDefault()
    End Function

    Friend Function GetPaymentDateByRentID(id As Integer) As Date?
        Dim payments As IGenRepository(Of payment) = New GenEnRepository(Of payment)
        Return payments.GetAll.Where(Function(p) p.rentID = id).Select(Function(p) p.paymentDate).FirstOrDefault
        'Standard LINQ in this case
        'Dim customerPay As Date? = Nothing
        'customerPay = (From cPay In database.payments Where cPay.rentID = rID
        '               Select cPay.paymentDate).FirstOrDefault()
    End Function

    Friend Function GetHireDate(id As Integer) As Date
        Dim rentals As IGenRepository(Of rental) = New GenEnRepository(Of rental)
        Return rentals.GetAll.Where(Function(r) r.rentID = id).Select(Function(r) r.rentalDate).FirstOrDefault
        'Standard LINQ in this case
        'Dim hireDate As Date = (From ren In Database.rentals
        '                        Where ren.rentID.Equals(renID)
        '                        Select ren.rentalDate).FirstOrDefault
        'Return hireDate
    End Function

    Friend Function GetRentalTime(id As Integer) As Date
        Dim rentals As IGenRepository(Of rental) = New GenEnRepository(Of rental)
        Return rentals.GetAll.Where(Function(r) r.rentID = id).Select(Function(r) r.rentalTime).FirstOrDefault
        'Standard LINQ in this case
        'Return (From ren In Database.rentals
        '        Where ren.rentID.Equals(renID)
        '        Select ren.rentalTime).FirstOrDefault
    End Function

    Friend Function GetPaymentByID(id As Integer) As payment
        Dim payments As IGenRepository(Of payment) = New GenEnRepository(Of payment)
        Return payments.GetById(id)
        'Standard LINQ in this case
        'Return (From rec In Database.payments
        '        Where rec.paymentID = id
        '        Select rec).FirstOrDefault
    End Function

    Friend Function GetCopyIdByRentID(id As Integer) As Integer
        Dim rentals As IGenRepository(Of rental) = New GenEnRepository(Of rental)
        Return rentals.GetAll.Where(Function(r) r.rentID = id).Select(Function(r) r.CopyID).FirstOrDefault
        'Standard LINQ in this case
        'Return (From rec In Database.rentals
        '        Where rec.rentID = id
        '        Select rec.CopyID).FirstOrDefault
    End Function

    Friend Function GetMovieIDByCopyID(id As Integer) As Integer
        Dim movieCopies As IGenRepository(Of movie_copies) = New GenEnRepository(Of movie_copies)
        Return movieCopies.GetAll.Where(Function(m) m.CopyID = id).Select(Function(m) m.movieID).FirstOrDefault
        'Standard LINQ in this case
        'Return (From copies In Database.movie_copies
        '        Where copies.CopyID.Equals(id)
        '        Select copies.movieID).FirstOrDefault
    End Function

    Friend Function GetTitleByMovieID(id As Integer) As String
        Dim movies As IGenRepository(Of movy) = New GenEnRepository(Of movy)
        Return movies.GetAll.Where(Function(m) m.movieID = id).Select(Function(m) m.title).FirstOrDefault
        'Standard LINQ in this case
        'Return (From movies In Database.movies
        '        Where movies.movieID.Equals(id)
        '        Select movies.title).FirstOrDefault
    End Function

    Friend Function GetNumberOfCopies(title As String) As ArrayList
        Dim noOfCopies As ArrayList = New ArrayList
        Try
            Dim movies As IGenRepository(Of movy) = New GenEnRepository(Of movy)
            Dim movieCopies As IGenRepository(Of movie_copies) = New GenEnRepository(Of movie_copies)
            Dim rentals As IGenRepository(Of rental) = New GenEnRepository(Of rental)
            Dim totalNoOfCopies As Integer? = movies.GetAll.Where(Function(m) m.title = title).Single.availableCopies
            Dim movieID As Integer = movies.GetAll.Where(Function(m) m.title = title).Single.movieID
            Dim copies() As movie_copies = movieCopies.GetAll.Where(Function(m) m.movieID = movieID).ToArray
            Dim count As Integer = 0

            For Each copy In copies
                count = rentals.GetAll.Count(Function(c) c.CopyID = copy.CopyID And CBool(c.currentlyHiring = 1))
                If count = 0 Then
                    noOfCopies.Add(copy.CopyID.ToString())
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return noOfCopies
    End Function

    Friend Function GetMovieLanguage() As String()
        Dim movies As IGenRepository(Of movy) = New GenEnRepository(Of movy)
        'Get Array of Distinct languages from movy Class
        Return movies.GetAll.Select(Function(c) c.language).Distinct.ToArray()
    End Function

    Friend Function GetMovieCountry() As String()
        Dim movies As IGenRepository(Of movy) = New GenEnRepository(Of movy)
        'Get Array of Distinct countries from movy Class
        Return movies.GetAll.Select(Function(c) c.country).Distinct.ToArray
    End Function

    'Find and return specified members from Database
    Friend Function FindCustomer(field As String) As List(Of member)
        Dim members As IGenRepository(Of member) = New GenEnRepository(Of member)
        Dim customer As List(Of member) = Nothing
        Dim id As Integer
        Try
            If IsNumeric(field) = True Then id = CInt(field)
            'List means the comparison takes place in-memory 
            'Search either by Id or lastname
            customer = members.GetAll.Where(Function(m)
                                                If id <> 0 Then
                                                    Return m.memberID = id
                                                Else
                                                    Return String.Equals(m.lastName, field, StringComparison.OrdinalIgnoreCase)
                                                End If
                                            End Function).ToList
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return customer
    End Function

    Friend Function CustomerPayments(id As Integer) As List(Of payment)
        Dim rentals As IGenRepository(Of rental) = New GenEnRepository(Of rental)
        Dim payment As IGenRepository(Of payment) = New GenEnRepository(Of payment)
        Dim rents As List(Of rental) = Nothing
        Dim customerPayment As New List(Of payment)

        Try
            rents = rentals.GetAll.Where(Function(r) Integer.Equals(r.memberID, id)).ToList()
            If rents.Count > 0 Then
                For Each rent In rents
                    customerPayment.Add(payment.GetAll.Where(Function(r) Long.Equals(r.rentID, rent.rentID)).SingleOrDefault)
                Next
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return customerPayment
    End Function

    Friend Function CustomerRentals(id As Integer, status As String) As List(Of rental)
        Dim rentals As IGenRepository(Of rental) = New GenEnRepository(Of rental)
        Dim rents As List(Of rental)
        Try
            If status = "All" Then
                rents = rentals.GetAll.Where(Function(r) Integer.Equals(r.memberID, id)).ToList()
            Else
                rents = rentals.GetAll.Where(Function(r) Integer.Equals(r.memberID, id) And
                                                 Byte.Equals(r.currentlyHiring, CByte(1))).ToList()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            rents = Nothing
        End Try
        If rents.Count = 0 Then
            Return Nothing
        Else
            Return rents
        End If
    End Function

    Friend Sub SaveRental()
        _rentalRepo.Save()
    End Sub

    Friend Sub SavePayments()
        _paymentRepo.Save()
    End Sub

    Friend Function GetPayment(condition As Func(Of payment, Boolean)) As payment
        Return _paymentRepo.GetAll.Where(condition).FirstOrDefault
    End Function
End Class


' ########################### ALTERNATIVE CHUNKS OF CODE USING DYNAMIC LINQ EXTENSION YOU MAY FIND USEFUL ##################################

'Friend Function CustomerRentals2(id As Integer, status As String) As List(Of rental)
'    Dim rents As List(Of rental)
'    Try
'        'Find all customer rentals and payments
'        Using pDtBase
'            If status = "All" Then
'                rents = rentals.Where("memberID = @0", id).ToList()
'            Else
'                rents = rentals.Where("memberID = @0 AND currentlyHiring = @1", id, CByte(1)).ToList()
'            End If
'        End Using
'    Catch ex As Exception
'        MessageBox.Show(ex.Message)
'        rents = Nothing
'    End Try

'    If rents.Count = 0 Then
'        Return Nothing
'    Else
'        Return rents
'    End If
'End Function

''Returns an array of strings of specified column in movies table
'Friend Function LoadComboBox(searched As String) As String()
'    Dim records As IQueryable(Of String)
'    Dim unique() As String = Nothing
'    Dim i As Integer = 0

'    Try
'        'Using DynamicLinq Query
'        Using pDtBase
'            If searched <> "" Then
'                records = movies.Select(searched).Cast(Of String)   'distinct does not work - only for keys, movies.Distinct.Select(searched) / .Cast(Of String) 'hopefully ascending order is default one
'            Else
'                Return Nothing
'            End If
'            unique = (From rec In records
'                      Select rec Distinct).Cast(Of String).ToArray()
'        End Using
'    Catch ex As Exception
'        MessageBox.Show(ex.Message)
'    End Try

'    Return unique

'End Function

'Find and return filtered movie list from Mysql Database
'Guide: https://www.codeproject.com/Articles/168981/Guide-to-Creating-Dynamic-LINQ-Queries
'Friend Function Filter(Optional year As Integer = 0,
'                             Optional country As String = "",
'                             Optional language As String = "",
'                             Optional genre As String = "") As List(Of movy)
'    Dim result As List(Of movy) = Nothing
'    Try
'        Using pDtBase
'            Dim records = movies.OrderBy("title")
'            If year <> 0 Then
'                records = records.Where("year = @0", year).OrderBy("title")
'            End If
'            If country.Length > 0 Then
'                records = records.Where("country = @0", country).OrderBy("title")
'            End If
'            If language.Length > 0 Then
'                records = records.Where("language = @0", language).OrderBy("title")
'            End If
'            If genre.Length > 0 Then
'                records = records.Where("genre = @0", genre).OrderBy("title")
'            End If

'            If records.Count = 0 Then
'                result = Nothing
'            Else
'                result = records.ToList()
'            End If
'        End Using
'    Catch ex As Exception
'        MessageBox.Show(ex.Message)
'    End Try

'    Return result
'End Function

'Find and return specified members from Mysql Database using Dynamic Linq
'Friend Function FindCustomer2(field As String) As List(Of member)
'    Dim customer As List(Of member)
'    Dim id As Integer

'    Try
'        If IsNumeric(field) = True Then
'            id = CInt(field)
'        End If
'        'Search either by Id or lastname
'        Using pDtBase
'            customer = members.Where("lastName = @0 or memberID = @1", field, id).ToList()
'        End Using
'    Catch ex As Exception
'        MessageBox.Show(ex.Message)
'        customer = Nothing
'    End Try

'    If customer.Count = 0 Then
'        Return Nothing
'    Else
'        Return customer
'    End If
'End Function

'Friend Function CheckAvailableCopies(title As String) As String()
'    Dim movieID As String
'    Dim copies As List(Of movie_copies)
'    Dim totalNoOfCopies As Integer
'    Dim freeCopies() As String = Nothing
'    Dim copyId As Integer
'    Dim check As Integer

'    'ISSUE WITH MULTIPLE LINQ QUERIES EXECUTED ON SINGLE CONNECTION
'    ' .ToList(): forces entityframework to load the list into memory
'    'http://stackoverflow.com/questions/4867602/entity-framework-there-is-already-an-open-datareader-associated-with-this-comma
'    Try
'        Using pDtBase
'            'How many copies in total
'            totalNoOfCopies = CType((From mov In movies
'                                     Where mov.title = title
'                                     Select mov.availableCopies).First, Integer)
'            'Take movieID by Title From movies
'            movieID = movies.Where("title = @0", title).Single.movieID.ToString()
'            'Take all copyIDs by movieID From movie_copies
'            'avoid using select command too many times on one connection, will throw exception
'            'that's why loading to Tolist()
'            copies = movie_copies.Where("movieID = @0", CInt(movieID)).ToList()

'            'Take currentlyRented copies
'            Dim i As Integer = 0
'            For y = 0 To copies.Count - 1
'                copyId = copies(y).CopyID
'                check = rentals.Count(Function(c) c.CopyID = copyId And CBool(c.currentlyHiring = 1))
'                If check = 0 Then
'                    ReDim Preserve freeCopies(i)
'                    freeCopies(i) = copyId.ToString()
'                    i += 1
'                End If
'            Next
'        End Using
'    Catch ex As Exception
'        MessageBox.Show(ex.Message & vbCrLf & ex.ToString)
'    Finally
'        copies = Nothing
'    End Try

'    Return freeCopies

'End Function

'Friend Function CheckDateOfReturn(title As String) As Date()
'    Dim movieID As String
'    Dim copies As List(Of movie_copies)
'    Dim dates() As Date = Nothing
'    Dim i As Integer

'    Try
'        Using pDtBase
'            'Take movieID by Title From movies
'            movieID = movies.Where("title = @0", title).Single.movieID.ToString()
'            'Take all copyIDs by movieID From movie_copies
'            copies = movie_copies.Where("movieID = @0", CInt(movieID)).ToList()
'            'Take rentalDate of each copyID
'            i = 0
'            ReDim dates(copies.Count - 1)
'            For Each copy In copies
'                dates(i) = rentals.Where("CopyID = @0 And currentlyHiring = @1", copy.CopyID, CByte(1)).Single.rentalTime
'                i += 1
'            Next
'        End Using
'    Catch ex As Exception
'        MessageBox.Show(ex.Message & vbCrLf & ex.ToString)
'    Finally
'        copies = Nothing
'    End Try

'    Return dates
'End Function

'Friend Function CustomerPayments2(id As Integer) As List(Of payment)()
'    Dim payment() As List(Of payment)
'    Dim rents As List(Of rental)

'    Try
'        'Find all customer rentals and payments
'        Using pDtBase
'            rents = rentals.Where("memberID = @0", id).ToList()
'            ReDim payment(rents.Count - 1)
'            For x As Integer = 0 To rents.Count - 1 'Each rent In rents
'                payment(x) = payments.Where("rentID = @0", rents(x).rentID).ToList()
'            Next
'        End Using
'    Catch ex As Exception
'        MessageBox.Show(ex.Message)
'        payment = Nothing
'        rents = Nothing
'    End Try

'    If rents.Count = 0 Then
'        Return Nothing
'    Else
'        Return payment
'    End If
'End Function

