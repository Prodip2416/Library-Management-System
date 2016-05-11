namespace Library_Management
{
    partial class Issue_Books
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAllBooks = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvIssueBooks = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBooks)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(362, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(201, 25);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Search Books Here";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvAllBooks);
            this.panel1.Location = new System.Drawing.Point(40, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(732, 211);
            this.panel1.TabIndex = 4;
            // 
            // dgvAllBooks
            // 
            this.dgvAllBooks.AllowUserToAddRows = false;
            this.dgvAllBooks.AllowUserToDeleteRows = false;
            this.dgvAllBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvAllBooks.Name = "dgvAllBooks";
            this.dgvAllBooks.ReadOnly = true;
            this.dgvAllBooks.Size = new System.Drawing.Size(732, 211);
            this.dgvAllBooks.TabIndex = 0;
            this.dgvAllBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllBooks_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "All Books";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvIssueBooks);
            this.panel2.Location = new System.Drawing.Point(43, 324);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(729, 179);
            this.panel2.TabIndex = 6;
            // 
            // dgvIssueBooks
            // 
            this.dgvIssueBooks.AllowUserToAddRows = false;
            this.dgvIssueBooks.AllowUserToDeleteRows = false;
            this.dgvIssueBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIssueBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvIssueBooks.Location = new System.Drawing.Point(0, 0);
            this.dgvIssueBooks.Name = "dgvIssueBooks";
            this.dgvIssueBooks.ReadOnly = true;
            this.dgvIssueBooks.Size = new System.Drawing.Size(729, 179);
            this.dgvIssueBooks.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "My Issue Books";
            // 
            // Issue_Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 525);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Issue_Books";
            this.Text = "Issue_Books";
            this.Load += new System.EventHandler(this.Issue_Books_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllBooks)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIssueBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAllBooks;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvIssueBooks;
        private System.Windows.Forms.Label label3;
    }
}