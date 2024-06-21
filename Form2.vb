Imports System.Net.Http
Imports Newtonsoft.Json

Public Class Form2
    Private Class Submission
        Public Property Name As String
        Public Property Email As String
        Public Property Phone As String
        Public Property GitHubLink As String
        Public Property StopwatchTime As String
    End Class

    Private stopwatch As Stopwatch = New Stopwatch()
    Private elapsedAtStop As TimeSpan = TimeSpan.Zero ' To store elapsed time when stopwatch is stopped

    Friend WithEvents lblElapsedTime As Label ' Declare lblElapsedTime at class level

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Enable editing by setting ReadOnly to False
        txtName.ReadOnly = False
        txtEmail.ReadOnly = False
        txtPhone.ReadOnly = False
        txtGitHubLink.ReadOnly = False

        ' Load sample data 
        'txtName.Text = "Jane Doe"
        'txtEmail.Text = "jane.doe@example.com"
        'txtPhone.Text = "987-654-3210"
        'txtGitHubLink.Text = "https://github.com/janedoe"

        ' Create and configure lblElapsedTime
        lblElapsedTime = New Label()
        lblElapsedTime.AutoSize = True
        lblElapsedTime.Text = "00:00:00" ' Initial text

        ' Calculate the position based on btnStartStopwatch's position and size
        Dim lblElapsedTimeLeft = btnStartStopwatch.Left + btnStartStopwatch.Width + 200
        Dim lblElapsedTimeTop = btnStartStopwatch.Top + (btnStartStopwatch.Height - lblElapsedTime.Height) / 2
        lblElapsedTime.Location = New Point(lblElapsedTimeLeft, lblElapsedTimeTop)
        Me.Controls.Add(lblElapsedTime) ' Add lblElapsedTime to the form

        ' Start the Timer1 to update the stopwatch display
        Timer1.Interval = 1000 ' Update every 1 second
        Timer1.Start()

        ' Enable KeyPreview to capture key events in the form
        Me.KeyPreview = True
    End Sub

    Private Sub btnStartStopwatch_Click(sender As Object, e As EventArgs) Handles btnStartStopwatch.Click
        If Not stopwatch.IsRunning Then
            stopwatch.Start()
            btnStartStopwatch.Text = "Stop Stopwatch"
        Else
            stopwatch.Stop()
            elapsedAtStop = stopwatch.Elapsed ' Store current elapsed time
            btnStartStopwatch.Text = "Start Stopwatch"
        End If
    End Sub

    Private Async Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim submission As New Submission() With {
            .Name = txtName.Text,
            .Email = txtEmail.Text,
            .Phone = txtPhone.Text,
            .GitHubLink = txtGitHubLink.Text,
            .StopwatchTime = If(stopwatch.IsRunning, stopwatch.Elapsed.ToString(), elapsedAtStop.ToString()) ' Use stored elapsed time if stopwatch is stopped
        }

        Try
            Dim httpClient As New HttpClient()
            Dim json As String = JsonConvert.SerializeObject(submission)
            Dim content As New StringContent(json, System.Text.Encoding.UTF8, "application/json")
            Dim response As HttpResponseMessage = Await httpClient.PostAsync("http://localhost:3000/submit", content)

            If response.IsSuccessStatusCode Then
                MessageBox.Show("Submission saved successfully.")
                Me.Close()
            ElseIf response.StatusCode = Net.HttpStatusCode.BadRequest Then
                Dim errorResponse As String = Await response.Content.ReadAsStringAsync()
                Dim errorObject As Object = JsonConvert.DeserializeObject(errorResponse)
                MessageBox.Show($"Failed to save submission. Error: {errorObject("error")}")
            Else
                MessageBox.Show("Failed to save submission.")
            End If
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If stopwatch.IsRunning Then
            lblElapsedTime.Text = stopwatch.Elapsed.ToString("hh\:mm\:ss")
        Else
            lblElapsedTime.Text = elapsedAtStop.ToString("hh\:mm\:ss") ' Update label with stored elapsed time when stopped
        End If
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        ' Handle keyboard shortcuts
        If e.Control AndAlso e.KeyCode = Keys.T Then
            btnStartStopwatch.PerformClick() ' Simulate btnStartStopwatch click
        ElseIf e.Control AndAlso e.KeyCode = Keys.S Then
            btnSubmit.PerformClick() ' Simulate btnSubmit click
        End If
    End Sub
End Class
