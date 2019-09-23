using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_project
{
    public class reader
    {
        string Name;
        string Surname;
        string Birthday;
        string Registration;
        List<book> books_reader;

        public reader()
        {
            books_reader = new List<book>();
        }
        public reader(string Name, string Surname, string Birthday, string Registration)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Birthday = Birthday;
            this.Registration = Registration;
            books_reader = new List<book>();
        }

        public void new_reader_book(book New_book)
        {
            books_reader.Add(New_book);
        }
        public void remove_reader_book(book Book)
        {
            books_reader.Remove(Book);
        }
        
        public string Get_reader_information()
        {
            string result = this.Name + ' ' + this.Surname + ' ' + this.Birthday + ' ' + this.Registration;
            return result;
        }

        public List<book> Get_reader_books()
        {
            return books_reader;
        }

        public string Get_reader_Registration()
        {
            return this.Registration;
        }
    }
}
