namespace library_project
{
    partial class Statistic_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Statistic_form));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_All_readers = new System.Windows.Forms.Label();
            this.label_Month_readers = new System.Windows.Forms.Label();
            this.label_Count_book = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(172, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Статистика";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Всего читателей";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(310, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Новых читателей за текущий месяц";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Книг выдано за месяц\r\n";
            // 
            // label_All_readers
            // 
            this.label_All_readers.AutoSize = true;
            this.label_All_readers.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_All_readers.Location = new System.Drawing.Point(414, 90);
            this.label_All_readers.Name = "label_All_readers";
            this.label_All_readers.Size = new System.Drawing.Size(147, 24);
            this.label_All_readers.TabIndex = 2;
            this.label_All_readers.Text = "label_All_readers";
            // 
            // label_Month_readers
            // 
            this.label_Month_readers.AutoSize = true;
            this.label_Month_readers.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Month_readers.Location = new System.Drawing.Point(414, 140);
            this.label_Month_readers.Name = "label_Month_readers";
            this.label_Month_readers.Size = new System.Drawing.Size(182, 24);
            this.label_Month_readers.TabIndex = 2;
            this.label_Month_readers.Text = "label_Month_readers";
            // 
            // label_Count_book
            // 
            this.label_Count_book.AutoSize = true;
            this.label_Count_book.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Count_book.Location = new System.Drawing.Point(414, 199);
            this.label_Count_book.Name = "label_Count_book";
            this.label_Count_book.Size = new System.Drawing.Size(154, 24);
            this.label_Count_book.TabIndex = 2;
            this.label_Count_book.Text = "label_Count_book";
            // 
            // Statistic_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label_Count_book);
            this.Controls.Add(this.label_Month_readers);
            this.Controls.Add(this.label_All_readers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Statistic_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Статистика";
            this.Load += new System.EventHandler(this.Statistic_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_All_readers;
        private System.Windows.Forms.Label label_Month_readers;
        private System.Windows.Forms.Label label_Count_book;
    }
}