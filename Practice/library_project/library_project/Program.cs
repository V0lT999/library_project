using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_project
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            Library_main.Update_library();
        }
    }

    public class Library_main
    {
        public static library Main_library = new library();

        public static void Update_library()
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter("../readers.txt", false, System.Text.Encoding.Default);
            List<reader> readers_main = new List<reader>();
            readers_main = Main_library.Get_readers();
            List<book> books_main = new List<book>();
            books_main = Main_library.Get_books();
            foreach (reader i in readers_main)
            {
                file.Write(i.Get_reader_information() + ' ');
                List<book> reader_books_main = new List<book>();
                reader_books_main = i.Get_reader_books();
                if(reader_books_main != null)
                {
                    foreach (book j in reader_books_main)
                    {
                        file.Write(j.Get_Name() + ' ');
                    }
                }
                file.WriteLine();
            }
            file.Close();
            file = new System.IO.StreamWriter("../books.txt", false, System.Text.Encoding.Default);
            foreach (book i in books_main)
            {
                file.WriteLine(i.Get_information());
            }
            file.Close();
        }
    }
}
