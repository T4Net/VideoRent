<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Name_TextBox = New System.Windows.Forms.TextBox()
        Me.Surname_TextBox = New System.Windows.Forms.TextBox()
        Me.Username_TextBox = New System.Windows.Forms.TextBox()
        Me.Pass_TextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FrmReg_mainLabel = New System.Windows.Forms.Label()
        Me.Ok_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Name_TextBox
        '
        Me.Name_TextBox.Location = New System.Drawing.Point(27, 69)
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.Size = New System.Drawing.Size(184, 20)
        Me.Name_TextBox.TabIndex = 0
        '
        'Surname_TextBox
        '
        Me.Surname_TextBox.Location = New System.Drawing.Point(27, 117)
        Me.Surname_TextBox.Name = "Surname_TextBox"
        Me.Surname_TextBox.Size = New System.Drawing.Size(184, 20)
        Me.Surname_TextBox.TabIndex = 1
        '
        'Username_TextBox
        '
        Me.Username_TextBox.Location = New System.Drawing.Point(27, 165)
        Me.Username_TextBox.Name = "Username_TextBox"
        Me.Username_TextBox.Size = New System.Drawing.Size(184, 20)
        Me.Username_TextBox.TabIndex = 2
        '
        'Pass_TextBox
        '
        Me.Pass_TextBox.Location = New System.Drawing.Point(27, 213)
        Me.Pass_TextBox.Name = "Pass_TextBox"
        Me.Pass_TextBox.Size = New System.Drawing.Size(184, 20)
        Me.Pass_TextBox.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(24, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(24, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Surname"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label3.Location = New System.Drawing.Point(24, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Username"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(24, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Password"
        '
        'FrmReg_mainLabel
        '
        Me.FrmReg_mainLabel.AutoSize = True
        Me.FrmReg_mainLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.FrmReg_mainLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.FrmReg_mainLabel.Location = New System.Drawing.Point(25, 9)
        Me.FrmReg_mainLabel.Name = "FrmReg_mainLabel"
        Me.FrmReg_mainLabel.Size = New System.Drawing.Size(271, 26)
        Me.FrmReg_mainLabel.TabIndex = 8
        Me.FrmReg_mainLabel.Text = "Please enter information to register new user." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Min. 4 characters required in eac" & _
    "h field below."
        '
        'Ok_Button
        '
        Me.Ok_Button.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Ok_Button.Location = New System.Drawing.Point(27, 253)
        Me.Ok_Button.Name = "Ok_Button"
        Me.Ok_Button.Size = New System.Drawing.Size(75, 23)
        Me.Ok_Button.TabIndex = 9
        Me.Ok_Button.Text = "Ok"
        Me.Ok_Button.UseVisualStyleBackColor = False
        '
        'Cancel_Button
        '
        Me.Cancel_Button.BackColor = System.Drawing.SystemColors.MenuBar
        Me.Cancel_Button.Location = New System.Drawing.Point(136, 253)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(75, 23)
        Me.Cancel_Button.TabIndex = 10
        Me.Cancel_Button.Text = "Cancel"
        Me.Cancel_Button.UseVisualStyleBackColor = False
        '
        'RegistrationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(362, 302)
        Me.Controls.Add(Me.Cancel_Button)
        Me.Controls.Add(Me.Ok_Button)
        Me.Controls.Add(Me.FrmReg_mainLabel)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pass_TextBox)
        Me.Controls.Add(Me.Username_TextBox)
        Me.Controls.Add(Me.Surname_TextBox)
        Me.Controls.Add(Me.Name_TextBox)
        Me.Name = "RegistrationForm"
        Me.Text = "RegistrationForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Name_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Surname_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Username_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Pass_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents FrmReg_mainLabel As System.Windows.Forms.Label
    Friend WithEvents Ok_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
End Class
