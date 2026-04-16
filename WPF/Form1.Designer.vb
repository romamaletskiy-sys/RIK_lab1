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

        Dim pnlHeader As New Panel()
        Dim lblTitle As New Label()
        Dim pnlContent As New Panel()
        Dim lblName As New Label()
        Dim lblAge As New Label()
        Dim lblLanguage As New Label()
        Dim btnSubmit As New Button()
        Dim lblFooter As New Label()

        Me.SuspendLayout()

        ' ── Header panel ──────────────────────────────────────────
        pnlHeader.Dock = DockStyle.Top
        pnlHeader.Height = 60
        pnlHeader.BackColor = Color.FromArgb(220, 38, 38)

        lblTitle.Text = "📋  Survey Form"
        lblTitle.Font = New Font("Segoe UI", 16, FontStyle.Bold)
        lblTitle.ForeColor = Color.White
        lblTitle.AutoSize = True
        lblTitle.Location = New Point(16, 14)
        pnlHeader.Controls.Add(lblTitle)

        ' ── Content panel ─────────────────────────────────────────
        pnlContent.Location = New Point(0, 60)
        pnlContent.Size = New Size(460, 260)
        pnlContent.BackColor = Color.FromArgb(245, 247, 250)

        Dim labelFont As New Font("Segoe UI", 10, FontStyle.Regular)
        Dim inputFont As New Font("Segoe UI", 10)
        Dim labelColor As Color = Color.FromArgb(55, 65, 81)

        ' Name row
        lblName.Text = "Name:"
        lblName.Font = labelFont
        lblName.ForeColor = labelColor
        lblName.AutoSize = True
        lblName.Location = New Point(30, 33)

        Me.txtName = New TextBox()
        Me.txtName.Font = inputFont
        Me.txtName.Location = New Point(200, 30)
        Me.txtName.Width = 210
        Me.txtName.BorderStyle = BorderStyle.FixedSingle
        Me.txtName.BackColor = Color.White

        ' Age row
        lblAge.Text = "Age:"
        lblAge.Font = labelFont
        lblAge.ForeColor = labelColor
        lblAge.AutoSize = True
        lblAge.Location = New Point(30, 83)

        Me.txtAge = New TextBox()
        Me.txtAge.Font = inputFont
        Me.txtAge.Location = New Point(200, 80)
        Me.txtAge.Width = 210
        Me.txtAge.BorderStyle = BorderStyle.FixedSingle
        Me.txtAge.BackColor = Color.White

        ' Language ComboBox
        lblLanguage.Text = "Favorite Language:"
        lblLanguage.Font = labelFont
        lblLanguage.ForeColor = labelColor
        lblLanguage.AutoSize = True
        lblLanguage.Location = New Point(30, 133)

        Me.cboLanguage = New ComboBox()
        Me.cboLanguage.Font = inputFont
        Me.cboLanguage.Location = New Point(200, 130)
        Me.cboLanguage.Width = 210
        Me.cboLanguage.DropDownStyle = ComboBoxStyle.DropDown
        Me.cboLanguage.AutoCompleteMode = AutoCompleteMode.SuggestAppend
        Me.cboLanguage.AutoCompleteSource = AutoCompleteSource.ListItems
        Me.cboLanguage.Items.AddRange(New String() {
            "C#", "Visual Basic .NET", "C++", "C", "Java", "Python",
            "JavaScript", "TypeScript", "Go", "Rust", "PHP", "Ruby",
            "Swift", "Kotlin", "Dart", "F#", "Scala", "R", "MATLAB", "SQL"
        })

        ' ── Submit button ─────────────────────────────────────────
        btnSubmit.Text = "Submit"
        btnSubmit.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        btnSubmit.ForeColor = Color.White
        btnSubmit.BackColor = Color.FromArgb(220, 38, 38)
        btnSubmit.FlatStyle = FlatStyle.Flat
        btnSubmit.FlatAppearance.BorderSize = 0
        btnSubmit.Size = New Size(120, 38)
        btnSubmit.Location = New Point(170, 185)
        btnSubmit.Cursor = Cursors.Hand
        AddHandler btnSubmit.Click, AddressOf BtnSubmit_Click

        ' ── Footer label ──────────────────────────────────────────
        lblFooter.Text = "WPF"
        lblFooter.Font = New Font("Segoe UI", 8, FontStyle.Italic)
        lblFooter.ForeColor = Color.FromArgb(156, 163, 175)
        lblFooter.AutoSize = True
        lblFooter.Location = New Point(210, 237)

        pnlContent.Controls.Add(lblName)
        pnlContent.Controls.Add(Me.txtName)
        pnlContent.Controls.Add(lblAge)
        pnlContent.Controls.Add(Me.txtAge)
        pnlContent.Controls.Add(lblLanguage)
        pnlContent.Controls.Add(Me.cboLanguage)
        pnlContent.Controls.Add(btnSubmit)
        pnlContent.Controls.Add(lblFooter)

        ' ── Form ──────────────────────────────────────────────────
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(460, 320)
        BackColor = Color.FromArgb(245, 247, 250)
        Text = "Survey Form"
        StartPosition = FormStartPosition.CenterScreen
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False

        Controls.Add(pnlContent)
        Controls.Add(pnlHeader)

        Me.ResumeLayout(False)
        Me.PerformLayout()
    End Sub

    Private WithEvents txtName     As TextBox
    Private WithEvents txtAge      As TextBox
    Private WithEvents cboLanguage As ComboBox

End Class
