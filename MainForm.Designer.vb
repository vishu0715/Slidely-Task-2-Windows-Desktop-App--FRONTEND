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
        TextBox1 = New TextBox()
        btnNavigateForm1 = New Button()
        btnNavigateForm2 = New Button()
        btndelete = New Button()
        btnsearch = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.MistyRose
        TextBox1.BorderStyle = BorderStyle.None
        TextBox1.Location = New Point(216, 30)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(376, 20)
        TextBox1.TabIndex = 0
        TextBox1.Text = "Vishwak , Slidely Task 2 - Slidely Form App "
        TextBox1.TextAlign = HorizontalAlignment.Center
        ' 
        ' btnNavigateForm1
        ' 
        btnNavigateForm1.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(128))
        btnNavigateForm1.Location = New Point(278, 102)
        btnNavigateForm1.Name = "btnNavigateForm1"
        btnNavigateForm1.Size = New Size(255, 51)
        btnNavigateForm1.TabIndex = 1
        btnNavigateForm1.Text = "View Submissions (CTRL + V)"
        btnNavigateForm1.UseVisualStyleBackColor = False
        ' 
        ' btnNavigateForm2
        ' 
        btnNavigateForm2.BackColor = Color.FromArgb(CByte(192), CByte(255), CByte(255))
        btnNavigateForm2.Location = New Point(278, 178)
        btnNavigateForm2.Name = "btnNavigateForm2"
        btnNavigateForm2.Size = New Size(255, 49)
        btnNavigateForm2.TabIndex = 2
        btnNavigateForm2.Text = "Create New Submission (CTRL + N)"
        btnNavigateForm2.UseVisualStyleBackColor = False
        ' 
        ' btndelete
        ' 
        btndelete.BackColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        btndelete.Location = New Point(278, 257)
        btndelete.Name = "btndelete"
        btndelete.Size = New Size(255, 53)
        btndelete.TabIndex = 3
        btndelete.Text = "Delete a Submission (CTRL + D)"
        btndelete.UseVisualStyleBackColor = False
        ' 
        ' btnsearch
        ' 
        btnsearch.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        btnsearch.Location = New Point(278, 344)
        btnsearch.Name = "btnsearch"
        btnsearch.Size = New Size(255, 51)
        btnsearch.TabIndex = 4
        btnsearch.Text = "Search Submission (CTRL + F)"
        btnsearch.UseVisualStyleBackColor = False
        ' 
        ' MainForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.MistyRose
        ClientSize = New Size(800, 450)
        Controls.Add(btnsearch)
        Controls.Add(btndelete)
        Controls.Add(btnNavigateForm2)
        Controls.Add(btnNavigateForm1)
        Controls.Add(TextBox1)
        Name = "MainForm"
        Text = "MainForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnNavigateForm1 As Button
    Friend WithEvents btnNavigateForm2 As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnsearch As Button

End Class
