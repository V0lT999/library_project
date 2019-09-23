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
    public partial class New_book_form : Form
    {
        public New_book_form()
        {
            InitializeComponent();
        }

        private void Save_new_book_button_Click(object sender, EventArgs e)
        {
            bool Error = false;
            if (String.IsNullOrEmpty(textBox_Autor.Text)){
                errorProvider1.SetError(textBox_Autor, "Поле Автор не может быть пустым");
                Error = true;
            } else errorProvider1.Clear();
            if (String.IsNullOrEmpty(textBox_Name.Text))
            {
                errorProvider2.SetError(textBox_Name, "Поле Название не может быть пустым");
                Error = true;
            } else errorProvider2.Clear();
            if (String.IsNullOrEmpty(textBox_Publisher.Text))
            {
                errorProvider3.SetError(textBox_Publisher, "Поле Издание не может быть пустым");
                Error = true;
            }
            else errorProvider3.Clear();
            int Year;
            bool result = int.TryParse(textBox_Year.Text, out Year);
            DateTime dt = new DateTime();
            if (result)
            {
                dt = new DateTime(Year, 1, 1);
            }
            if (String.IsNullOrEmpty(textBox_Year.Text) || !result)
            {
                if (String.IsNullOrEmpty(textBox_Year.Text))
                {
                    errorProvider4.SetError(textBox_Year, "Поле Год не может быть пустым");
                    Error = true;
                    
                }
                else
                {
                    errorProvider4.SetError(textBox_Year, "Год введён не верно");
                    Error = true;
                }
            }
            else if (dt > DateTime.Today)
            {
                errorProvider4.SetError(textBox_Year, "Год введён не верно");
                Error = true;
            } else errorProvider4.Clear();
            if (String.IsNullOrEmpty(textBox_Code.Text) || Library_main.Main_library.Proof_Code(textBox_Code.Text))
            {
                if (String.IsNullOrEmpty(textBox_Code.Text))
                {
                    errorProvider5.SetError(textBox_Code, "Поле Код не может быть пустым");
                    Error = true;
                }
                else
                {
                    errorProvider5.SetError(textBox_Code, "Такой Код уже существует");
                    Error = true;
                }
            }
            else errorProvider5.Clear();
            if (!Error)
            {
                Library_main.Main_library.New_Book(textBox_Autor.Text, textBox_Name.Text, textBox_Publisher.Text, textBox_Year.Text, textBox_Code.Text);
                Dialog_form Form2 = new Dialog_form();
                Form2.Set_Dialog("Книга успешно добавлена", false);
                Form2.ShowDialog(this);
                this.Close();
            }
        }

        private void New_book_form_Load(object sender, EventArgs e)
        {

        }
    }
}
