<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        components = New ComponentModel.Container()
        TextBox1 = New TextBox()
        lblname = New Label()
        lblEmail = New Label()
        lblPhone = New Label()
        lblGitHubLink = New Label()
        txtName = New TextBox()
        txtEmail = New TextBox()
        txtPhone = New TextBox()
        txtGitHubLink = New TextBox()
        btnStartStopwatch = New Button()
        btnSubmit = New Button()
        Timer1 = New Timer(components)
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        TextBox1.Location = New Point(216, 28)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(363, 27)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Vishwak , Slidely Task 2 - Create New Submission "
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' lblname
        ' 
        lblname.AutoSize = True
        lblname.Location = New Point(213, 111)
        lblname.Name = "lblname"
        lblname.Size = New Size(49, 20)
        lblname.TabIndex = 1
        lblname.Text = "Name"
        ' 
        ' lblEmail
        ' 
        lblEmail.AutoSize = True
        lblEmail.Location = New Point(216, 179)
        lblEmail.Name = "lblEmail"
        lblEmail.Size = New Size(46, 20)
        lblEmail.TabIndex = 2
        lblEmail.Text = "Email"
        ' 
        ' lblPhone
        ' 
        lblPhone.AutoSize = True
        lblPhone.Location = New Point(216, 243)
        lblPhone.Name = "lblPhone"
        lblPhone.Size = New Size(50, 20)
        lblPhone.TabIndex = 3
        lblPhone.Text = "Phone"
        ' 
        ' lblGitHubLink
        ' 
        lblGitHubLink.AutoSize = True
        lblGitHubLink.Location = New Point(216, 306)
        lblGitHubLink.Name = "lblGitHubLink"
        lblGitHubLink.Size = New Size(86, 20)
        lblGitHubLink.TabIndex = 4
        lblGitHubLink.Text = "GitHub Link"
        ' 
        ' txtName
        ' 
        txtName.BackColor = SystemColors.InactiveBorder
        txtName.Location = New Point(406, 111)
        txtName.Name = "txtName"
        txtName.Size = New Size(262, 27)
        txtName.TabIndex = 5
        ' 
        ' txtEmail
        ' 
        txtEmail.BackColor = SystemColors.InactiveBorder
        txtEmail.Location = New Point(406, 172)
        txtEmail.Name = "txtEmail"
        txtEmail.Size = New Size(262, 27)
        txtEmail.TabIndex = 6
        ' 
        ' txtPhone
        ' 
        txtPhone.BackColor = SystemColors.InactiveBorder
        txtPhone.Location = New Point(406, 236)
        txtPhone.Name = "txtPhone"
        txtPhone.Size = New Size(262, 27)
        txtPhone.TabIndex = 7
        ' 
        ' txtGitHubLink
        ' 
        txtGitHubLink.BackColor = SystemColors.InactiveBorder
        txtGitHubLink.Location = New Point(406, 299)
        txtGitHubLink.Name = "txtGitHubLink"
        txtGitHubLink.Size = New Size(262, 27)
        txtGitHubLink.TabIndex = 8
        ' 
        ' btnStartStopwatch
        ' 
        btnStartStopwatch.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(192))
        btnStartStopwatch.Location = New Point(145, 351)
        btnStartStopwatch.Name = "btnStartStopwatch"
        btnStartStopwatch.Size = New Size(238, 39)
        btnStartStopwatch.TabIndex = 9
        btnStartStopwatch.Text = "StopWatch Timer (CTRL + T)"
        btnStartStopwatch.UseVisualStyleBackColor = False
        ' 
        ' btnSubmit
        ' 
        btnSubmit.BackColor = Color.FromArgb(CByte(128), CByte(128), CByte(255))
        btnSubmit.Location = New Point(406, 397)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(173, 41)
        btnSubmit.TabIndex = 10
        btnSubmit.Text = "Submit (CTRL + S)"
        btnSubmit.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        ClientSize = New Size(800, 450)
        Controls.Add(btnSubmit)
        Controls.Add(btnStartStopwatch)
        Controls.Add(txtGitHubLink)
        Controls.Add(txtPhone)
        Controls.Add(txtEmail)
        Controls.Add(txtName)
        Controls.Add(lblGitHubLink)
        Controls.Add(lblPhone)
        Controls.Add(lblEmail)
        Controls.Add(lblname)
        Controls.Add(TextBox1)
        Name = "Form2"
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lblname As Label
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblGitHubLink As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtGitHubLink As TextBox
    Friend WithEvents btnStartStopwatch As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Timer1 As Timer
End Class
