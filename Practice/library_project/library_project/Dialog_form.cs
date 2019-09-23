using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_project
{
    public partial class Dialog_form : Form
    {
        public Dialog_form()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Visible)
            {
                Data_book_form main = this.Owner as Data_book_form;
                string Data_book = main.Get_current_book();
                string New_code = textBox1.Text;
                New_code = New_code.Replace(" ", "_");
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    errorProvider1.SetError(button1, "Код не может быть пустым");
                } else if (Library_main.Main_library.Proof_Code(New_code))
                {
                    errorProvider1.SetError(button1, "Такой код уже существует");
                }
                else
                {
                    errorProvider1.Clear();
                    Library_main.Main_library.New_code_book(Data_book, New_code);
                    this.Close();
                }
            }
            else
            {
                this.Close();
            }
        }

        private void Dialog_form_Load(object sender, EventArgs e)
        {
            
        }

        public void Set_Dialog(string Label, bool Visible)
        {
            label1.Text = Label;
            textBox1.Visible = Visible;
        }
    }
}
