using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_project
{
    public class library
    {
        List<reader> readers = new List<reader>();
        List<book> books = new List<book>();
        public library()
        {
            System.IO.StreamReader file = new System.IO.StreamReader("../books.txt", Encoding.Default);
            string line = file.ReadLine();
            while(line != null && line != ""){
                string[] words = line.Split(new char[] {' '});
                book New_book = new book(words[0], words[1], words[2], words[3], words[4]);
                books.Add(New_book);
                line = file.ReadLine();
            }
            file.Close();
            file = new System.IO.StreamReader("../readers.txt", System.Text.Encoding.Default);
            line = file.ReadLine();
            while (line != null && line != "")
            {
                string[] words = line.Split(new char[] { ' ' });
                reader New_reader = new reader(words[0], words[1], words[2], words[3]);
                for(int i = 4; i < words.Length; i++)
                {
                    foreach(book k in books)
                    {
                        if(k.Get_Name() == words[i])
                        {
                            New_reader.new_reader_book(k);
                            k.Change_Available();
                        }
                    }
                }
                readers.Add(New_reader);
                line = file.ReadLine();
            }
            file.Close();
        }

        public void New_Reader(string Name, string Surname, string Birthday)
        {
            Name = Name.Replace(" ", "_");
            Surname = Surname.Replace(" ", "_");
            string DataTime = Convert.ToString(DateTime.Today).Substring(0, 10);
            reader New_reader = new reader(Name, Surname, Birthday, DataTime);
            readers.Add(New_reader);
            Library_main.Update_library();
        }

        public void New_Book(string Autor, string Name, string Publisher, string Year, string Code)
        {
            Autor = Autor.Replace(" ", "_");
            Name = Name.Replace(" ", "_");
            Publisher = Publisher.Replace(" ", "_");
            book New_book = new book(Autor, Name, Publisher, Year, Code);
            books.Add(New_book);
            Library_main.Update_library();
        }

        public reader Get_reader(string Data)
        {
            reader result = null;
            foreach (reader i in readers)
            {
                if(i.Get_reader_information() == Data)
                {
                    result = i;
                }
            }
            return result;
        }

        public List<book> Get_books()
        {
            return books;
        }

        public List<reader> Get_readers()
        {
            return readers;
        }

        public void New_book_reader(string Data_reader, string Data_book)
        {
            foreach(reader i in readers)
            {
                if(i.Get_reader_information() == Data_reader)
                {
                    foreach(book j in books)
                    {
                        if(j.Get_information() == Data_book)
                        {
                            readers[readers.IndexOf(i)].new_reader_book(books[books.IndexOf(j)]);
                            books[books.IndexOf(j)].Change_Available();
                        }
                    }
                }
            }
            Library_main.Main_library.Add_book_month();
            Library_main.Update_library();
        }

        public void Remove_book_reader(string Data_reader, string Data_book)
        {
            foreach (reader i in readers)
            {
                if (i.Get_reader_information() == Data_reader)
                {
                    foreach (book j in books)
                    {
                        if (j.Get_information() == Data_book)
                        {
                            readers[readers.IndexOf(i)].remove_reader_book(books[books.IndexOf(j)]);
                            books[books.IndexOf(j)].Change_Available();
                        }
                    }
                }
            }
            Library_main.Update_library();
        }

        public void Remove_reader(string Data_reader)
        {
            foreach(reader i in readers)
            {
                if (i.Get_reader_information() == Data_reader)
                {
                    List<book> Data_books = new List<book>();
                    Data_books = i.Get_reader_books();
                    foreach(book j in Data_books)
                    {
                        foreach(book k in books)
                        {
                            if(j.Get_information() == k.Get_information())
                            {
                                books[books.IndexOf(k)].Change_Available();
                                break;
                            }
                        }
                    }
                    readers.Remove(i);
                    break;
                }
            }
            Library_main.Update_library();
        }

        public reader Get_reader_book(string Data_book)
        {
            reader result = new reader();
            result = null;
            foreach(book i in books)
            {
                if(i.Get_information() == Data_book)
                {
                    if (i.Get_Available())
                    {
                        return result;
                    }
                    else
                    {
                        foreach(reader j in readers){
                            List<book> Data_reader_book = new List<book>();
                            Data_reader_book = j.Get_reader_books();
                            foreach(book k in Data_reader_book)
                            {
                                if (k.Get_information() == Data_book)
                                {
                                    result = readers[readers.IndexOf(j)];
                                    return result;
                                }
                            }
                        }
                    }
                }
            }
            return result;
        }

        public void New_code_book(string Data_book, string New_code)
        {
            foreach(book i in books)
            {
                if(i.Get_information() == Data_book)
                {
                    books[books.IndexOf(i)].Change_code(New_code);
                }
            }
            Library_main.Update_library();
        }

        public void Delete_book(string Data_book, string Data_reader)
        {
            if(Data_reader == null)
            {
                foreach(book i in books)
                {
                    if(i.Get_information() == Data_book)
                    {
                        books.Remove(books[books.IndexOf(i)]);
                        break;
                    }
                }
            }
            else
            {
                this.Remove_book_reader(Data_reader, Data_book);
                foreach (book i in books)
                {
                    if (i.Get_information() == Data_book)
                    {
                        books.Remove(books[books.IndexOf(i)]);
                        break;
                    }
                }
            }
            Library_main.Update_library();
        }

        public bool Proof_Code(string Code)
        {
            foreach(book i in books)
            {
                if (i.Get_information().Contains(Code))
                {
                    return true;
                }
            }
            return false;
        }

        public void Add_book_month()
        {
            int month = DateTime.Today.Month;
            System.IO.StreamReader file = new System.IO.StreamReader("../statistic.txt", Encoding.Default);
            string Data = file.ReadLine();
            string[] words = Data.Split(new char[] { ' ' });
            int count = int.Parse(words[1]);
            if(int.Parse(words[0]) == month)
            {
                count++;
            }
            else
            {
                count = 1;
            }
            file.Close();
            System.IO.StreamWriter file_write = new System.IO.StreamWriter("../statistic.txt", false, System.Text.Encoding.Default);
            file_write.WriteLine(Convert.ToString(month) + ' ' + Convert.ToString(count));
            file_write.Close();
        }

        public string Get_count_readers_month()
        {
            System.IO.StreamReader file = new System.IO.StreamReader("../statistic.txt", Encoding.Default);
            string Data = file.ReadLine();
            file.Close();
            string[] words = Data.Split(new char[] { ' ' });
            int month_current = int.Parse(words[0]);
            int counter = 0;
            foreach (reader i in readers)
            {
                string reader_registration = i.Get_reader_Registration();
                DateTime dt = DateTime.Parse(reader_registration);
                if(month_current == dt.Month && DateTime.Today.Year == dt.Year)
                {
                    counter++;
                }
            }
            return Convert.ToString(counter);
        }

        public string Get_count_book_month()
        {
            System.IO.StreamReader file = new System.IO.StreamReader("../statistic.txt", Encoding.Default);
            string Data = file.ReadLine();
            file.Close();
            string[] words = Data.Split(new char[] { ' ' });
            return words[1];
        }

        public string Get_count_readers()
        {
            return Convert.ToString(readers.Count);
        }
    }
}
