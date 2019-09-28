namespace BookSearchProgram
{
    partial class frmBookSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnProcessAdd = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblAddKeyword = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtAddKeywords = new System.Windows.Forms.TextBox();
            this.txtSearchKeyword = new System.Windows.Forms.TextBox();
            this.lblSearchKeyword = new System.Windows.Forms.Label();
            this.btnProcessSearch = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnName = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.pnlSearch.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(90, 54);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(56, 19);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add Book";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(334, 54);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(56, 19);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search Book";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Visible = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnProcessAdd
            // 
            this.btnProcessAdd.Location = new System.Drawing.Point(45, 80);
            this.btnProcessAdd.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcessAdd.Name = "btnProcessAdd";
            this.btnProcessAdd.Size = new System.Drawing.Size(110, 21);
            this.btnProcessAdd.TabIndex = 11;
            this.btnProcessAdd.Text = "Process Command";
            this.btnProcessAdd.UseVisualStyleBackColor = true;
            this.btnProcessAdd.Click += new System.EventHandler(this.btnProcessAdd_Click);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(11, 14);
            this.lblWelcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(117, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome! Enter Name:";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(30, 15);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "Title:";
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Location = new System.Drawing.Point(30, 37);
            this.lblAuthor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 7;
            this.lblAuthor.Text = "Author:";
            // 
            // lblAddKeyword
            // 
            this.lblAddKeyword.AutoSize = true;
            this.lblAddKeyword.Location = new System.Drawing.Point(30, 59);
            this.lblAddKeyword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddKeyword.Name = "lblAddKeyword";
            this.lblAddKeyword.Size = new System.Drawing.Size(56, 13);
            this.lblAddKeyword.TabIndex = 9;
            this.lblAddKeyword.Text = "Keywords:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 11);
            this.txtName.Margin = new System.Windows.Forms.Padding(2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(76, 20);
            this.txtName.TabIndex = 1;
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(89, 34);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(2);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(76, 20);
            this.txtAuthor.TabIndex = 8;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(89, 11);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(2);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(76, 20);
            this.txtTitle.TabIndex = 6;
            // 
            // txtAddKeywords
            // 
            this.txtAddKeywords.Location = new System.Drawing.Point(89, 56);
            this.txtAddKeywords.Margin = new System.Windows.Forms.Padding(2);
            this.txtAddKeywords.Name = "txtAddKeywords";
            this.txtAddKeywords.Size = new System.Drawing.Size(76, 20);
            this.txtAddKeywords.TabIndex = 10;
            // 
            // txtSearchKeyword
            // 
            this.txtSearchKeyword.Location = new System.Drawing.Point(100, 31);
            this.txtSearchKeyword.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(76, 20);
            this.txtSearchKeyword.TabIndex = 13;
            // 
            // lblSearchKeyword
            // 
            this.lblSearchKeyword.AutoSize = true;
            this.lblSearchKeyword.Location = new System.Drawing.Point(27, 34);
            this.lblSearchKeyword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchKeyword.Name = "lblSearchKeyword";
            this.lblSearchKeyword.Size = new System.Drawing.Size(51, 13);
            this.lblSearchKeyword.TabIndex = 12;
            this.lblSearchKeyword.Text = "Keyword:";
            // 
            // btnProcessSearch
            // 
            this.btnProcessSearch.Location = new System.Drawing.Point(60, 80);
            this.btnProcessSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnProcessSearch.Name = "btnProcessSearch";
            this.btnProcessSearch.Size = new System.Drawing.Size(97, 21);
            this.btnProcessSearch.TabIndex = 14;
            this.btnProcessSearch.Text = "Process Search";
            this.btnProcessSearch.UseVisualStyleBackColor = true;
            this.btnProcessSearch.Click += new System.EventHandler(this.btnProcessSearch_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(415, 217);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(53, 21);
            this.btnExit.TabIndex = 15;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnName
            // 
            this.btnName.Location = new System.Drawing.Point(242, 9);
            this.btnName.Name = "btnName";
            this.btnName.Size = new System.Drawing.Size(84, 23);
            this.btnName.TabIndex = 2;
            this.btnName.Text = "Validate Name";
            this.btnName.UseVisualStyleBackColor = true;
            this.btnName.Click += new System.EventHandler(this.btnName_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.lblSearchKeyword);
            this.pnlSearch.Controls.Add(this.txtSearchKeyword);
            this.pnlSearch.Controls.Add(this.btnProcessSearch);
            this.pnlSearch.Enabled = false;
            this.pnlSearch.Location = new System.Drawing.Point(263, 84);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(200, 111);
            this.pnlSearch.TabIndex = 15;
            this.pnlSearch.Visible = false;
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.txtTitle);
            this.pnlAdd.Controls.Add(this.lblTitle);
            this.pnlAdd.Controls.Add(this.lblAuthor);
            this.pnlAdd.Controls.Add(this.lblAddKeyword);
            this.pnlAdd.Controls.Add(this.txtAuthor);
            this.pnlAdd.Controls.Add(this.txtAddKeywords);
            this.pnlAdd.Controls.Add(this.btnProcessAdd);
            this.pnlAdd.Enabled = false;
            this.pnlAdd.Location = new System.Drawing.Point(15, 84);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(200, 111);
            this.pnlAdd.TabIndex = 16;
            this.pnlAdd.Visible = false;
            // 
            // frmBookSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(479, 249);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.btnName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnAdd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmBookSearch";
            this.Text = "Add And Search";
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnProcessAdd;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblAddKeyword;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtAddKeywords;
        private System.Windows.Forms.TextBox txtSearchKeyword;
        private System.Windows.Forms.Label lblSearchKeyword;
        private System.Windows.Forms.Button btnProcessSearch;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnName;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel pnlAdd;
    }
}

