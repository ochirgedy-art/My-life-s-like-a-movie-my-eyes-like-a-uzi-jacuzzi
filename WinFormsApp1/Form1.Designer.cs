namespace WinFormsApp1
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
            txtWord = new TextBox();
            panel1 = new Panel();
            txtMeaning = new TextBox();
            label6 = new Label();
            lblMeaning = new Label();
            btnSearch = new Button();
            btnAdd = new Button();
            lstWords = new ListBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtWord
            // 
            txtWord.Location = new Point(86, 73);
            txtWord.Name = "txtWord";
            txtWord.Size = new Size(100, 23);
            txtWord.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RoyalBlue;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 50);
            panel1.TabIndex = 1;
            // 
            // txtMeaning
            // 
            txtMeaning.Location = new Point(86, 102);
            txtMeaning.Name = "txtMeaning";
            txtMeaning.Size = new Size(100, 23);
            txtMeaning.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(29, 73);
            label6.Name = "label6";
            label6.Size = new Size(29, 19);
            label6.TabIndex = 5;
            label6.Text = "UG";
            // 
            // lblMeaning
            // 
            lblMeaning.AutoSize = true;
            lblMeaning.Font = new Font("Segoe UI", 10F);
            lblMeaning.Location = new Point(29, 151);
            lblMeaning.Name = "lblMeaning";
            lblMeaning.Size = new Size(113, 19);
            lblMeaning.TabIndex = 6;
            lblMeaning.Text = "Tailbar/orchuulga";
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(206, 72);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(100, 23);
            btnSearch.TabIndex = 7;
            btnSearch.Text = "Haih";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(312, 73);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 23);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Ug nemeh";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lstWords
            // 
            lstWords.FormattingEnabled = true;
            lstWords.Location = new Point(148, 151);
            lstWords.Name = "lstWords";
            lstWords.Size = new Size(305, 94);
            lstWords.TabIndex = 9;
            lstWords.SelectedIndexChanged += lstWords_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(253, 37);
            label1.TabIndex = 0;
            label1.Text = "SUPER DICTIONARY";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstWords);
            Controls.Add(btnAdd);
            Controls.Add(btnSearch);
            Controls.Add(lblMeaning);
            Controls.Add(label6);
            Controls.Add(txtMeaning);
            Controls.Add(panel1);
            Controls.Add(txtWord);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWord;
        private Panel panel1;
        private TextBox txtMeaning;
        private Label label6;
        private Label lblMeaning;
        private Button btnSearch;
        private Button btnAdd;
        private ListBox lstWords;
        private Label label1;
    }
}
