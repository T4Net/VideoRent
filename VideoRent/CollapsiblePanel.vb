'based on: https : //www.daniweb.com/programming/software-development/code/456419/collapsible-panel
Imports System.Windows.Forms
Public Class CollapsiblePanel
    Inherits Windows.Forms.Panel
    Private _isCollasped As Boolean = False
    Private _bSellerExLoc As Point = New Point(3, 35)
    Private _bSellerColLoc As Point = New Point(1, 5)
    Friend WithEvents BestsellerMovieLabel As Label
    Friend WithEvents BestsellerLabel As Label
    Friend WithEvents BestsellerMoviePictureBox As PictureBox
    Friend WithEvents BestsellerDescriptionLabel As Label

    Public ReadOnly Property PanelCollapsed As Boolean
        Get
            Return _isCollasped
        End Get
    End Property
    Private Property OriginalSize As Size
#Region "Events"
    Public Event Expanding(ByVal sender As Object, ByVal e As CollapsiblePanelEventArgs)
    Public Event Expanded(ByVal sender As Object, ByVal e As CollapsiblePanelEventArgs)
    Public Event Collapsing(ByVal sender As Object, ByVal e As CollapsiblePanelEventArgs)
    Public Event Collapsed(ByVal sender As Object, ByVal e As CollapsiblePanelEventArgs)
#End Region
    Public Sub New()
        'InitializeComponent() - Default constructor call InitializeComponent() by itself.
        MyBase.New()
        SetPosition()
        'Me.OriginalSize = Me.Size
        AddComponent()
    End Sub

    Private Sub SetPosition()
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Dock = System.Windows.Forms.DockStyle.Left
        Me.Location = New System.Drawing.Point(0, 35)
        Me.Name = "BestsellerPanel"
        Me.Size = New System.Drawing.Size(258, 500) 'WelcomeTabPage.height = 525 - switchToolStrip.height = 25
        Me.OriginalSize = Me.Size
        Me.TabIndex = 20
    End Sub

    Private Sub AddComponent()
        Me.BestsellerDescriptionLabel = New System.Windows.Forms.Label()
        Me.BestsellerMoviePictureBox = New System.Windows.Forms.PictureBox()
        Me.BestsellerMovieLabel = New System.Windows.Forms.Label()
        Me.BestsellerLabel = New System.Windows.Forms.Label()

        'BestsellerDescriptionLabel
        '
        Me.BestsellerDescriptionLabel.AutoSize = True
        Me.BestsellerDescriptionLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BestsellerDescriptionLabel.Location = New System.Drawing.Point(3, 265)
        Me.BestsellerDescriptionLabel.Name = "BestsellerDescriptionLabel"
        Me.BestsellerDescriptionLabel.Size = New System.Drawing.Size(85, 16)
        Me.BestsellerDescriptionLabel.TabIndex = 19
        Me.BestsellerDescriptionLabel.Text = "description"
        '
        'BestsellerMoviePictureBox
        '
        Me.BestsellerMoviePictureBox.Location = New System.Drawing.Point(6, 95)
        Me.BestsellerMoviePictureBox.Name = "BestsellerMoviePictureBox"
        Me.BestsellerMoviePictureBox.Size = New System.Drawing.Size(248, 167)
        Me.BestsellerMoviePictureBox.TabIndex = 18
        Me.BestsellerMoviePictureBox.TabStop = False
        '
        'BestsellerMovieLabel
        '
        Me.BestsellerMovieLabel.AutoSize = True
        Me.BestsellerMovieLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BestsellerMovieLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BestsellerMovieLabel.Location = New System.Drawing.Point(3, 65)
        Me.BestsellerMovieLabel.Name = "BestsellerMovieLabel"
        Me.BestsellerMovieLabel.Size = New System.Drawing.Size(86, 16)
        Me.BestsellerMovieLabel.TabIndex = 15
        Me.BestsellerMovieLabel.Text = "movie title"
        Me.BestsellerMovieLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'BestsellerLabel
        '
        Me.BestsellerLabel.AutoSize = True
        Me.BestsellerLabel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BestsellerLabel.ForeColor = System.Drawing.Color.WhiteSmoke
        Me.BestsellerLabel.Location = _bSellerExLoc 'New System.Drawing.Point(3, 35)
        Me.BestsellerLabel.Name = "BestsellerLabel"
        Me.BestsellerLabel.Size = New System.Drawing.Size(172, 16)
        Me.BestsellerLabel.TabIndex = 14
        Me.BestsellerLabel.Text = "This week's bestseller:"
        Me.BestsellerLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter

        Me.Controls.Add(Me.BestsellerLabel)
        Me.Controls.Add(Me.BestsellerDescriptionLabel)
        Me.Controls.Add(Me.BestsellerMovieLabel)
        Me.Controls.Add(Me.BestsellerMoviePictureBox)

    End Sub

    Public Sub Expand(Optional ByVal e As CollapsiblePanelEventArgs = Nothing)
        Try
            If Not IsNothing(e) Then
                RaiseEvent Expanding(Me, e)
            Else
                RaiseEvent Expanding(Me, New CollapsiblePanelEventArgs(False, OriginalSize))
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub Collapse(Optional ByVal e As CollapsiblePanelEventArgs = Nothing)
        If Not IsNothing(e) Then
            RaiseEvent Collapsing(Me, e)
        Else
            RaiseEvent Collapsing(Me, New CollapsiblePanelEventArgs)
        End If
        'RaiseEvent Collapsing(Me, New CollapsiblePanelEventArgs)
    End Sub
    Private Sub _OnExpanding(ByVal sender As Object, ByVal e As CollapsiblePanelEventArgs) Handles Me.Expanding
        If Not e.Cancel Then
            Me.Dock = System.Windows.Forms.DockStyle.Left
            Me.Size = e.Size
            Me.BestsellerLabel.Location = _bSellerExLoc
            RaiseEvent Expanded(sender, e)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub _OnCollapsing(ByVal sender As Object, ByVal e As CollapsiblePanelEventArgs) Handles Me.Collapsing
        If Not e.Cancel Then
            Me.Dock = System.Windows.Forms.DockStyle.None
            Me.Size = e.Size
            Me.BestsellerLabel.Location = _bSellerColLoc
            RaiseEvent Collapsed(sender, e)
        Else
            Exit Sub
        End If
    End Sub
    Private Sub _OnExpanded(ByVal sender As Object, ByVal e As CollapsiblePanelEventArgs) Handles Me.Expanded
        _isCollasped = False
    End Sub
    Private Sub _OnCollapsed(ByVal sender As Object, ByVal e As CollapsiblePanelEventArgs) Handles Me.Collapsed
        _isCollasped = True
    End Sub

    Private Sub Me_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        Try
            ControlPaint.DrawBorder(e.Graphics, Me.ClientRectangle,
                                      Color.WhiteSmoke, 3, ButtonBorderStyle.Outset,
                                      Color.WhiteSmoke, 3, ButtonBorderStyle.Outset,
                                      Color.WhiteSmoke, 3, ButtonBorderStyle.Outset,
                                      Color.WhiteSmoke, 3, ButtonBorderStyle.Outset)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        '#############OR ALTERNATIVE WAY###############
        'Me.BorderStyle = BorderStyle.FixedSingle
        'Dim pen As Pen = New Pen(Color.Gold, 3)
        'e.Graphics.DrawRectangle(pen,
        '                         e.ClipRectangle.Left,
        '                         e.ClipRectangle.Top,
        '                         e.ClipRectangle.Width,
        '                         e.ClipRectangle.Height)
    End Sub

#Region "CollapsiblePanelEventArgs"
    Public Class CollapsiblePanelEventArgs
#Region "Properties"
        Public Property Cancel As Boolean = False
        Public Property Size As Size = New Size(265, 30) '(10, 5)
        Public Property Width As Integer = Size.Width
        Public Property Height As Integer = Size.Height
#End Region
#Region "Constructors"
        Public Sub New()
        End Sub
        Public Sub New(ByVal cancel As Boolean)
            Me.Cancel = cancel
        End Sub
        Public Sub New(ByVal cancel As Boolean, size As Size)
            Me.Cancel = cancel
            Me.Size = size
        End Sub
#End Region
    End Class
#End Region
End Class
