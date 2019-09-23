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
    public partial class Statistic_form : Form
    {
        public Statistic_form()
        {
            InitializeComponent();
        }

        private void Statistic_form_Load(object sender, EventArgs e)
        {
            label_All_readers.Text = Library_main.Main_library.Get_count_readers();
            label_Month_readers.Text = Library_main.Main_library.Get_count_readers_month();
            label_Count_book.Text = Library_main.Main_library.Get_count_book_month();
        }
    }
}
