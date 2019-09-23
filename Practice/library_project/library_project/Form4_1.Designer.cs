namespace library_project
{
    partial class Profile_reader_form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile_reader_form));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Name = new System.Windows.Forms.TextBox();
            this.textBox_Surname = new System.Windows.Forms.TextBox();
            this.textBox_Birthday = new System.Windows.Forms.TextBox();
            this.textBox_Registrarion = new System.Windows.Forms.TextBox();
            this.comboBox_Books = new System.Windows.Forms.ComboBox();
            this.Delete_book_button = new System.Windows.Forms.Button();
            this.Add_book_button = new System.Windows.Forms.Button();
            this.comboBox_Availablebook = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button_Delete_reader = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Данные о читателе";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(161, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "Дата регистрации";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Книги на руках";
            // 
            // textBox_Name
            // 
            this.textBox_Name.Location = new System.Drawing.Point(224, 94);
            this.textBox_Name.Name = "textBox_Name";
            this.textBox_Name.ReadOnly = true;
            this.textBox_Name.Size = new System.Drawing.Size(505, 22);
            this.textBox_Name.TabIndex = 4;
            // 
            // textBox_Surname
            // 
            this.textBox_Surname.Location = new System.Drawing.Point(224, 137);
            this.textBox_Surname.Name = "textBox_Surname";
            this.textBox_Surname.ReadOnly = true;
            this.textBox_Surname.Size = new System.Drawing.Size(505, 22);
            this.textBox_Surname.TabIndex = 4;
            // 
            // textBox_Birthday
            // 
            this.textBox_Birthday.Location = new System.Drawing.Point(224, 183);
            this.textBox_Birthday.Name = "textBox_Birthday";
            this.textBox_Birthday.ReadOnly = true;
            this.textBox_Birthday.Size = new System.Drawing.Size(505, 22);
            this.textBox_Birthday.TabIndex = 4;
            // 
            // textBox_Registrarion
            // 
            this.textBox_Registrarion.Location = new System.Drawing.Point(224, 229);
            this.textBox_Registrarion.Name = "textBox_Registrarion";
            this.textBox_Registrarion.ReadOnly = true;
            this.textBox_Registrarion.Size = new System.Drawing.Size(505, 22);
            this.textBox_Registrarion.TabIndex = 4;
            // 
            // comboBox_Books
            // 
            this.comboBox_Books.FormattingEnabled = true;
            this.comboBox_Books.Location = new System.Drawing.Point(224, 280);
            this.comboBox_Books.Name = "comboBox_Books";
            this.comboBox_Books.Size = new System.Drawing.Size(505, 24);
            this.comboBox_Books.TabIndex = 5;
            // 
            // Delete_book_button
            // 
            this.Delete_book_button.Location = new System.Drawing.Point(735, 280);
            this.Delete_book_button.Name = "Delete_book_button";
            this.Delete_book_button.Size = new System.Drawing.Size(129, 24);
            this.Delete_book_button.TabIndex = 6;
            this.Delete_book_button.Text = "Списать";
            this.Delete_book_button.UseVisualStyleBackColor = true;
            this.Delete_book_button.Click += new System.EventHandler(this.Delete_book_button_Click);
            // 
            // Add_book_button
            // 
            this.Add_book_button.Location = new System.Drawing.Point(735, 328);
            this.Add_book_button.Name = "Add_book_button";
            this.Add_book_button.Size = new System.Drawing.Size(129, 24);
            this.Add_book_button.TabIndex = 7;
            this.Add_book_button.Text = "Добавить книгу";
            this.Add_book_button.UseVisualStyleBackColor = true;
            this.Add_book_button.Click += new System.EventHandler(this.Add_book_button_Click);
            // 
            // comboBox_Availablebook
            // 
            this.comboBox_Availablebook.FormattingEnabled = true;
            this.comboBox_Availablebook.Location = new System.Drawing.Point(224, 328);
            this.comboBox_Availablebook.Name = "comboBox_Availablebook";
            this.comboBox_Availablebook.Size = new System.Drawing.Size(505, 24);
            this.comboBox_Availablebook.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(14, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 24);
            this.label7.TabIndex = 2;
            this.label7.Text = "Доступные книги";
            // 
            // button_Delete_reader
            // 
            this.button_Delete_reader.Location = new System.Drawing.Point(369, 385);
            this.button_Delete_reader.Name = "button_Delete_reader";
            this.button_Delete_reader.Size = new System.Drawing.Size(163, 35);
            this.button_Delete_reader.TabIndex = 9;
            this.button_Delete_reader.Text = "Удалить читателя";
            this.button_Delete_reader.UseVisualStyleBackColor = true;
            this.button_Delete_reader.Click += new System.EventHandler(this.Button_Delete_reader_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider2.ContainerControl = this;
            // 
            // Profile_reader_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.button_Delete_reader);
            this.Controls.Add(this.comboBox_Availablebook);
            this.Controls.Add(this.Add_book_button);
            this.Controls.Add(this.Delete_book_button);
            this.Controls.Add(this.comboBox_Books);
            this.Controls.Add(this.textBox_Registrarion);
            this.Controls.Add(this.textBox_Birthday);
            this.Controls.Add(this.textBox_Surname);
            this.Controls.Add(this.textBox_Name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profile_reader_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Данные о читателе";
            this.Load += new System.EventHandler(this.Profile_reader_form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Name;
        private System.Windows.Forms.TextBox textBox_Surname;
        private System.Windows.Forms.TextBox textBox_Birthday;
        private System.Windows.Forms.TextBox textBox_Registrarion;
        private System.Windows.Forms.ComboBox comboBox_Books;
        private System.Windows.Forms.Button Delete_book_button;
        private System.Windows.Forms.Button Add_book_button;
        private System.Windows.Forms.ComboBox comboBox_Availablebook;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button_Delete_reader;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}