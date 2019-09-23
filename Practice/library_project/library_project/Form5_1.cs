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
    public partial class Data_book_form : Form
    {
        public Data_book_form()
        {
            InitializeComponent();
        }

        private void Data_book_form_Load(object sender, EventArgs e)
        {
            Form_Update();
        }

        private void Change_code_button_Click(object sender, EventArgs e)
        {
            Search_book_form main = this.Owner as Search_book_form;
            string Data = main.comboBox_books.Text;
            int index = main.comboBox_books.SelectedIndex;
            Dialog_form Form2 = new Dialog_form();
            Form2.Owner = this;
            Form2.ShowDialog();
            main.Form_Update();
            main.comboBox_books.Text = Convert.ToString(main.comboBox_books.Items[index]);
            Form_Update();
        }

        public void Form_Update()
        {
            Search_book_form main = this.Owner as Search_book_form;
            string Data = main.comboBox_books.Text;
            string[] words = Data.Split(new char[] { ' ' });
            textBox_Autor.Text = words[0];
            textBox_Name.Text = words[1];
            textBox_Publisher.Text = words[2];
            textBox_Year.Text = words[3];
            textBox_Code.Text = words[4];
            reader Data_reader = new reader();
            Data_reader = Library_main.Main_library.Get_reader_book(Data);
            if (Data_reader == null)
            {
                textBox_Available.Text = "Доступна";
            }
            else
            {
                textBox_Available.Text = "На руках У " + Data_reader.Get_reader_information();
            }
        }

        public string Get_current_book()
        {
            Search_book_form main = this.Owner as Search_book_form;
            string Data = main.comboBox_books.Text;
            return Data;
        }

        private void Delete_book_button_Click(object sender, EventArgs e)
        {
            Search_book_form main = this.Owner as Search_book_form;
            string Data = main.comboBox_books.Text;
            reader Data_reader = new reader();
            Data_reader = Library_main.Main_library.Get_reader_book(Data);
            string Data_reader_string;
            if (Data_reader == null)
            {
                Data_reader_string = null;
            } else Data_reader_string = Data_reader.Get_reader_information();
            Library_main.Main_library.Delete_book(Data, Data_reader_string);
            Dialog_form Form2 = new Dialog_form();
            Form2.Set_Dialog("Книга успешно добавлена", false);
            Form2.ShowDialog(this);
            this.Close();
        }
    }
}
