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
    public partial class New_reader_form : Form
    {
        public New_reader_form()
        {
            InitializeComponent();
        }

        private void New_reader_form_Load(object sender, EventArgs e)
        {
            toolTip_Name.SetToolTip(textBox_Name, "Введите Имя");
            toolTip_Surname.SetToolTip(textBox_Surname, "Введите Фамилию");
            toolTip_Birthday.SetToolTip(textBox_Birthday, "Введите Дату рождения в виде дд.мм.гггг");
        }

        private void Save_new_reader_button_Click(object sender, EventArgs e)
        {
            DateTime dt;
            bool result = DateTime.TryParse(textBox_Birthday.Text, out dt);
            bool Error = false;
            if (string.IsNullOrEmpty(textBox_Name.Text))
            {
                errorProvider1.SetError(textBox_Name, "Поле Имя не может быть пустым");
                Error = true;
            } else errorProvider1.Clear();
            if (string.IsNullOrEmpty(textBox_Surname.Text))
            {
                errorProvider2.SetError(textBox_Surname, "Поле Фамиилия не может быть пустым");
                Error = true;
            } else errorProvider2.Clear();
            if (!result || dt > DateTime.Today)
            {
                errorProvider3.SetError(textBox_Birthday, "Дата задана не верно");
                Error = true;
            } else errorProvider3.Clear();
            if(!Error)
            {
                Library_main.Main_library.New_Reader(textBox_Name.Text, textBox_Surname.Text, textBox_Birthday.Text);
                Dialog_form Form2 = new Dialog_form();
                Form2.Set_Dialog("Читатель успешно добавлен", false);
                Form2.ShowDialog(this);
                this.Close();
            }
        }

    }
}
