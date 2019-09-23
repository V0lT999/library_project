using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace library_project
{
    public class book
    {
        string Name;
        string Year;
        string Autor;
        string Publisher;
        string Code;
        bool Available;

        public book()
        {
            
        }
        public book(string Autor, string Name, string Publisher, string Year, string Code)
        {
            this.Name = Name;
            this.Year = Year;
            this.Autor = Autor;
            this.Publisher = Publisher;
            this.Code = Code;
            this.Available = true;
        }

        public void Change_code(string Code)
        {
            this.Code = Code;
        }
        public void Change_Available()
        {
            if (this.Available)
            {
                this.Available = false;
            }
            else this.Available = true;
        }

        public string Get_Name()
        {
            return this.Name;
        }

        public string Get_information()
        {
            return Autor + ' ' + Name + ' ' + Publisher + ' ' + Year + ' ' + Code;
        }

        public bool Get_Available()
        {
            return this.Available;
        }
    }
}
