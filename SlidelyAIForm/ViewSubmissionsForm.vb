Imports System.Net.Http
Imports Newtonsoft.Json

Public Class ViewSubmissionsForm

    Private submissions As List(Of Submission)
    Private currentIndex As Integer = 0

    Private Sub ViewSubmissionsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
        FetchSubmissionsFromBackend()
    End Sub

    Private Async Sub FetchSubmissionsFromBackend()
        Try
            Using client As New HttpClient()
                Dim response As HttpResponseMessage = Await client.GetAsync("http://localhost:3000/readAll")

                If response.IsSuccessStatusCode Then
                    Dim jsonResponse As String = Await response.Content.ReadAsStringAsync()
                    submissions = JsonConvert.DeserializeObject(Of List(Of Submission))(jsonResponse)
                    ShowSubmissionDetails(currentIndex)
                Else
                    MessageBox.Show("Failed to fetch submissions.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error fetching submissions: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ShowSubmissionDetails(index As Integer)
        If submissions IsNot Nothing AndAlso index >= 0 AndAlso index < submissions.Count Then
            Dim currentSubmission As Submission = submissions(index)
            txtName.Text = currentSubmission.Name
            txtEmail.Text = currentSubmission.Email
            txtPhone.Text = currentSubmission.Phone
            txtGitHubLink.Text = currentSubmission.GitHubLink
        Else
            ClearSubmissionDetails()
        End If
    End Sub

    Private Sub ClearSubmissionDetails()
        txtName.Text = ""
        txtEmail.Text = ""
        txtPhone.Text = ""
        txtGitHubLink.Text = ""
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        NavigateToPreviousSubmission()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        NavigateToNextSubmission()
    End Sub

    Private Sub ViewSubmissionsForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.P Then
            NavigateToPreviousSubmission()
        ElseIf e.Control AndAlso e.KeyCode = Keys.N Then
            NavigateToNextSubmission()
        End If
    End Sub

    Private Sub NavigateToPreviousSubmission()
        currentIndex -= 1
        If currentIndex < 0 Then
            currentIndex = 0
        End If
        ShowSubmissionDetails(currentIndex)
    End Sub

    Private Sub NavigateToNextSubmission()
        currentIndex += 1
        If currentIndex >= submissions.Count Then
            currentIndex = submissions.Count - 1
        End If
        ShowSubmissionDetails(currentIndex)
    End Sub

End Class
