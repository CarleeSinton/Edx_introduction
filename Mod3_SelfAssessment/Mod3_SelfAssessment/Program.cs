using System;

namespace Mod3_SelfAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("Hello!");
            GetStudentInformation();
            GetTeacherInformation();
            ValidStudentBirthday();
          
          


        }
        static void GetStudentInformation()
        {

            Console.WriteLine("Enter student's first name: ");
            string sfirstName = Console.ReadLine();
            Console.WriteLine("Enter Student's last name: ");
            string slastName = Console.ReadLine();
            Console.WriteLine("Enter birthday: ");
            string sbirthday = Console.ReadLine();
            PrintStudentDetails(sfirstName, slastName, sbirthday);

        }
        static void PrintStudentDetails(string sfirst, string slast, string sbirthday)
        {
            Console.WriteLine("{0} {1} was born on: {2}", sfirst, slast, sbirthday);
        }
        static void GetTeacherInformation()
        {
            Console.WriteLine("Enter teacher's first name: ");
            string tfirstName = Console.ReadLine();
            Console.WriteLine("Enter teacher's last name: ");
            string tlastName = Console.ReadLine();
            Console.WriteLine("Enter teacher's birthday: ");
            string tbirthday = Console.ReadLine();
            PrintTeacherInformation(tfirstName, tlastName, tbirthday);
        }
        static void PrintTeacherInformation(string tfirst, string tlast, string tbirthday)
        {
            Console.WriteLine("Teacher {0} {1} was born on: {2}", tfirst, tlast, tbirthday);
        }
        static void ValidStudentBirthday()
        {
            throw new NotImplementedException();
        }
    }
}
