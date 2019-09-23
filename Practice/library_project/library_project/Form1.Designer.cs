namespace library_project
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.New_reader_button = new System.Windows.Forms.Button();
            this.New_book_button = new System.Windows.Forms.Button();
            this.Search_reader_button = new System.Windows.Forms.Button();
            this.Search_book_button = new System.Windows.Forms.Button();
            this.Statistic_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(346, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // New_reader_button
            // 
            this.New_reader_button.Location = new System.Drawing.Point(228, 177);
            this.New_reader_button.Name = "New_reader_button";
            this.New_reader_button.Size = new System.Drawing.Size(331, 49);
            this.New_reader_button.TabIndex = 1;
            this.New_reader_button.Text = "Новый читатель";
            this.New_reader_button.UseVisualStyleBackColor = true;
            this.New_reader_button.Click += new System.EventHandler(this.New_reader_button_Click);
            // 
            // New_book_button
            // 
            this.New_book_button.Location = new System.Drawing.Point(228, 232);
            this.New_book_button.Name = "New_book_button";
            this.New_book_button.Size = new System.Drawing.Size(331, 49);
            this.New_book_button.TabIndex = 2;
            this.New_book_button.Text = "Новая книга";
            this.New_book_button.UseVisualStyleBackColor = true;
            this.New_book_button.Click += new System.EventHandler(this.New_book_button_Click);
            // 
            // Search_reader_button
            // 
            this.Search_reader_button.Location = new System.Drawing.Point(228, 287);
            this.Search_reader_button.Name = "Search_reader_button";
            this.Search_reader_button.Size = new System.Drawing.Size(331, 49);
            this.Search_reader_button.TabIndex = 3;
            this.Search_reader_button.Text = "Поиск читателя";
            this.Search_reader_button.UseVisualStyleBackColor = true;
            this.Search_reader_button.Click += new System.EventHandler(this.Search_reader_button_Click);
            // 
            // Search_book_button
            // 
            this.Search_book_button.Location = new System.Drawing.Point(228, 342);
            this.Search_book_button.Name = "Search_book_button";
            this.Search_book_button.Size = new System.Drawing.Size(331, 49);
            this.Search_book_button.TabIndex = 4;
            this.Search_book_button.Text = "Поиск книги";
            this.Search_book_button.UseVisualStyleBackColor = true;
            this.Search_book_button.Click += new System.EventHandler(this.Search_book_button_Click);
            // 
            // Statistic_button
            // 
            this.Statistic_button.Location = new System.Drawing.Point(228, 397);
            this.Statistic_button.Name = "Statistic_button";
            this.Statistic_button.Size = new System.Drawing.Size(331, 49);
            this.Statistic_button.TabIndex = 5;
            this.Statistic_button.Text = "Статистика";
            this.Statistic_button.UseVisualStyleBackColor = true;
            this.Statistic_button.Click += new System.EventHandler(this.Statistic_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 483);
            this.Controls.Add(this.Statistic_button);
            this.Controls.Add(this.Search_book_button);
            this.Controls.Add(this.Search_reader_button);
            this.Controls.Add(this.New_book_button);
            this.Controls.Add(this.New_reader_button);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "library";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button New_reader_button;
        private System.Windows.Forms.Button New_book_button;
        private System.Windows.Forms.Button Search_reader_button;
        private System.Windows.Forms.Button Search_book_button;
        private System.Windows.Forms.Button Statistic_button;
    }
}

