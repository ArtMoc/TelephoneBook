using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneBook
{
   public class Persone
    {
        public string Name { get; set; }
        public int Age { get; private set; }
        private DateTime bday;
        string telephone;
        public string Photo { get; set; }

        public DateTime Bday
        {
            get { return bday; }
            set
            {
                bday = value;
                Age = DateTime.Now.Year - bday.Year;
            }
        }

        public string Telephone
        {
            get { return telephone; }
            set
            {
                bool isCorrect = true;
                for(int i = 0; i < value.Length; i++)
                {
                    if (value[i] < '0' || value[i] > '9')
                    {
                        isCorrect = false;
                        break;
                    }
                }
                if (isCorrect) telephone = value;
                else telephone = "Номер не определен";
            }
        }
    }
}
