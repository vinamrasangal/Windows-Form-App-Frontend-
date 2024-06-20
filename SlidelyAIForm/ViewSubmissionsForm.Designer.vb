<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ViewSubmissionsForm
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
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtGitHubLink = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblGitHubLink = New System.Windows.Forms.Label()
        Me.lblStopwatchTime = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(18, 18)
        Me.btnPrevious.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(138, 35)
        Me.btnPrevious.TabIndex = 0
        Me.btnPrevious.Text = "Previous (ctrl+P)"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(164, 18)
        Me.btnNext.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(112, 35)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next (ctrl+N)"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(152, 89)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtName.Name = "txtName"
        Me.txtName.ReadOnly = True
        Me.txtName.Size = New System.Drawing.Size(373, 26)
        Me.txtName.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(152, 129)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.ReadOnly = True
        Me.txtEmail.Size = New System.Drawing.Size(373, 26)
        Me.txtEmail.TabIndex = 3
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(152, 169)
        Me.txtPhone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.ReadOnly = True
        Me.txtPhone.Size = New System.Drawing.Size(373, 26)
        Me.txtPhone.TabIndex = 4
        '
        'txtGitHubLink
        '
        Me.txtGitHubLink.Location = New System.Drawing.Point(152, 209)
        Me.txtGitHubLink.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.txtGitHubLink.Name = "txtGitHubLink"
        Me.txtGitHubLink.ReadOnly = True
        Me.txtGitHubLink.Size = New System.Drawing.Size(373, 26)
        Me.txtGitHubLink.TabIndex = 5
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(18, 94)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 20)
        Me.lblName.TabIndex = 6
        Me.lblName.Text = "Name:"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(18, 134)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(52, 20)
        Me.lblEmail.TabIndex = 7
        Me.lblEmail.Text = "Email:"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(18, 174)
        Me.lblPhone.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(59, 20)
        Me.lblPhone.TabIndex = 8
        Me.lblPhone.Text = "Phone:"
        '
        'lblGitHubLink
        '
        Me.lblGitHubLink.AutoSize = True
        Me.lblGitHubLink.Location = New System.Drawing.Point(18, 214)
        Me.lblGitHubLink.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGitHubLink.Name = "lblGitHubLink"
        Me.lblGitHubLink.Size = New System.Drawing.Size(97, 20)
        Me.lblGitHubLink.TabIndex = 9
        Me.lblGitHubLink.Text = "GitHub Link:"
        '
        'lblStopwatchTime
        '
        Me.lblStopwatchTime.AutoSize = True
        Me.lblStopwatchTime.Location = New System.Drawing.Point(18, 254)
        Me.lblStopwatchTime.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblStopwatchTime.Name = "lblStopwatchTime"
        Me.lblStopwatchTime.Size = New System.Drawing.Size(127, 20)
        Me.lblStopwatchTime.TabIndex = 10
        Me.lblStopwatchTime.Text = "Stopwatch Time:"
        '
        'ViewSubmissionsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 308)
        Me.Controls.Add(Me.lblStopwatchTime)
        Me.Controls.Add(Me.lblGitHubLink)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtGitHubLink)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnPrevious)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ViewSubmissionsForm"
        Me.Text = "View Submissions"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGitHubLink As Label
    Friend WithEvents lblStopwatchTime As Label
End Class
