namespace WinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();

            Label lblName = new Label();
            Label lblAge = new Label();
            Label lblLanguage = new Label();
            Button btnSubmit = new Button();
            Label lblFooter = new Label();

            SuspendLayout();

            lblName.AutoSize = true;
            lblName.Location = new Point(30, 30);
            lblName.Text = "Name:";

            txtName = new TextBox();
            txtName.Location = new Point(200, 27);
            txtName.Width = 180;

            lblAge.AutoSize = true;
            lblAge.Location = new Point(30, 70);
            lblAge.Text = "Age:";

            txtAge = new TextBox();
            txtAge.Location = new Point(200, 67);
            txtAge.Width = 180;

            lblLanguage.AutoSize = true;
            lblLanguage.Location = new Point(30, 110);
            lblLanguage.Text = "Favorite Language:";

            txtLanguage = new TextBox();
            txtLanguage.Location = new Point(200, 107);
            txtLanguage.Width = 180;

            btnSubmit.Location = new Point(160, 160);
            btnSubmit.Text = "Submit";
            btnSubmit.Width = 100;
            btnSubmit.Height = 35;
            btnSubmit.Click += BtnSubmit_Click;

            lblFooter.AutoSize = true;
            lblFooter.Location = new Point(180, 270);
            lblFooter.Text = "WinForms";
            lblFooter.Font = new Font("Arial", 10, FontStyle.Bold);

            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 300);
            Text = "Survey Form";
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(lblAge);
            Controls.Add(txtAge);
            Controls.Add(lblLanguage);
            Controls.Add(txtLanguage);
            Controls.Add(btnSubmit);
            Controls.Add(lblFooter);

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtLanguage;
    }
}
