using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._2_sharp
{
    class BusinessLayer
    {
        
          public void Dereferencing(DataManage obj,  Student[] student, string File, bool Read)
        {
            obj.ChooseMethod(student, File, Read);  
        }

          public int Searching_of_students ( Student[] student)
          {
              int Counter = 0;
              for (int i = 0; i < Student.Student_quantity; i++)
              {
                  if (student[i].Year == 3 && student[i].Country == "Ukraine")

                      Counter++;
              }

              
              return Counter;
          }
        
        public void Converter (string my_string)
          {
              Student[] student = new Student[Student.Student_quantity];
              my_string = my_string.Replace("\n\r", ""); ///// \r - возвращения позиции устройства к началу строки.
            string [] Lines = my_string.Split('\n');     ////
            
            
            string temp = "";
            int field_iterator = 0, object_iterator = 0;
            for (int i = 1; i < Lines.Length-1; i++)   
            {
                student[object_iterator] = new Student();
                while (field_iterator != Student.Student_quantity)
                {
                    Lines[i] = Lines[i].Replace("  ", " ");
                    temp = Lines[i].Substring(0, Lines[i].IndexOf(" "));  ///////Возвращает индекс с отсчетом от нуля первого вхождения значения указанной строки в данном экземпляре
                    if (field_iterator == 0)
                        student[object_iterator].Name = temp;

                    if (field_iterator == 1)
                        student[object_iterator].Surname = temp;

                    if (field_iterator == 2)
                        student[object_iterator].Country = temp;
                    
                    if (field_iterator == 3)
                        student[object_iterator].Gradebook = temp;

                    if (field_iterator == 4)
                        student[object_iterator].Academic_results = temp;

                    if (field_iterator == 5)
                        student[object_iterator].Identity_card = int.Parse(temp);

                    if (field_iterator == 6)
                        student[object_iterator].Year = int.Parse(temp);

                    Lines[i] = Lines[i].Remove(0, temp.Length+1);
                    
                    field_iterator++;
                }
                field_iterator = 0;
                object_iterator++;
            }
            this.Searching_of_students( student);
           
        }
          
    }
}
