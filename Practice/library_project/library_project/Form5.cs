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
    public partial class Search_book_form : Form
    {
        public Search_book_form()
        {
            InitializeComponent();
        }

        private void Search_book_form_Load(object sender, EventArgs e)
        {
            Form_Update();
        }

        public void Form_Update()
        {
            comboBox_books.Items.Clear();
            List<book> books = new List<book>();
            books = Library_main.Main_library.Get_books();
            if (books != null)
            {
                foreach (book i in books)
                {
                    comboBox_books.Items.Add(i.Get_information());
                }
                comboBox_books.Text = Convert.ToString(comboBox_books.Items[0]);
            } else comboBox_books.Text = "В библиотеке нет книг :(";
        }

        private void TextBox_Search_TextChanged(object sender, EventArgs e)
        {
            int index = -1;
            for(int i = 0;i < comboBox_books.Items.Count; i++)
            {
                if (Convert.ToString(comboBox_books.Items[i]).Contains(textBox_Search.Text))
                {
                    index = i;
                    break;
                }
            }
            
            if (index >= 0)
            {
                comboBox_books.Text = Convert.ToString(comboBox_books.Items[index]);
            }
            else comboBox_books.Text = Convert.ToString(comboBox_books.Items[0]);
        }

        private void Button_more_Click(object sender, EventArgs e)
        {
            Data_book_form Form2 = new Data_book_form();
            Form2.Owner = this;
            Form2.ShowDialog();
            Form_Update();
        }
    }
}
