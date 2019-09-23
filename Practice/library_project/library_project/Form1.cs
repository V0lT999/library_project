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
    public partial class Form1 : Form
    {
        library _Main_library = new library();
        public library Get()
        {
            return _Main_library;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            library Main_library = new library();
        }

        private void New_reader_button_Click(object sender, EventArgs e)
        {
            New_reader_form Form2 = new New_reader_form();
            Form2.ShowDialog(this);
        }

        private void New_book_button_Click(object sender, EventArgs e)
        {
            New_book_form Form2 = new New_book_form();
            Form2.ShowDialog(this);
        }

        private void Search_reader_button_Click(object sender, EventArgs e)
        {
            Search_reader_form Form2 = new Search_reader_form();
            Form2.ShowDialog(this);
        }

        private void Search_book_button_Click(object sender, EventArgs e)
        {
            Search_book_form Form2 = new Search_book_form();
            Form2.ShowDialog(this);
        }

        private void Statistic_button_Click(object sender, EventArgs e)
        {
            Statistic_form Form2 = new Statistic_form();
            Form2.ShowDialog(this);
        }
    }
}
