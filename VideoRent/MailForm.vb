Public Class MailForm
    Inherits Windows.Forms.Form

    Friend WithEvents MailSendToLabel As System.Windows.Forms.Label
    Friend WithEvents MailSubjectLabel As System.Windows.Forms.Label
    Friend WithEvents MailBodyLabel As System.Windows.Forms.Label
    Friend WithEvents MailAttachmentLabel As System.Windows.Forms.Label
    Friend WithEvents MailSenderLabel As System.Windows.Forms.Label
    Friend WithEvents MailSendToTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MailSubjectTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MailBodyTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents MailAttachmentTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MailSenderTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MailSendButton As System.Windows.Forms.Button
    Friend WithEvents MailBrowseButton As System.Windows.Forms.Button
    Dim components() As Control

    Public Sub New()
        MyBase.New
        InitializeComponent()
    End Sub

    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        MyBase.Dispose(disposing)
    End Sub

    Private Sub InitializeComponent()
        MailSendToLabel = New System.Windows.Forms.Label
        MailSubjectLabel = New System.Windows.Forms.Label
        MailBodyLabel = New System.Windows.Forms.Label
        MailAttachmentLabel = New System.Windows.Forms.Label
        MailSenderLabel = New System.Windows.Forms.Label
        MailSendToTextBox = New System.Windows.Forms.TextBox
        MailSubjectTextBox = New System.Windows.Forms.TextBox
        MailBodyTextBox = New System.Windows.Forms.RichTextBox
        MailAttachmentTextBox = New System.Windows.Forms.TextBox
        MailSenderTextBox = New System.Windows.Forms.TextBox
        MailSendButton = New System.Windows.Forms.Button
        MailBrowseButton = New System.Windows.Forms.Button

        'MailSendToLabel
        With MailSendToLabel
            .AutoSize = True
            .Location = New System.Drawing.Point(12, 36)
            .Name = "MailSendToLabel"
            .Size = New System.Drawing.Size(39, 13)
            .TabIndex = 0
            .Text = "To:"
        End With

        'MailSubjectLabel
        With MailSubjectLabel
            .AutoSize = True
            .Location = New System.Drawing.Point(12, 72)
            .Name = "MailSubjectLabel"
            .Size = New System.Drawing.Size(39, 13)
            .TabIndex = 1
            .Text = "Subject:"
        End With
        '
        'MailBodyLabel
        With MailBodyLabel
            .AutoSize = True
            .Location = New System.Drawing.Point(12, 148)
            .Name = "MailBodyLabel"
            .Size = New System.Drawing.Size(39, 13)
            .TabIndex = 2
            .Text = "Body:"
        End With

        'MailAttachmentLabel
        With MailAttachmentLabel
            .AutoSize = True
            .Location = New System.Drawing.Point(12, 297)
            .Name = "MailAttachmentLabel"
            .Size = New System.Drawing.Size(39, 13)
            .TabIndex = 3
            .Text = "File Attachment:"
        End With

        'MailSenderLabel
        With MailSenderLabel
            .AutoSize = True
            .Location = New System.Drawing.Point(12, 334)
            .Name = "MailSenderLabel"
            .Size = New System.Drawing.Size(39, 13)
            .TabIndex = 4
            .Text = "Sender:"
        End With

        'MailSendToTextBox
        With MailSendToTextBox
            .Location = New System.Drawing.Point(71, 33)
            .Name = "MailSendToTextBox"
            .Size = New System.Drawing.Size(170, 20)
            .TabIndex = 5
        End With

        'MailSubjectTextBox
        With MailSubjectTextBox
            .Location = New System.Drawing.Point(71, 69)
            .Name = "MailSubjectTextBox"
            .Size = New System.Drawing.Size(170, 20)
            .TabIndex = 6
        End With

        'MailBodyTextBox
        With MailBodyTextBox
            .Location = New System.Drawing.Point(71, 148)
            .Name = "MailBodyTextBox"
            .Size = New System.Drawing.Size(326, 119)
            .TabIndex = 7
            .Text = ""
        End With

        'MailAttachmentTextBox
        With MailAttachmentTextBox
            .Location = New System.Drawing.Point(71, 294)
            .Name = "MailAttachmentTextBox"
            .Size = New System.Drawing.Size(170, 20)
            .TabIndex = 8
        End With

        'MailSenderTextBox
        With MailSenderTextBox
            .Location = New System.Drawing.Point(71, 331)
            .Name = "MailSenderTextBox"
            .Size = New System.Drawing.Size(170, 20)
            .TabIndex = 9
        End With

        'MailSendButton
        With MailSendButton
            .Location = New System.Drawing.Point(71, 366)
            .Name = "MailSendButton"
            .Size = New System.Drawing.Size(75, 23)
            .TabIndex = 10
            .Text = "Send"
            .UseVisualStyleBackColor = True
        End With

        'MailBrowseButton
        With MailBrowseButton
            .Location = New System.Drawing.Point(247, 292)
            .Name = "MailBrowseButton"
            .Size = New System.Drawing.Size(75, 23)
            .TabIndex = 11
            .Text = "Browse"
            .UseVisualStyleBackColor = True
        End With

        'Me
        components = New System.Windows.Forms.Control() {MailSendToLabel, MailSubjectLabel, MailBodyLabel,
            MailAttachmentLabel, MailSenderLabel, MailSendToTextBox, MailSubjectTextBox,
           MailBodyTextBox, MailAttachmentTextBox, MailSenderTextBox, MailSendButton, MailBrowseButton}

        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(409, 397)
        Me.Controls.AddRange(components)
        Me.Text = "Send Email"
        Me.ResumeLayout(False)
        Me.PerformLayout()
        Me.Name = "MailForm"
    End Sub

    'The color and the width of the border.
    Private borderColor As Color = Color.Black 'Border Color
    Private borderWidth As Integer = 10
    Private formRegion As Rectangle

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        'Sets the location of the form w.r.t the position
        formRegion = New Rectangle(0, 0, 653, 408) 'Here 653 and 408 is form's Size

    End Sub

    Private Sub Me_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        'Draws the border.
        ControlPaint.DrawBorder(e.Graphics, formRegion, borderColor,
        borderWidth, ButtonBorderStyle.Solid, borderColor, borderWidth,
        ButtonBorderStyle.Solid, borderColor, borderWidth, ButtonBorderStyle.Solid,
        borderColor, borderWidth, ButtonBorderStyle.Solid)
    End Sub
End Class
