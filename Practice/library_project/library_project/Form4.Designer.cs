namespace library_project
{
    partial class Search_reader_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Search_reader_form));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_readers = new System.Windows.Forms.ComboBox();
            this.Profile_button = new System.Windows.Forms.Button();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(326, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Пользователи библиотеки";
            // 
            // comboBox_readers
            // 
            this.comboBox_readers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox_readers.FormattingEnabled = true;
            this.comboBox_readers.Location = new System.Drawing.Point(18, 101);
            this.comboBox_readers.Name = "comboBox_readers";
            this.comboBox_readers.Size = new System.Drawing.Size(741, 297);
            this.comboBox_readers.TabIndex = 2;
            // 
            // Profile_button
            // 
            this.Profile_button.Location = new System.Drawing.Point(326, 404);
            this.Profile_button.Name = "Profile_button";
            this.Profile_button.Size = new System.Drawing.Size(127, 34);
            this.Profile_button.TabIndex = 4;
            this.Profile_button.Text = "Подробнее";
            this.Profile_button.UseVisualStyleBackColor = true;
            this.Profile_button.Click += new System.EventHandler(this.Profile_button_Click);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(212, 73);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(346, 22);
            this.textBox_Search.TabIndex = 5;
            this.textBox_Search.Text = "Поиск";
            this.textBox_Search.TextChanged += new System.EventHandler(this.TextBox_Search_TextChanged);
            // 
            // Search_reader_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.Profile_button);
            this.Controls.Add(this.comboBox_readers);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Search_reader_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск читателя";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Profile_button;
        public System.Windows.Forms.ComboBox comboBox_readers;
        private System.Windows.Forms.TextBox textBox_Search;
    }
}