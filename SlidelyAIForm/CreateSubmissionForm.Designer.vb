<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CreateSubmissionForm
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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.lblGitHubLink = New System.Windows.Forms.Label()
        Me.txtGitHubLink = New System.Windows.Forms.TextBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnStartPause = New System.Windows.Forms.Button()
        Me.lblElapsedTime = New System.Windows.Forms.Label()
        Me.tmrStopwatch = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(45, 40)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(55, 20)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name:"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(150, 37)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(230, 26)
        Me.txtName.TabIndex = 1
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.Location = New System.Drawing.Point(45, 90)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(52, 20)
        Me.lblEmail.TabIndex = 2
        Me.lblEmail.Text = "Email:"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(150, 87)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(230, 26)
        Me.txtEmail.TabIndex = 3
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(45, 140)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(59, 20)
        Me.lblPhone.TabIndex = 4
        Me.lblPhone.Text = "Phone:"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(150, 137)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(230, 26)
        Me.txtPhone.TabIndex = 5
        '
        'lblGitHubLink
        '
        Me.lblGitHubLink.AutoSize = True
        Me.lblGitHubLink.Location = New System.Drawing.Point(45, 190)
        Me.lblGitHubLink.Name = "lblGitHubLink"
        Me.lblGitHubLink.Size = New System.Drawing.Size(97, 20)
        Me.lblGitHubLink.TabIndex = 6
        Me.lblGitHubLink.Text = "GitHub Link:"
        '
        'txtGitHubLink
        '
        Me.txtGitHubLink.Location = New System.Drawing.Point(150, 187)
        Me.txtGitHubLink.Name = "txtGitHubLink"
        Me.txtGitHubLink.Size = New System.Drawing.Size(230, 26)
        Me.txtGitHubLink.TabIndex = 7
        '
        'btnSubmit
        '
        Me.btnSubmit.Location = New System.Drawing.Point(49, 249)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(165, 55)
        Me.btnSubmit.TabIndex = 8
        Me.btnSubmit.Text = "Submit (ctrl+S)"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'btnStartPause
        '
        Me.btnStartPause.Location = New System.Drawing.Point(236, 249)
        Me.btnStartPause.Name = "btnStartPause"
        Me.btnStartPause.Size = New System.Drawing.Size(165, 55)
        Me.btnStartPause.TabIndex = 9
        Me.btnStartPause.Text = "Toggle Stopwatch"
        Me.btnStartPause.UseVisualStyleBackColor = True
        '
        'lblElapsedTime
        '
        Me.lblElapsedTime.AutoSize = True
        Me.lblElapsedTime.Location = New System.Drawing.Point(45, 329)
        Me.lblElapsedTime.Name = "lblElapsedTime"
        Me.lblElapsedTime.Size = New System.Drawing.Size(71, 20)
        Me.lblElapsedTime.TabIndex = 10
        Me.lblElapsedTime.Text = "00:00:00"
        '
        'CreateSubmissionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(428, 386)
        Me.Controls.Add(Me.lblElapsedTime)
        Me.Controls.Add(Me.btnStartPause)
        Me.Controls.Add(Me.btnSubmit)
        Me.Controls.Add(Me.txtGitHubLink)
        Me.Controls.Add(Me.lblGitHubLink)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.lblPhone)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.lblEmail)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "CreateSubmissionForm"
        Me.Text = "Create Submission"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblPhone As Label
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents lblGitHubLink As Label
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnStartPause As Button
    Friend WithEvents lblElapsedTime As Label
    Friend WithEvents tmrStopwatch As Timer
End Class
