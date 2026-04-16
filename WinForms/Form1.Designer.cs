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

            Panel pnlHeader    = new Panel();
            Label lblTitle     = new Label();
            Panel pnlContent   = new Panel();
            Label lblName      = new Label();
            Label lblAge       = new Label();
            Label lblLanguage  = new Label();
            Button btnSubmit   = new Button();
            Label lblFooter    = new Label();

            SuspendLayout();

            // ── Header panel ──────────────────────────────────────────
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Height = 60;
            pnlHeader.BackColor = Color.FromArgb(37, 99, 235);   // blue-600

            lblTitle.Text = "📋  Survey Form";
            lblTitle.Font = new Font("Segoe UI", 16, FontStyle.Bold);
            lblTitle.ForeColor = Color.White;
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(16, 14);
            pnlHeader.Controls.Add(lblTitle);

            // ── Content panel ─────────────────────────────────────────
            pnlContent.Location = new Point(0, 60);
            pnlContent.Size = new Size(460, 260);
            pnlContent.BackColor = Color.FromArgb(245, 247, 250);

            Font labelFont   = new Font("Segoe UI", 10, FontStyle.Regular);
            Font inputFont   = new Font("Segoe UI", 10);
            Color labelColor = Color.FromArgb(55, 65, 81);

            void AddRow(Label lbl, TextBox txt, string text, int y)
            {
                lbl.Text      = text;
                lbl.Font      = labelFont;
                lbl.ForeColor = labelColor;
                lbl.AutoSize  = true;
                lbl.Location  = new Point(30, y + 3);

                txt.Font      = inputFont;
                txt.Location  = new Point(200, y);
                txt.Width     = 210;
                txt.Height    = 28;
                txt.BorderStyle = BorderStyle.FixedSingle;
                txt.BackColor = Color.White;

                pnlContent.Controls.Add(lbl);
                pnlContent.Controls.Add(txt);
            }

            AddRow(lblName,     txtName     = new TextBox(), "Name:",             30);
            AddRow(lblAge,      txtAge      = new TextBox(), "Age:",              80);
            AddRow(lblLanguage, txtLanguage = new TextBox(), "Favorite Language:", 130);

            // ── Submit button ─────────────────────────────────────────
            btnSubmit.Text      = "Submit";
            btnSubmit.Font      = new Font("Segoe UI", 10, FontStyle.Bold);
            btnSubmit.ForeColor = Color.White;
            btnSubmit.BackColor = Color.FromArgb(37, 99, 235);
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.Size      = new Size(120, 38);
            btnSubmit.Location  = new Point(170, 185);
            btnSubmit.Cursor    = Cursors.Hand;
            btnSubmit.Click    += BtnSubmit_Click;
            pnlContent.Controls.Add(btnSubmit);

            // ── Footer label ──────────────────────────────────────────
            lblFooter.Text      = "WinForms";
            lblFooter.Font      = new Font("Segoe UI", 8, FontStyle.Italic);
            lblFooter.ForeColor = Color.FromArgb(156, 163, 175);
            lblFooter.AutoSize  = true;
            lblFooter.Location  = new Point(190, 237);
            pnlContent.Controls.Add(lblFooter);

            // ── Form ──────────────────────────────────────────────────
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize    = new Size(460, 320);
            BackColor     = Color.FromArgb(245, 247, 250);
            Text          = "Survey Form";
            StartPosition = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox   = false;

            Controls.Add(pnlContent);
            Controls.Add(pnlHeader);

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtLanguage;
    }
}
