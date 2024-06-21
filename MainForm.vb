Imports System.Net.Http
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class MainForm
    ' Define the base URL of the Node.js backend
    Private Const BASE_URL As String = "http://localhost:3000"

    Private Async Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        ' Prompt for the email ID of the submission to delete
        Dim emailToDelete As String = InputBox("Enter the Email ID of the submission to delete:", "Delete Submission")

        If String.IsNullOrWhiteSpace(emailToDelete) Then
            MessageBox.Show("Email ID cannot be empty. Deletion canceled.")
            Return
        End If

        ' Check if the submission with the given email exists
        Dim submissionToDelete As JObject = Await GetSubmissionByEmail(emailToDelete)

        If submissionToDelete Is Nothing Then
            MessageBox.Show($"Submission with email '{emailToDelete}' not found.")
            Return
        End If

        ' Confirm deletion
        Dim confirmResult As DialogResult = MessageBox.Show($"Are you sure you want to delete the submission with email '{emailToDelete}'?",
                                                             "Confirm Delete", MessageBoxButtons.YesNo)

        If confirmResult = DialogResult.Yes Then
            ' Perform deletion
            Dim deletionSuccessful As Boolean = Await DeleteSubmissionByEmail(emailToDelete)

            If deletionSuccessful Then
                MessageBox.Show($"Submission with email '{emailToDelete}' deleted successfully.")
            Else
                MessageBox.Show($"Failed to delete submission with email '{emailToDelete}'.")
            End If
        Else
            MessageBox.Show("Deletion canceled.")
        End If
    End Sub

    Private Async Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        ' Prompt for the email ID to search
        Dim emailToSearch As String = InputBox("Enter the Email ID to search:", "Search Submission")

        If String.IsNullOrWhiteSpace(emailToSearch) Then
            MessageBox.Show("Email ID cannot be empty. Search canceled.")
            Return
        End If

        ' Check if the submission with the given email exists
        Dim submissionFound As JObject = Await GetSubmissionByEmail(emailToSearch)

        If submissionFound Is Nothing Then
            MessageBox.Show($"Submission with email '{emailToSearch}' not found.")
        Else
            ' Display submission details
            Dim name As String = submissionFound("name").ToString()
            Dim phone As String = submissionFound("phone").ToString()
            Dim githubLink As String = submissionFound("github_link").ToString()
            Dim stopwatchTime As String = submissionFound("stopwatch_time").ToString()

            Dim detailsMessage As String = $"Name: {name}{vbCrLf}Email: {emailToSearch}{vbCrLf}Phone: {phone}{vbCrLf}GitHub Link: {githubLink}{vbCrLf}Stopwatch Time: {stopwatchTime}"
            MessageBox.Show(detailsMessage, "Submission Details")
        End If
    End Sub

    Private Async Function GetSubmissionByEmail(email As String) As Task(Of JObject)
        Try
            Using httpClient As New HttpClient()
                Dim response As HttpResponseMessage = Await httpClient.GetAsync($"{BASE_URL}/readByEmail?email={email}")

                If response.IsSuccessStatusCode Then
                    Dim json As String = Await response.Content.ReadAsStringAsync()
                    Return JObject.Parse(json)
                Else
                    Return Nothing
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return Nothing
        End Try
    End Function

    Private Async Function DeleteSubmissionByEmail(email As String) As Task(Of Boolean)
        Try
            Using httpClient As New HttpClient()
                Dim response As HttpResponseMessage = Await httpClient.DeleteAsync($"{BASE_URL}/delete?email={email}")

                If response.IsSuccessStatusCode Then
                    Return True
                Else
                    Return False
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
            Return False
        End Try
    End Function

    ' ProcessCmdKey remains as is for navigation shortcuts
    Protected Overrides Function ProcessCmdKey(ByRef msg As Message, ByVal keyData As Keys) As Boolean
        If keyData = (Keys.Control Or Keys.V) Then
            btnNavigateForm1.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.N) Then
            btnNavigateForm2.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.D) Then
            btndelete.PerformClick()
            Return True
        ElseIf keyData = (Keys.Control Or Keys.F) Then
            btnsearch.PerformClick()
            Return True
        End If
        Return MyBase.ProcessCmdKey(msg, keyData)
    End Function

    Private Sub btnNavigateForm1_Click(sender As Object, e As EventArgs) Handles btnNavigateForm1.Click
        Dim form1 As New Form1()
        form1.Show()
    End Sub

    Private Sub btnNavigateForm2_Click(sender As Object, e As EventArgs) Handles btnNavigateForm2.Click
        Dim form2 As New Form2()
        form2.Show()
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
