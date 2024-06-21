<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        TextBox1 = New TextBox()
        lblName = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGitHubLink = New Label()
        lblStopwatchTime = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHubLink = New TextBox()
        txtStopwatchTime = New TextBox()
        btnprevious = New Button()
        btnedit = New Button()
        btnsave = New Button()
        btnnext = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = SystemColors.GradientInactiveCaption
        TextBox1.Location = New Point(247, 21)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(370, 27)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Vishwak , Slidely Task 2 - View Submissions "
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(186, 100)
        lblName.Name = "lblName"
        lblName.Size = New Size(49, 20)
        lblName.TabIndex = 1
        lblName.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(186, 158)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(182, 214)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(50, 20)
        lblPhone.TabIndex = 3
        lblPhone.Text = "Phone"
        ' 
        ' lblGitHubLink
        ' 
        lblGitHubLink.AutoSize = True
        lblGitHubLink.Location = New Point(173, 267)
        lblGitHubLink.Name = "lblGitHubLink"
        lblGitHubLink.Size = New Size(86, 20)
        lblGitHubLink.TabIndex = 4
        lblGitHubLink.Text = "GitHub Link"
        ' 
        ' lblStopwatchTime
        ' 
        lblStopwatchTime.AutoSize = True
        lblStopwatchTime.Location = New Point(173, 320)
        lblStopwatchTime.Name = "lblStopwatchTime"
        lblStopwatchTime.Size = New Size(112, 20)
        lblStopwatchTime.TabIndex = 5
        lblStopwatchTime.Text = "StopwatchTime"
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.MenuBar
        txtName.Location = New Point(356, 93)
        txtName.Name = "txtName"
        txtName.Size = New Size(300, 27)
        txtName.TabIndex = 6
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.MenuBar
        txtEmail.Location = New Point(356, 151)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(300, 27)
        txtEmail.TabIndex = 7
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = SystemColors.MenuBar
        txtPhone.Location = New Point(356, 207)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(300, 27)
        txtPhone.TabIndex = 8
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.BackColor = SystemColors.MenuBar
        txtGitHubLink.Location = New Point(356, 260)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(300, 27)
        txtGitHubLink.TabIndex = 9
        ' 
        ' txtStopwatchTime
        ' 
        txtStopwatchTime.BackColor = SystemColors.MenuBar
        txtStopwatchTime.Location = New Point(356, 313)
        txtStopwatchTime.Name = "txtStopwatchTime"
        txtStopwatchTime.Size = New Size(300, 27)
        txtStopwatchTime.TabIndex = 10
        ' 
        ' btnprevious
        ' 
        btnprevious.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnprevious.Location = New Point(197, 398)
        btnprevious.Name = "btnprevious"
        btnprevious.Size = New Size(160, 29)
        btnprevious.TabIndex = 11
        btnprevious.Text = "Previous (CTRL + P)"
        btnprevious.UseVisualStyleBackColor = False
        ' 
        ' btnedit
        ' 
        btnedit.BackColor = Color.NavajoWhite
        btnedit.Location = New Point(410, 374)
        btnedit.Name = "btnedit"
        btnedit.Size = New Size(144, 29)
        btnedit.TabIndex = 12
        btnedit.Text = "Edit (CTRL + H)"
        btnedit.UseVisualStyleBackColor = False
        ' 
        ' btnsave
        ' 
        btnsave.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(128))
        btnsave.Location = New Point(410, 409)
        btnsave.Name = "btnsave"
        btnsave.Size = New Size(144, 29)
        btnsave.TabIndex = 13
        btnsave.Text = "Save"
        btnsave.UseVisualStyleBackColor = False
        ' 
        ' btnnext
        ' 
        btnnext.BackColor = Color.FromArgb(CByte(128), CByte(255), CByte(255))
        btnnext.Location = New Point(624, 398)
        btnnext.Name = "btnnext"
        btnnext.Size = New Size(147, 29)
        btnnext.TabIndex = 14
        btnnext.Text = "Next (CTRL + N)"
        btnnext.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.GradientInactiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(btnnext)
        Controls.Add(btnsave)
        Controls.Add(btnedit)
        Controls.Add(btnprevious)
        Controls.Add(txtStopwatchTime)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblStopwatchTime)
        Controls.Add(lblGitHubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblName)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGitHubLink As Label
    Friend WithEvents lblStopwatchTime As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents txtStopwatchTime As TextBox
    Friend WithEvents btnprevious As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnsave As Button
    Friend WithEvents btnnext As Button
End Class
