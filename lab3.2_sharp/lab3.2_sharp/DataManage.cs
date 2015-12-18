using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace lab3._2_sharp
{
    class DataManage
    {
        BusinessLayer business_obj = new BusinessLayer();

        public void ChooseMethod(Student[] student, string File, bool Read)
        {
            if (Read)

                this.Reading_from_file(File);

            else

                this.Recording_into_file(File, student);
            
            
        }
        public void Reading_from_file(string reading_file)
        {
            StreamReader read = new StreamReader(reading_file + ".txt"); ////
            string current_string = read.ReadToEnd();  //// Reading all file recording all string to file
            read.Close();
            business_obj.Converter(current_string);
        }

        public void Recording_into_file(string writing_file, Student[] student)
        {
            StreamWriter writer = new StreamWriter(writing_file + ".txt"); ////

            for (int i = 0; i < Student.Student_quantity; i++)
            {
                if (i == 0)
                writer.WriteLine("Name  Surname   Country  Gradebook  Academic_results  Identity_card  Year \n");
                writer.WriteLine(student[i].Name + "  " + student[i].Surname + "  " + student[i].Country + "  " + student[i].Gradebook
                + "  " + student[i].Academic_results + "  " + student[i].Identity_card + "  " + student[i].Year + "  " + "\n");
            }
            writer.Close();
            this.Reading_from_file(writing_file);
        }


    }
}
