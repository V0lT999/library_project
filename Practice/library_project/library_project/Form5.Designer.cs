namespace library_project
{
    partial class Search_book_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_book_form));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_books = new System.Windows.Forms.ComboBox();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.button_more = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(231, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Книги библиотеки";
            // 
            // comboBox_books
            // 
            this.comboBox_books.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox_books.FormattingEnabled = true;
            this.comboBox_books.Location = new System.Drawing.Point(33, 113);
            this.comboBox_books.Name = "comboBox_books";
            this.comboBox_books.Size = new System.Drawing.Size(729, 281);
            this.comboBox_books.TabIndex = 3;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(201, 74);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(392, 22);
            this.textBox_Search.TabIndex = 4;
            this.textBox_Search.Text = "Поиск";
            this.textBox_Search.TextChanged += new System.EventHandler(this.TextBox_Search_TextChanged);
            // 
            // button_more
            // 
            this.button_more.Location = new System.Drawing.Point(324, 400);
            this.button_more.Name = "button_more";
            this.button_more.Size = new System.Drawing.Size(138, 38);
            this.button_more.TabIndex = 5;
            this.button_more.Text = "Подробнее";
            this.button_more.UseVisualStyleBackColor = true;
            this.button_more.Click += new System.EventHandler(this.Button_more_Click);
            // 
            // Search_book_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_more);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.comboBox_books);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search_book_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск книг";
            this.Load += new System.EventHandler(this.Search_book_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_more;
        public System.Windows.Forms.ComboBox comboBox_books;
        protected System.Windows.Forms.TextBox textBox_Search;
    }
}