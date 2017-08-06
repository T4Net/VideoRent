<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LabelTimer = New System.Windows.Forms.Label()
        Me.LabelWelcome = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.CatalogPictureBox = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PrintToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MoviesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AccountsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateUserToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteAccountToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ImageListMovieCover = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControlMain = New System.Windows.Forms.TabControl()
        Me.WelcomeTabPage = New System.Windows.Forms.TabPage()
        Me.CatalogTabPage = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.RentButton = New System.Windows.Forms.Button()
        Me.GroupBoxFilters = New System.Windows.Forms.GroupBox()
        Me.LabelCategories = New System.Windows.Forms.Label()
        Me.FilterButton = New System.Windows.Forms.Button()
        Me.ListBoxCategories = New System.Windows.Forms.ListBox()
        Me.LabelCountry = New System.Windows.Forms.Label()
        Me.ComboBoxCountry = New System.Windows.Forms.ComboBox()
        Me.LabelLang = New System.Windows.Forms.Label()
        Me.ComboBoxLang = New System.Windows.Forms.ComboBox()
        Me.LabelYear = New System.Windows.Forms.Label()
        Me.ComboBoxYear = New System.Windows.Forms.ComboBox()
        Me.CoverPictureBox = New System.Windows.Forms.PictureBox()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.LabelCatalog = New System.Windows.Forms.Label()
        Me.SearchTextBox = New System.Windows.Forms.TextBox()
        Me.SearchedMovieDataGridView = New System.Windows.Forms.DataGridView()
        Me.RentTabPage = New System.Windows.Forms.TabPage()
        Me.ConfirmationLabel = New System.Windows.Forms.Label()
        Me.ConfirmRentButton = New System.Windows.Forms.Button()
        Me.PaymentButton = New System.Windows.Forms.Button()
        Me.ChooseCopyLabel = New System.Windows.Forms.Label()
        Me.ChooseCopyComboBox_Rent = New System.Windows.Forms.ComboBox()
        Me.ClientAccountButton = New System.Windows.Forms.Button()
        Me.ClientNotFoundLabel = New System.Windows.Forms.Label()
        Me.BalanceLabel = New System.Windows.Forms.Label()
        Me.BalanceTextBox = New System.Windows.Forms.TextBox()
        Me.FullNameLabel = New System.Windows.Forms.Label()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.CustomerLabel = New System.Windows.Forms.Label()
        Me.CustomerTextBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MonthCalendar_Rent = New System.Windows.Forms.MonthCalendar()
        Me.DateLabel = New System.Windows.Forms.Label()
        Me.AvailabilityLabel = New System.Windows.Forms.Label()
        Me.DateTimePicker_Rent = New System.Windows.Forms.DateTimePicker()
        Me.MovieTitleLabel = New System.Windows.Forms.Label()
        Me.MovieTitleTextBox = New System.Windows.Forms.TextBox()
        Me.ReturnTabPage = New System.Windows.Forms.TabPage()
        Me.CustomerGroupBox_Return = New System.Windows.Forms.GroupBox()
        Me.CustomerIDTextBox_Return = New System.Windows.Forms.TextBox()
        Me.CustomerIDLabel_Return = New System.Windows.Forms.Label()
        Me.CustomerFullNameTextBox_Return = New System.Windows.Forms.TextBox()
        Me.CustomerFullNameLabel_Return = New System.Windows.Forms.Label()
        Me.SearchLabel_Return = New System.Windows.Forms.Label()
        Me.ReturnGroupBox_Return = New System.Windows.Forms.GroupBox()
        Me.DaysOverdueTextBox_Return = New System.Windows.Forms.TextBox()
        Me.ExpectedReturnDateTimePicker_Return = New System.Windows.Forms.DateTimePicker()
        Me.ExpextedReturnLabel_Return = New System.Windows.Forms.Label()
        Me.RentIDTextBox_Return = New System.Windows.Forms.TextBox()
        Me.RentIDLabel_Return = New System.Windows.Forms.Label()
        Me.TitleTextBox_Return = New System.Windows.Forms.TextBox()
        Me.DaysOverdueLabel_Return = New System.Windows.Forms.Label()
        Me.TitleLabel_Return = New System.Windows.Forms.Label()
        Me.FineLabel_Return = New System.Windows.Forms.Label()
        Me.DateTimePicker_Return = New System.Windows.Forms.DateTimePicker()
        Me.FineTextBox_Return = New System.Windows.Forms.TextBox()
        Me.DateOfReturnLabel_Return = New System.Windows.Forms.Label()
        Me.ConfirmationLabel_Return = New System.Windows.Forms.Label()
        Me.ChargeTextBox_Return = New System.Windows.Forms.TextBox()
        Me.OkButton_Return = New System.Windows.Forms.Button()
        Me.ChargeLabel_Return = New System.Windows.Forms.Label()
        Me.PayNowButton_Return = New System.Windows.Forms.Button()
        Me.VerifyDurationLabel_Return = New System.Windows.Forms.Label()
        Me.SearchTextBox_Return = New System.Windows.Forms.TextBox()
        Me.PaymentTabPage = New System.Windows.Forms.TabPage()
        Me.ManualPaymentCheckBox_Payment = New System.Windows.Forms.CheckBox()
        Me.AutoGeneratedGroupBox_Payment = New System.Windows.Forms.GroupBox()
        Me.PrintButton_Payment = New System.Windows.Forms.Button()
        Me.PreviewPrintButton_Payment = New System.Windows.Forms.Button()
        Me.TransactionOwnerTextBox_Payment = New System.Windows.Forms.TextBox()
        Me.TransactionOwnerLabel_Payment = New System.Windows.Forms.Label()
        Me.PaymentDateTimePicker_Payment = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.PaymentIDTextBox_Payment = New System.Windows.Forms.TextBox()
        Me.RentIDLabel_Payment = New System.Windows.Forms.Label()
        Me.PaymentIDLabel_Payment = New System.Windows.Forms.Label()
        Me.RentIDTextBox_Payment = New System.Windows.Forms.TextBox()
        Me.PaymentGroupBox_Payment = New System.Windows.Forms.GroupBox()
        Me.FineTextBox_Payment = New System.Windows.Forms.TextBox()
        Me.FineLabel_Payment = New System.Windows.Forms.Label()
        Me.ApplyButton_Payment = New System.Windows.Forms.Button()
        Me.RateLabel_Payment = New System.Windows.Forms.Label()
        Me.TotalTextBox_Payment = New System.Windows.Forms.TextBox()
        Me.TotalLabel_Payment = New System.Windows.Forms.Label()
        Me.NoOfDaysTextBox_Payment = New System.Windows.Forms.TextBox()
        Me.RateTextBox_Payment = New System.Windows.Forms.TextBox()
        Me.NoOfDaysLabel_Payment = New System.Windows.Forms.Label()
        Me.MovieGroupBox_Payment = New System.Windows.Forms.GroupBox()
        Me.CopyIDTextBox_Payment = New System.Windows.Forms.TextBox()
        Me.TitleLabel_Payment = New System.Windows.Forms.Label()
        Me.CopyIDLabel_Payment = New System.Windows.Forms.Label()
        Me.TitleTextBox_Payment = New System.Windows.Forms.TextBox()
        Me.CustomerGroupBox_Payment = New System.Windows.Forms.GroupBox()
        Me.CustomerIDTextBox_Payment = New System.Windows.Forms.TextBox()
        Me.CustomerIDLabel_Payment = New System.Windows.Forms.Label()
        Me.FullNameTextBox_Payment = New System.Windows.Forms.TextBox()
        Me.FullNameLabel_Payment = New System.Windows.Forms.Label()
        Me.AcceptedPictureBox_Payment = New System.Windows.Forms.PictureBox()
        Me.CustomerTabPage = New System.Windows.Forms.TabPage()
        Me.GroupBoxPayments_Customers = New System.Windows.Forms.GroupBox()
        Me.RadioButtonCurrPayment_Customer = New System.Windows.Forms.RadioButton()
        Me.ListViewPayments_Customers = New System.Windows.Forms.ListView()
        Me.RadioButtonOverdue_Customers = New System.Windows.Forms.RadioButton()
        Me.RadioButtonAll_Customers = New System.Windows.Forms.RadioButton()
        Me.GroupBoxCSDetails_Customer = New System.Windows.Forms.GroupBox()
        Me.ButtonSendEmail_Customer = New System.Windows.Forms.Button()
        Me.LabelBalance_Customers = New System.Windows.Forms.Label()
        Me.TextBoxBalance_Customers = New System.Windows.Forms.TextBox()
        Me.PictureBoxCustomer_Customers = New System.Windows.Forms.PictureBox()
        Me.TextBoxCustomerID_Customers = New System.Windows.Forms.TextBox()
        Me.LabelCustomerID_Customers = New System.Windows.Forms.Label()
        Me.LabelEmail_Customers = New System.Windows.Forms.Label()
        Me.ButtonEdit_Customers = New System.Windows.Forms.Button()
        Me.TextBoxAddress_Customers = New System.Windows.Forms.TextBox()
        Me.TextBoxEmail_Customers = New System.Windows.Forms.TextBox()
        Me.LabelAddress_Customers = New System.Windows.Forms.Label()
        Me.LabelFullName_Customers = New System.Windows.Forms.Label()
        Me.TextBoxFullName_Customers = New System.Windows.Forms.TextBox()
        Me.GroupBoxActiveRents_Customers = New System.Windows.Forms.GroupBox()
        Me.ListViewFullHistory_Customers = New System.Windows.Forms.ListView()
        Me.ButtonFullHistory_Customers = New System.Windows.Forms.Button()
        Me.ListViewActiveRents_Customers = New System.Windows.Forms.ListView()
        Me.LostTabPage = New System.Windows.Forms.TabPage()
        Me.ReportTabPage = New System.Windows.Forms.TabPage()
        Me.SettingTabPage = New System.Windows.Forms.TabPage()
        Me.ExitTabPage = New System.Windows.Forms.TabPage()
        Me.PaymentImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.PrintPreviewDialog_Payment = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDocument_Payment = New System.Drawing.Printing.PrintDocument()
        Me.PrintDialog_Payment = New System.Windows.Forms.PrintDialog()
        Me.ErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CatalogPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.TabControlMain.SuspendLayout()
        Me.CatalogTabPage.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBoxFilters.SuspendLayout()
        CType(Me.CoverPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchedMovieDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RentTabPage.SuspendLayout()
        Me.ReturnTabPage.SuspendLayout()
        Me.CustomerGroupBox_Return.SuspendLayout()
        Me.ReturnGroupBox_Return.SuspendLayout()
        Me.PaymentTabPage.SuspendLayout()
        Me.AutoGeneratedGroupBox_Payment.SuspendLayout()
        Me.PaymentGroupBox_Payment.SuspendLayout()
        Me.MovieGroupBox_Payment.SuspendLayout()
        Me.CustomerGroupBox_Payment.SuspendLayout()
        CType(Me.AcceptedPictureBox_Payment, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustomerTabPage.SuspendLayout()
        Me.GroupBoxPayments_Customers.SuspendLayout()
        Me.GroupBoxCSDetails_Customer.SuspendLayout()
        CType(Me.PictureBoxCustomer_Customers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxActiveRents_Customers.SuspendLayout()
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(73, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "SETTINGS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(71, 141)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "CATALOG"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(52, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 16)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "CUSTOMERS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(76, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "REPORTS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label5.Location = New System.Drawing.Point(91, 448)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "EXIT"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label6.Location = New System.Drawing.Point(32, 265)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 16)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "LOST/DAMAGED"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.LabelTimer)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.LabelWelcome)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.CatalogPictureBox)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(1044, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(161, 554)
        Me.Panel1.TabIndex = 12
        '
        'LabelTimer
        '
        Me.LabelTimer.AutoSize = True
        Me.LabelTimer.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTimer.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelTimer.Location = New System.Drawing.Point(3, 0)
        Me.LabelTimer.Name = "LabelTimer"
        Me.LabelTimer.Size = New System.Drawing.Size(98, 16)
        Me.LabelTimer.TabIndex = 15
        Me.LabelTimer.Text = "CurrentTime"
        '
        'LabelWelcome
        '
        Me.LabelWelcome.AutoSize = True
        Me.LabelWelcome.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelWelcome.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelWelcome.Location = New System.Drawing.Point(5, 37)
        Me.LabelWelcome.Name = "LabelWelcome"
        Me.LabelWelcome.Size = New System.Drawing.Size(75, 16)
        Me.LabelWelcome.TabIndex = 14
        Me.LabelWelcome.Text = "Welcome"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(76, 467)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(74, 39)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(76, 406)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(74, 39)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), System.Drawing.Image)
        Me.PictureBox6.Location = New System.Drawing.Point(76, 284)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(74, 39)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 10
        Me.PictureBox6.TabStop = False
        '
        'CatalogPictureBox
        '
        Me.CatalogPictureBox.Image = CType(resources.GetObject("CatalogPictureBox.Image"), System.Drawing.Image)
        Me.CatalogPictureBox.Location = New System.Drawing.Point(74, 160)
        Me.CatalogPictureBox.Name = "CatalogPictureBox"
        Me.CatalogPictureBox.Size = New System.Drawing.Size(74, 39)
        Me.CatalogPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.CatalogPictureBox.TabIndex = 1
        Me.CatalogPictureBox.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(74, 225)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(74, 39)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(76, 345)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(74, 39)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 3
        Me.PictureBox4.TabStop = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.MoviesToolStripMenuItem, Me.AccountsToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1205, 24)
        Me.MenuStrip1.TabIndex = 13
        Me.MenuStrip1.Text = "Welcome"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PrintToolStripMenuItem, Me.SearchToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.ToolStripMenuItem1.Text = "File"
        '
        'PrintToolStripMenuItem
        '
        Me.PrintToolStripMenuItem.Name = "PrintToolStripMenuItem"
        Me.PrintToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.PrintToolStripMenuItem.Text = "Print"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(109, 22)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'MoviesToolStripMenuItem
        '
        Me.MoviesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem1})
        Me.MoviesToolStripMenuItem.Name = "MoviesToolStripMenuItem"
        Me.MoviesToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.MoviesToolStripMenuItem.Text = "Movies"
        '
        'SearchToolStripMenuItem1
        '
        Me.SearchToolStripMenuItem1.Name = "SearchToolStripMenuItem1"
        Me.SearchToolStripMenuItem1.Size = New System.Drawing.Size(109, 22)
        Me.SearchToolStripMenuItem1.Text = "Search"
        '
        'AccountsToolStripMenuItem
        '
        Me.AccountsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserToolStripMenuItem, Me.CreateUserToolStripMenuItem, Me.DeleteAccountToolStripMenuItem})
        Me.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem"
        Me.AccountsToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.AccountsToolStripMenuItem.Text = "Accounts"
        '
        'UserToolStripMenuItem
        '
        Me.UserToolStripMenuItem.Name = "UserToolStripMenuItem"
        Me.UserToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.UserToolStripMenuItem.Text = "Current User"
        '
        'CreateUserToolStripMenuItem
        '
        Me.CreateUserToolStripMenuItem.Name = "CreateUserToolStripMenuItem"
        Me.CreateUserToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.CreateUserToolStripMenuItem.Text = "Create User"
        '
        'DeleteAccountToolStripMenuItem
        '
        Me.DeleteAccountToolStripMenuItem.Name = "DeleteAccountToolStripMenuItem"
        Me.DeleteAccountToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.DeleteAccountToolStripMenuItem.Text = "Delete Account"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InfoToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(95, 22)
        Me.InfoToolStripMenuItem.Text = "Info"
        '
        'Timer1
        '
        '
        'ImageListMovieCover
        '
        Me.ImageListMovieCover.ImageStream = CType(resources.GetObject("ImageListMovieCover.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageListMovieCover.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageListMovieCover.Images.SetKeyName(0, "Action-icon.png")
        Me.ImageListMovieCover.Images.SetKeyName(1, "Adventure-icon (1).png")
        Me.ImageListMovieCover.Images.SetKeyName(2, "Comedy-icon.png")
        Me.ImageListMovieCover.Images.SetKeyName(3, "Documentary-icon.png")
        Me.ImageListMovieCover.Images.SetKeyName(4, "Drama-icon.png")
        Me.ImageListMovieCover.Images.SetKeyName(5, "Fantasy-icon.png")
        Me.ImageListMovieCover.Images.SetKeyName(6, "Scifi-icon.png")
        Me.ImageListMovieCover.Images.SetKeyName(7, "Thriller-icon (1).png")
        '
        'TabControlMain
        '
        Me.TabControlMain.Controls.Add(Me.WelcomeTabPage)
        Me.TabControlMain.Controls.Add(Me.CatalogTabPage)
        Me.TabControlMain.Controls.Add(Me.RentTabPage)
        Me.TabControlMain.Controls.Add(Me.ReturnTabPage)
        Me.TabControlMain.Controls.Add(Me.PaymentTabPage)
        Me.TabControlMain.Controls.Add(Me.CustomerTabPage)
        Me.TabControlMain.Controls.Add(Me.LostTabPage)
        Me.TabControlMain.Controls.Add(Me.ReportTabPage)
        Me.TabControlMain.Controls.Add(Me.SettingTabPage)
        Me.TabControlMain.Controls.Add(Me.ExitTabPage)
        Me.TabControlMain.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControlMain.Location = New System.Drawing.Point(0, 24)
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        Me.TabControlMain.Size = New System.Drawing.Size(1044, 554)
        Me.TabControlMain.TabIndex = 17
        '
        'WelcomeTabPage
        '
        Me.WelcomeTabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.WelcomeTabPage.BackgroundImage = CType(resources.GetObject("WelcomeTabPage.BackgroundImage"), System.Drawing.Image)
        Me.WelcomeTabPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.WelcomeTabPage.Location = New System.Drawing.Point(4, 25)
        Me.WelcomeTabPage.Name = "WelcomeTabPage"
        Me.WelcomeTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.WelcomeTabPage.Size = New System.Drawing.Size(1036, 525)
        Me.WelcomeTabPage.TabIndex = 1
        Me.WelcomeTabPage.Text = "Welcome"
        '
        'CatalogTabPage
        '
        Me.CatalogTabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CatalogTabPage.Controls.Add(Me.FlowLayoutPanel1)
        Me.CatalogTabPage.Location = New System.Drawing.Point(4, 25)
        Me.CatalogTabPage.Name = "CatalogTabPage"
        Me.CatalogTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.CatalogTabPage.Size = New System.Drawing.Size(1036, 525)
        Me.CatalogTabPage.TabIndex = 0
        Me.CatalogTabPage.Text = "Catalog"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.FlowLayoutPanel1.Controls.Add(Me.SplitContainer1)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1030, 519)
        Me.FlowLayoutPanel1.TabIndex = 17
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.RentButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBoxFilters)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CoverPictureBox)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SearchButton)
        Me.SplitContainer1.Panel1.Controls.Add(Me.LabelCatalog)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SearchTextBox)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.SearchedMovieDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(1012, 511)
        Me.SplitContainer1.SplitterDistance = 278
        Me.SplitContainer1.TabIndex = 2
        '
        'RentButton
        '
        Me.RentButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RentButton.Location = New System.Drawing.Point(6, 250)
        Me.RentButton.Name = "RentButton"
        Me.RentButton.Size = New System.Drawing.Size(121, 25)
        Me.RentButton.TabIndex = 11
        Me.RentButton.Text = "Rent"
        Me.RentButton.UseVisualStyleBackColor = True
        '
        'GroupBoxFilters
        '
        Me.GroupBoxFilters.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.GroupBoxFilters.Controls.Add(Me.LabelCategories)
        Me.GroupBoxFilters.Controls.Add(Me.FilterButton)
        Me.GroupBoxFilters.Controls.Add(Me.ListBoxCategories)
        Me.GroupBoxFilters.Controls.Add(Me.LabelCountry)
        Me.GroupBoxFilters.Controls.Add(Me.ComboBoxCountry)
        Me.GroupBoxFilters.Controls.Add(Me.LabelLang)
        Me.GroupBoxFilters.Controls.Add(Me.ComboBoxLang)
        Me.GroupBoxFilters.Controls.Add(Me.LabelYear)
        Me.GroupBoxFilters.Controls.Add(Me.ComboBoxYear)
        Me.GroupBoxFilters.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBoxFilters.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBoxFilters.Location = New System.Drawing.Point(6, 68)
        Me.GroupBoxFilters.Name = "GroupBoxFilters"
        Me.GroupBoxFilters.Size = New System.Drawing.Size(501, 166)
        Me.GroupBoxFilters.TabIndex = 1
        Me.GroupBoxFilters.TabStop = False
        Me.GroupBoxFilters.Text = "Filters"
        '
        'LabelCategories
        '
        Me.LabelCategories.AutoSize = True
        Me.LabelCategories.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCategories.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelCategories.Location = New System.Drawing.Point(341, 15)
        Me.LabelCategories.Name = "LabelCategories"
        Me.LabelCategories.Size = New System.Drawing.Size(92, 16)
        Me.LabelCategories.TabIndex = 4
        Me.LabelCategories.Text = "Categories:"
        Me.LabelCategories.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'FilterButton
        '
        Me.FilterButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.FilterButton.Location = New System.Drawing.Point(343, 127)
        Me.FilterButton.Name = "FilterButton"
        Me.FilterButton.Size = New System.Drawing.Size(121, 25)
        Me.FilterButton.TabIndex = 10
        Me.FilterButton.Text = "Filter"
        Me.FilterButton.UseVisualStyleBackColor = True
        '
        'ListBoxCategories
        '
        Me.ListBoxCategories.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ListBoxCategories.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListBoxCategories.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBoxCategories.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ListBoxCategories.FormattingEnabled = True
        Me.ListBoxCategories.ItemHeight = 16
        Me.ListBoxCategories.Items.AddRange(New Object() {"Action", "Adventure", "Comedy", "Documentary", "Drama", "Fantasy", "Sci-fi", "Thriller"})
        Me.ListBoxCategories.Location = New System.Drawing.Point(344, 35)
        Me.ListBoxCategories.Name = "ListBoxCategories"
        Me.ListBoxCategories.Size = New System.Drawing.Size(120, 48)
        Me.ListBoxCategories.TabIndex = 3
        '
        'LabelCountry
        '
        Me.LabelCountry.AutoSize = True
        Me.LabelCountry.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelCountry.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelCountry.Location = New System.Drawing.Point(180, 15)
        Me.LabelCountry.Name = "LabelCountry"
        Me.LabelCountry.Size = New System.Drawing.Size(66, 16)
        Me.LabelCountry.TabIndex = 9
        Me.LabelCountry.Text = "Country:"
        Me.LabelCountry.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ComboBoxCountry
        '
        Me.ComboBoxCountry.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ComboBoxCountry.FormattingEnabled = True
        Me.ComboBoxCountry.Location = New System.Drawing.Point(183, 35)
        Me.ComboBoxCountry.Name = "ComboBoxCountry"
        Me.ComboBoxCountry.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxCountry.TabIndex = 8
        '
        'LabelLang
        '
        Me.LabelLang.AutoSize = True
        Me.LabelLang.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelLang.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelLang.Location = New System.Drawing.Point(39, 66)
        Me.LabelLang.Name = "LabelLang"
        Me.LabelLang.Size = New System.Drawing.Size(77, 16)
        Me.LabelLang.TabIndex = 7
        Me.LabelLang.Text = "Language:"
        Me.LabelLang.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ComboBoxLang
        '
        Me.ComboBoxLang.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ComboBoxLang.FormattingEnabled = True
        Me.ComboBoxLang.Location = New System.Drawing.Point(42, 86)
        Me.ComboBoxLang.Name = "ComboBoxLang"
        Me.ComboBoxLang.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxLang.TabIndex = 6
        '
        'LabelYear
        '
        Me.LabelYear.AutoSize = True
        Me.LabelYear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.LabelYear.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelYear.Location = New System.Drawing.Point(39, 15)
        Me.LabelYear.Name = "LabelYear"
        Me.LabelYear.Size = New System.Drawing.Size(43, 16)
        Me.LabelYear.TabIndex = 5
        Me.LabelYear.Text = "Year:"
        Me.LabelYear.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ComboBoxYear
        '
        Me.ComboBoxYear.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.ComboBoxYear.FormattingEnabled = True
        Me.ComboBoxYear.Location = New System.Drawing.Point(42, 35)
        Me.ComboBoxYear.Name = "ComboBoxYear"
        Me.ComboBoxYear.Size = New System.Drawing.Size(121, 24)
        Me.ComboBoxYear.TabIndex = 0
        '
        'CoverPictureBox
        '
        Me.CoverPictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CoverPictureBox.Location = New System.Drawing.Point(551, 47)
        Me.CoverPictureBox.Name = "CoverPictureBox"
        Me.CoverPictureBox.Size = New System.Drawing.Size(436, 217)
        Me.CoverPictureBox.TabIndex = 0
        Me.CoverPictureBox.TabStop = False
        '
        'SearchButton
        '
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.Location = New System.Drawing.Point(278, 28)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(75, 23)
        Me.SearchButton.TabIndex = 2
        Me.SearchButton.Text = "Go"
        Me.SearchButton.UseVisualStyleBackColor = True
        '
        'LabelCatalog
        '
        Me.LabelCatalog.AutoSize = True
        Me.LabelCatalog.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelCatalog.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LabelCatalog.Location = New System.Drawing.Point(3, 31)
        Me.LabelCatalog.Name = "LabelCatalog"
        Me.LabelCatalog.Size = New System.Drawing.Size(69, 16)
        Me.LabelCatalog.TabIndex = 1
        Me.LabelCatalog.Text = "Catalog:"
        Me.LabelCatalog.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'SearchTextBox
        '
        Me.SearchTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SearchTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.SearchTextBox.Location = New System.Drawing.Point(78, 30)
        Me.SearchTextBox.Name = "SearchTextBox"
        Me.SearchTextBox.Size = New System.Drawing.Size(184, 20)
        Me.SearchTextBox.TabIndex = 0
        Me.SearchTextBox.Text = "Search.."
        '
        'SearchedMovieDataGridView
        '
        Me.SearchedMovieDataGridView.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.SearchedMovieDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.SearchedMovieDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SearchedMovieDataGridView.Location = New System.Drawing.Point(2, 3)
        Me.SearchedMovieDataGridView.MultiSelect = False
        Me.SearchedMovieDataGridView.Name = "SearchedMovieDataGridView"
        Me.SearchedMovieDataGridView.Size = New System.Drawing.Size(1012, 220)
        Me.SearchedMovieDataGridView.TabIndex = 3
        '
        'RentTabPage
        '
        Me.RentTabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.RentTabPage.Controls.Add(Me.ConfirmationLabel)
        Me.RentTabPage.Controls.Add(Me.ConfirmRentButton)
        Me.RentTabPage.Controls.Add(Me.PaymentButton)
        Me.RentTabPage.Controls.Add(Me.ChooseCopyLabel)
        Me.RentTabPage.Controls.Add(Me.ChooseCopyComboBox_Rent)
        Me.RentTabPage.Controls.Add(Me.ClientAccountButton)
        Me.RentTabPage.Controls.Add(Me.ClientNotFoundLabel)
        Me.RentTabPage.Controls.Add(Me.BalanceLabel)
        Me.RentTabPage.Controls.Add(Me.BalanceTextBox)
        Me.RentTabPage.Controls.Add(Me.FullNameLabel)
        Me.RentTabPage.Controls.Add(Me.FullNameTextBox)
        Me.RentTabPage.Controls.Add(Me.IDLabel)
        Me.RentTabPage.Controls.Add(Me.IDTextBox)
        Me.RentTabPage.Controls.Add(Me.CustomerLabel)
        Me.RentTabPage.Controls.Add(Me.CustomerTextBox)
        Me.RentTabPage.Controls.Add(Me.Label7)
        Me.RentTabPage.Controls.Add(Me.MonthCalendar_Rent)
        Me.RentTabPage.Controls.Add(Me.DateLabel)
        Me.RentTabPage.Controls.Add(Me.AvailabilityLabel)
        Me.RentTabPage.Controls.Add(Me.DateTimePicker_Rent)
        Me.RentTabPage.Controls.Add(Me.MovieTitleLabel)
        Me.RentTabPage.Controls.Add(Me.MovieTitleTextBox)
        Me.RentTabPage.Location = New System.Drawing.Point(4, 25)
        Me.RentTabPage.Name = "RentTabPage"
        Me.RentTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.RentTabPage.Size = New System.Drawing.Size(1036, 525)
        Me.RentTabPage.TabIndex = 7
        Me.RentTabPage.Text = "Rent"
        '
        'ConfirmationLabel
        '
        Me.ConfirmationLabel.AutoSize = True
        Me.ConfirmationLabel.ForeColor = System.Drawing.Color.LimeGreen
        Me.ConfirmationLabel.Location = New System.Drawing.Point(386, 304)
        Me.ConfirmationLabel.Name = "ConfirmationLabel"
        Me.ConfirmationLabel.Size = New System.Drawing.Size(133, 16)
        Me.ConfirmationLabel.TabIndex = 21
        Me.ConfirmationLabel.Text = "ConfirmationLabel"
        '
        'ConfirmRentButton
        '
        Me.ConfirmRentButton.AutoSize = True
        Me.ConfirmRentButton.Location = New System.Drawing.Point(266, 304)
        Me.ConfirmRentButton.Name = "ConfirmRentButton"
        Me.ConfirmRentButton.Size = New System.Drawing.Size(97, 26)
        Me.ConfirmRentButton.TabIndex = 20
        Me.ConfirmRentButton.Text = "OK"
        Me.ConfirmRentButton.UseVisualStyleBackColor = True
        '
        'PaymentButton
        '
        Me.PaymentButton.AutoSize = True
        Me.PaymentButton.Location = New System.Drawing.Point(163, 304)
        Me.PaymentButton.Name = "PaymentButton"
        Me.PaymentButton.Size = New System.Drawing.Size(97, 26)
        Me.PaymentButton.TabIndex = 19
        Me.PaymentButton.Text = "Pay now"
        Me.PaymentButton.UseVisualStyleBackColor = True
        '
        'ChooseCopyLabel
        '
        Me.ChooseCopyLabel.AutoSize = True
        Me.ChooseCopyLabel.Location = New System.Drawing.Point(58, 277)
        Me.ChooseCopyLabel.Name = "ChooseCopyLabel"
        Me.ChooseCopyLabel.Size = New System.Drawing.Size(99, 16)
        Me.ChooseCopyLabel.TabIndex = 18
        Me.ChooseCopyLabel.Text = "Choose copy"
        '
        'ChooseCopyComboBox_Rent
        '
        Me.ChooseCopyComboBox_Rent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ChooseCopyComboBox_Rent.FormattingEnabled = True
        Me.ChooseCopyComboBox_Rent.Location = New System.Drawing.Point(163, 274)
        Me.ChooseCopyComboBox_Rent.Name = "ChooseCopyComboBox_Rent"
        Me.ChooseCopyComboBox_Rent.Size = New System.Drawing.Size(97, 24)
        Me.ChooseCopyComboBox_Rent.TabIndex = 17
        '
        'ClientAccountButton
        '
        Me.ClientAccountButton.AutoSize = True
        Me.ClientAccountButton.Location = New System.Drawing.Point(163, 210)
        Me.ClientAccountButton.Name = "ClientAccountButton"
        Me.ClientAccountButton.Size = New System.Drawing.Size(155, 26)
        Me.ClientAccountButton.TabIndex = 16
        Me.ClientAccountButton.Text = "See client account"
        Me.ClientAccountButton.UseVisualStyleBackColor = True
        '
        'ClientNotFoundLabel
        '
        Me.ClientNotFoundLabel.AutoSize = True
        Me.ClientNotFoundLabel.ForeColor = System.Drawing.Color.Red
        Me.ClientNotFoundLabel.Location = New System.Drawing.Point(187, 107)
        Me.ClientNotFoundLabel.Name = "ClientNotFoundLabel"
        Me.ClientNotFoundLabel.Size = New System.Drawing.Size(153, 16)
        Me.ClientNotFoundLabel.TabIndex = 15
        Me.ClientNotFoundLabel.Text = "ClientNotFoundLabel"
        Me.ClientNotFoundLabel.Visible = False
        '
        'BalanceLabel
        '
        Me.BalanceLabel.AutoSize = True
        Me.BalanceLabel.Location = New System.Drawing.Point(92, 185)
        Me.BalanceLabel.Name = "BalanceLabel"
        Me.BalanceLabel.Size = New System.Drawing.Size(65, 16)
        Me.BalanceLabel.TabIndex = 14
        Me.BalanceLabel.Text = "Balance"
        '
        'BalanceTextBox
        '
        Me.BalanceTextBox.Location = New System.Drawing.Point(163, 182)
        Me.BalanceTextBox.Name = "BalanceTextBox"
        Me.BalanceTextBox.ReadOnly = True
        Me.BalanceTextBox.Size = New System.Drawing.Size(200, 22)
        Me.BalanceTextBox.TabIndex = 13
        '
        'FullNameLabel
        '
        Me.FullNameLabel.AutoSize = True
        Me.FullNameLabel.Location = New System.Drawing.Point(108, 157)
        Me.FullNameLabel.Name = "FullNameLabel"
        Me.FullNameLabel.Size = New System.Drawing.Size(49, 16)
        Me.FullNameLabel.TabIndex = 12
        Me.FullNameLabel.Text = "Name"
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.Location = New System.Drawing.Point(163, 154)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.ReadOnly = True
        Me.FullNameTextBox.Size = New System.Drawing.Size(200, 22)
        Me.FullNameTextBox.TabIndex = 11
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.Location = New System.Drawing.Point(134, 129)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(23, 16)
        Me.IDLabel.TabIndex = 10
        Me.IDLabel.Text = "ID"
        '
        'IDTextBox
        '
        Me.IDTextBox.Location = New System.Drawing.Point(163, 126)
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.ReadOnly = True
        Me.IDTextBox.Size = New System.Drawing.Size(200, 22)
        Me.IDTextBox.TabIndex = 9
        '
        'CustomerLabel
        '
        Me.CustomerLabel.AutoSize = True
        Me.CustomerLabel.Location = New System.Drawing.Point(84, 77)
        Me.CustomerLabel.Name = "CustomerLabel"
        Me.CustomerLabel.Size = New System.Drawing.Size(73, 16)
        Me.CustomerLabel.TabIndex = 8
        Me.CustomerLabel.Text = "Customer"
        '
        'CustomerTextBox
        '
        Me.CustomerTextBox.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.CustomerTextBox.Location = New System.Drawing.Point(163, 74)
        Me.CustomerTextBox.Name = "CustomerTextBox"
        Me.CustomerTextBox.Size = New System.Drawing.Size(200, 22)
        Me.CustomerTextBox.TabIndex = 7
        Me.CustomerTextBox.Text = "ID\Surname"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(424, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 16)
        Me.Label7.TabIndex = 6
        '
        'MonthCalendar_Rent
        '
        Me.MonthCalendar_Rent.Location = New System.Drawing.Point(522, 46)
        Me.MonthCalendar_Rent.Name = "MonthCalendar_Rent"
        Me.MonthCalendar_Rent.TabIndex = 5
        '
        'DateLabel
        '
        Me.DateLabel.AutoSize = True
        Me.DateLabel.Location = New System.Drawing.Point(69, 251)
        Me.DateLabel.Name = "DateLabel"
        Me.DateLabel.Size = New System.Drawing.Size(88, 16)
        Me.DateLabel.TabIndex = 4
        Me.DateLabel.Text = "Return date"
        '
        'AvailabilityLabel
        '
        Me.AvailabilityLabel.AutoSize = True
        Me.AvailabilityLabel.ForeColor = System.Drawing.Color.LimeGreen
        Me.AvailabilityLabel.Location = New System.Drawing.Point(386, 49)
        Me.AvailabilityLabel.Name = "AvailabilityLabel"
        Me.AvailabilityLabel.Size = New System.Drawing.Size(124, 16)
        Me.AvailabilityLabel.TabIndex = 3
        Me.AvailabilityLabel.Text = "AvailabilityLabel"
        Me.AvailabilityLabel.Visible = False
        '
        'DateTimePicker_Rent
        '
        Me.DateTimePicker_Rent.Location = New System.Drawing.Point(163, 246)
        Me.DateTimePicker_Rent.Name = "DateTimePicker_Rent"
        Me.DateTimePicker_Rent.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker_Rent.TabIndex = 2
        '
        'MovieTitleLabel
        '
        Me.MovieTitleLabel.AutoSize = True
        Me.MovieTitleLabel.Location = New System.Drawing.Point(118, 49)
        Me.MovieTitleLabel.Name = "MovieTitleLabel"
        Me.MovieTitleLabel.Size = New System.Drawing.Size(39, 16)
        Me.MovieTitleLabel.TabIndex = 1
        Me.MovieTitleLabel.Text = "Title"
        '
        'MovieTitleTextBox
        '
        Me.MovieTitleTextBox.Location = New System.Drawing.Point(163, 46)
        Me.MovieTitleTextBox.Name = "MovieTitleTextBox"
        Me.MovieTitleTextBox.ReadOnly = True
        Me.MovieTitleTextBox.Size = New System.Drawing.Size(200, 22)
        Me.MovieTitleTextBox.TabIndex = 0
        '
        'ReturnTabPage
        '
        Me.ReturnTabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ReturnTabPage.Controls.Add(Me.CustomerGroupBox_Return)
        Me.ReturnTabPage.Controls.Add(Me.SearchLabel_Return)
        Me.ReturnTabPage.Controls.Add(Me.ReturnGroupBox_Return)
        Me.ReturnTabPage.Controls.Add(Me.VerifyDurationLabel_Return)
        Me.ReturnTabPage.Controls.Add(Me.SearchTextBox_Return)
        Me.ReturnTabPage.Location = New System.Drawing.Point(4, 25)
        Me.ReturnTabPage.Name = "ReturnTabPage"
        Me.ReturnTabPage.Size = New System.Drawing.Size(1036, 525)
        Me.ReturnTabPage.TabIndex = 8
        Me.ReturnTabPage.Text = "Return"
        '
        'CustomerGroupBox_Return
        '
        Me.CustomerGroupBox_Return.Controls.Add(Me.CustomerIDTextBox_Return)
        Me.CustomerGroupBox_Return.Controls.Add(Me.CustomerIDLabel_Return)
        Me.CustomerGroupBox_Return.Controls.Add(Me.CustomerFullNameTextBox_Return)
        Me.CustomerGroupBox_Return.Controls.Add(Me.CustomerFullNameLabel_Return)
        Me.CustomerGroupBox_Return.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CustomerGroupBox_Return.Location = New System.Drawing.Point(59, 279)
        Me.CustomerGroupBox_Return.Name = "CustomerGroupBox_Return"
        Me.CustomerGroupBox_Return.Size = New System.Drawing.Size(611, 81)
        Me.CustomerGroupBox_Return.TabIndex = 47
        Me.CustomerGroupBox_Return.TabStop = False
        Me.CustomerGroupBox_Return.Text = "Client"
        '
        'CustomerIDTextBox_Return
        '
        Me.CustomerIDTextBox_Return.Location = New System.Drawing.Point(111, 36)
        Me.CustomerIDTextBox_Return.Name = "CustomerIDTextBox_Return"
        Me.CustomerIDTextBox_Return.ReadOnly = True
        Me.CustomerIDTextBox_Return.Size = New System.Drawing.Size(200, 22)
        Me.CustomerIDTextBox_Return.TabIndex = 45
        '
        'CustomerIDLabel_Return
        '
        Me.CustomerIDLabel_Return.AutoSize = True
        Me.CustomerIDLabel_Return.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CustomerIDLabel_Return.Location = New System.Drawing.Point(13, 39)
        Me.CustomerIDLabel_Return.Name = "CustomerIDLabel_Return"
        Me.CustomerIDLabel_Return.Size = New System.Drawing.Size(92, 16)
        Me.CustomerIDLabel_Return.TabIndex = 27
        Me.CustomerIDLabel_Return.Text = "Customer ID"
        '
        'CustomerFullNameTextBox_Return
        '
        Me.CustomerFullNameTextBox_Return.Location = New System.Drawing.Point(381, 34)
        Me.CustomerFullNameTextBox_Return.Name = "CustomerFullNameTextBox_Return"
        Me.CustomerFullNameTextBox_Return.ReadOnly = True
        Me.CustomerFullNameTextBox_Return.Size = New System.Drawing.Size(200, 22)
        Me.CustomerFullNameTextBox_Return.TabIndex = 30
        '
        'CustomerFullNameLabel_Return
        '
        Me.CustomerFullNameLabel_Return.AutoSize = True
        Me.CustomerFullNameLabel_Return.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CustomerFullNameLabel_Return.Location = New System.Drawing.Point(326, 39)
        Me.CustomerFullNameLabel_Return.Name = "CustomerFullNameLabel_Return"
        Me.CustomerFullNameLabel_Return.Size = New System.Drawing.Size(49, 16)
        Me.CustomerFullNameLabel_Return.TabIndex = 31
        Me.CustomerFullNameLabel_Return.Text = "Name"
        '
        'SearchLabel_Return
        '
        Me.SearchLabel_Return.AutoSize = True
        Me.SearchLabel_Return.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.SearchLabel_Return.Location = New System.Drawing.Point(63, 13)
        Me.SearchLabel_Return.Name = "SearchLabel_Return"
        Me.SearchLabel_Return.Size = New System.Drawing.Size(57, 16)
        Me.SearchLabel_Return.TabIndex = 29
        Me.SearchLabel_Return.Text = "Search"
        '
        'ReturnGroupBox_Return
        '
        Me.ReturnGroupBox_Return.Controls.Add(Me.DaysOverdueTextBox_Return)
        Me.ReturnGroupBox_Return.Controls.Add(Me.ExpectedReturnDateTimePicker_Return)
        Me.ReturnGroupBox_Return.Controls.Add(Me.ExpextedReturnLabel_Return)
        Me.ReturnGroupBox_Return.Controls.Add(Me.RentIDTextBox_Return)
        Me.ReturnGroupBox_Return.Controls.Add(Me.RentIDLabel_Return)
        Me.ReturnGroupBox_Return.Controls.Add(Me.TitleTextBox_Return)
        Me.ReturnGroupBox_Return.Controls.Add(Me.DaysOverdueLabel_Return)
        Me.ReturnGroupBox_Return.Controls.Add(Me.TitleLabel_Return)
        Me.ReturnGroupBox_Return.Controls.Add(Me.FineLabel_Return)
        Me.ReturnGroupBox_Return.Controls.Add(Me.DateTimePicker_Return)
        Me.ReturnGroupBox_Return.Controls.Add(Me.FineTextBox_Return)
        Me.ReturnGroupBox_Return.Controls.Add(Me.DateOfReturnLabel_Return)
        Me.ReturnGroupBox_Return.Controls.Add(Me.ConfirmationLabel_Return)
        Me.ReturnGroupBox_Return.Controls.Add(Me.ChargeTextBox_Return)
        Me.ReturnGroupBox_Return.Controls.Add(Me.OkButton_Return)
        Me.ReturnGroupBox_Return.Controls.Add(Me.ChargeLabel_Return)
        Me.ReturnGroupBox_Return.Controls.Add(Me.PayNowButton_Return)
        Me.ReturnGroupBox_Return.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ReturnGroupBox_Return.Location = New System.Drawing.Point(59, 43)
        Me.ReturnGroupBox_Return.Name = "ReturnGroupBox_Return"
        Me.ReturnGroupBox_Return.Size = New System.Drawing.Size(611, 214)
        Me.ReturnGroupBox_Return.TabIndex = 46
        Me.ReturnGroupBox_Return.TabStop = False
        Me.ReturnGroupBox_Return.Text = "Return"
        '
        'DaysOverdueTextBox_Return
        '
        Me.DaysOverdueTextBox_Return.Location = New System.Drawing.Point(388, 89)
        Me.DaysOverdueTextBox_Return.Name = "DaysOverdueTextBox_Return"
        Me.DaysOverdueTextBox_Return.ReadOnly = True
        Me.DaysOverdueTextBox_Return.Size = New System.Drawing.Size(97, 22)
        Me.DaysOverdueTextBox_Return.TabIndex = 49
        Me.DaysOverdueTextBox_Return.Visible = False
        '
        'ExpectedReturnDateTimePicker_Return
        '
        Me.ExpectedReturnDateTimePicker_Return.Location = New System.Drawing.Point(347, 175)
        Me.ExpectedReturnDateTimePicker_Return.Name = "ExpectedReturnDateTimePicker_Return"
        Me.ExpectedReturnDateTimePicker_Return.Size = New System.Drawing.Size(200, 22)
        Me.ExpectedReturnDateTimePicker_Return.TabIndex = 48
        Me.ExpectedReturnDateTimePicker_Return.Visible = False
        '
        'ExpextedReturnLabel_Return
        '
        Me.ExpextedReturnLabel_Return.AutoSize = True
        Me.ExpextedReturnLabel_Return.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ExpextedReturnLabel_Return.Location = New System.Drawing.Point(344, 151)
        Me.ExpextedReturnLabel_Return.Name = "ExpextedReturnLabel_Return"
        Me.ExpextedReturnLabel_Return.Size = New System.Drawing.Size(168, 16)
        Me.ExpextedReturnLabel_Return.TabIndex = 47
        Me.ExpextedReturnLabel_Return.Text = "Expected date of return"
        Me.ExpextedReturnLabel_Return.Visible = False
        '
        'RentIDTextBox_Return
        '
        Me.RentIDTextBox_Return.Location = New System.Drawing.Point(111, 34)
        Me.RentIDTextBox_Return.Name = "RentIDTextBox_Return"
        Me.RentIDTextBox_Return.ReadOnly = True
        Me.RentIDTextBox_Return.Size = New System.Drawing.Size(200, 22)
        Me.RentIDTextBox_Return.TabIndex = 45
        '
        'RentIDLabel_Return
        '
        Me.RentIDLabel_Return.AutoSize = True
        Me.RentIDLabel_Return.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RentIDLabel_Return.Location = New System.Drawing.Point(46, 37)
        Me.RentIDLabel_Return.Name = "RentIDLabel_Return"
        Me.RentIDLabel_Return.Size = New System.Drawing.Size(59, 16)
        Me.RentIDLabel_Return.TabIndex = 46
        Me.RentIDLabel_Return.Text = "Rent ID"
        '
        'TitleTextBox_Return
        '
        Me.TitleTextBox_Return.Location = New System.Drawing.Point(111, 62)
        Me.TitleTextBox_Return.Name = "TitleTextBox_Return"
        Me.TitleTextBox_Return.ReadOnly = True
        Me.TitleTextBox_Return.Size = New System.Drawing.Size(200, 22)
        Me.TitleTextBox_Return.TabIndex = 21
        '
        'DaysOverdueLabel_Return
        '
        Me.DaysOverdueLabel_Return.AutoSize = True
        Me.DaysOverdueLabel_Return.ForeColor = System.Drawing.Color.Red
        Me.DaysOverdueLabel_Return.Location = New System.Drawing.Point(491, 93)
        Me.DaysOverdueLabel_Return.Name = "DaysOverdueLabel_Return"
        Me.DaysOverdueLabel_Return.Size = New System.Drawing.Size(105, 16)
        Me.DaysOverdueLabel_Return.TabIndex = 44
        Me.DaysOverdueLabel_Return.Text = "Days overdue"
        Me.DaysOverdueLabel_Return.Visible = False
        '
        'TitleLabel_Return
        '
        Me.TitleLabel_Return.AutoSize = True
        Me.TitleLabel_Return.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TitleLabel_Return.Location = New System.Drawing.Point(66, 65)
        Me.TitleLabel_Return.Name = "TitleLabel_Return"
        Me.TitleLabel_Return.Size = New System.Drawing.Size(39, 16)
        Me.TitleLabel_Return.TabIndex = 22
        Me.TitleLabel_Return.Text = "Title"
        '
        'FineLabel_Return
        '
        Me.FineLabel_Return.AutoSize = True
        Me.FineLabel_Return.ForeColor = System.Drawing.Color.Red
        Me.FineLabel_Return.Location = New System.Drawing.Point(344, 121)
        Me.FineLabel_Return.Name = "FineLabel_Return"
        Me.FineLabel_Return.Size = New System.Drawing.Size(38, 16)
        Me.FineLabel_Return.TabIndex = 43
        Me.FineLabel_Return.Text = "Fine"
        Me.FineLabel_Return.Visible = False
        '
        'DateTimePicker_Return
        '
        Me.DateTimePicker_Return.Location = New System.Drawing.Point(111, 90)
        Me.DateTimePicker_Return.Name = "DateTimePicker_Return"
        Me.DateTimePicker_Return.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker_Return.TabIndex = 23
        '
        'FineTextBox_Return
        '
        Me.FineTextBox_Return.Location = New System.Drawing.Point(388, 118)
        Me.FineTextBox_Return.Name = "FineTextBox_Return"
        Me.FineTextBox_Return.ReadOnly = True
        Me.FineTextBox_Return.Size = New System.Drawing.Size(97, 22)
        Me.FineTextBox_Return.TabIndex = 42
        Me.FineTextBox_Return.Visible = False
        '
        'DateOfReturnLabel_Return
        '
        Me.DateOfReturnLabel_Return.AutoSize = True
        Me.DateOfReturnLabel_Return.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.DateOfReturnLabel_Return.Location = New System.Drawing.Point(4, 95)
        Me.DateOfReturnLabel_Return.Name = "DateOfReturnLabel_Return"
        Me.DateOfReturnLabel_Return.Size = New System.Drawing.Size(101, 16)
        Me.DateOfReturnLabel_Return.TabIndex = 25
        Me.DateOfReturnLabel_Return.Text = "Date of return"
        '
        'ConfirmationLabel_Return
        '
        Me.ConfirmationLabel_Return.AutoSize = True
        Me.ConfirmationLabel_Return.ForeColor = System.Drawing.Color.LimeGreen
        Me.ConfirmationLabel_Return.Location = New System.Drawing.Point(108, 184)
        Me.ConfirmationLabel_Return.Name = "ConfirmationLabel_Return"
        Me.ConfirmationLabel_Return.Size = New System.Drawing.Size(186, 16)
        Me.ConfirmationLabel_Return.TabIndex = 40
        Me.ConfirmationLabel_Return.Text = "ConfirmationLabel_Return"
        Me.ConfirmationLabel_Return.Visible = False
        '
        'ChargeTextBox_Return
        '
        Me.ChargeTextBox_Return.Location = New System.Drawing.Point(111, 118)
        Me.ChargeTextBox_Return.Name = "ChargeTextBox_Return"
        Me.ChargeTextBox_Return.ReadOnly = True
        Me.ChargeTextBox_Return.Size = New System.Drawing.Size(200, 22)
        Me.ChargeTextBox_Return.TabIndex = 32
        '
        'OkButton_Return
        '
        Me.OkButton_Return.AutoSize = True
        Me.OkButton_Return.Location = New System.Drawing.Point(214, 146)
        Me.OkButton_Return.Name = "OkButton_Return"
        Me.OkButton_Return.Size = New System.Drawing.Size(97, 26)
        Me.OkButton_Return.TabIndex = 39
        Me.OkButton_Return.Text = "OK"
        Me.OkButton_Return.UseVisualStyleBackColor = True
        '
        'ChargeLabel_Return
        '
        Me.ChargeLabel_Return.AutoSize = True
        Me.ChargeLabel_Return.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ChargeLabel_Return.Location = New System.Drawing.Point(47, 121)
        Me.ChargeLabel_Return.Name = "ChargeLabel_Return"
        Me.ChargeLabel_Return.Size = New System.Drawing.Size(58, 16)
        Me.ChargeLabel_Return.TabIndex = 33
        Me.ChargeLabel_Return.Text = "Charge"
        '
        'PayNowButton_Return
        '
        Me.PayNowButton_Return.AutoSize = True
        Me.PayNowButton_Return.Enabled = False
        Me.PayNowButton_Return.Location = New System.Drawing.Point(111, 146)
        Me.PayNowButton_Return.Name = "PayNowButton_Return"
        Me.PayNowButton_Return.Size = New System.Drawing.Size(97, 26)
        Me.PayNowButton_Return.TabIndex = 38
        Me.PayNowButton_Return.Text = "Pay"
        Me.PayNowButton_Return.UseVisualStyleBackColor = True
        '
        'VerifyDurationLabel_Return
        '
        Me.VerifyDurationLabel_Return.AutoSize = True
        Me.VerifyDurationLabel_Return.ForeColor = System.Drawing.Color.LimeGreen
        Me.VerifyDurationLabel_Return.Location = New System.Drawing.Point(346, 13)
        Me.VerifyDurationLabel_Return.Name = "VerifyDurationLabel_Return"
        Me.VerifyDurationLabel_Return.Size = New System.Drawing.Size(198, 16)
        Me.VerifyDurationLabel_Return.TabIndex = 41
        Me.VerifyDurationLabel_Return.Text = "VerifyDurationLabel_Return"
        Me.VerifyDurationLabel_Return.Visible = False
        '
        'SearchTextBox_Return
        '
        Me.SearchTextBox_Return.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.SearchTextBox_Return.Location = New System.Drawing.Point(132, 10)
        Me.SearchTextBox_Return.Name = "SearchTextBox_Return"
        Me.SearchTextBox_Return.Size = New System.Drawing.Size(200, 22)
        Me.SearchTextBox_Return.TabIndex = 28
        Me.SearchTextBox_Return.Text = "type copy ID"
        '
        'PaymentTabPage
        '
        Me.PaymentTabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.PaymentTabPage.Controls.Add(Me.ManualPaymentCheckBox_Payment)
        Me.PaymentTabPage.Controls.Add(Me.AutoGeneratedGroupBox_Payment)
        Me.PaymentTabPage.Controls.Add(Me.PaymentGroupBox_Payment)
        Me.PaymentTabPage.Controls.Add(Me.MovieGroupBox_Payment)
        Me.PaymentTabPage.Controls.Add(Me.CustomerGroupBox_Payment)
        Me.PaymentTabPage.Controls.Add(Me.AcceptedPictureBox_Payment)
        Me.PaymentTabPage.Location = New System.Drawing.Point(4, 25)
        Me.PaymentTabPage.Name = "PaymentTabPage"
        Me.PaymentTabPage.Size = New System.Drawing.Size(1036, 525)
        Me.PaymentTabPage.TabIndex = 9
        Me.PaymentTabPage.Text = "Payment"
        '
        'ManualPaymentCheckBox_Payment
        '
        Me.ManualPaymentCheckBox_Payment.AutoSize = True
        Me.ManualPaymentCheckBox_Payment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ManualPaymentCheckBox_Payment.Location = New System.Drawing.Point(471, 9)
        Me.ManualPaymentCheckBox_Payment.Name = "ManualPaymentCheckBox_Payment"
        Me.ManualPaymentCheckBox_Payment.Size = New System.Drawing.Size(141, 20)
        Me.ManualPaymentCheckBox_Payment.TabIndex = 55
        Me.ManualPaymentCheckBox_Payment.Text = "Manual Payment"
        Me.ManualPaymentCheckBox_Payment.UseVisualStyleBackColor = True
        '
        'AutoGeneratedGroupBox_Payment
        '
        Me.AutoGeneratedGroupBox_Payment.Controls.Add(Me.PrintButton_Payment)
        Me.AutoGeneratedGroupBox_Payment.Controls.Add(Me.PreviewPrintButton_Payment)
        Me.AutoGeneratedGroupBox_Payment.Controls.Add(Me.TransactionOwnerTextBox_Payment)
        Me.AutoGeneratedGroupBox_Payment.Controls.Add(Me.TransactionOwnerLabel_Payment)
        Me.AutoGeneratedGroupBox_Payment.Controls.Add(Me.PaymentDateTimePicker_Payment)
        Me.AutoGeneratedGroupBox_Payment.Controls.Add(Me.Label8)
        Me.AutoGeneratedGroupBox_Payment.Controls.Add(Me.PaymentIDTextBox_Payment)
        Me.AutoGeneratedGroupBox_Payment.Controls.Add(Me.RentIDLabel_Payment)
        Me.AutoGeneratedGroupBox_Payment.Controls.Add(Me.PaymentIDLabel_Payment)
        Me.AutoGeneratedGroupBox_Payment.Controls.Add(Me.RentIDTextBox_Payment)
        Me.AutoGeneratedGroupBox_Payment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.AutoGeneratedGroupBox_Payment.Location = New System.Drawing.Point(473, 31)
        Me.AutoGeneratedGroupBox_Payment.Name = "AutoGeneratedGroupBox_Payment"
        Me.AutoGeneratedGroupBox_Payment.Size = New System.Drawing.Size(358, 193)
        Me.AutoGeneratedGroupBox_Payment.TabIndex = 53
        Me.AutoGeneratedGroupBox_Payment.TabStop = False
        Me.AutoGeneratedGroupBox_Payment.Text = "Auto Generated"
        '
        'PrintButton_Payment
        '
        Me.PrintButton_Payment.AutoSize = True
        Me.PrintButton_Payment.Location = New System.Drawing.Point(123, 146)
        Me.PrintButton_Payment.Name = "PrintButton_Payment"
        Me.PrintButton_Payment.Size = New System.Drawing.Size(108, 26)
        Me.PrintButton_Payment.TabIndex = 56
        Me.PrintButton_Payment.Text = "Print"
        Me.PrintButton_Payment.UseVisualStyleBackColor = True
        '
        'PreviewPrintButton_Payment
        '
        Me.PreviewPrintButton_Payment.AutoSize = True
        Me.PreviewPrintButton_Payment.Location = New System.Drawing.Point(9, 146)
        Me.PreviewPrintButton_Payment.Name = "PreviewPrintButton_Payment"
        Me.PreviewPrintButton_Payment.Size = New System.Drawing.Size(108, 26)
        Me.PreviewPrintButton_Payment.TabIndex = 55
        Me.PreviewPrintButton_Payment.Text = "Preview Print"
        Me.PreviewPrintButton_Payment.UseVisualStyleBackColor = True
        '
        'TransactionOwnerTextBox_Payment
        '
        Me.TransactionOwnerTextBox_Payment.Location = New System.Drawing.Point(149, 105)
        Me.TransactionOwnerTextBox_Payment.Name = "TransactionOwnerTextBox_Payment"
        Me.TransactionOwnerTextBox_Payment.ReadOnly = True
        Me.TransactionOwnerTextBox_Payment.Size = New System.Drawing.Size(100, 22)
        Me.TransactionOwnerTextBox_Payment.TabIndex = 50
        '
        'TransactionOwnerLabel_Payment
        '
        Me.TransactionOwnerLabel_Payment.AutoSize = True
        Me.TransactionOwnerLabel_Payment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TransactionOwnerLabel_Payment.Location = New System.Drawing.Point(6, 108)
        Me.TransactionOwnerLabel_Payment.Name = "TransactionOwnerLabel_Payment"
        Me.TransactionOwnerLabel_Payment.Size = New System.Drawing.Size(137, 16)
        Me.TransactionOwnerLabel_Payment.TabIndex = 51
        Me.TransactionOwnerLabel_Payment.Text = "Transaction Owner"
        '
        'PaymentDateTimePicker_Payment
        '
        Me.PaymentDateTimePicker_Payment.Location = New System.Drawing.Point(149, 74)
        Me.PaymentDateTimePicker_Payment.Name = "PaymentDateTimePicker_Payment"
        Me.PaymentDateTimePicker_Payment.Size = New System.Drawing.Size(200, 22)
        Me.PaymentDateTimePicker_Payment.TabIndex = 49
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(38, 79)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(105, 16)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Payment Date"
        '
        'PaymentIDTextBox_Payment
        '
        Me.PaymentIDTextBox_Payment.Location = New System.Drawing.Point(149, 46)
        Me.PaymentIDTextBox_Payment.Name = "PaymentIDTextBox_Payment"
        Me.PaymentIDTextBox_Payment.ReadOnly = True
        Me.PaymentIDTextBox_Payment.Size = New System.Drawing.Size(100, 22)
        Me.PaymentIDTextBox_Payment.TabIndex = 40
        '
        'RentIDLabel_Payment
        '
        Me.RentIDLabel_Payment.AutoSize = True
        Me.RentIDLabel_Payment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RentIDLabel_Payment.Location = New System.Drawing.Point(84, 21)
        Me.RentIDLabel_Payment.Name = "RentIDLabel_Payment"
        Me.RentIDLabel_Payment.Size = New System.Drawing.Size(59, 16)
        Me.RentIDLabel_Payment.TabIndex = 39
        Me.RentIDLabel_Payment.Text = "Rent ID"
        '
        'PaymentIDLabel_Payment
        '
        Me.PaymentIDLabel_Payment.AutoSize = True
        Me.PaymentIDLabel_Payment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PaymentIDLabel_Payment.Location = New System.Drawing.Point(56, 49)
        Me.PaymentIDLabel_Payment.Name = "PaymentIDLabel_Payment"
        Me.PaymentIDLabel_Payment.Size = New System.Drawing.Size(87, 16)
        Me.PaymentIDLabel_Payment.TabIndex = 41
        Me.PaymentIDLabel_Payment.Text = "Payment ID"
        '
        'RentIDTextBox_Payment
        '
        Me.RentIDTextBox_Payment.Location = New System.Drawing.Point(149, 18)
        Me.RentIDTextBox_Payment.Name = "RentIDTextBox_Payment"
        Me.RentIDTextBox_Payment.ReadOnly = True
        Me.RentIDTextBox_Payment.Size = New System.Drawing.Size(100, 22)
        Me.RentIDTextBox_Payment.TabIndex = 46
        '
        'PaymentGroupBox_Payment
        '
        Me.PaymentGroupBox_Payment.Controls.Add(Me.FineTextBox_Payment)
        Me.PaymentGroupBox_Payment.Controls.Add(Me.FineLabel_Payment)
        Me.PaymentGroupBox_Payment.Controls.Add(Me.ApplyButton_Payment)
        Me.PaymentGroupBox_Payment.Controls.Add(Me.RateLabel_Payment)
        Me.PaymentGroupBox_Payment.Controls.Add(Me.TotalTextBox_Payment)
        Me.PaymentGroupBox_Payment.Controls.Add(Me.TotalLabel_Payment)
        Me.PaymentGroupBox_Payment.Controls.Add(Me.NoOfDaysTextBox_Payment)
        Me.PaymentGroupBox_Payment.Controls.Add(Me.RateTextBox_Payment)
        Me.PaymentGroupBox_Payment.Controls.Add(Me.NoOfDaysLabel_Payment)
        Me.PaymentGroupBox_Payment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.PaymentGroupBox_Payment.Location = New System.Drawing.Point(62, 241)
        Me.PaymentGroupBox_Payment.Name = "PaymentGroupBox_Payment"
        Me.PaymentGroupBox_Payment.Size = New System.Drawing.Size(340, 157)
        Me.PaymentGroupBox_Payment.TabIndex = 53
        Me.PaymentGroupBox_Payment.TabStop = False
        Me.PaymentGroupBox_Payment.Text = "Payment"
        '
        'FineTextBox_Payment
        '
        Me.FineTextBox_Payment.Location = New System.Drawing.Point(149, 82)
        Me.FineTextBox_Payment.Name = "FineTextBox_Payment"
        Me.FineTextBox_Payment.ReadOnly = True
        Me.FineTextBox_Payment.Size = New System.Drawing.Size(67, 22)
        Me.FineTextBox_Payment.TabIndex = 56
        '
        'FineLabel_Payment
        '
        Me.FineLabel_Payment.AutoSize = True
        Me.FineLabel_Payment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FineLabel_Payment.Location = New System.Drawing.Point(105, 85)
        Me.FineLabel_Payment.Name = "FineLabel_Payment"
        Me.FineLabel_Payment.Size = New System.Drawing.Size(38, 16)
        Me.FineLabel_Payment.TabIndex = 55
        Me.FineLabel_Payment.Text = "Fine"
        '
        'ApplyButton_Payment
        '
        Me.ApplyButton_Payment.AutoSize = True
        Me.ApplyButton_Payment.Location = New System.Drawing.Point(237, 112)
        Me.ApplyButton_Payment.Name = "ApplyButton_Payment"
        Me.ApplyButton_Payment.Size = New System.Drawing.Size(97, 26)
        Me.ApplyButton_Payment.TabIndex = 54
        Me.ApplyButton_Payment.Text = "Apply"
        Me.ApplyButton_Payment.UseVisualStyleBackColor = True
        '
        'RateLabel_Payment
        '
        Me.RateLabel_Payment.AutoSize = True
        Me.RateLabel_Payment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.RateLabel_Payment.Location = New System.Drawing.Point(45, 29)
        Me.RateLabel_Payment.Name = "RateLabel_Payment"
        Me.RateLabel_Payment.Size = New System.Drawing.Size(98, 16)
        Me.RateLabel_Payment.TabIndex = 47
        Me.RateLabel_Payment.Text = "Rate per day"
        '
        'TotalTextBox_Payment
        '
        Me.TotalTextBox_Payment.Location = New System.Drawing.Point(149, 114)
        Me.TotalTextBox_Payment.Name = "TotalTextBox_Payment"
        Me.TotalTextBox_Payment.ReadOnly = True
        Me.TotalTextBox_Payment.Size = New System.Drawing.Size(67, 22)
        Me.TotalTextBox_Payment.TabIndex = 44
        '
        'TotalLabel_Payment
        '
        Me.TotalLabel_Payment.AutoSize = True
        Me.TotalLabel_Payment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TotalLabel_Payment.Location = New System.Drawing.Point(99, 117)
        Me.TotalLabel_Payment.Name = "TotalLabel_Payment"
        Me.TotalLabel_Payment.Size = New System.Drawing.Size(44, 16)
        Me.TotalLabel_Payment.TabIndex = 45
        Me.TotalLabel_Payment.Text = "Total"
        '
        'NoOfDaysTextBox_Payment
        '
        Me.NoOfDaysTextBox_Payment.Location = New System.Drawing.Point(149, 54)
        Me.NoOfDaysTextBox_Payment.Name = "NoOfDaysTextBox_Payment"
        Me.NoOfDaysTextBox_Payment.Size = New System.Drawing.Size(67, 22)
        Me.NoOfDaysTextBox_Payment.TabIndex = 50
        '
        'RateTextBox_Payment
        '
        Me.RateTextBox_Payment.Location = New System.Drawing.Point(149, 26)
        Me.RateTextBox_Payment.Name = "RateTextBox_Payment"
        Me.RateTextBox_Payment.ReadOnly = True
        Me.RateTextBox_Payment.Size = New System.Drawing.Size(67, 22)
        Me.RateTextBox_Payment.TabIndex = 48
        '
        'NoOfDaysLabel_Payment
        '
        Me.NoOfDaysLabel_Payment.AutoSize = True
        Me.NoOfDaysLabel_Payment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.NoOfDaysLabel_Payment.Location = New System.Drawing.Point(26, 57)
        Me.NoOfDaysLabel_Payment.Name = "NoOfDaysLabel_Payment"
        Me.NoOfDaysLabel_Payment.Size = New System.Drawing.Size(117, 16)
        Me.NoOfDaysLabel_Payment.TabIndex = 49
        Me.NoOfDaysLabel_Payment.Text = "Number of days"
        '
        'MovieGroupBox_Payment
        '
        Me.MovieGroupBox_Payment.Controls.Add(Me.CopyIDTextBox_Payment)
        Me.MovieGroupBox_Payment.Controls.Add(Me.TitleLabel_Payment)
        Me.MovieGroupBox_Payment.Controls.Add(Me.CopyIDLabel_Payment)
        Me.MovieGroupBox_Payment.Controls.Add(Me.TitleTextBox_Payment)
        Me.MovieGroupBox_Payment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.MovieGroupBox_Payment.Location = New System.Drawing.Point(62, 31)
        Me.MovieGroupBox_Payment.Name = "MovieGroupBox_Payment"
        Me.MovieGroupBox_Payment.Size = New System.Drawing.Size(340, 88)
        Me.MovieGroupBox_Payment.TabIndex = 52
        Me.MovieGroupBox_Payment.TabStop = False
        Me.MovieGroupBox_Payment.Text = "Movie"
        '
        'CopyIDTextBox_Payment
        '
        Me.CopyIDTextBox_Payment.Location = New System.Drawing.Point(102, 49)
        Me.CopyIDTextBox_Payment.Name = "CopyIDTextBox_Payment"
        Me.CopyIDTextBox_Payment.ReadOnly = True
        Me.CopyIDTextBox_Payment.Size = New System.Drawing.Size(200, 22)
        Me.CopyIDTextBox_Payment.TabIndex = 40
        '
        'TitleLabel_Payment
        '
        Me.TitleLabel_Payment.AutoSize = True
        Me.TitleLabel_Payment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.TitleLabel_Payment.Location = New System.Drawing.Point(57, 24)
        Me.TitleLabel_Payment.Name = "TitleLabel_Payment"
        Me.TitleLabel_Payment.Size = New System.Drawing.Size(39, 16)
        Me.TitleLabel_Payment.TabIndex = 39
        Me.TitleLabel_Payment.Text = "Title"
        '
        'CopyIDLabel_Payment
        '
        Me.CopyIDLabel_Payment.AutoSize = True
        Me.CopyIDLabel_Payment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CopyIDLabel_Payment.Location = New System.Drawing.Point(37, 51)
        Me.CopyIDLabel_Payment.Name = "CopyIDLabel_Payment"
        Me.CopyIDLabel_Payment.Size = New System.Drawing.Size(59, 16)
        Me.CopyIDLabel_Payment.TabIndex = 41
        Me.CopyIDLabel_Payment.Text = "CopyID"
        '
        'TitleTextBox_Payment
        '
        Me.TitleTextBox_Payment.Location = New System.Drawing.Point(102, 21)
        Me.TitleTextBox_Payment.Name = "TitleTextBox_Payment"
        Me.TitleTextBox_Payment.ReadOnly = True
        Me.TitleTextBox_Payment.Size = New System.Drawing.Size(200, 22)
        Me.TitleTextBox_Payment.TabIndex = 46
        '
        'CustomerGroupBox_Payment
        '
        Me.CustomerGroupBox_Payment.Controls.Add(Me.CustomerIDTextBox_Payment)
        Me.CustomerGroupBox_Payment.Controls.Add(Me.CustomerIDLabel_Payment)
        Me.CustomerGroupBox_Payment.Controls.Add(Me.FullNameTextBox_Payment)
        Me.CustomerGroupBox_Payment.Controls.Add(Me.FullNameLabel_Payment)
        Me.CustomerGroupBox_Payment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CustomerGroupBox_Payment.Location = New System.Drawing.Point(62, 136)
        Me.CustomerGroupBox_Payment.Name = "CustomerGroupBox_Payment"
        Me.CustomerGroupBox_Payment.Size = New System.Drawing.Size(340, 88)
        Me.CustomerGroupBox_Payment.TabIndex = 51
        Me.CustomerGroupBox_Payment.TabStop = False
        Me.CustomerGroupBox_Payment.Text = "Customer"
        '
        'CustomerIDTextBox_Payment
        '
        Me.CustomerIDTextBox_Payment.Location = New System.Drawing.Point(104, 23)
        Me.CustomerIDTextBox_Payment.Name = "CustomerIDTextBox_Payment"
        Me.CustomerIDTextBox_Payment.ReadOnly = True
        Me.CustomerIDTextBox_Payment.Size = New System.Drawing.Size(200, 22)
        Me.CustomerIDTextBox_Payment.TabIndex = 37
        '
        'CustomerIDLabel_Payment
        '
        Me.CustomerIDLabel_Payment.AutoSize = True
        Me.CustomerIDLabel_Payment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.CustomerIDLabel_Payment.Location = New System.Drawing.Point(6, 26)
        Me.CustomerIDLabel_Payment.Name = "CustomerIDLabel_Payment"
        Me.CustomerIDLabel_Payment.Size = New System.Drawing.Size(92, 16)
        Me.CustomerIDLabel_Payment.TabIndex = 38
        Me.CustomerIDLabel_Payment.Text = "Customer ID"
        '
        'FullNameTextBox_Payment
        '
        Me.FullNameTextBox_Payment.Location = New System.Drawing.Point(104, 51)
        Me.FullNameTextBox_Payment.Name = "FullNameTextBox_Payment"
        Me.FullNameTextBox_Payment.ReadOnly = True
        Me.FullNameTextBox_Payment.Size = New System.Drawing.Size(200, 22)
        Me.FullNameTextBox_Payment.TabIndex = 42
        '
        'FullNameLabel_Payment
        '
        Me.FullNameLabel_Payment.AutoSize = True
        Me.FullNameLabel_Payment.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.FullNameLabel_Payment.Location = New System.Drawing.Point(20, 54)
        Me.FullNameLabel_Payment.Name = "FullNameLabel_Payment"
        Me.FullNameLabel_Payment.Size = New System.Drawing.Size(78, 16)
        Me.FullNameLabel_Payment.TabIndex = 43
        Me.FullNameLabel_Payment.Text = "Full Name"
        '
        'AcceptedPictureBox_Payment
        '
        Me.AcceptedPictureBox_Payment.Image = CType(resources.GetObject("AcceptedPictureBox_Payment.Image"), System.Drawing.Image)
        Me.AcceptedPictureBox_Payment.Location = New System.Drawing.Point(471, 257)
        Me.AcceptedPictureBox_Payment.Name = "AcceptedPictureBox_Payment"
        Me.AcceptedPictureBox_Payment.Size = New System.Drawing.Size(251, 108)
        Me.AcceptedPictureBox_Payment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.AcceptedPictureBox_Payment.TabIndex = 54
        Me.AcceptedPictureBox_Payment.TabStop = False
        '
        'CustomerTabPage
        '
        Me.CustomerTabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.CustomerTabPage.Controls.Add(Me.GroupBoxPayments_Customers)
        Me.CustomerTabPage.Controls.Add(Me.GroupBoxCSDetails_Customer)
        Me.CustomerTabPage.Controls.Add(Me.GroupBoxActiveRents_Customers)
        Me.CustomerTabPage.Location = New System.Drawing.Point(4, 25)
        Me.CustomerTabPage.Name = "CustomerTabPage"
        Me.CustomerTabPage.Size = New System.Drawing.Size(1036, 525)
        Me.CustomerTabPage.TabIndex = 2
        Me.CustomerTabPage.Text = "Customers"
        '
        'GroupBoxPayments_Customers
        '
        Me.GroupBoxPayments_Customers.Controls.Add(Me.RadioButtonCurrPayment_Customer)
        Me.GroupBoxPayments_Customers.Controls.Add(Me.ListViewPayments_Customers)
        Me.GroupBoxPayments_Customers.Controls.Add(Me.RadioButtonOverdue_Customers)
        Me.GroupBoxPayments_Customers.Controls.Add(Me.RadioButtonAll_Customers)
        Me.GroupBoxPayments_Customers.Location = New System.Drawing.Point(27, 321)
        Me.GroupBoxPayments_Customers.Name = "GroupBoxPayments_Customers"
        Me.GroupBoxPayments_Customers.Size = New System.Drawing.Size(546, 196)
        Me.GroupBoxPayments_Customers.TabIndex = 64
        Me.GroupBoxPayments_Customers.TabStop = False
        Me.GroupBoxPayments_Customers.Text = "Payments"
        '
        'RadioButtonCurrPayment_Customer
        '
        Me.RadioButtonCurrPayment_Customer.AutoSize = True
        Me.RadioButtonCurrPayment_Customer.Location = New System.Drawing.Point(153, 23)
        Me.RadioButtonCurrPayment_Customer.Name = "RadioButtonCurrPayment_Customer"
        Me.RadioButtonCurrPayment_Customer.Size = New System.Drawing.Size(75, 20)
        Me.RadioButtonCurrPayment_Customer.TabIndex = 66
        Me.RadioButtonCurrPayment_Customer.TabStop = True
        Me.RadioButtonCurrPayment_Customer.Text = "Current"
        Me.RadioButtonCurrPayment_Customer.UseVisualStyleBackColor = True
        '
        'ListViewPayments_Customers
        '
        Me.ListViewPayments_Customers.Location = New System.Drawing.Point(12, 49)
        Me.ListViewPayments_Customers.Name = "ListViewPayments_Customers"
        Me.ListViewPayments_Customers.Size = New System.Drawing.Size(525, 141)
        Me.ListViewPayments_Customers.TabIndex = 65
        Me.ListViewPayments_Customers.UseCompatibleStateImageBehavior = False
        '
        'RadioButtonOverdue_Customers
        '
        Me.RadioButtonOverdue_Customers.AutoSize = True
        Me.RadioButtonOverdue_Customers.Location = New System.Drawing.Point(62, 23)
        Me.RadioButtonOverdue_Customers.Name = "RadioButtonOverdue_Customers"
        Me.RadioButtonOverdue_Customers.Size = New System.Drawing.Size(85, 20)
        Me.RadioButtonOverdue_Customers.TabIndex = 1
        Me.RadioButtonOverdue_Customers.TabStop = True
        Me.RadioButtonOverdue_Customers.Text = "Overdue"
        Me.RadioButtonOverdue_Customers.UseVisualStyleBackColor = True
        '
        'RadioButtonAll_Customers
        '
        Me.RadioButtonAll_Customers.AutoSize = True
        Me.RadioButtonAll_Customers.Location = New System.Drawing.Point(12, 23)
        Me.RadioButtonAll_Customers.Name = "RadioButtonAll_Customers"
        Me.RadioButtonAll_Customers.Size = New System.Drawing.Size(44, 20)
        Me.RadioButtonAll_Customers.TabIndex = 0
        Me.RadioButtonAll_Customers.TabStop = True
        Me.RadioButtonAll_Customers.Text = "All"
        Me.RadioButtonAll_Customers.UseVisualStyleBackColor = True
        '
        'GroupBoxCSDetails_Customer
        '
        Me.GroupBoxCSDetails_Customer.Controls.Add(Me.ButtonSendEmail_Customer)
        Me.GroupBoxCSDetails_Customer.Controls.Add(Me.LabelBalance_Customers)
        Me.GroupBoxCSDetails_Customer.Controls.Add(Me.TextBoxBalance_Customers)
        Me.GroupBoxCSDetails_Customer.Controls.Add(Me.PictureBoxCustomer_Customers)
        Me.GroupBoxCSDetails_Customer.Controls.Add(Me.TextBoxCustomerID_Customers)
        Me.GroupBoxCSDetails_Customer.Controls.Add(Me.LabelCustomerID_Customers)
        Me.GroupBoxCSDetails_Customer.Controls.Add(Me.LabelEmail_Customers)
        Me.GroupBoxCSDetails_Customer.Controls.Add(Me.ButtonEdit_Customers)
        Me.GroupBoxCSDetails_Customer.Controls.Add(Me.TextBoxAddress_Customers)
        Me.GroupBoxCSDetails_Customer.Controls.Add(Me.TextBoxEmail_Customers)
        Me.GroupBoxCSDetails_Customer.Controls.Add(Me.LabelAddress_Customers)
        Me.GroupBoxCSDetails_Customer.Controls.Add(Me.LabelFullName_Customers)
        Me.GroupBoxCSDetails_Customer.Controls.Add(Me.TextBoxFullName_Customers)
        Me.GroupBoxCSDetails_Customer.Location = New System.Drawing.Point(27, 49)
        Me.GroupBoxCSDetails_Customer.Name = "GroupBoxCSDetails_Customer"
        Me.GroupBoxCSDetails_Customer.Size = New System.Drawing.Size(546, 250)
        Me.GroupBoxCSDetails_Customer.TabIndex = 63
        Me.GroupBoxCSDetails_Customer.TabStop = False
        Me.GroupBoxCSDetails_Customer.Text = "Customer details"
        '
        'ButtonSendEmail_Customer
        '
        Me.ButtonSendEmail_Customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSendEmail_Customer.Location = New System.Drawing.Point(103, 218)
        Me.ButtonSendEmail_Customer.Name = "ButtonSendEmail_Customer"
        Me.ButtonSendEmail_Customer.Size = New System.Drawing.Size(102, 23)
        Me.ButtonSendEmail_Customer.TabIndex = 60
        Me.ButtonSendEmail_Customer.Text = "Send Email"
        Me.ButtonSendEmail_Customer.UseVisualStyleBackColor = True
        '
        'LabelBalance_Customers
        '
        Me.LabelBalance_Customers.AutoSize = True
        Me.LabelBalance_Customers.Location = New System.Drawing.Point(32, 107)
        Me.LabelBalance_Customers.Name = "LabelBalance_Customers"
        Me.LabelBalance_Customers.Size = New System.Drawing.Size(65, 16)
        Me.LabelBalance_Customers.TabIndex = 59
        Me.LabelBalance_Customers.Text = "Balance"
        '
        'TextBoxBalance_Customers
        '
        Me.TextBoxBalance_Customers.Location = New System.Drawing.Point(103, 104)
        Me.TextBoxBalance_Customers.Name = "TextBoxBalance_Customers"
        Me.TextBoxBalance_Customers.ReadOnly = True
        Me.TextBoxBalance_Customers.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxBalance_Customers.TabIndex = 58
        '
        'PictureBoxCustomer_Customers
        '
        Me.PictureBoxCustomer_Customers.Image = CType(resources.GetObject("PictureBoxCustomer_Customers.Image"), System.Drawing.Image)
        Me.PictureBoxCustomer_Customers.Location = New System.Drawing.Point(422, 21)
        Me.PictureBoxCustomer_Customers.Name = "PictureBoxCustomer_Customers"
        Me.PictureBoxCustomer_Customers.Size = New System.Drawing.Size(115, 124)
        Me.PictureBoxCustomer_Customers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBoxCustomer_Customers.TabIndex = 0
        Me.PictureBoxCustomer_Customers.TabStop = False
        '
        'TextBoxCustomerID_Customers
        '
        Me.TextBoxCustomerID_Customers.Location = New System.Drawing.Point(103, 29)
        Me.TextBoxCustomerID_Customers.Name = "TextBoxCustomerID_Customers"
        Me.TextBoxCustomerID_Customers.ReadOnly = True
        Me.TextBoxCustomerID_Customers.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxCustomerID_Customers.TabIndex = 47
        '
        'LabelCustomerID_Customers
        '
        Me.LabelCustomerID_Customers.AutoSize = True
        Me.LabelCustomerID_Customers.Location = New System.Drawing.Point(9, 32)
        Me.LabelCustomerID_Customers.Name = "LabelCustomerID_Customers"
        Me.LabelCustomerID_Customers.Size = New System.Drawing.Size(88, 16)
        Me.LabelCustomerID_Customers.TabIndex = 48
        Me.LabelCustomerID_Customers.Text = "CustomerID"
        '
        'LabelEmail_Customers
        '
        Me.LabelEmail_Customers.AutoSize = True
        Me.LabelEmail_Customers.Location = New System.Drawing.Point(50, 188)
        Me.LabelEmail_Customers.Name = "LabelEmail_Customers"
        Me.LabelEmail_Customers.Size = New System.Drawing.Size(47, 16)
        Me.LabelEmail_Customers.TabIndex = 49
        Me.LabelEmail_Customers.Text = "Email"
        '
        'ButtonEdit_Customers
        '
        Me.ButtonEdit_Customers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonEdit_Customers.Location = New System.Drawing.Point(462, 218)
        Me.ButtonEdit_Customers.Name = "ButtonEdit_Customers"
        Me.ButtonEdit_Customers.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEdit_Customers.TabIndex = 57
        Me.ButtonEdit_Customers.Text = "Edit"
        Me.ButtonEdit_Customers.UseVisualStyleBackColor = True
        '
        'TextBoxAddress_Customers
        '
        Me.TextBoxAddress_Customers.Location = New System.Drawing.Point(103, 157)
        Me.TextBoxAddress_Customers.Name = "TextBoxAddress_Customers"
        Me.TextBoxAddress_Customers.ReadOnly = True
        Me.TextBoxAddress_Customers.Size = New System.Drawing.Size(434, 22)
        Me.TextBoxAddress_Customers.TabIndex = 50
        '
        'TextBoxEmail_Customers
        '
        Me.TextBoxEmail_Customers.Location = New System.Drawing.Point(103, 185)
        Me.TextBoxEmail_Customers.Name = "TextBoxEmail_Customers"
        Me.TextBoxEmail_Customers.ReadOnly = True
        Me.TextBoxEmail_Customers.Size = New System.Drawing.Size(279, 22)
        Me.TextBoxEmail_Customers.TabIndex = 56
        '
        'LabelAddress_Customers
        '
        Me.LabelAddress_Customers.AutoSize = True
        Me.LabelAddress_Customers.Location = New System.Drawing.Point(31, 160)
        Me.LabelAddress_Customers.Name = "LabelAddress_Customers"
        Me.LabelAddress_Customers.Size = New System.Drawing.Size(66, 16)
        Me.LabelAddress_Customers.TabIndex = 51
        Me.LabelAddress_Customers.Text = "Address"
        '
        'LabelFullName_Customers
        '
        Me.LabelFullName_Customers.AutoSize = True
        Me.LabelFullName_Customers.Location = New System.Drawing.Point(19, 60)
        Me.LabelFullName_Customers.Name = "LabelFullName_Customers"
        Me.LabelFullName_Customers.Size = New System.Drawing.Size(78, 16)
        Me.LabelFullName_Customers.TabIndex = 53
        Me.LabelFullName_Customers.Text = "Full Name"
        '
        'TextBoxFullName_Customers
        '
        Me.TextBoxFullName_Customers.Location = New System.Drawing.Point(103, 57)
        Me.TextBoxFullName_Customers.Name = "TextBoxFullName_Customers"
        Me.TextBoxFullName_Customers.ReadOnly = True
        Me.TextBoxFullName_Customers.Size = New System.Drawing.Size(200, 22)
        Me.TextBoxFullName_Customers.TabIndex = 52
        '
        'GroupBoxActiveRents_Customers
        '
        Me.GroupBoxActiveRents_Customers.Controls.Add(Me.ListViewFullHistory_Customers)
        Me.GroupBoxActiveRents_Customers.Controls.Add(Me.ButtonFullHistory_Customers)
        Me.GroupBoxActiveRents_Customers.Controls.Add(Me.ListViewActiveRents_Customers)
        Me.GroupBoxActiveRents_Customers.Location = New System.Drawing.Point(595, 49)
        Me.GroupBoxActiveRents_Customers.Name = "GroupBoxActiveRents_Customers"
        Me.GroupBoxActiveRents_Customers.Size = New System.Drawing.Size(438, 334)
        Me.GroupBoxActiveRents_Customers.TabIndex = 62
        Me.GroupBoxActiveRents_Customers.TabStop = False
        Me.GroupBoxActiveRents_Customers.Text = "Active rents"
        '
        'ListViewFullHistory_Customers
        '
        Me.ListViewFullHistory_Customers.Location = New System.Drawing.Point(6, 218)
        Me.ListViewFullHistory_Customers.Name = "ListViewFullHistory_Customers"
        Me.ListViewFullHistory_Customers.Size = New System.Drawing.Size(426, 110)
        Me.ListViewFullHistory_Customers.TabIndex = 63
        Me.ListViewFullHistory_Customers.UseCompatibleStateImageBehavior = False
        '
        'ButtonFullHistory_Customers
        '
        Me.ButtonFullHistory_Customers.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonFullHistory_Customers.Location = New System.Drawing.Point(6, 189)
        Me.ButtonFullHistory_Customers.Name = "ButtonFullHistory_Customers"
        Me.ButtonFullHistory_Customers.Size = New System.Drawing.Size(101, 23)
        Me.ButtonFullHistory_Customers.TabIndex = 63
        Me.ButtonFullHistory_Customers.Text = "Full History"
        Me.ButtonFullHistory_Customers.UseVisualStyleBackColor = True
        '
        'ListViewActiveRents_Customers
        '
        Me.ListViewActiveRents_Customers.Location = New System.Drawing.Point(6, 45)
        Me.ListViewActiveRents_Customers.Name = "ListViewActiveRents_Customers"
        Me.ListViewActiveRents_Customers.Size = New System.Drawing.Size(426, 104)
        Me.ListViewActiveRents_Customers.TabIndex = 60
        Me.ListViewActiveRents_Customers.UseCompatibleStateImageBehavior = False
        '
        'LostTabPage
        '
        Me.LostTabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.LostTabPage.Location = New System.Drawing.Point(4, 25)
        Me.LostTabPage.Name = "LostTabPage"
        Me.LostTabPage.Size = New System.Drawing.Size(1036, 525)
        Me.LostTabPage.TabIndex = 3
        Me.LostTabPage.Text = "Lost/Damaged"
        '
        'ReportTabPage
        '
        Me.ReportTabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ReportTabPage.Location = New System.Drawing.Point(4, 25)
        Me.ReportTabPage.Name = "ReportTabPage"
        Me.ReportTabPage.Size = New System.Drawing.Size(1036, 525)
        Me.ReportTabPage.TabIndex = 4
        Me.ReportTabPage.Text = "Reports"
        '
        'SettingTabPage
        '
        Me.SettingTabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.SettingTabPage.Location = New System.Drawing.Point(4, 25)
        Me.SettingTabPage.Name = "SettingTabPage"
        Me.SettingTabPage.Size = New System.Drawing.Size(1036, 525)
        Me.SettingTabPage.TabIndex = 5
        Me.SettingTabPage.Text = "Settings"
        '
        'ExitTabPage
        '
        Me.ExitTabPage.BackColor = System.Drawing.Color.FromArgb(CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ExitTabPage.Location = New System.Drawing.Point(4, 25)
        Me.ExitTabPage.Name = "ExitTabPage"
        Me.ExitTabPage.Size = New System.Drawing.Size(1036, 525)
        Me.ExitTabPage.TabIndex = 6
        Me.ExitTabPage.Text = "Exit"
        '
        'PaymentImageList
        '
        Me.PaymentImageList.ImageStream = CType(resources.GetObject("PaymentImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.PaymentImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.PaymentImageList.Images.SetKeyName(0, "accepted.jpg")
        Me.PaymentImageList.Images.SetKeyName(1, "rejected.png")
        '
        'PrintPreviewDialog_Payment
        '
        Me.PrintPreviewDialog_Payment.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog_Payment.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog_Payment.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog_Payment.Enabled = True
        Me.PrintPreviewDialog_Payment.Icon = CType(resources.GetObject("PrintPreviewDialog_Payment.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog_Payment.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog_Payment.Visible = False
        '
        'PrintDocument_Payment
        '
        '
        'PrintDialog_Payment
        '
        Me.PrintDialog_Payment.UseEXDialog = True
        '
        'ErrorProvider
        '
        Me.ErrorProvider.ContainerControl = Me
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(1205, 578)
        Me.Controls.Add(Me.TabControlMain)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "MainForm"
        Me.Text = "MOVIE RENT SYSTEM"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CatalogPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.TabControlMain.ResumeLayout(False)
        Me.CatalogTabPage.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBoxFilters.ResumeLayout(False)
        Me.GroupBoxFilters.PerformLayout()
        CType(Me.CoverPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchedMovieDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RentTabPage.ResumeLayout(False)
        Me.RentTabPage.PerformLayout()
        Me.ReturnTabPage.ResumeLayout(False)
        Me.ReturnTabPage.PerformLayout()
        Me.CustomerGroupBox_Return.ResumeLayout(False)
        Me.CustomerGroupBox_Return.PerformLayout()
        Me.ReturnGroupBox_Return.ResumeLayout(False)
        Me.ReturnGroupBox_Return.PerformLayout()
        Me.PaymentTabPage.ResumeLayout(False)
        Me.PaymentTabPage.PerformLayout()
        Me.AutoGeneratedGroupBox_Payment.ResumeLayout(False)
        Me.AutoGeneratedGroupBox_Payment.PerformLayout()
        Me.PaymentGroupBox_Payment.ResumeLayout(False)
        Me.PaymentGroupBox_Payment.PerformLayout()
        Me.MovieGroupBox_Payment.ResumeLayout(False)
        Me.MovieGroupBox_Payment.PerformLayout()
        Me.CustomerGroupBox_Payment.ResumeLayout(False)
        Me.CustomerGroupBox_Payment.PerformLayout()
        CType(Me.AcceptedPictureBox_Payment, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustomerTabPage.ResumeLayout(False)
        Me.GroupBoxPayments_Customers.ResumeLayout(False)
        Me.GroupBoxPayments_Customers.PerformLayout()
        Me.GroupBoxCSDetails_Customer.ResumeLayout(False)
        Me.GroupBoxCSDetails_Customer.PerformLayout()
        CType(Me.PictureBoxCustomer_Customers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxActiveRents_Customers.ResumeLayout(False)
        CType(Me.ErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents CatalogPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox6 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MoviesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AccountsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PrintToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LabelWelcome As System.Windows.Forms.Label
    Friend WithEvents LabelTimer As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ImageListMovieCover As System.Windows.Forms.ImageList
    Friend WithEvents CreateUserToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteAccountToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents TabControlMain As System.Windows.Forms.TabControl
    Friend WithEvents CatalogTabPage As System.Windows.Forms.TabPage
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SearchButton As System.Windows.Forms.Button
    Friend WithEvents LabelCatalog As System.Windows.Forms.Label
    Friend WithEvents SearchTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxFilters As System.Windows.Forms.GroupBox
    Friend WithEvents LabelCategories As System.Windows.Forms.Label
    Friend WithEvents FilterButton As System.Windows.Forms.Button
    Friend WithEvents ListBoxCategories As System.Windows.Forms.ListBox
    Friend WithEvents LabelCountry As System.Windows.Forms.Label
    Friend WithEvents ComboBoxCountry As System.Windows.Forms.ComboBox
    Friend WithEvents LabelLang As System.Windows.Forms.Label
    Friend WithEvents ComboBoxLang As System.Windows.Forms.ComboBox
    Friend WithEvents LabelYear As System.Windows.Forms.Label
    Friend WithEvents ComboBoxYear As System.Windows.Forms.ComboBox
    Friend WithEvents CoverPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents SearchedMovieDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents WelcomeTabPage As System.Windows.Forms.TabPage
    Friend WithEvents CustomerTabPage As System.Windows.Forms.TabPage
    Friend WithEvents LostTabPage As System.Windows.Forms.TabPage
    Friend WithEvents ReportTabPage As System.Windows.Forms.TabPage
    Friend WithEvents SettingTabPage As System.Windows.Forms.TabPage
    Friend WithEvents ExitTabPage As System.Windows.Forms.TabPage
    Friend WithEvents RentButton As Button
    Friend WithEvents RentTabPage As TabPage
    Friend WithEvents ConfirmRentButton As Button
    Friend WithEvents PaymentButton As Button
    Friend WithEvents ChooseCopyLabel As Label
    Friend WithEvents ChooseCopyComboBox_Rent As ComboBox
    Friend WithEvents ClientAccountButton As Button
    Friend WithEvents ClientNotFoundLabel As Label
    Friend WithEvents BalanceLabel As Label
    Friend WithEvents BalanceTextBox As TextBox
    Friend WithEvents FullNameLabel As Label
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents IDLabel As Label
    Friend WithEvents IDTextBox As TextBox
    Friend WithEvents CustomerLabel As Label
    Friend WithEvents CustomerTextBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents MonthCalendar_Rent As MonthCalendar
    Friend WithEvents DateLabel As Label
    Friend WithEvents AvailabilityLabel As Label
    Friend WithEvents DateTimePicker_Rent As DateTimePicker
    Friend WithEvents MovieTitleLabel As Label
    Friend WithEvents MovieTitleTextBox As TextBox
    Friend WithEvents ReturnTabPage As TabPage
    Friend WithEvents OkButton_Return As Button
    Friend WithEvents PayNowButton_Return As Button
    Friend WithEvents ChargeLabel_Return As Label
    Friend WithEvents ChargeTextBox_Return As TextBox
    Friend WithEvents CustomerFullNameLabel_Return As Label
    Friend WithEvents CustomerFullNameTextBox_Return As TextBox
    Friend WithEvents SearchLabel_Return As Label
    Friend WithEvents SearchTextBox_Return As TextBox
    Friend WithEvents CustomerIDLabel_Return As Label
    Friend WithEvents DateOfReturnLabel_Return As Label
    Friend WithEvents DateTimePicker_Return As DateTimePicker
    Friend WithEvents TitleLabel_Return As Label
    Friend WithEvents TitleTextBox_Return As TextBox
    Friend WithEvents ConfirmationLabel As Label
    Friend WithEvents DaysOverdueLabel_Return As Label
    Friend WithEvents FineLabel_Return As Label
    Friend WithEvents FineTextBox_Return As TextBox
    Friend WithEvents VerifyDurationLabel_Return As Label
    Friend WithEvents ConfirmationLabel_Return As Label
    Friend WithEvents PaymentTabPage As TabPage
    Friend WithEvents TitleTextBox_Payment As TextBox
    Friend WithEvents TotalLabel_Payment As Label
    Friend WithEvents TotalTextBox_Payment As TextBox
    Friend WithEvents FullNameLabel_Payment As Label
    Friend WithEvents FullNameTextBox_Payment As TextBox
    Friend WithEvents CopyIDLabel_Payment As Label
    Friend WithEvents CopyIDTextBox_Payment As TextBox
    Friend WithEvents TitleLabel_Payment As Label
    Friend WithEvents CustomerIDLabel_Payment As Label
    Friend WithEvents CustomerIDTextBox_Payment As TextBox
    Friend WithEvents GroupBoxPayments_Customers As GroupBox
    Friend WithEvents ListViewPayments_Customers As ListView
    Friend WithEvents RadioButtonOverdue_Customers As RadioButton
    Friend WithEvents RadioButtonAll_Customers As RadioButton
    Friend WithEvents GroupBoxCSDetails_Customer As GroupBox
    Friend WithEvents PictureBoxCustomer_Customers As PictureBox
    Friend WithEvents TextBoxCustomerID_Customers As TextBox
    Friend WithEvents LabelCustomerID_Customers As Label
    Friend WithEvents LabelEmail_Customers As Label
    Friend WithEvents ButtonEdit_Customers As Button
    Friend WithEvents TextBoxAddress_Customers As TextBox
    Friend WithEvents TextBoxEmail_Customers As TextBox
    Friend WithEvents LabelAddress_Customers As Label
    Friend WithEvents LabelFullName_Customers As Label
    Friend WithEvents TextBoxFullName_Customers As TextBox
    Friend WithEvents GroupBoxActiveRents_Customers As GroupBox
    Friend WithEvents ListViewFullHistory_Customers As ListView
    Friend WithEvents ButtonFullHistory_Customers As Button
    Friend WithEvents ListViewActiveRents_Customers As ListView
    Friend WithEvents LabelBalance_Customers As Label
    Friend WithEvents TextBoxBalance_Customers As TextBox
    Friend WithEvents RadioButtonCurrPayment_Customer As RadioButton
    Friend WithEvents ButtonSendEmail_Customer As Button
    Friend WithEvents NoOfDaysTextBox_Payment As TextBox
    Friend WithEvents NoOfDaysLabel_Payment As Label
    Friend WithEvents RateTextBox_Payment As TextBox
    Friend WithEvents RateLabel_Payment As Label
    Friend WithEvents AcceptedPictureBox_Payment As PictureBox
    Friend WithEvents PaymentGroupBox_Payment As GroupBox
    Friend WithEvents ApplyButton_Payment As Button
    Friend WithEvents MovieGroupBox_Payment As GroupBox
    Friend WithEvents CustomerGroupBox_Payment As GroupBox
    Friend WithEvents PaymentImageList As ImageList
    Friend WithEvents AutoGeneratedGroupBox_Payment As GroupBox
    Friend WithEvents TransactionOwnerTextBox_Payment As TextBox
    Friend WithEvents TransactionOwnerLabel_Payment As Label
    Friend WithEvents PaymentDateTimePicker_Payment As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents PaymentIDTextBox_Payment As TextBox
    Friend WithEvents RentIDLabel_Payment As Label
    Friend WithEvents PaymentIDLabel_Payment As Label
    Friend WithEvents RentIDTextBox_Payment As TextBox
    Friend WithEvents PrintPreviewDialog_Payment As PrintPreviewDialog
    Friend WithEvents PreviewPrintButton_Payment As Button
    Friend WithEvents PrintDocument_Payment As Printing.PrintDocument
    Friend WithEvents PrintDialog_Payment As PrintDialog
    Friend WithEvents PrintButton_Payment As Button
    Friend WithEvents CustomerIDTextBox_Return As TextBox
    Friend WithEvents ReturnGroupBox_Return As GroupBox
    Friend WithEvents RentIDTextBox_Return As TextBox
    Friend WithEvents RentIDLabel_Return As Label
    Friend WithEvents ExpectedReturnDateTimePicker_Return As DateTimePicker
    Friend WithEvents ExpextedReturnLabel_Return As Label
    Friend WithEvents ErrorProvider As ErrorProvider
    Friend WithEvents DaysOverdueTextBox_Return As TextBox
    Friend WithEvents CustomerGroupBox_Return As GroupBox
    Friend WithEvents ManualPaymentCheckBox_Payment As CheckBox
    Friend WithEvents FineTextBox_Payment As TextBox
    Friend WithEvents FineLabel_Payment As Label
End Class
