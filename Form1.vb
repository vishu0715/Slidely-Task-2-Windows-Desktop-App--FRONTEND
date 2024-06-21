Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Diagnostics

Public Class Form1
    Private index As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Set the text boxes to read-only initially
        SetReadOnlyFields(True)

        ' Load initial submission data
        LoadSubmission(index)

        ' Enable KeyPreview so the form receives key events
        Me.KeyPreview = True

        ' Hide the Save button initially
        btnsave.Visible = False
    End Sub

    Private Sub SetReadOnlyFields(ByVal [readOnly] As Boolean)
        txtName.ReadOnly = [readOnly]
        txtEmail.ReadOnly = [readOnly]
        txtPhone.ReadOnly = [readOnly]
        txtGitHubLink.ReadOnly = [readOnly]
        txtStopwatchTime.ReadOnly = [readOnly]
    End Sub

    Private Async Sub LoadSubmission(index As Integer)
        Try
            Dim httpClient As New HttpClient()
            Dim response As HttpResponseMessage = Await httpClient.GetAsync($"http://localhost:3000/read?index={index}")

            If response.IsSuccessStatusCode Then
                Dim json As String = Await response.Content.ReadAsStringAsync()
                Debug.WriteLine($"Received JSON: {json}")
                DisplaySubmission(json) ' Pass raw JSON string to display method
            Else
                MessageBox.Show("Failed to fetch submission.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub DisplaySubmission(json As String)
        Try
            Dim submissionData As JObject = JObject.Parse(json)

            txtName.Text = submissionData("name").ToString()
            txtEmail.Text = submissionData("email").ToString()
            txtPhone.Text = submissionData("phone").ToString()
            txtGitHubLink.Text = submissionData("github_link").ToString()

            ' Format StopwatchTime to 00:00:00 format
            Dim stopwatchTime As String = submissionData("stopwatch_time").ToString()
            If Not String.IsNullOrEmpty(stopwatchTime) Then
                Dim timeSpan As TimeSpan = TimeSpan.Parse(stopwatchTime)
                txtStopwatchTime.Text = timeSpan.ToString("hh\:mm\:ss")
            Else
                txtStopwatchTime.Text = ""
            End If
        Catch ex As Exception
            MessageBox.Show("Error parsing JSON: " & ex.Message)
        End Try
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnprevious.Click
        If index > 0 Then
            index -= 1
            LoadSubmission(index)
        Else
            MessageBox.Show("Already at the first submission.")
        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        index += 1
        LoadSubmission(index)
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle keyboard shortcuts Ctrl + P, Ctrl + N, and Ctrl + E
        If e.Control AndAlso e.KeyCode = Keys.P Then
            btnPrevious_Click(Nothing, Nothing)
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            btnNext_Click(Nothing, Nothing)
        ElseIf e.Control AndAlso e.KeyCode = Keys.H Then
            e.SuppressKeyPress = True ' Suppress the key press to prevent further processing
            btnedit_Click(Nothing, Nothing) ' Trigger btnedit click event programmatically
        End If

        ' For Enter key, handle directly
        If e.KeyCode = Keys.Enter Then
            btnSave_Click(Nothing, Nothing)
        End If
    End Sub

    Private Sub btnedit_Click(sender As Object, e As EventArgs) Handles btnedit.Click
        ' Enable editing of text boxes
        SetReadOnlyFields(False)

        ' Hide navigation buttons
        btnprevious.Visible = False
        btnnext.Visible = False
        btnedit.Visible = False
        btnsave.Visible = True ' Show the Save button
    End Sub

    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        ' Save changes to database
        Await SaveChanges()

        ' Reload and display the edited submission
        LoadSubmission(index)

        ' Restore read-only state and show navigation buttons
        SetReadOnlyFields(True)
        btnprevious.Visible = True
        btnnext.Visible = True
        btnedit.Visible = True
        btnsave.Visible = False ' Hide the Save button after saving
    End Sub

    Private Async Function SaveChanges() As Task
        Try
            Dim submissionData As New JObject()
            submissionData("name") = txtName.Text
            submissionData("email") = txtEmail.Text
            submissionData("phone") = txtPhone.Text
            submissionData("github_link") = txtGitHubLink.Text
            submissionData("stopwatch_time") = txtStopwatchTime.Text

            Dim httpClient As New HttpClient()
            Dim content As New StringContent(submissionData.ToString(), System.Text.Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await httpClient.PostAsync("http://localhost:3000/update", content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Changes saved successfully.")
            Else
                MessageBox.Show("Failed to save changes.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
