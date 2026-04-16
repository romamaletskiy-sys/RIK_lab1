Imports System.IO

Public Class Form1

    Private Sub BtnSubmit_Click(sender As Object, e As EventArgs)
        Dim entry As String =
            $"--- Survey Entry [{DateTime.Now}] ---{Environment.NewLine}" &
            $"Name: {txtName.Text}{Environment.NewLine}" &
            $"Age: {txtAge.Text}{Environment.NewLine}" &
            $"Favorite Language: {txtLanguage.Text}{Environment.NewLine}" &
            Environment.NewLine

        Dim filePath As String = Path.Combine(Application.StartupPath, "survey_answers.txt")
        File.AppendAllText(filePath, entry)

        MessageBox.Show("Survey saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

        txtName.Clear()
        txtAge.Clear()
        txtLanguage.Clear()
    End Sub

End Class
