using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3._2_sharp
{
    class User_Interface
    {
        BusinessLayer bl_object = new BusinessLayer();
       
        Student[] stud;
        public void StudentOutput(int i, Student[] student)  /////////
        {

            string s = "  ";
            if (!Student.FLAG)
                Console.WriteLine("\n  The information about found student(s) : \n");
            
            Console.WriteLine(student[i].Name + s + student[i].Surname + s + student[i].Country + s + student[i].Gradebook
            + s + student[i].Academic_results + s +  student[i].Identity_card + s + student[i].Year );
            Student.FLAG = true;
        }

     
        public void Inputing_amount_of_students()
        {
            Console.Write("Input the number of students in database : ");

            while (!int.TryParse(Console.ReadLine(), out Student.Student_quantity))  ////////////
            {
                Console.WriteLine("Please input a number");
                Console.ReadKey();
                Console.Clear();
                Console.Write("Input the number of students in database : ");
            }
            Console.Clear();
            stud = new Student[Student.Student_quantity];
            
        }

        public void Inputing_method()
        {
            
            for (int i = 0; i < Student.Student_quantity; i++)
            {
                stud[i] = new Student();
               
                    Console.Write("Input the name of student : ");
                    string Name = Console.ReadLine();

                    if (RegExpr.StringCheck(Name, RegExpr.Name))
                        stud[i].Name = Name;
                    else
                    {
                        Console.WriteLine("You wrote unacceptable symbol ");
                        Console.ReadKey();
                        Console.Clear();
                        this.interface_method();
                    }

                    Console.Write("Input the surname of the student : ");
                    string Surname = Console.ReadLine();
                    if (RegExpr.StringCheck(Surname, RegExpr.Surname))
                        stud[i].Surname = Surname;
                    else
                    {
                        Console.WriteLine("You wrote unacceptable symbol ");
                        Console.ReadKey();
                        Console.Clear();
                        this.interface_method();
                    }


                    Console.Write("Input the Student's Country : ");
                    string Country = Console.ReadLine();
                    if (RegExpr.StringCheck(Country, RegExpr.Country))
                        stud[i].Country = Country;
                    else
                    {
                        Console.WriteLine("You wrote unacceptable symbol ");
                        Console.ReadKey();
                        Console.Clear();
                        this.interface_method();
                    }


                    Console.Write("Input the Student's Gradebook : ");
                    string Gradebook = Console.ReadLine();
                    if (RegExpr.StringCheck(Gradebook, RegExpr.Gradebook))
                        stud[i].Gradebook = Gradebook;
                    else
                    {
                        Console.WriteLine("You wrote unacceptable symbol ");
                        Console.ReadKey();
                        Console.Clear();
                        this.interface_method();
                    }


                    Console.Write("Input the Student's academic results : ");
                    string Academic_results = Console.ReadLine();
                    if (RegExpr.StringCheck(Academic_results, RegExpr.Academic_results))
                        stud[i].Gradebook = Academic_results;
                    else
                    {
                        Console.WriteLine("You wrote unacceptable symbol ");
                        Console.ReadKey();
                        Console.Clear();
                        this.interface_method();
                    }

                    Console.Write("Input the Student's year of study : ");
                    string Year = Console.ReadLine();
                    if (RegExpr.StringCheck(Year, RegExpr.Year))
                        stud[i].Year = int.Parse(Year); // Преобразует строковое представление числа в эквивалентное ему 32-битовое целое число со знаком.
                    else
                    {
                        Console.WriteLine("You wrote unacceptable symbol ");
                        Console.ReadKey();
                        Console.Clear();
                        this.interface_method();
                    }

                    Console.Write("Input the number of the Student's Identical card : ");
                    string Identical_card = Console.ReadLine();
                    if (RegExpr.StringCheck(Identical_card, RegExpr.Identical_card))
                        stud[i].Identity_card = int.Parse(Identical_card);
                    else
                    {
                        Console.WriteLine("You wrote unacceptable symbol ");
                        Console.ReadKey();
                        Console.Clear();
                        this.interface_method();
                    }

                    Console.Clear();
                
                              

            }

        }
        public void Outputing_method (int StudentRezult)
        {
            Console.WriteLine("The Student's database has " + StudentRezult + " third year students  who live in Ukraine");

            Console.Write("If you want to find the student input the surname  : ");
            string Surname = Console.ReadLine();

            Console.Write("Input gradebook : ");
            string gradebook = Console.ReadLine();

                 if (string.IsNullOrEmpty(Surname) && string.IsNullOrEmpty(gradebook))
                     return;


            bool StudEXIST = false; // flag which shows if there are such students with input surname     


            for (int i = 0; i < Student.Student_quantity; i++)
            {
                if (stud[i].Surname == Surname && stud[i].Gradebook == gradebook)
                {
                    this.StudentOutput(i, stud);

                    StudEXIST = true;
                }
            }
            if (!StudEXIST)
                Console.WriteLine("There are no students with Surname : " + Surname + " and Gradebook: " + gradebook);
            Console.ReadKey();

        }

        public void interface_method()
        {
            int curr_key;
            do
            {
            
            Console.WriteLine("Choose the action \n");
            Console.WriteLine("1 - Choosing amount of students\n");
            Console.WriteLine("2 - Inputing data\n");
            Console.WriteLine("3 - Outputing data\n");
            Console.WriteLine("4 - Reading file\n");
            Console.WriteLine("5 - Recording file\n");
            Console.WriteLine("0 - Finish the prgramm");

           
            curr_key = Convert.ToInt32(Console.ReadLine());
            switch (curr_key)
            {
                case 1:
                    {
                        Inputing_amount_of_students();
                        
                        
                    } break;
               
                case 2:
                    {
                        Inputing_method();
                    } break;
                case 3:
                    {
                        int number = bl_object.Searching_of_students(stud);
                        this.Outputing_method(number);
                    } break;
                case 4:
                    {
                        Console.WriteLine("Please input the name of file you want to read from : ");
                        string File = Console.ReadLine();
                        bl_object.Dereferencing(new DataManage(), stud, File, true);
                    }break;
                case 5:
                    {
                        Console.WriteLine("Please input the name of file you want to write in : ");
                        string File = Console.ReadLine();
                        bl_object.Dereferencing(new DataManage(), stud, File, false);
                    }break;

            }


            } while (curr_key != 0);
        }










    } ////////// class
} ////////// namespace