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
    public partial class Search_reader_form : Form
    {
        public Search_reader_form()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Form_Update();
        }

        private void Profile_button_Click(object sender, EventArgs e)
        {
            Profile_reader_form Form2 = new Profile_reader_form();
            Form2.Owner = this;
            Form2.ShowDialog();
            Form_Update();
        }

        private void TextBox_Search_GotFocus(object sender, EventArgs e)
        {
            textBox_Search.Text = "";
        }

        private void TextBox_Search_TextChanged(object sender, EventArgs e)
        {
            int index = -1;
            for (int i = 0; i < comboBox_readers.Items.Count; i++)
            {
                if (Convert.ToString(comboBox_readers.Items[i]).Contains(textBox_Search.Text))
                {
                    index = i;
                    break;
                }
            }
            if (index >= 0)
            {
                comboBox_readers.Text = Convert.ToString(comboBox_readers.Items[index]);
            } else comboBox_readers.Text = Convert.ToString(comboBox_readers.Items[0]);

        }

        public void Form_Update()
        {
            comboBox_readers.Items.Clear();
            System.IO.StreamReader file = new System.IO.StreamReader("../readers.txt", Encoding.Default);
            string line = file.ReadLine();
            while (line != null && line != "")
            {
                string[] words = line.Split(new char[] { ' ' });
                string New_reader = words[0] + ' ' + words[1] + ' ' + words[2] + ' ' + words[3];
                comboBox_readers.Items.Add(New_reader);
                line = file.ReadLine();
            }
            file.Close();
            if (comboBox_readers.Items.Count != 0)
            {
                comboBox_readers.Text = Convert.ToString(comboBox_readers.Items[0]);
            } else comboBox_readers.Text = "В библиотеке нет читателей :(";
        }
    }
}
