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
    public partial class Profile_reader_form : Form
    {
        public Profile_reader_form()
        {
            InitializeComponent();
        }

        private void Profile_reader_form_Load(object sender, EventArgs e)
        {
            Update_form();
        }

        public void Update_form()
        {
            comboBox_Books.Items.Clear();
            comboBox_Availablebook.Items.Clear();
            Search_reader_form main = this.Owner as Search_reader_form;
            string Data = main.comboBox_readers.Text;
            string[] words = Data.Split(new char[] { ' ' });
            textBox_Name.Text = words[0];
            textBox_Surname.Text = words[1];
            textBox_Birthday.Text = words[2];
            textBox_Registrarion.Text = words[3];
            reader Data_reader = Library_main.Main_library.Get_reader(Data);
            List<book> Data_book = new List<book>();
            Data_book = Data_reader.Get_reader_books();
            if (Data_book != null && Data_book.Count != 0)
            {
                foreach (book i in Data_book)
                {
                    comboBox_Books.Items.Add(i.Get_information());
                }
                comboBox_Books.Text = Convert.ToString(comboBox_Books.Items[0]);
            }
            else
            {
                comboBox_Books.Text = "Нет книг на руках";
            }
            List<book> Data_books_available = new List<book>();
            Data_books_available = Library_main.Main_library.Get_books();
            if(Data_books_available != null && Data_books_available.Count != 0)
            {
                foreach (book i in Data_books_available)
                {
                    if (i.Get_Available())
                    {
                        comboBox_Availablebook.Items.Add(i.Get_information());
                        if (comboBox_Availablebook.Items.Count == 1)
                        {
                            comboBox_Availablebook.Text = Convert.ToString(comboBox_Availablebook.Items[0]);
                        }
                    }
                }     
            }
            else
            {
                comboBox_Availablebook.Text = "Нет доступных книг";
            }
            if (comboBox_Availablebook.Items.Count == 0)
            {
                comboBox_Availablebook.Text = "Нет доступных книг";
            }
        }

        private void Add_book_button_Click(object sender, EventArgs e)
        {
            if (comboBox_Availablebook.Items.Count != 0)
            {
                errorProvider2.Clear();
                Search_reader_form main = this.Owner as Search_reader_form;
                string Data = main.comboBox_readers.Text;
                reader Data_reader = Library_main.Main_library.Get_reader(Data);
                Library_main.Main_library.New_book_reader(Data_reader.Get_reader_information(), comboBox_Availablebook.Text);
                Update_form();
            } else
            {
                errorProvider2.SetError(Add_book_button, "Нет доступных книг");
            }  
        }

        private void Delete_book_button_Click(object sender, EventArgs e)
        {
            if (comboBox_Books.Items.Count != 0)
            {
                errorProvider1.Clear();
                Search_reader_form main = this.Owner as Search_reader_form;
                string Data = main.comboBox_readers.Text;
                reader Data_reader = Library_main.Main_library.Get_reader(Data);
                Library_main.Main_library.Remove_book_reader(Data_reader.Get_reader_information(), comboBox_Books.Text);
                Update_form();           
            } else
            {
                errorProvider1.SetError(Delete_book_button, "Нет книг для удаления");
            }
        }

        private void Button_Delete_reader_Click(object sender, EventArgs e)
        {
            Search_reader_form main = this.Owner as Search_reader_form;
            string Data = main.comboBox_readers.Text;
            Library_main.Main_library.Remove_reader(Data);
            Dialog_form Form2 = new Dialog_form();
            Form2.Set_Dialog("Читатель успешно удалён", false);
            Form2.ShowDialog(this);
            this.Close();
        }
    }
}
