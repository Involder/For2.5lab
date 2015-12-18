using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._2_sharp
{
    class Student
    {
   static public bool FLAG = false;
   static public int Student_quantity;
   public string Name;
   public string Surname;
   public string Country;
   public string Gradebook;
   public string Academic_results;
   public int Identity_card;
   public int Year;


   public Student()
   {

   }
        public Student(string Name, string Surname, string Gradebook, string Country, int Identity_card, string Academic_results, int Year)
        {
            this.Name = Name;
            this.Surname = Surname;
            this.Year = Year;
            this.Country = Country;
            this.Academic_results = Academic_results;
            this.Gradebook = Gradebook;
            this.Identity_card = Identity_card;
        }

    }
}
