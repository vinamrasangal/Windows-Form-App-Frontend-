Imports System.Net.Http
Imports Newtonsoft.Json

Public Class CreateSubmissionForm

    Private Sub CreateSubmissionForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub CreateSubmissionForm_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.S Then
            e.SuppressKeyPress = True
            SubmitForm()
        End If
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        SubmitForm()
    End Sub

    Private Async Sub SubmitForm()
        Dim submission As New Submission()
        submission.Name = txtName.Text
        submission.Email = txtEmail.Text
        submission.Phone = txtPhone.Text
        submission.GitHubLink = txtGitHubLink.Text


        Debug.WriteLine("Submission Details:")
        Debug.WriteLine($"Name: {submission.Name}")
        Debug.WriteLine($"Email: {submission.Email}")
        Debug.WriteLine($"Phone: {submission.Phone}")
        Debug.WriteLine($"GitHub Link: {submission.GitHubLink}")

        Await SubmitToBackend(submission)
    End Sub

    Private Async Function SubmitToBackend(submission As Submission) As Task
        Try
            Using client As New HttpClient()
                Dim jsonSubmission As String = JsonConvert.SerializeObject(submission)
                Dim content As New StringContent(jsonSubmission, System.Text.Encoding.UTF8, "application/json")

                Dim response As HttpResponseMessage = Await client.PostAsync("http://localhost:3000/submit", content)

                If response.IsSuccessStatusCode Then
                    MessageBox.Show("Submission successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ResetForm()
                Else
                    Dim errorMessage As String = Await response.Content.ReadAsStringAsync()
                    MessageBox.Show($"Failed to submit. Server returned: {response.StatusCode}. Error: {errorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End Using
        Catch ex As Exception
            MessageBox.Show($"Error submitting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub ResetForm()
        txtName.Clear()
        txtEmail.Clear()
        txtPhone.Clear()
        txtGitHubLink.Clear()
    End Sub

End Class
