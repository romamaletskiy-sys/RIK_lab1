<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New System.ComponentModel.Container()

        Dim lblName As New Label()
        Dim lblAge As New Label()
        Dim lblLanguage As New Label()
        Dim btnSubmit As New Button()
        Dim lblFooter As New Label()

        Me.SuspendLayout()

        lblName.AutoSize = True
        lblName.Location = New Point(30, 30)
        lblName.Text = "Name:"

        Me.txtName = New TextBox()
        Me.txtName.Location = New Point(200, 27)
        Me.txtName.Width = 180

        lblAge.AutoSize = True
        lblAge.Location = New Point(30, 70)
        lblAge.Text = "Age:"

        Me.txtAge = New TextBox()
        Me.txtAge.Location = New Point(200, 67)
        Me.txtAge.Width = 180

        lblLanguage.AutoSize = True
        lblLanguage.Location = New Point(30, 110)
        lblLanguage.Text = "Favorite Language:"

        Me.txtLanguage = New TextBox()
        Me.txtLanguage.Location = New Point(200, 107)
        Me.txtLanguage.Width = 180

        btnSubmit.Location = New Point(160, 160)
        btnSubmit.Text = "Submit"
        btnSubmit.Width = 100
        btnSubmit.Height = 35
        AddHandler btnSubmit.Click, AddressOf BtnSubmit_Click

        lblFooter.AutoSize = True
        lblFooter.Location = New Point(190, 270)
        lblFooter.Text = "WPF"
        lblFooter.Font = New Font("Arial", 10, FontStyle.Bold)

        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(420, 300)
        Text = "Survey Form"
        Controls.Add(lblName)
        Controls.Add(Me.txtName)
        Controls.Add(lblAge)
        Controls.Add(Me.txtAge)
        Controls.Add(lblLanguage)
        Controls.Add(Me.txtLanguage)
        Controls.Add(btnSubmit)
        Controls.Add(lblFooter)

        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private WithEvents txtName As TextBox
    Private WithEvents txtAge As TextBox
    Private WithEvents txtLanguage As TextBox

End Class
