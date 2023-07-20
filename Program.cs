using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalInformationMethodInClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalInformation personInfo = new PersonalInformation();

            string nameSurname, job;
            int age;

            Console.WriteLine("Enter the Personal Information");

            nameSurname = Console.ReadLine();
            job = Console.ReadLine();
            age = Convert.ToInt32(Console.ReadLine());




            personInfo.personalInfo(nameSurname, job, age);


            Console.Read();
        }
    }
}
