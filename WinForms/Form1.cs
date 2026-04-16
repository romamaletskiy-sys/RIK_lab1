namespace WinForms
{
    using System.IO;

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnSubmit_Click(object? sender, EventArgs e)
        {
            // ── Validation ────────────────────────────────────────────
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please enter your name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }

            if (!int.TryParse(txtAge.Text.Trim(), out int age) || age < 1 || age > 120)
            {
                MessageBox.Show("Please enter a valid age (1–120).", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(cboLanguage.Text))
            {
                MessageBox.Show("Please select or enter your favorite programming language.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboLanguage.Focus();
                return;
            }

            // ── Save to file ──────────────────────────────────────────
            string entry =
                $"--- Survey Entry [{DateTime.Now}] ---{Environment.NewLine}" +
                $"Name: {txtName.Text.Trim()}{Environment.NewLine}" +
                $"Age: {age}{Environment.NewLine}" +
                $"Favorite Language: {cboLanguage.Text}{Environment.NewLine}" +
                Environment.NewLine;

            string path = Path.Combine(Application.StartupPath, "survey_answers.txt");
            File.AppendAllText(path, entry);

            MessageBox.Show("Survey saved successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtName.Clear();
            txtAge.Clear();
            cboLanguage.SelectedIndex = -1;
            cboLanguage.Text = string.Empty;
        }
    }
}
