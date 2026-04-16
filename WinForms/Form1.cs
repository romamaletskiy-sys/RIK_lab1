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
            string entry =
                $"--- Survey Entry [{DateTime.Now}] ---{Environment.NewLine}" +
                $"Name: {txtName.Text}{Environment.NewLine}" +
                $"Age: {txtAge.Text}{Environment.NewLine}" +
                $"Favorite Language: {txtLanguage.Text}{Environment.NewLine}" +
                Environment.NewLine;

            string path = Path.Combine(Application.StartupPath, "survey_answers.txt");
            File.AppendAllText(path, entry);

            MessageBox.Show("Survey saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtName.Clear();
            txtAge.Clear();
            txtLanguage.Clear();
        }
    }
}
