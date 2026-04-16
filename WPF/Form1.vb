Imports System.IO

Public Class Form1

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs)
        ' ── Validation ────────────────────────────────────────────
        If String.IsNullOrWhiteSpace(txtName.Text) Then
            MessageBox.Show("Please enter your name.", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtName.Focus()
            Return
        End If

        Dim age As Integer
        If Not Integer.TryParse(txtAge.Text.Trim(), age) OrElse age < 1 OrElse age > 120 Then
            MessageBox.Show("Please enter a valid age (1–120).", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtAge.Focus()
            Return
        End If

        If String.IsNullOrWhiteSpace(cboLanguage.Text) Then
            MessageBox.Show("Please select or enter your favorite programming language.", "Validation Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboLanguage.Focus()
            Return
        End If

        ' ── Save to file ──────────────────────────────────────────
        Dim entry As String =
            $"--- Survey Entry [{DateTime.Now}] ---{Environment.NewLine}" &
            $"Name: {txtName.Text.Trim()}{Environment.NewLine}" &
            $"Age: {age}{Environment.NewLine}" &
            $"Favorite Language: {cboLanguage.Text}{Environment.NewLine}" &
            Environment.NewLine

        Dim filePath As String = Path.Combine(Application.StartupPath, "survey_answers.txt")
        File.AppendAllText(filePath, entry)

        MessageBox.Show("Survey saved successfully!", "Success",
            MessageBoxButtons.OK, MessageBoxIcon.Information)

        txtName.Clear()
        txtAge.Clear()
        cboLanguage.SelectedIndex = -1
        cboLanguage.Text = String.Empty
    End Sub

End Class
