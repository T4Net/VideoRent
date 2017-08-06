Option Strict On
Option Explicit On
'HOW TO DESIGN WINFORM APPLICATION - https://www.codeproject.com/Articles/14660/WinForms-Model-View-Presenter
Imports MySql.Data.MySqlClient
Imports System.Drawing
Imports System.Windows.Forms
Imports System.Text.RegularExpressions
Imports System.IO
Imports System.ComponentModel
Imports System.Drawing.Drawing2D
Imports System.Globalization
Imports System.Drawing.Printing
Imports System.Text
Imports VideoRent.PaymentModule
Imports System.Net.Mail
Imports System.Data.Common
Imports System.Linq
Imports VideoRent.Ms.Linq.Dynamic

Public Class MainForm
    Public userLog As String = LoginForm.UsernameTextBox.Text
    Dim curDate As Date = Date.Now()
    Dim curTime As Date = DateTime.Now
    Dim query As String
    Private tabPage As TabPage
    'Dim conn As MySqlConnection
    'Dim cmd As MySqlCommand
    'Dim reader As MySqlDataReader
    'Dim myconn As String = System.Configuration.ConfigurationManager.ConnectionStrings("dbCon").ToString()
    Dim database As New Database
    Dim idComboBox As ComboBox
    Dim nameComboBox As ComboBox
    Dim balanceComboBox As ComboBox
    Dim bestSellerPanel As CollapsiblePanel
    Private WithEvents toolStripExpandButton As ToolStripButton
    Private WithEvents toolStripCollapseButton As ToolStripButton
    Private switchToolStrip As ToolStrip
    Private Declare Function InternetGetConnectedState Lib "wininet.dll" (ByRef lpdwFlags As Int32,
ByVal dwReserved As Int32) As Boolean

    ' LOAD PICTURE - http://www.codeguru.com/vb/gen/vb_database/sqlserver/article.php/c7427/Load-Images-from-and-Save-Images-to-a-Database.htm
    ' ON LOAD
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Timer1.Enabled = True
            LabelWelcome.Text = curDate.ToString("dd MMM yyyy") & vbCrLf _
                & "Welcome " & vbCrLf & userLog
            DeleteForm.user = userLog
            If InternetConnectionState() = True Then
                AddToolStrip()
                AddCollapsiblePanel()
                GetLatestBestseller()
            Else
                MessageBox.Show("Not connected to the Internet!")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub AddToolStrip()
        switchToolStrip = New ToolStrip
        toolStripExpandButton = New ToolStripButton
        toolStripCollapseButton = New ToolStripButton

        'switchToolStrip
        With Me.switchToolStrip
            .Dock = System.Windows.Forms.DockStyle.None
            .Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.toolStripExpandButton, Me.toolStripCollapseButton})
            .Location = New System.Drawing.Point(8, 8)
            .Name = "switchToolStrip"
            .Size = New System.Drawing.Size(67, 25)
            .TabIndex = 21
            .Text = "Collapse/Expand"
            .BackColor = Color.WhiteSmoke
        End With
        'toolStripExpandButton
        With Me.toolStripExpandButton
            .DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            .Image = CType(My.Resources.ResourceManager.GetObject("expand"), System.Drawing.Image) 'GetObject("expand.png")
            .ImageTransparentColor = System.Drawing.Color.WhiteSmoke
            .Name = "toolStripExpandButton"
            .Size = New System.Drawing.Size(23, 22)
            .Text = "Expand"
        End With
        'toolStripCollapseButton
        With Me.toolStripCollapseButton
            .DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
            .Image = CType(My.Resources.ResourceManager.GetObject("collapse"), System.Drawing.Image)
            .ImageTransparentColor = System.Drawing.Color.WhiteSmoke
            .Name = "toolStripCollapseButton"
            .Size = New System.Drawing.Size(23, 22)
            .Text = "Collapse"
        End With
        Me.WelcomeTabPage.Controls.Add(Me.switchToolStrip)
    End Sub

    Private Sub AddCollapsiblePanel()
        bestSellerPanel = New CollapsiblePanel
        Me.WelcomeTabPage.Controls.Add(Me.bestSellerPanel)
    End Sub

    Private Sub toolStripExpandButton_Click(sender As Object, e As EventArgs) Handles toolStripExpandButton.Click
        If bestSellerPanel.PanelCollapsed Then bestSellerPanel.Expand()
        bestSellerPanel.Invalidate()
    End Sub


    Private Sub toolStripCollapseButton_Click(sender As Object, e As EventArgs) Handles toolStripCollapseButton.Click
        If Not bestSellerPanel.PanelCollapsed Then bestSellerPanel.Collapse()
        bestSellerPanel.Invalidate()
    End Sub

    Public Enum Status
        All
        Active
    End Enum

    ' MAIN TAB CONTROL ACTIONS
    Private Sub TabControlMain_Selected(sender As Object, e As TabControlEventArgs) Handles TabControlMain.Selected
        Dim deleteList As Boolean = True
        Dim activeRents = Status.Active

        Select Case e.TabPageIndex
            Case 0

            Case 1
                ClearFilters(deleteList)
                LoadComboBox()
                ResetDataGrid()
            Case 2
                ResetRentPage()
            Case 3

            Case 4
                ResetPage(PaymentTabPage)
                ManualPaymentCheckBox_Payment.Checked = False
                ErrorProvider.SetError(PaymentIDTextBox_Payment, String.Empty)
            Case 5
                GetCustomerPicture()
                GetAddressAndEmail()
                GetPayments()
                GetRents(ListViewActiveRents_Customers, activeRents)
                ListViewFullHistory_Customers.Clear()
                ListViewFullHistory_Customers.GridLines = False
            Case 6

        End Select
    End Sub

    ' WELCOME TAB PAGE ACTIONS
    '- Displays current Time
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            'show current time
            LabelTimer.Text = "Time:" & vbCrLf & Date.Now.ToString("HH:mm:ss")
            'move bestseller label from left to right(sort of text animation)
            With bestSellerPanel.BestsellerLabel
                .Left += 10
                If .Left >= bestSellerPanel.Width Then
                    .Left = -bestSellerPanel.Width
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    ' CATALOG TAB PAGE ACTIONS

    'Fills Year, Language and Country filters when Catalog Tab selected
    Private Sub LoadComboBox()
        Dim strArray() As String
        Dim maxVal As Integer
        Dim y As Integer = 0

        Try
            strArray = database.GetMovieCountry()
            ComboBoxCountry.Sorted = True 'or Array.Sort(countries)
            ComboBoxCountry.Items.AddRange(strArray)
            maxVal = CInt(Now.ToString("yyyy")) - 1950
            Array.Clear(strArray, 0, strArray.Length) ' instead strArray.Clear - Method Clear is a static/shared method so it can be invoked with its 'ClassName', Array in this case

            ReDim strArray(maxVal)
            For i As Integer = 1950 To CInt(Date.Now.ToString("yyyy"))
                strArray(y) = i.ToString
                y += 1
            Next i
            ComboBoxYear.Sorted = True
            ComboBoxYear.Items.AddRange(strArray)
            Array.Clear(strArray, 0, strArray.Length)
            strArray = database.GetMovieLanguage()
            ComboBoxLang.Sorted = True
            ComboBoxLang.Items.AddRange(strArray)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ClearFilters(deleteList As Boolean)
        ComboBoxCountry.SelectedIndex = -1
        ComboBoxYear.SelectedIndex = -1
        ComboBoxLang.SelectedIndex = -1
        ListBoxCategories.SelectedIndex = -1
        UpdateImage()
        If deleteList Then
            ComboBoxCountry.Items.Clear()
            ComboBoxYear.Items.Clear()
            ComboBoxLang.Items.Clear()
        End If
    End Sub

    'https://weblogs.asp.net/scottgu/dynamic-linq-part-1-using-the-linq-dynamic-query-library
    Private Sub FilterButton_Click(sender As Object, e As EventArgs) Handles FilterButton.Click
        Dim filter As String = ""
        Dim filteredRec As List(Of movy) = Nothing
        Dim catalog As New MovieFilters
        ResetDataGrid()
        Try
            Dim movies As IGenRepository(Of movy)
            movies = New GenEnRepository(Of movy)

            If ComboBoxYear.SelectedIndex >= 0 Then
                filter = ComboBoxYear.SelectedItem.ToString ' Convert.ToInt32(ComboBoxYear.SelectedItem)
                filteredRec = catalog.FilterMovies(filteredRec, movies, FilterType.Year, filter)
            End If
            If ComboBoxCountry.SelectedIndex >= 0 Then
                filter = ComboBoxCountry.SelectedItem.ToString()
                filteredRec = catalog.FilterMovies(filteredRec, movies, FilterType.Country, filter)
            End If
            If ComboBoxLang.SelectedIndex >= 0 Then
                filter = ComboBoxLang.SelectedItem.ToString()
                filteredRec = catalog.FilterMovies(filteredRec, movies, FilterType.Language, filter)
            End If
            If ListBoxCategories.SelectedIndex >= 0 Then
                filter = ListBoxCategories.SelectedItem.ToString()
                filteredRec = catalog.FilterMovies(filteredRec, movies, FilterType.Category, filter)
            End If

            With Me.SearchedMovieDataGridView
                If filteredRec IsNot Nothing Then
                    'SET THE DATASOURCE OF THE DATAGRIDVIEW / 'FILLING DATAGRIDVIEW
                    'https://msdn.microsoft.com/en-us/library/system.windows.forms.datagridview.alternatingrowsdefaultcellstyle(v=vs.110).aspx?cs-save-lang=1&cs-lang=vb#code-snippet-2
                    .AutoGenerateColumns = True
                    .DataSource = filteredRec
                    .AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders
                Else
                    .Columns.Add("res", "Result")
                    .Rows.Add("No movies found")
                End If
                BeautifyDataGrid()
            End With
            UpdateImage()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            If filteredRec IsNot Nothing Then filteredRec = Nothing
            If catalog IsNot Nothing Then catalog = Nothing
        End Try
    End Sub

    Public Sub ResetDataGrid()
        SearchedMovieDataGridView.Dispose()
        SearchedMovieDataGridView = New System.Windows.Forms.DataGridView
        With Me.SearchedMovieDataGridView
            .Location = New Point(2, 3)
            .Width = 1012
            .Height = 221
            .BackgroundColor = Color.FromArgb(65, 65, 65)
            .BorderStyle = BorderStyle.None
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False
        End With
        SplitContainer1.Panel2.Controls.Add(SearchedMovieDataGridView)
    End Sub

    'User request movie to rent
    Private Sub RentButton_Click(sender As Object, e As EventArgs) Handles RentButton.Click
        Dim title As String = String.Empty
        Dim noOfCopies As ArrayList = New ArrayList
        Try
            title = CopyMovieTitle()
            If title <> "" Then
                ShowPage("RentTabPage")
                MovieTitleTextBox.Text = title
                noOfCopies = database.GetNumberOfCopies(title)
                ShowLabelStatus(title, noOfCopies)
            Else
                MessageBox.Show("Select movie first.")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            noOfCopies = Nothing
        End Try
    End Sub

    'Get movie title of the selected row
    Private Function CopyMovieTitle() As String
        Dim row As DataGridViewRow
        Dim title As String = ""

        Try
            row = SearchedMovieDataGridView.CurrentRow
            If row IsNot Nothing Then
                title = row.Cells(1).Value.ToString() ' title column
            Else 'in case no movie was selected
                Return title
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return title
    End Function

    Private Sub ShowPage(tabName As String)
        'TabControlMain.SelectedIndex = 2
        TabControlMain.SelectTab(tabName)
    End Sub

    Private Sub ShowLabelStatus(movie As String, noOfAvailableCopies As ArrayList)
        With AvailabilityLabel
            If noOfAvailableCopies.Count > 0 Then
                .ForeColor = Color.LimeGreen
                ChooseCopyComboBox_Rent.Items.Clear()
                ChooseCopyComboBox_Rent.Items.AddRange(noOfAvailableCopies.ToArray)
                .Text = noOfAvailableCopies.Count.ToString() & " copy available"
            Else
                .ForeColor = Color.Red
                ShowClosestAvailableDate(movie)
                .Text = "No copy is available"
            End If
            .Visible = True
        End With
    End Sub

    Private Sub LoadCopycombo(range() As String)
        'ChooseCopyComboBox_Rent.Items.AddRange(range) sometime fails somehow :(
        For x = 0 To range.Count - 1
            ChooseCopyComboBox_Rent.Items.Add(range(x))
        Next
    End Sub

    Private Sub ShowClosestAvailableDate(title As String)
        'Get dates when movies are returned
        'Dim datesOfReturn() As Date = database.CheckDateOfReturn(title)
        Dim lowestDate As Date
        Dim movieID As Integer
        'Check which rentalDate is the closest
        '#########################################################
        Dim movies As IGenRepository(Of movy) = New GenEnRepository(Of movy)
        Dim movieCopies As IGenRepository(Of movie_copies) = New GenEnRepository(Of movie_copies)
        Dim rentals As IGenRepository(Of rental) = New GenEnRepository(Of rental)
        Dim copies As List(Of movie_copies)
        Dim datesOfReturn As ArrayList = New ArrayList
        Dim count As Integer
        movieID = movies.GetAll.Where(Function(c) c.title = title).Single.movieID
        'Take all copyIDs by movieID From movie_copies
        copies = movieCopies.GetAll.Where(Function(c) c.movieID = movieID).ToList
        'Take rentalDate of each copyID
        For Each copy In copies
            count = rentals.GetAll.Count(Function(c) c.CopyID = copy.CopyID And CBool(c.currentlyHiring = 1))
            If count = 1 Then
                datesOfReturn.Add(rentals.GetAll.Where(Function(c) c.CopyID = copy.CopyID And
                                                           CBool(c.currentlyHiring = 1)).Single.rentalTime)
            End If
        Next
        datesOfReturn.Sort()
        lowestDate = CDate(datesOfReturn.Item(0))
        '#########################################################
        Try

            'lowestDate = datesOfReturn(0)
            'For i As Integer = 0 To datesOfReturn.Count - 1
            '    If datesOfReturn(i) < lowestDate Then
            '        lowestDate = datesOfReturn(i)
            '    End If
            'Next
            With MonthCalendar_Rent
                .AddBoldedDate(lowestDate)
                .ForeColor = Color.BurlyWood
                .ShowWeekNumbers = True
                .ShowTodayCircle = False
                .Visible = True
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        Finally
            datesOfReturn = Nothing
            lowestDate = Nothing
        End Try

    End Sub

    'Load category image from ImageList (ImageListMovieCover); 
    'ListBoxCategories index = ImageList images index
    Private Sub UpdateImage()
        Dim currIdx As Integer = ListBoxCategories.SelectedIndex
        If currIdx >= 0 Then
            CoverPictureBox.Image = ImageListMovieCover.Images(currIdx)
        Else
            CoverPictureBox.Image = Nothing
        End If
    End Sub

    ' ########################### MENU STRIP EVENTS ##################################
    Private Sub CreateUserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreateUserToolStripMenuItem.Click
        RegistrationForm.Show()
    End Sub

    Private Sub DeleteAccountToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteAccountToolStripMenuItem.Click
        DeleteForm.Show()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim searched As String = SearchTextBox.Text
        Dim connName As String = "dbCon"
        'request to database and check if movie exist in title column
        'if exists, load movie details to SearchedMovieDataGridView
        Dim query As String = "SELECT mov.movieID, mov.title, mov.year, mov.language, mov.country," &
            " mov.availableCopies, mov.genre,  mov.rentalRate, mov.category, im.image FROM movies mov INNER JOIN cover_images im" &
            " ON im.title = mov.title WHERE mov.title LIKE @param1"
        Dim deleteList As Boolean = False

        ClearFilters(deleteList)
        If ValidateSearchedMovie(searched) Then
            OpenConnectionQuery(query, searched, connName)
            'CloseQueryConnection()
        End If
    End Sub

    Private Sub BeautifyDataGrid()

        Dim headerStyle As New DataGridViewCellStyle

        Try
            With Me.SearchedMovieDataGridView
                .AutoResizeColumns()
                '.Location = New Point(20, 464)
                .BorderStyle = BorderStyle.Fixed3D
                .BackgroundColor = Color.FromArgb(65, 65, 65)
                .ForeColor = Color.Black
                .GridColor = Color.Blue
                .ReadOnly = True
                .AllowUserToResizeColumns = False
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .AllowUserToOrderColumns = False
                .MultiSelect = True
                ' Set the selection background color for all the cells.
                .DefaultCellStyle.SelectionBackColor = Color.Gray
                .DefaultCellStyle.SelectionForeColor = Color.White
                ' Set RowHeadersDefaultCellStyle.SelectionBackColor so that its default
                ' value won't override DataGridView.DefaultCellStyle.SelectionBackColor.
                '.RowHeadersDefaultCellStyle.SelectionBackColor = Color.Empty
                ' Set the background color for all rows and for alternating rows. 
                ' The value for alternating rows overrides the value for all rows. 
                .RowsDefaultCellStyle.BackColor = Color.LightBlue
                .AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray
                ' Set the row and column header styles.
                .ColumnHeadersDefaultCellStyle.ForeColor = Color.White
                .ColumnHeadersDefaultCellStyle.BackColor = Color.Tomato
                .RowHeadersDefaultCellStyle.BackColor = Color.Tomato
                headerStyle.BackColor = Color.Goldenrod
                For Each column As DataGridViewColumn In .Columns
                    column.HeaderCell.Style = headerStyle
                Next
                .EnableHeadersVisualStyles = False
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message())
        End Try

    End Sub

    Public Sub OpenConnectionQuery(queryString As String, queryParam As String, connName As String)
        'Dim dt As DataTable = New DataTable
        'Dim da As MySqlDataAdapter
        Dim dSet As DataSet = Nothing
        Dim colNumber As Integer
        Dim params(0) As String
        Dim database As IRepository = Nothing
        queryParam = "%" + queryParam + "%"
        params(0) = queryParam
        ResetDataGrid()
        Try
            database = DatabaseFactory.CreateDatabase(DatabaseConnectionType.MySql)
            database.CreateConnection(connName)
            database.CreateCommand(queryString, CommandTextValidator.TypeOfcommand.Fetch)
            database.BuildParameters(params)
            database.CreateAdapter()

            Dim crud As New DataSetCrud(database.DatabaseType)
            dSet = crud.SelectData
            'Dim ad As DbDataAdapter
            'ad = database.Database.Adapter
            'ad.Fill(dSet)
            'database.Database.Adapter.Fill(dSet)

            SearchedMovieDataGridView.DataSource = dSet.Tables(0).DefaultView
            colNumber = SearchedMovieDataGridView.ColumnCount

            BeautifyDataGrid()

            For Each row As DataGridViewRow In SearchedMovieDataGridView.Rows
                row.Height = 50
            Next

            Dim column As DataGridViewImageColumn = CType(SearchedMovieDataGridView.Columns(colNumber - 1),
                DataGridViewImageColumn)
            column.Width = 150
            column.ImageLayout = DataGridViewImageCellLayout.Stretch


            'conn = New MySqlConnection(myconn)
            'conn.Open()
            'cmd = New MySqlCommand(queryString, conn)
            'cmd.Parameters.Add("@param", MySqlDbType.VarChar).Value = "%" + queryParam + "%"
            'da = New MySqlDataAdapter(cmd)
            'ds = New DataSet
            'da.Fill(ds)
            'SearchedMovieDataGridView.DataSource = ds.Tables(0).DefaultView
            'colNumber = SearchedMovieDataGridView.ColumnCount
            'BeautifyDataGrid()

            'For Each row As DataGridViewRow In SearchedMovieDataGridView.Rows
            '    row.Height = 50
            'Next

            'Dim column As DataGridViewImageColumn = CType(SearchedMovieDataGridView.Columns(colNumber - 1),
            '    DataGridViewImageColumn)
            'column.Width = 150
            'column.ImageLayout = DataGridViewImageCellLayout.Stretch
            'da.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        Finally
            If Not dSet Is Nothing Then dSet.Dispose()
            If Not database Is Nothing Then database.CloseConnection()
        End Try
    End Sub

    Private Sub CustomizeLastColumn()
        'Change last column type to ImageCell
        Dim lastColumn As Integer = SearchedMovieDataGridView.ColumnCount - 1
        Dim column As DataGridViewColumn = SearchedMovieDataGridView.Columns(lastColumn)
        Dim cell As DataGridViewCell = New DataGridViewImageCell()

        column.CellTemplate = cell
        SearchedMovieDataGridView.InvalidateColumn(lastColumn)

    End Sub

    'Private Sub CloseQueryConnection()
    '    'reader.Close()
    '    conn.Close()
    'End Sub

    Private Function ValidateSearchedMovie(ByVal userInput As String) As Boolean

        Dim regExpression As Regex = New System.Text.RegularExpressions.Regex("^[a-zA-Z0-9]{1,20}$") 'Regex("^[a-zA-Z0-9\s*]{1,20}$")
        If regExpression.IsMatch(userInput) Then
            Return True
        Else
            Return False
        End If
    End Function
    ' ########################### PICTURE PANEL - (RIGHT WING ICONS) EVENTS ##################################

    Private Sub CatalogPictureBox_Click(sender As Object, e As EventArgs) Handles CatalogPictureBox.Click
        'Me.tabPage = New TabPage()
        'tabPage.Name = "Catalog"
        ''TabControlMain.TabPages.Add("Catalog")
        'ShowTabPage(tabPage)
        'FlowLayoutPanel1.Visible = True
        'GroupBox1.Visible = True
        'MessageBox.Show("Catalog")
        'TabControlMain.SelectTab(e.Index)
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim numbers() As Integer = {0, 1, 2, 3, 4, 5, 6}

        ' Query creation.
        Dim evensQuery = From num In numbers
                         Where num Mod 2 = 0
                         Select num

        ' Query execution.
        For Each number In evensQuery
            Console.Write(number & " ")
        Next
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        MessageBox.Show("Disappear")
        FlowLayoutPanel1.Visible = False
        GroupBoxFilters.Visible = False
        ListBoxCategories.SelectedIndex = -1
        UpdateImage()
    End Sub

    Private Sub ComboBoxYear_SelectedIndexChanged(sender As Object, e As EventArgs) _
        Handles ComboBoxYear.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxYear_Click(sender As Object, e As EventArgs) Handles ComboBoxYear.Click

    End Sub

    Private Sub ComboBoxLang_Click(sender As Object, e As EventArgs) Handles ComboBoxLang.Click

    End Sub

    Private Sub ComboBoxLang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxLang.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxCountry_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCountry.SelectedIndexChanged

    End Sub

    Private Sub ComboBoxCountry_Click(sender As Object, e As EventArgs) Handles ComboBoxCountry.Click

    End Sub

    'Clearing 
    Private Sub MainForm_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        'If SearchedMovieDataGridView IsNot Nothing Then SearchedMovieDataGridView.Dispose()
        'If conn IsNot Nothing Then conn.Dispose()
        'If myconn IsNot Nothing Then myconn = Nothing
        'If cmd IsNot Nothing Then cmd.Dispose()
        'If reader IsNot Nothing Then reader.Dispose()
        If database IsNot Nothing Then database = Nothing
        If idComboBox IsNot Nothing Then idComboBox.Dispose()
        If nameComboBox IsNot Nothing Then nameComboBox.Dispose()
        If balanceComboBox IsNot Nothing Then balanceComboBox.Dispose()
    End Sub

    'Find member only if Enter Key is down
    Private Sub CustomerTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles CustomerTextBox.KeyDown
        Dim customerData As List(Of member)

        Try

            If e.KeyCode = Keys.Enter Then
                Dim name As String = CustomerTextBox.Text
                'ErrorProvider.SetError(OkButton_Return, String.Empty)
                If ValidateSearchedMovie(name) = True Then ' Verify user input
                    RefreshLabels() 'Restore default values
                    customerData = database.FindCustomer(name) 'Search and find in database
                    If customerData IsNot Nothing Then
                        FillCustomer(customerData) 'Populate controls with found values
                    Else
                        DisplayLabelMessage("Client not found")
                    End If
                Else
                    DisplayLabelMessage("Invalid Characters")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            customerData = Nothing
        End Try

    End Sub

    'Show message
    Private Sub DisplayLabelMessage(message As String)
        With ClientNotFoundLabel
            .Text = message
            .ForeColor = Color.Red
            .Visible = True
        End With
    End Sub

    'Populate customer Ids and names to the coresponding controls
    Private Sub FillCustomer(customer As List(Of member))
        Dim newComboBoxArr() As ComboBox
        Dim noOfmembers As Integer = customer.Count

        Try 'Set values of controls on the RentTab
            If noOfmembers = 1 Then
                FillTextBoxes(customer(0).memberID.ToString,
                              customer(0).firstName.ToString & " " & customer(0).lastName.ToString,
                              customer(0).balance.ToString)
                'If more then one member is found then populate information to ComboBoxes instead of TextBoxes
            ElseIf noOfmembers > 1 Then
                newComboBoxArr = CreateComboBoxes()
                For Each client As member In customer
                    newComboBoxArr(0).Items.Add(client.memberID.ToString)
                    newComboBoxArr(1).Items.Add(client.firstName.ToString & " " & client.lastName.ToString)
                    newComboBoxArr(2).Items.Add(client.balance.ToString)
                Next
                SetValues(newComboBoxArr)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            newComboBoxArr = Nothing
        End Try
    End Sub

    Private Sub SetValues(ByRef arrOfComboBoxes() As ComboBox)
        For Each comboBox In arrOfComboBoxes
            comboBox.SelectedIndex = 0
        Next
    End Sub

    Private Sub FillTextBoxes(ID As String, fullName As String, balance As String)
        If IDTextBox.Visible = False Then
            ShowComboBoxes(False)
            ShowTextBoxes(True)
        End If
        IDTextBox.Text = ID
        FullNameTextBox.Text = fullName
        BalanceTextBox.Text = balance
    End Sub

    Private Sub ShowComboBoxes(visible As Boolean)
        idComboBox.Visible = visible
        nameComboBox.Visible = visible
        balanceComboBox.Visible = visible
    End Sub

    Private Sub ShowTextBoxes(visible As Boolean)
        IDTextBox.Visible = visible
        FullNameTextBox.Visible = visible
        BalanceTextBox.Visible = visible
    End Sub

    'Creates and returns an array of ComboBoxes
    'https://msdn.microsoft.com/en-us/library/system.windows.forms.combobox(v=vs.110).aspx
    Private Function CreateComboBoxes() As ComboBox()

        Dim comboBoxArr() As ComboBox = Nothing

        Try
            ShowTextBoxes(False)
            If IsNothing(idComboBox) = False Then
                ShowComboBoxes(True)
                ClearComboBoxes()
                comboBoxArr = New ComboBox() {idComboBox, nameComboBox, balanceComboBox}
                Return comboBoxArr
            Else
                idComboBox = New ComboBox
                nameComboBox = New ComboBox
                balanceComboBox = New ComboBox
            End If
            comboBoxArr = New ComboBox() {idComboBox, nameComboBox, balanceComboBox}

            'Set ComboBox location, size etc. Each ComboBox has the same size but different location
            For i As Integer = 0 To comboBoxArr.Count - 1
                Select Case i
                    Case 0
                        SetComboBoxParameters(comboBoxArr(i), New Point(163, 126))
                        AddHandler comboBoxArr(i).SelectedIndexChanged, AddressOf Me.idComboBox_SelectedIndexChanged
                    Case 1
                        SetComboBoxParameters(comboBoxArr(i), New Point(163, 154))
                        AddHandler comboBoxArr(i).SelectedIndexChanged, AddressOf Me.nameComboBox_SelectedIndexChanged
                    Case 2
                        SetComboBoxParameters(comboBoxArr(i), New Point(163, 182))
                        AddHandler comboBoxArr(i).SelectedIndexChanged, AddressOf Me.balanceComboBox_SelectedIndexChanged
                End Select

            Next
            RentTabPage.Controls.AddRange(comboBoxArr)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return comboBoxArr
    End Function

    Private Sub ClearComboBoxes()
        idComboBox.Items.Clear()
        nameComboBox.Items.Clear()
        balanceComboBox.Items.Clear()
    End Sub

    Private Sub SetComboBoxParameters(ByRef comBox As ComboBox, point As Point)
        comBox.Location = point
        comBox.Size = New Size(200, 22)
        comBox.Visible = True
        comBox.Sorted = True
    End Sub

    'Bind customer data via idComboBox + nameComboBox + balanceComboBox
    Private Sub idComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim index As Integer = idComboBox.SelectedIndex

        If nameComboBox.SelectedIndex <> index And
            balanceComboBox.SelectedIndex <> index Then
            nameComboBox.SelectedIndex = index
            balanceComboBox.SelectedIndex = index
        End If
    End Sub

    'Bind customer data via idComboBox + nameComboBox + balanceComboBox
    Private Sub nameComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim index As Integer = nameComboBox.SelectedIndex

        If idComboBox.SelectedIndex <> index And
            balanceComboBox.SelectedIndex <> index Then
            idComboBox.SelectedIndex = index
            balanceComboBox.SelectedIndex = index
        End If
    End Sub

    'Bind customer data via idComboBox + nameComboBox + balanceComboBox
    Private Sub balanceComboBox_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim index As Integer = balanceComboBox.SelectedIndex

        If idComboBox.SelectedIndex <> index And
            nameComboBox.SelectedIndex <> index Then
            idComboBox.SelectedIndex = index
            nameComboBox.SelectedIndex = index
        End If
    End Sub

    'Resets chosen controls on the RentPage to their default values 
    Private Sub RefreshLabels()
        ClientNotFoundLabel.ResetText()
        ConfirmationLabel.ResetText()
        ClientNotFoundLabel.Visible = False
        ConfirmationLabel.Visible = False
    End Sub

    Private Sub ResetRentPage()
        Dim cBox As ComboBox = Nothing
        Try
            For Each control As Control In RentTabPage.Controls
                Select Case control.GetType()
                    Case GetType(Label)
                        If control.Name = "ClientNotFoundLabel" Or
                            control.Name = "ConfirmationLabel" Or
                            control.Name = "AvailabilityLabel" Then
                            control.ResetText()
                        End If
                    Case GetType(ComboBox)
                        control.ResetText()
                        If cBox IsNot Nothing Then cBox = Nothing
                        cBox = TryCast(control, ComboBox)
                        cBox.Items.Clear()
                    Case GetType(Button)
                        If control.Name = "ConfirmRentButton" Then _
                            ConfirmRentButton.Enabled = True
                    Case Else
                        control.ResetText()
                End Select
            Next
            MonthCalendar_Rent.Visible = False
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ClientAccountButton_Click(sender As Object, e As EventArgs) Handles ClientAccountButton.Click
        Dim idControl As Control = IsClientSelected()
        If idControl IsNot Nothing Then
            CopyCustomerInfo(idControl)
            ShowPage("CustomerTabPage")
        End If
    End Sub

    Private Function IsClientSelected() As Control
        If IDTextBox.Visible = True Then
            If IDTextBox.Text <> "" Then
                Return IDTextBox
            End If
        Else
            If idComboBox.Visible = True Then
                If idComboBox.SelectedIndex >= 0 Then
                    Return idComboBox
                End If
            End If
        End If
        Return Nothing
    End Function

    Private Sub CopyCustomerInfo(id As Control)
        Try
            Select Case id.GetType()
                Case GetType(TextBox)
                    TextBoxCustomerID_Customers.Text = id.Text
                    TextBoxFullName_Customers.Text = FullNameTextBox.Text
                    TextBoxBalance_Customers.Text = BalanceTextBox.Text
                Case GetType(ComboBox)
                    Dim cBox As ComboBox = TryCast(id, ComboBox)
                    TextBoxCustomerID_Customers.Text = cBox.SelectedItem.ToString()
                    TextBoxFullName_Customers.Text = nameComboBox.SelectedItem.ToString()
                    TextBoxBalance_Customers.Text = balanceComboBox.SelectedItem.ToString()
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub GetAddressAndEmail()
        Dim customerID As String = TextBoxCustomerID_Customers.Text
        Dim address As String = ""
        Dim email As String = ""
        Dim customerData As List(Of member)

        Try
            If customerID IsNot Nothing Then
                customerData = database.FindCustomer(customerID)
                address = customerData(0).street + " " + customerData(0).number _
                    + "; " + customerData(0).city + "; " + customerData(0).zip
                email = customerData(0).email
            End If

            TextBoxAddress_Customers.Text = address
            TextBoxEmail_Customers.Text = email

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub GetCustomerPicture() 'Normally this should come from database. Database could store a path to a loaction where the pictures are stored and from where they're loaded
        PictureBoxCustomer_Customers.Visible = True
    End Sub

    Private Sub CustomerTabPage_Leave(sender As Object, e As EventArgs) Handles CustomerTabPage.Leave
        'ClearCustomerTabPage()
    End Sub

    Private Sub GetPayments()
        Dim customerID As Integer = CInt(TextBoxCustomerID_Customers.Text)
        Dim customerPayments As List(Of payment)
        'Clear previous data
        ListViewPayments_Customers.Clear()
        ListViewPayments_Customers.Columns.Clear()

        Try
            'set default to All
            RadioButtonAll_Customers.Checked = True
            If Not IsNothing(customerID) Then
                customerPayments = database.CustomerPayments(customerID)
                If customerPayments IsNot Nothing Then
                    DisplayInListView(customerPayments)
                Else
                    ShowNoPayments()
                End If
            End If
            'adjust width in case of no records
            ListViewPayments_Customers.LabelWrap = False
            ListViewPayments_Customers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ShowNoPayments()
        Dim emptyItem As New ListViewItem("No Payments")
        'Show just one item text without column
        With ListViewPayments_Customers
            .OwnerDraw = False
            .ForeColor = Color.DarkBlue
            .Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Regular)
            .View = View.List
            .Items.Add(emptyItem)
        End With
    End Sub

    Private Sub SetListView(ByRef listView As ListView, draw As Boolean)
        With listView
            'Handles header draw event
            .OwnerDraw = draw
            ' Set the view to show details.
            .View = View.Details
            ' Allow the user to edit item text.
            .LabelEdit = False
            ' Allow the user to rearrange columns.
            .AllowColumnReorder = False
            ' Display check boxes.
            .CheckBoxes = False
            ' Select the item and subitems when selection is made.
            .FullRowSelect = True
            ' Display grid lines.
            .GridLines = True
            ' Sort the items in the list in ascending order.
            .Sorting = SortOrder.Ascending
        End With
    End Sub

    'https://msdn.microsoft.com/en-us/library/system.windows.forms.listview.ownerdraw(v=vs.110).aspx
    Private Sub DisplayInListView(clientPayment As List(Of payment))
        'Application.EnableVisualStyles()
        SetListView(ListViewPayments_Customers, True)
        Try
            ' Create and initialize column headers for ListViewPayments_Customers.
            Dim rentHeader As New ColumnHeader()
            Dim amountHeader As New ColumnHeader()
            Dim dateHeader As New ColumnHeader()

            'set column text and position
            rentHeader.Text = "RentID"
            amountHeader.Text = "Amount"
            dateHeader.Text = "Payment Date"
            rentHeader.TextAlign = HorizontalAlignment.Center
            amountHeader.TextAlign = HorizontalAlignment.Center
            dateHeader.TextAlign = HorizontalAlignment.Left

            ' Add the column headers to ListViewPayments_Customers.
            ListViewPayments_Customers.Columns.AddRange(New ColumnHeader() _
                {rentHeader, amountHeader, dateHeader})
            ListViewPayments_Customers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

            Dim recNumber As Integer = 0
            Dim records() As ListViewItem = Nothing
            Dim listRecord As ListViewItem

            For Each item In clientPayment
                listRecord = New ListViewItem(item.rentID.ToString())
                listRecord.ForeColor = Color.DarkBlue
                listRecord.SubItems.Add(item.amount.ToString())
                ReDim Preserve records(recNumber)
                If Not item.paymentDate Is Nothing Then
                    listRecord.SubItems.Add(item.paymentDate.ToString())
                Else
                    listRecord.SubItems.Add("Not paid")
                End If
                records(recNumber) = listRecord
                recNumber += 1
                listRecord = Nothing
            Next

            ' Create three items and sets of subitems for each item.
            'For x As Integer = 0 To clientPayment.Count - 1
            '    For Each item In clientPayment(x)
            '        listRecord = New ListViewItem(item.rentID.ToString())
            '        listRecord.ForeColor = Color.DarkBlue
            '        listRecord.SubItems.Add(item.amount.ToString())
            '        ReDim Preserve records(recNumber)
            '        If Not item.paymentDate Is Nothing Then
            '            listRecord.SubItems.Add(item.paymentDate.ToString())
            '        Else
            '            listRecord.SubItems.Add("Not paid")
            '        End If
            '        records(recNumber) = listRecord
            '        recNumber += 1
            '        listRecord = Nothing
            '    Next
            'Next
            Dim group As ListGroup
            group = ListGroup.All
            'Add the items to the ListView.
            ListViewPayments_Customers.Items.AddRange(records)
            CreateGroups(group)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Public Enum ListGroup As Integer
        NotPaid = 1
        Paid = 2
        Overdue = 3
        All = 4
    End Enum

    Private Sub CreateGroups(group As ListGroup)
        ' Clears all groups:
        ListViewPayments_Customers.Groups.Clear()
        Dim notPaidGroup As New ListViewGroup("Not paid")
        Dim overdueGroup As New ListViewGroup("Overdue")
        Dim paidGroup As New ListViewGroup("Paid")

        Select Case group
            Case ListGroup.All
                ListViewPayments_Customers.Groups.AddRange(New ListViewGroup() {paidGroup, overdueGroup, notPaidGroup})
            Case ListGroup.NotPaid
                ListViewPayments_Customers.Groups.Add(notPaidGroup)
            Case ListGroup.Overdue
                ListViewPayments_Customers.Groups.Add(overdueGroup)
            Case ListGroup.Paid
                ListViewPayments_Customers.Groups.Add(paidGroup)
        End Select

        Dim subItem As ListViewItem.ListViewSubItem
        Dim rec As ListViewItem

        Try
            ' Iterate through the items in myListView.
            For Each rec In ListViewPayments_Customers.Items
                'Change subItem Font color
                For Each subItem In rec.SubItems
                    subItem.ForeColor = Color.DarkBlue
                Next
                ' Retrieve the subitem text corresponding to the column.
                Dim amountItemText As Double = CDbl(rec.SubItems(1).Text)
                Dim dateItemText As String = rec.SubItems(2).Text
                ' Assign the item to the matching group.
                If group = ListGroup.All Then
                    Select Case True
                        Case amountItemText < 0
                            If dateItemText = "Not paid" Then
                                rec.Group = notPaidGroup
                            ElseIf dateItemText <> "" Then
                                rec.Group = overdueGroup
                            End If
                        Case amountItemText = 0
                            rec.Group = paidGroup
                    End Select
                ElseIf group = ListGroup.NotPaid Then
                    If dateItemText = "Not paid" Then rec.Group = notPaidGroup
                ElseIf group = ListGroup.Overdue Then
                    If amountItemText < 0 AndAlso dateItemText <> "" _
                        AndAlso dateItemText <> "Not paid" Then rec.Group = overdueGroup
                ElseIf group = ListGroup.Paid Then
                    If amountItemText = 0 AndAlso dateItemText <> "" _
                        AndAlso dateItemText <> "Not paid" Then rec.Group = paidGroup
                End If
            Next rec
            ListViewPayments_Customers.ShowGroups = True
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            notPaidGroup = Nothing
            overdueGroup = Nothing
            paidGroup = Nothing
            subItem = Nothing
            rec = Nothing
        End Try

    End Sub

    Private Sub ListViewPayments_Customers_DrawColumnHeader(ByVal sender As Object,
        ByVal e As DrawListViewColumnHeaderEventArgs) _
        Handles ListViewPayments_Customers.DrawColumnHeader

        Dim strFormat As New StringFormat()

        Try
            If e.Header.TextAlign = HorizontalAlignment.Center Then
                strFormat.Alignment = StringAlignment.Center
            ElseIf e.Header.TextAlign = HorizontalAlignment.Right Then
                strFormat.Alignment = StringAlignment.Far
            Else
                strFormat.Alignment = StringAlignment.Near
            End If
            e.DrawBackground()
            e.Graphics.FillRectangle(Brushes.SteelBlue, e.Bounds)
            Dim headerFont As New Font("Arial", 11, FontStyle.Bold)

            e.Graphics.DrawString(e.Header.Text, headerFont, Brushes.White, e.Bounds, strFormat)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strFormat.Dispose()
        End Try

    End Sub
    ' https://msdn.microsoft.com/en-us/library/system.windows.forms.listview.drawitem(v=vs.110).aspx?cs-save-lang=1&cs-lang=vb#code-snippet-1
    'Because of a bug in the underlying Win32 control, the DrawItem event occurs without accompanying DrawSubItem events 
    'once per row In the details view When the mouse pointer moves over the row, causing 
    'anything painted In a DrawSubItem Event handler To be painted over by a custom background 
    'drawn In a DrawItem Event handler. See the example In the OwnerDraw reference 
    'topic For a workaround that invalidates Each row When the extra Event occurs. 
    'An alternative workaround Is To put all your custom drawing code In a DrawSubItem Event handler 
    'And paint the background For the entire item (including subitems) only When 
    'the DrawListViewSubItemEventArgs.ColumnIndex value Is 0.

    Private Sub ListViewPayments_Customers_DrawItem(ByVal sender As Object,
        ByVal e As DrawListViewItemEventArgs) _
        Handles ListViewPayments_Customers.DrawItem

        If Not (e.State And ListViewItemStates.Selected) = 0 Then
            ' Draw the background for a selected item.
            e.Graphics.FillRectangle(Brushes.Goldenrod, e.Bounds)
            e.DrawFocusRectangle()
        Else
            ' Draw the background for an unselected item.
            Dim brush As New SolidBrush(Color.White)

            Try
                e.Graphics.FillRectangle(brush, e.Bounds)

            Finally
                brush.Dispose()
            End Try

        End If

        ' Draw the item text for views other than the Details view.
        If Not Me.ListViewPayments_Customers.View = View.Details Then
            e.DrawText()
        End If

    End Sub

    'Draws subitem text And applies content-based formatting.
    Private Sub ListViewPayments_Customers_DrawSubItem(ByVal sender As Object,
        ByVal e As DrawListViewSubItemEventArgs) _
        Handles ListViewPayments_Customers.DrawSubItem

        Dim flags As TextFormatFlags = TextFormatFlags.Left

        Dim sf As New StringFormat()
        Try

            ' Store the column text alignment, letting it default
            ' to Left if it has not been set to Center or Right.
            Select Case e.Header.TextAlign
                Case HorizontalAlignment.Center
                    sf.Alignment = StringAlignment.Center
                    flags = TextFormatFlags.HorizontalCenter
                Case HorizontalAlignment.Right
                    sf.Alignment = StringAlignment.Far
                    flags = TextFormatFlags.Right
            End Select
            ' Draw the text for a subitem with a 
            ' negative value. 
            Dim subItemValue As Double

            If e.ColumnIndex > 0 AndAlso
                Double.TryParse(e.SubItem.Text, NumberStyles.Currency,
                NumberFormatInfo.CurrentInfo, subItemValue) AndAlso
                subItemValue < 0 Then
                'If negative Draw the subitem text in red to highlight it. 
                e.Graphics.DrawString(e.SubItem.Text,
                    Me.ListViewPayments_Customers.Font, Brushes.Red, e.Bounds, sf)
                Return
            End If
            ' Draw normal text for a subitem with a nonnegative 
            ' or nonnumerical value.
            e.DrawText(flags)

        Finally
            sf.Dispose()
        End Try

    End Sub

    Private Sub RadioButtonCurrPayment_Customer_Click(sender As Object, e As EventArgs) Handles RadioButtonCurrPayment_Customer.Click
        If RadioButtonCurrPayment_Customer.Checked = True Then
            RadioButtonOverdue_Customers.Checked = False
            RadioButtonAll_Customers.Checked = False
            Dim group As ListGroup = ListGroup.NotPaid
            CreateGroups(group)
        End If
    End Sub

    Private Sub RadioButtonOverdue_Customers_Click(sender As Object, e As EventArgs) Handles RadioButtonOverdue_Customers.Click
        If RadioButtonOverdue_Customers.Checked = True Then
            RadioButtonCurrPayment_Customer.Checked = False
            RadioButtonAll_Customers.Checked = False
            Dim group As ListGroup = ListGroup.Overdue
            CreateGroups(group)
        End If
    End Sub

    Private Sub RadioButtonAll_Customers_Click(sender As Object, e As EventArgs) Handles RadioButtonAll_Customers.Click
        If RadioButtonAll_Customers.Checked = True Then
            RadioButtonOverdue_Customers.Checked = False
            RadioButtonCurrPayment_Customer.Checked = False
            Dim group As ListGroup = ListGroup.All
            CreateGroups(group)
        End If
    End Sub

    Private Sub ButtonEdit_Customers_Click(sender As Object, e As EventArgs) Handles ButtonEdit_Customers.Click
        Try
            MembersForm.Show()
            Dim record As DataGridViewRow = MembersForm.customerDataGridView.Rows(CInt(TextBoxCustomerID_Customers.Text) - 1)
            MembersForm.SelectMember(record, 0)
        Catch ex As Exception
            MessageBox.Show(ex.Message & vbCrLf & ex.InnerException.ToString)
        End Try

    End Sub

    Private Sub GetRents(ByRef list As ListView, status As Status)
        Dim customerID As Integer = CInt(TextBoxCustomerID_Customers.Text)
        Dim rents As List(Of rental)
        'Clear previous data
        list.Clear()
        Try
            If Not IsNothing(customerID) Then
                rents = database.CustomerRentals(customerID, status.ToString())
                If rents IsNot Nothing Then
                    DisplayActiveRents(rents, list)
                Else
                    Dim listRecord As New ListViewItem()
                    listRecord.ForeColor = Color.DarkBlue
                    listRecord.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Regular)
                    listRecord.Text = "No records"
                    'Tell that list is empty 
                    list.View = View.List
                    list.Items.Add(listRecord)
                End If
            End If
            'adjust width in case of no records
            With list
                If .Items(0).SubItems(0).Text <> "No records" Then
                    .Columns(0).Width = -2
                    .Columns(1).Width = -2
                    .Columns(2).Width = -2
                    .Columns(3).Width = -2
                    .Columns(4).Width = -2
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DisplayActiveRents(rentals As List(Of rental), ByRef rentList As ListView)

        SetListView(rentList, False)
        Try
            ' Create and initialize column headers for ListViewPayments_Customers.
            Dim rentIDHeader As New ColumnHeader()
            Dim copyIDHeader As New ColumnHeader()
            Dim beginningOfRentHeader As New ColumnHeader()
            Dim durationHeader As New ColumnHeader()
            Dim statusRentHeader As New ColumnHeader()

            'set column text and position
            rentIDHeader.Text = "Rent ID"
            copyIDHeader.Text = "Copy ID"
            beginningOfRentHeader.Text = "Beginning Date"
            durationHeader.Text = "Duration"
            statusRentHeader.Text = "Status"

            rentIDHeader.TextAlign = HorizontalAlignment.Center
            copyIDHeader.TextAlign = HorizontalAlignment.Center
            beginningOfRentHeader.TextAlign = HorizontalAlignment.Center
            durationHeader.TextAlign = HorizontalAlignment.Center
            statusRentHeader.TextAlign = HorizontalAlignment.Center

            ' Add the column headers to ListViewActiveRents_Customers.
            rentList.Columns.AddRange(New ColumnHeader() _
                {rentIDHeader, copyIDHeader, beginningOfRentHeader, durationHeader, statusRentHeader})
            rentList.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize)

            Dim listRecord As New ListViewItem()
            ' Create items and sets of subitems for each item.
            If rentals IsNot Nothing Then
                'Dim emptyItem As New ListViewItem("Empty")          
                For Each item In rentals
                    If IsNothing(listRecord) Then listRecord = New ListViewItem
                    listRecord.ForeColor = Color.DarkBlue
                    listRecord.Font = New System.Drawing.Font("Arial", 9, System.Drawing.FontStyle.Regular)
                    listRecord.Text = item.rentID.ToString()
                    listRecord.SubItems.Add(item.CopyID.ToString())
                    listRecord.SubItems.Add(item.rentalDate.ToShortDateString())
                    listRecord.SubItems.Add(item.rentalTime.ToShortDateString())
                    listRecord.SubItems.Add(IIf(CInt(item.currentlyHiring) = 1, "Active", "Returned").ToString())
                    rentList.Items.Add(listRecord)
                    listRecord = Nothing
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonFullHistory_Customers_Click(sender As Object, e As EventArgs) Handles ButtonFullHistory_Customers.Click
        Dim fullList As Status = Status.All
        GetRents(ListViewFullHistory_Customers, fullList)
    End Sub

    Private Sub PaymentButton_Click(sender As Object, e As EventArgs) Handles PaymentButton.Click
        Try
            If ConfirmRentButton.Enabled = False Then
                Dim payment As PaymentModule.Payment
                payment = GetPaymentDetails(ReturnTabPage)
                payment.CalculateDuration(DateTimePicker_Rent.Value, Now())
                payment.CalculateTotal(CDbl(RateTextBox_Payment.Text), CInt(NoOfDaysTextBox_Payment.Text))
                ShowPage("PaymentTabPage")
                payment.SetPaymentDetails()
                'GetPaymentDetails()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function GetLastRent() As Integer
        Dim rentalID As Integer
        Try
            Using entities = New video_dbEntities()
                Dim rowsCount As Integer = entities.rentals.Count
                rentalID = CInt(entities.rentals.OrderBy(Function(c) c.rentID).Skip(rowsCount - 1).Single.rentID)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return rentalID
    End Function

    Private Function GetDuration(rId As Integer) As Integer
        Dim today As Date = Date.Now
        Dim returnDate As Date = DateTimePicker_Rent.Value
        Dim ts As TimeSpan = returnDate.Subtract(today)
        Dim duration As Double = Math.Round(ts.TotalDays)

        Return CInt(duration)
    End Function

    Private Function GetRate(movTitle As String) As Decimal
        Dim rate As Decimal
        Try
            Using entities = New video_dbEntities()
                'Fetch ID after autoincrement fired on rental Table in Database
                rate = (From movie In entities.movies
                        Where movie.title = movTitle
                        Select movie.rentalRate).FirstOrDefault
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return rate
    End Function

    Private Sub ApplyButton_Payment_Click(sender As Object, e As EventArgs) Handles ApplyButton_Payment.Click
        Dim payAccepted As Boolean
        ErrorProvider.SetError(ApplyButton_Payment, String.Empty)
        Try
            If ManualPaymentCheckBox_Payment.Checked = True And
            PaymentIDTextBox_Payment.Text <> "" And
            TotalTextBox_Payment.Text <> "" Then
                'transaction = UpdateCustomerBalance()
                payAccepted = MakeTransaction(CInt(PaymentIDTextBox_Payment.Text), CDec(TotalTextBox_Payment.Text))
            Else
                If IsDataAvailable(PaymentTabPage) Then
                    'transaction = MakePaymentTransaction()
                    payAccepted = MakeTransaction(0, CDec(TotalTextBox_Payment.Text), CInt(RentIDTextBox_Payment.Text))
                Else
                    MessageBox.Show("Not all required fields are fulfilled")
                End If
            End If
            If payAccepted Then
                AcceptedPictureBox_Payment.Image = PaymentImageList.Images(0)
                If PaymentIDTextBox_Payment.Text = "" Then PaymentIDTextBox_Payment.Text = GetPaymentId().ToString()
                'ErrorProvider.SetError(ApplyButton_Payment, "This movie was already paid off.")
            Else
                AcceptedPictureBox_Payment.Image = PaymentImageList.Images(1)
            End If
            AcceptedPictureBox_Payment.Visible = True
        Catch ex As Exception
            ErrorProvider.SetError(ApplyButton_Payment, ex.Message)
        End Try
    End Sub

    Private Function IsDataAvailable(ctrl As Control) As Boolean
        Dim dataInPlace As Boolean = True
        Try
            For Each control As Control In ctrl.Controls
                If control.HasChildren Then
                    IsDataAvailable(control)
                Else
                    Select Case control.GetType()
                        Case GetType(TextBox)
                            If control.Text = "" And
                               control.Visible Then dataInPlace = False
                        Case Else
                            'do nothing
                    End Select
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return dataInPlace
    End Function

    'Private Function UpdateCustomerBalance() As Boolean
    '    Dim operation As Boolean = True
    '    Dim pID As Integer = CInt(PaymentIDTextBox_Payment.Text)
    '    Dim total As Decimal = CDec(TotalTextBox_Payment.Text)
    '    Dim customerPay As payment
    '    Try
    '        customerPay = (From cPay In database.payments Where cPay.paymentID = pID
    '                       Select cPay).FirstOrDefault()
    '        If customerPay.amount <= 0 Then
    '            customerPay.amount = Math.Abs(total)
    '            customerPay.paymentDate = Now()
    '            database.SaveChanges()
    '        Else
    '            ErrorProvider.SetError(ApplyButton_Payment, "This movie was already paid off at " &
    '                                           customerPay.paymentDate)
    '        End If
    '    Catch ex As Exception
    '        ErrorProvider.SetError(ApplyButton_Payment, ex.Message)
    '        operation = False
    '    Finally
    '        customerPay = Nothing
    '    End Try
    '    Return operation
    'End Function

    'Private Function MakePaymentTransaction() As Boolean
    '    Dim operation As Boolean = True
    '    Dim newPayment As New payment
    '    Dim total As Decimal = CDec(TotalTextBox_Payment.Text)
    '    Dim memberID As Integer = CInt(CustomerIDTextBox_Payment.Text)
    '    Dim payDate As Date = PaymentDateTimePicker_Payment.Value
    '    Dim rentID As Integer = CInt(RentIDTextBox_Payment.Text)

    '    Try
    '        newPayment.memberID = memberID
    '        newPayment.rentID = rentID
    '        newPayment.amount = total
    '        newPayment.paymentDate = Now

    '        Using entities = New video_dbEntities()
    '            entities.payments.Add(newPayment)
    '            entities.SaveChanges()
    '        End Using
    '    Catch ex As Exception
    '        operation = False
    '    Finally
    '        newPayment = Nothing
    '    End Try
    '    Return operation
    'End Function

    Private Function GetPaymentId() As Integer
        Dim rentalID As Integer
        'Fetch last paymnetID from Payment Table
        Try
            Using entities = New video_dbEntities()
                Dim rowsCount As Integer = entities.payments.Count
                rentalID = CInt(entities.payments.OrderBy(Function(p) p.paymentID).Skip(rowsCount - 1).Single.paymentID)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return rentalID
    End Function

    'open the print preview
    Private Sub PreviewPrintButton_Payment_Click(sender As Object, e As EventArgs) Handles PreviewPrintButton_Payment.Click
        PrintPreviewDialog_Payment.Document = PrintDocument_Payment 'PrintPreviewDialog associate with PrintDocument
        PrintPreviewDialog_Payment.ShowDialog()
    End Sub

    'associate text with print page
    Private Sub PrintDocument_Payment_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument_Payment.PrintPage
        Dim textToPrint As String
        Dim printFont = New Font("Arial", 10)
        textToPrint = ReadForm()
        e.Graphics.DrawString(textToPrint, printFont, Brushes.Black, 20, 20)
        e.Graphics.PageUnit = GraphicsUnit.Inch
    End Sub

    'create text to print
    Private Function ReadForm() As String
        Dim strBuilder As StringBuilder = New StringBuilder(
            vbTab & vbTab & vbTab & "PAYMENT CONFIRMATION").AppendLine()
        Try
            strBuilder.Append("Date: " & Now().ToShortDateString).Append _
            (vbTab & "::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::").AppendLine()
            strBuilder.Append(vbTab & "Customer: " & FullNameTextBox_Payment.Text).AppendLine()
            strBuilder.Append(vbTab & "Customer ID: " & CustomerIDTextBox_Payment.Text).AppendLine()
            strBuilder.Append(vbTab & "Movie: " & TitleTextBox_Payment.Text).AppendLine()
            strBuilder.Append(vbTab & "Movie ID: " & CopyIDTextBox_Payment.Text).AppendLine()
            strBuilder.Append(vbTab & "Paid amount: " & TotalTextBox_Payment.Text).AppendLine()
            strBuilder.Append(vbTab & "Renting duration: " & NoOfDaysTextBox_Payment.Text).AppendLine()
            strBuilder.Append(vbTab & "Payment ID: " & PaymentIDTextBox_Payment.Text).AppendLine()
            strBuilder.
                Append("---------------------------------------------------------------------------------------").AppendLine()
            strBuilder.Append("Confirmed by: " & TransactionOwnerTextBox_Payment.Text)
            strBuilder.Append("Rent ID: " & RentIDTextBox_Payment.Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return strBuilder.ToString()
    End Function

    'show print dialog
    Private Sub PrintButton_Payment_Click(sender As Object, e As EventArgs) Handles PrintButton_Payment.Click
        PrintDialog_Payment.Document = PrintDocument_Payment 'PrintDialog associate with PrintDocument.
        If PrintDialog_Payment.ShowDialog() = DialogResult.OK Then
            PrintDocument_Payment.Print()
        End If
    End Sub

    'clear previous data on page
    Private Sub ResetPage(ctrl As Control)
        AcceptedPictureBox_Payment.Visible = False
        ConfirmationLabel_Return.Visible = False
        Try
            For Each control As Control In ctrl.Controls
                If control.HasChildren Then
                    ResetPage(control)
                Else
                    Select Case control.GetType()
                        Case GetType(TextBox)
                            control.ResetText()
                        Case Else
                            'do nothing
                    End Select
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ConfirmRentButton_Click(sender As Object, e As EventArgs) Handles ConfirmRentButton.Click
        If IsDataAvailable(RentTabPage) And
            MonthCalendar_Rent.Visible = False And
            ChooseCopyComboBox_Rent.SelectedIndex <> -1 Then
            CreateNewRentRecord()
            ConfirmRentButton.Enabled = False
            ConfirmationLabel.Text = "New rental added successfully"
            ConfirmationLabel.Visible = True
        Else
            MessageBox.Show("Not all required fields are fulfilled")
        End If
    End Sub

    Private Sub CreateNewRentRecord()
        Dim newRent As New rental
        Try
            newRent.CopyID = CInt(ChooseCopyComboBox_Rent.SelectedItem)
            newRent.employeeID = GetEmployeeID(userLog)
            If IDTextBox.Visible = True Then
                newRent.memberID = CInt(IDTextBox.Text)
            Else
                newRent.memberID = CInt(idComboBox.SelectedItem)
            End If
            newRent.rentalTime = DateTimePicker_Rent.Value
            newRent.currentlyHiring = CByte(1)

            Using entities = New video_dbEntities()
                entities.rentals.Add(newRent)
                entities.SaveChanges()
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            newRent = Nothing
        End Try
    End Sub

    Private Function GetEmployeeID(name As String) As Integer
        Dim employee As Integer
        Try
            Using entities = New video_dbEntities()
                'Fetch ID after autoincrement fired on rental Table in Database
                employee = (From empl In entities.employees
                            Where empl.employee_name = name
                            Select empl.employeeID).FirstOrDefault
                'Return entities.employees.Where(Function(e) e.employee_name.Equals(name)).FirstOrDefault(Function(em) em.employeeID)
            End Using
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return employee
    End Function

    'Lease duration
    Private Sub NoOfDaysTextBox_Payment_TextChanged(sender As Object, e As EventArgs) Handles NoOfDaysTextBox_Payment.TextChanged
        If Not IsNothing(RateTextBox_Payment.Text) Then
            If IsNumeric(NoOfDaysTextBox_Payment.Text) Then
                TotalTextBox_Payment.Text = (CInt(NoOfDaysTextBox_Payment.Text) * CInt(RateTextBox_Payment.Text)).ToString()
            Else
                MessageBox.Show("Number of days must be a number")
            End If
        End If
    End Sub

    'if there Internet connection - connect to IMDB website, get most trending movie
    'and displays details of that movie on main Tab
    Private Sub GetLatestBestseller()
        Dim str As System.IO.Stream = Nothing
        Dim strRead As System.IO.StreamReader = Nothing

        Try
            'make web request
            Dim req As System.Net.WebRequest = System.Net.WebRequest.Create(
                "http://www.imdb.com/list/ls069621399/?pf_rd_m=A2FGELUUNOQJNL&pf_rd_p=3021378022&pf_rd_r=1MFDSHJ9V1QD75GCEC2T&pf_rd_s=center-12&pf_rd_t=15061&pf_rd_i=homepage&ref_=hm_aiv_sm")
            Dim resp As System.Net.WebResponse = req.GetResponse
            str = resp.GetResponseStream
            strRead = New System.IO.StreamReader(str)
            'read page
            Dim pageText As String = strRead.ReadToEnd
            'to create new HTMLDocument we need WebBrowser Object - otherwise we can't instantiate standalone HTMLDocument
            Dim wbc As WebBrowser = New WebBrowser()
            wbc.DocumentText = ""
            With wbc.Document
                .OpenNew(True)
                .Write(pageText)
            End With
            Dim doc As System.Windows.Forms.HtmlDocument = wbc.Document

            If Not IsNothing(doc) Then FindFirstMovie(doc)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
            bestSellerPanel.BestsellerDescriptionLabel.Text = "Unable to download content"
        Finally
            'close stream reader
            strRead.Close()
            str.Close()
        End Try
    End Sub

    'Get section with identified id = "main" and finds top movie with its picture src and description
    Private Sub FindFirstMovie(ByRef sourceHtml As System.Windows.Forms.HtmlDocument)
        Dim itemList As System.Windows.Forms.HtmlElementCollection = sourceHtml.GetElementsByTagName("DIV")
        Dim topElement As HtmlElement
        Try
            For Each item As System.Windows.Forms.HtmlElement In itemList 'look at each item in the collection
                If item.Id = "main" Then
                    topElement = FindTopElement(item.FirstChild)
                    If Not topElement Is Nothing Then GetPicture(topElement)
                    Exit For
                End If
            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            itemList = Nothing
            topElement = Nothing
        End Try
    End Sub

    'Get list of trending movies
    Private Function FindTopElement(outerItem As HtmlElement) As HtmlElement
        For Each subItem As HtmlElement In outerItem.Children
            If subItem.GetAttribute("className").ToString() = "list detail" Then
                Return subItem.FirstChild
            End If
        Next
        Return Nothing
    End Function

    'Get picture of the most trending movie - first on the list
    Private Sub GetPicture(topItem As HtmlElement)
        Dim imageSource As String = ""
        Try
            Dim imageItem As HtmlElement = topItem.FirstChild
            Dim imageSrc As HtmlElement = imageItem.FirstChild.Children(0)
            'workaround - imageSrc.GetAttribute("src") doesn't work
            imageSource = imageSrc.InnerHtml
            imageSource = Mid(imageSource, (InStr(imageSource, "src=") + 5))
            imageSource = Strings.Left(imageSource, InStr(imageSource, ".jpg") + 3)
            'Get picture
            'http://www.vbforums.com/showthread.php?387841-Display-image-from-internet-in-a-Picturebox
            bestSellerPanel.BestsellerMoviePictureBox.Image = New System.Drawing.Bitmap(
          New IO.MemoryStream(New System.Net.WebClient().DownloadData(imageSource)))
            'Get movie description
            GetDescription(imageItem.NextSibling.NextSibling)
            'Get movie title
            GetTitle(imageItem.NextSibling.NextSibling)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Get description of the most trending movie - first on the list
    Private Sub GetDescription(desItem As HtmlElement)
        For Each subItem As HtmlElement In desItem.Children
            If subItem.GetAttribute("className").ToString() = "item_description" Then
                bestSellerPanel.BestsellerDescriptionLabel.Width = bestSellerPanel.BestsellerMoviePictureBox.Width
                bestSellerPanel.BestsellerDescriptionLabel.AutoSize = False
                bestSellerPanel.BestsellerDescriptionLabel.Height = bestSellerPanel.BestsellerMoviePictureBox.Height
                bestSellerPanel.BestsellerDescriptionLabel.Text = subItem.GetAttribute("InnerText")
                Exit For
            End If
        Next
    End Sub

    'Get title of the most trending movie - first on the list
    Private Sub GetTitle(Item As HtmlElement)
        For Each subItem As HtmlElement In Item.Children
            If subItem.InnerHtml.Contains("title") Then
                bestSellerPanel.BestsellerMovieLabel.Text = subItem.InnerText
                Exit For
            End If
        Next
    End Sub

    'Check if Internet connection is available
    'https://support.microsoft.com/en-us/help/821770/how-to-determine-the-connection-state-of-your-local-system-and-how-to-initiate-or-end-an-internet-connection-by-using-visual-basic-net-or-visual-basic-2005
    Private Function InternetConnectionState() As Boolean
        Dim out As Integer
        If InternetGetConnectedState(out, 0) = True Then
            Return True
        Else
            Return False
        End If
    End Function

    'Find copyID when Enter Key is down
    Private Sub SearchTextBox_Return_KeyDown(sender As Object, e As KeyEventArgs) Handles SearchTextBox_Return.KeyDown
        Dim customerRent As rental
        Dim location As New Point(346, 13)
        Try
            If e.KeyCode = Keys.Enter Then
                ResetPage(ReturnGroupBox_Return)
                ResetPage(CustomerGroupBox_Return)
                HideFine()
                If ValidateSearchedMovie(SearchTextBox_Return.Text) = True And
                    IsNumeric(SearchTextBox_Return.Text) Then ' Verify user input
                    Dim copyID As Integer = CInt(SearchTextBox_Return.Text)
                    customerRent = database.GetRentByCopyID(copyID, 1)
                    'Dim duration = RentalDuration(customerRent)
                    'Dim onTime As Integer = IsOnTime(customerRent)
                    'GetRentalCost(movTitle, duration, onTime)
                    If (customerRent IsNot Nothing) Then
                        FillReturn(customerRent) 'Populate controls with found values
                    Else
                        VerifyDurationLabel_Return.Location = location
                        VerifyDurationLabel_Return.Text = "Movie not found"
                        VerifyDurationLabel_Return.Visible = True
                        ReturnTabPage.Controls.Add(VerifyDurationLabel_Return)
                    End If
                Else
                    VerifyDurationLabel_Return.Location = location
                    VerifyDurationLabel_Return.Text = "Invalid Characters"
                    VerifyDurationLabel_Return.Visible = True
                    ReturnTabPage.Controls.Add(VerifyDurationLabel_Return)
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            customerRent = Nothing
            location = Nothing
        End Try

    End Sub

    Private Sub FillReturn(rent As rental)
        Try
            RentIDTextBox_Return.Text = rent.rentID.ToString()
            Dim movieId As Integer = database.GetMovieIDByCopyID(rent.CopyID)
            Dim movTitle As String = database.GetTitleByMovieID(movieId)
            TitleTextBox_Return.Text = movTitle
            'DateTimePicker_Return.SuspendLayout()
            'DateTimePicker_Return.Value = Now()
            CustomerIDTextBox_Return.Text = rent.memberID.ToString()
            CustomerFullNameTextBox_Return.Text = rent.member.firstName & " " & rent.member.lastName
            'check duration and fine
            Dim duration = EstimatedRentalDuration(rent)
            Dim onTime As Integer = IsOnTime(rent)
            ChargeTextBox_Return.Text = EstimatedRentalCost(movTitle, duration, onTime)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    'Just to match calculations on datbase side
    Private Function EstimatedRentalCost(title As String, elapsedTime As Integer, onTime As Integer) As String
        Dim rate As Decimal = GetRate(title)
        Dim result As String

        If onTime > 0 Then
            result = ((elapsedTime * rate) + CInt(FineTextBox_Return.Text)).ToString()
        Else
            result = (elapsedTime * rate).ToString()
        End If
        Return result
    End Function

    'Just to match calculations on datbase side
    Private Function EstimatedRentalDuration(rent As rental) As Integer
        Dim duration As Integer
        Dim rentalTime As DateTime = database.GetRentalTime(CInt(rent.rentID))
        'If rent.returnDate Is Nothing Then
        '    returnDate = DateTimePicker_Return.Value.Date
        'Else
        '    returnDate = rent.returnDate.Value.Date
        'End If
        'duration = returnDate.Subtract(rent.rentalDate.Date).Days
        duration = rentalTime.Subtract(rent.rentalDate.Date).Days
        Return duration
    End Function

    'The accurate calculations
    'Private Function GetRentalCost(title As String, elapsedTime As Integer, onTime As Integer) As String
    '    Dim rate As Decimal = GetRate(title)
    '    Return IIf(onTime > 0, (elapsedTime * rate +
    '                                        CInt(FineTextBox_Return.Text)),
    '                                        IIf(elapsedTime < 0, "0", (elapsedTime * rate))).ToString()
    'End Function

    'The accurate calculations
    'Private Function RentalDuration(rent As rental, Optional returned As Boolean = False) As Integer
    '    Dim duration As Integer
    '    Dim returnDate As DateTime
    '    If returned = False Then
    '        returnDate = DateTimePicker_Return.Value.Date
    '        duration = returnDate.Subtract(rent.rentalDate.Date).Days
    '    Else
    '        returnDate = rent.returnDate.Value.Date
    '        duration = returnDate.Subtract(rent.rentalDate.Date).Days
    '    End If
    '    'Alternative:
    '    'DateDiff(DateInterval.Day, returnDate, rent.rentalDate.Date)
    '    'Dim ts As TimeSpan = returnDate.Subtract(rent.rentalDate.Date)
    '    'Dim duration As Integer = CInt(Math.Round(ts.Days))
    '    Return duration
    'End Function

    Private Function IsOnTime(cRent As rental) As Integer
        Dim returnDate As DateTime
        Dim deadline As DateTime = cRent.rentalTime.Date

        If cRent.returnDate Is Nothing Then
            returnDate = DateTimePicker_Return.Value.Date
        Else
            returnDate = cRent.returnDate.Value.Date
        End If

        Dim result As Integer = DateTime.Compare(returnDate, deadline)

        Try
            Dim relationship As String
            Dim location As New Point(344, 93)
            If result < 0 Then
                relationship = "Return is earlier than expected."
                With VerifyDurationLabel_Return
                    .Location = location
                    .Text = relationship
                    .ForeColor = Color.LimeGreen
                    .Visible = True
                End With
            ElseIf result = 0 Then
                relationship = "Return is on time."
                With VerifyDurationLabel_Return
                    .Visible = True
                    .Location = location
                    .Text = relationship
                    .ForeColor = Color.LimeGreen
                End With
            Else
                relationship = "Return is later than expected."
                With VerifyDurationLabel_Return
                    .Visible = True
                    .Location = New Point(385, 62)
                    .Text = relationship
                    .ForeColor = Color.Red
                End With
                ShowFine(cRent.rentalTime)
            End If
            ReturnGroupBox_Return.Controls.Add(VerifyDurationLabel_Return)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            returnDate = Nothing
            deadline = Nothing
        End Try
        Return result
    End Function

    Private Sub ShowFine(expectedDate As Date)
        FineLabel_Return.Visible = True
        FineTextBox_Return.Visible = True
        DaysOverdueLabel_Return.Visible = True
        ExpectedReturnDateTimePicker_Return.Value = expectedDate
        ExpextedReturnLabel_Return.Visible = True
        ExpectedReturnDateTimePicker_Return.Visible = True

        Dim returnDate As Date = DateTimePicker_Return.Value.Date
        Dim delay As Integer = returnDate.Subtract(expectedDate.Date).Days

        DaysOverdueTextBox_Return.Text = delay.ToString()
        DaysOverdueTextBox_Return.Visible = True
        Try
            Dim fine As Double
            fine = database.GetFineByTitle(TitleTextBox_Return.Text)
            FineTextBox_Return.Text = (delay * fine).ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub HideFine()
        DaysOverdueTextBox_Return.Visible = False
        FineLabel_Return.Visible = False
        FineTextBox_Return.Visible = False
        DaysOverdueLabel_Return.Visible = False
        ExpextedReturnLabel_Return.Visible = False
        ExpectedReturnDateTimePicker_Return.Visible = False
    End Sub

    Private Sub ReturnTabPage_Leave(sender As Object, e As EventArgs) Handles ReturnTabPage.Leave
        'clear page
        ResetPage(ReturnTabPage)
        DateTimePicker_Return.Value = Now()
        VerifyDurationLabel_Return.Visible = False
        FineLabel_Return.Visible = False
        FineTextBox_Return.Visible = False
        DaysOverdueTextBox_Return.Visible = False
        DaysOverdueLabel_Return.Visible = False
        ExpextedReturnLabel_Return.Visible = False
        ExpectedReturnDateTimePicker_Return.Visible = False
        PayNowButton_Return.Enabled = False
        ConfirmationLabel_Return.Visible = False
    End Sub

    Private Sub OkButton_Return_Click(sender As Object, e As EventArgs) Handles OkButton_Return.Click
        If IsDataAvailable(ReturnTabPage) Then
            Dim rentDb As New Database(RepoType.Rent)
            Try
                Dim rID As Integer = CInt(RentIDTextBox_Return.Text)
                Dim customerRent As rental = rentDb.GetRentByRentID(rID)

                If customerRent.returnDate Is Nothing Then
                    customerRent.returnDate = DateTimePicker_Return.Value
                    rentDb.SaveRental()
                Else
                    ErrorProvider.SetError(OkButton_Return, "This movie was already returned on " &
                                           customerRent.returnDate)
                End If

                Dim customerPay As Date? = database.GetPaymentDateByRentID(rID)
                If customerPay Is Nothing Then PayNowButton_Return.Enabled = True
                ConfirmationLabel_Return.Text = "Movie returned on shelf"
                ConfirmationLabel_Return.Visible = True
            Catch ex As Exception
                ErrorProvider.SetError(OkButton_Return, ex.Message)
            End Try
        Else
            ErrorProvider.SetError(OkButton_Return, "Not all required fields are fulfilled.")
        End If
    End Sub

    Private Function GetPaymentDetails(tab As TabPage) As PaymentModule.Payment
        Dim payDetails As PaymentModule.Payment = Nothing
        Dim movTitle As String

        Try
            Select Case tab.Name
                Case "ReturnTabPage"
                    movTitle = TitleTextBox_Return.Text
                    payDetails = New PaymentModule.Payment(CInt(SearchTextBox_Return.Text),
                                CustomerFullNameTextBox_Return.Text, CInt(CustomerIDTextBox_Return.Text),
                                TitleTextBox_Return.Text, CInt(RentIDTextBox_Return.Text), GetRate(movTitle))
                    payDetails.Total = CDbl(ChargeTextBox_Return.Text)
                    payDetails.Fine = CInt((IIf(FineTextBox_Return.Text <> "", FineTextBox_Return.Text, 0)).ToString())

                Case "RentTabPage"
                    movTitle = TitleTextBox_Payment.Text
                    payDetails = New PaymentModule.Payment(CInt(ChooseCopyComboBox_Rent.SelectedItem),
                                FullNameTextBox.Text, CInt(IDTextBox.Text), MovieTitleTextBox.Text,
                                GetLastRent(), GetRate(movTitle))
            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return payDetails
    End Function

    Private Sub PayNowButton_Return_Click(sender As Object, e As EventArgs) Handles PayNowButton_Return.Click
        Dim payment As PaymentModule.Payment
        Try
            Dim id As Integer = CInt(RentIDTextBox_Return.Text)
            payment = GetPaymentDetails(ReturnTabPage)
            payment.CalculateDuration(database.GetRentalTime(id), database.GetHireDate(id))
            payment.CalculateTotal(CDbl(IIf(FineTextBox_Return.Visible = True, FineTextBox_Return.Text, 0).ToString()))
            ShowPage("PaymentTabPage")
            payment.SetPaymentDetails()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            payment = Nothing
        End Try

        With PayNowButton_Return
            If .Enabled = True Then .Enabled = False
        End With
    End Sub

    Private Sub PayNowButton_Return_EnabledChanged(sender As Object, e As EventArgs) Handles PayNowButton_Return.EnabledChanged
        ErrorProvider.SetError(OkButton_Return, String.Empty)
    End Sub

    Private Sub DateTimePicker_Return_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker_Return.ValueChanged
        If DateTimePicker_Return.Value <> Today.Date Then
            Dim movTitle As String = TitleTextBox_Return.Text
            Dim copy As String = SearchTextBox_Return.Text
            HideFine()
            If movTitle <> "" And copy <> "" Then
                Dim rent As rental = database.GetRentByCopyID(CInt(copy), 1)
                Dim duration = EstimatedRentalDuration(rent) ' RentalDuration(rent)
                Dim onTime As Integer = IsOnTime(rent)
                ChargeTextBox_Return.Text = EstimatedRentalCost(movTitle, duration, onTime) 'GetRentalCost(movTitle, duration, onTime)
            End If
        End If
    End Sub

    Private Sub ManualPaymentCheckBox_Payment_CheckedChanged(sender As Object, e As EventArgs) Handles ManualPaymentCheckBox_Payment.CheckedChanged
        If ManualPaymentCheckBox_Payment.Checked = True Then
            PaymentIDTextBox_Payment.ReadOnly = False
        Else
            PaymentIDTextBox_Payment.ReadOnly = True
        End If
    End Sub

    Private Sub PaymentIDTextBox_Payment_KeyDown(sender As Object, e As KeyEventArgs) Handles PaymentIDTextBox_Payment.KeyDown
        If e.KeyCode = Keys.Enter And
             PaymentIDTextBox_Payment.ReadOnly = False Then
            Dim paydInfo As payment
            If IsNumeric(PaymentIDTextBox_Payment.Text) Then
                paydInfo = database.GetPaymentByID(CInt(PaymentIDTextBox_Payment.Text))
                FillPaymentPage(paydInfo)
            Else
                ErrorProvider.SetError(PaymentIDTextBox_Payment, "Numbers only!")
            End If
        End If
    End Sub

    Private Sub PaymentIDTextBox_Payment_TextChanged(sender As Object, e As EventArgs) Handles PaymentIDTextBox_Payment.TextChanged
        ErrorProvider.SetError(PaymentIDTextBox_Payment, String.Empty)
    End Sub

    Private Sub FillPaymentPage(pay As payment)
        Try
            CustomerIDTextBox_Payment.Text = pay.memberID.ToString()
            FullNameTextBox_Payment.Text = pay.member.firstName() & " " & pay.member.lastName()
            RentIDTextBox_Payment.Text = pay.rentID.ToString()
            Dim mId As Integer = database.GetMovieIDByCopyID(database.GetCopyIdByRentID(CInt(RentIDTextBox_Payment.Text)))
            TitleTextBox_Payment.Text = database.GetTitleByMovieID(mId)
            CopyIDTextBox_Payment.Text = database.GetCopyIdByRentID(CInt(RentIDTextBox_Payment.Text)).ToString()
            TransactionOwnerTextBox_Payment.Text = userLog
            TotalTextBox_Payment.Text = pay.amount.ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButtonSendEmail_Customer_Click(sender As Object, e As EventArgs) Handles ButtonSendEmail_Customer.Click
        Dim mailForm As New MailGUI
        mailForm.Show()
        'Dim mailForm As New MailForm
        'mailForm.Show()
        'Dim message As New MailMessage("sender@address", "from@address", "Subject", "Message Text")
        'Dim emailClient As New SmtpClient("Email Server Name")
        'emailClient.Send(message)
    End Sub
    ' ########################### OBSOLETE CODE ##################################

    'Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Try  
    '        TabControlMain.DrawMode = TabDrawMode.OwnerDrawFixed
    '        For x As Integer = TabControlMain.Controls.Count - 1 To 1 Step -1
    '            TabControlMain.TabPages.RemoveAt(x)
    '        Next
    '        AddHandler TabControlMain.DrawItem, AddressOf OnDrawItem

    '    Catch ex As Exception
    '        MsgBox(ex.Message)
    '    End Try

    'End Sub

    'Private Sub OnDrawItem(ByVal sender As Object, ByVal e As DrawItemEventArgs) Handles TabControlMain.DrawItem ' FillRectangle
    '    Dim graph As Graphics = e.Graphics
    '    Dim brush As New SolidBrush(Color.Bisque)
    '    Dim drawString As String
    '    Dim drawFont As New System.Drawing.Font("Arial", 10)
    '    Dim drawBrush As New System.Drawing.SolidBrush(System.Drawing.Color.Black)
    '    Dim tabTextArea As RectangleF = RectangleF.op_Implicit(TabControlMain.GetTabRect(e.Index))
    '    Dim format = New StringFormat

    '    format.Alignment = StringAlignment.Center
    '    format.LineAlignment = StringAlignment.Far
    '    Select Case e.Index
    '        Case 0
    '            drawString = "Welcome"
    '        Case 1
    '            drawString = "Catalog"
    '            'TabControlMain.Controls(1).Hide()
    '            'TabControlMain.SelectTab("Catalog")
    '        Case 2
    '            drawString = "Customers"
    '            'TabControlMain.Controls(2).Hide()
    '        Case 3
    '            drawString = "Lost/Damaged"
    '        Case 4
    '            drawString = "Reports"
    '        Case 5
    '            drawString = "Settings"
    '        Case 6
    '            drawString = "Exit"
    '            'TabControlMain.Controls(6).Hide()
    '    End Select

    '    'myTabRect = TabControlMain.GetTabRect(e.Index)
    '    graph.FillRectangle(brush, tabTextArea) ' myTabRect
    '    graph.DrawString(drawString, drawFont, drawBrush, tabTextArea, format)
    'End Sub

    'Private Sub ShowTab(tabName As String)
    '    TabControlMain.TabPages.Add(tabName)

    '    For Each myTab As TabPage In TabControlMain.TabPages
    '        If myTab.Name = tabName Then
    '            MsgBox(myTab.Name + " exist")
    '        Else
    '            MsgBox(myTab.Name + " removing")
    '            'TabControlMain.TabPages.RemoveByKey(myTab.Name)
    '            'If TabControlMain.TabPages.Contains(myTab) Then
    '            '    MsgBox(myTab.Name + " exist")
    '            '    'TabControlMain.TabPages.RemoveByKey(myTab.Name)
    '            'End If
    '        End If
    '    Next
    'End Sub

    'Private Sub HideTabPage(ByVal tabName As TabPage)
    '    If TabControlMain.TabPages.Contains(tabName) Then TabControlMain.TabPages.Remove(tabName)
    'End Sub

    'Private Sub ShowTabPage(ByVal tabName As TabPage)
    '    ShowTabPage(tabName, TabControlMain.TabPages.Count)
    'End Sub

    'Private Sub ShowTabPage(ByVal tabName As TabPage, ByVal index As Integer)
    '    If TabControlMain.TabPages.Contains(tabName) Then Return
    '    InsertTabPage(tabName, index)
    'End Sub

    'Private Sub InsertTabPage(ByVal [tabpage] As TabPage, ByVal [index] As Integer)
    '    If [index] <0 Or [index] > TabControlMain.TabCount Then
    '        Throw New ArgumentException("Index out of Range.")
    '    End If
    '    TabControlMain.TabPages.Add([tabpage])
    '    If [index] <TabControlMain.TabCount - 1 Then
    '        Do While TabControlMain.TabPages.IndexOf([tabpage]) <> [index]
    '            SwapTabPages([tabpage], (TabControlMain.TabPages(TabControlMain.TabPages.IndexOf([tabpage]) - 1)))
    '        Loop
    '    End If
    '    TabControlMain.SelectedTab = [tabpage]
    'End Sub

    'Private Sub SwapTabPages(ByVal tp1 As TabPage, ByVal tp2 As TabPage)
    '    If TabControlMain.TabPages.Contains(tp1) = False Or TabControlMain.TabPages.Contains(tp2) = False Then
    '        Throw New ArgumentException("TabPages must be in the TabCotrols TabPageCollection.")
    '    End If
    '    Dim Index1 As Integer = TabControlMain.TabPages.IndexOf(tp1)
    '    Dim Index2 As Integer = TabControlMain.TabPages.IndexOf(tp2)
    '    TabControlMain.TabPages(Index1) = tp2
    '    TabControlMain.TabPages(Index2) = tp1

    '    'Uncomment the following section to overcome bugs in the Compact Framework
    '    'TabControlMain.SelectedIndex = TabControlMain.SelectedIndex 
    '    'Dim tp1Text, tp2Text As String
    '    'tp1Text = tp1.Text
    '    'tp2Text = tp2.Text
    '    'tp1.Text=tp2Text
    '    'tp2.Text=tp1Text

    'End Sub

    'Private Sub LoadComboBox()
    '    Dim maxVal As Integer
    '    ComboBoxLang.Items.Clear()
    '    ComboBoxCountry.Items.Clear()
    '    Dim countryArray() As System.Object = New Object() {"Denmark", "England", "Finland", "France",
    '                                                   "Germany", "Italy", "Norway", "Romania",
    '                                                   "Russia", "Spain", "Sweden"}
    '    Dim langArray() As System.Object = New Object() {"Danish", "English", "Finnish", "French",
    '                                                   "German", "Italian", "Norwegian", "Romanian",
    '                                                   "Russian", "Spanish", "Swedish"}
    '    Dim y As Integer = 0
    '    'ComboBoxYear.Items.Clear()
    '    'ComboBoxYear.SelectedValue = Nothing
    '    maxVal = CInt(Date.Now.ToString("yyyy")) - 1950
    '    Dim myRange(maxVal) As System.Object
    '    For i As Integer = 1950 To CInt(Date.Now.ToString("yyyy"))
    '        myRange(y) = i
    '        y = y + 1
    '    Next i
    '    ComboBoxYear.Items.AddRange(myRange)
    '    Array.Sort(langArray)
    '    ComboBoxLang.Items.AddRange(langArray)
    '    Array.Sort(countryArray)
    '    ComboBoxCountry.Items.AddRange(countryArray)
    'End Sub

    'Private Sub LoadCountry()

    '    Dim myArray() As System.Object = New Object() {"Denmark", "England", "Finland", "France", _
    '                                                   "Germany", "Italy", "Norway", "Romania", _
    '                                                   "Russia", "Spain", "Sweden"}
    '    Array.Sort(myArray)
    '    ComboBox3.Items.AddRange(myArray)
    '    'For i = 0 To myArray.Length - 1
    '    '    ComboBox3.Items.Add(myArray(i))
    '    'Next
    '    'ComboBox3.Items.Add("England")
    '    'ComboBox3.Items.Add("France")
    '    'ComboBox3.Items.Add("Germany")
    '    'ComboBox3.Items.Add("Norway")
    '    'ComboBox3.Items.Add("Poland")
    '    'ComboBox3.Items.Add("Sweden")
    '    'ComboBox3.Items.Add("Denmark")
    '    'ComboBox3.Items.Add("Italy")
    '    'ComboBox3.Items.Add("Finland")
    '    'ComboBox3.Items.Add("Romania")
    '    'ComboBox3.Items.Add("Russia")
    '    'ComboBox3.Items.Add("Spain")

    'End Sub

    'Public Class Person
    '    Public Fname, Lname As String

    '    Sub New(ByVal FirstName As String, ByVal LastName As String)
    '        Fname = FirstName
    '        Lname = LastName
    '    End Sub

    '    Public Overrides Function ToString() As String
    '        Return Fname + " " + Lname
    '    End Function
    'End Class
End Class