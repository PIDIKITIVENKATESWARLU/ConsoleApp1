using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace static_constuctor
{
    class student
    {
        int Sid;
        string Sname;
        int Smobile;
        static string collegename;
        static string collegeaddress;
        static student()
        {
            collegename = "narayana";
            collegeaddress = "vijayawadaa";

        }
        internal student(int sid, string sname, int smobile)
        {
            Sid = sid; Sname = sname;

            Smobile = smobile;


        }
        internal void sdisplay()
        {
            Console.WriteLine("student id is {0}", Sid);
            Console.WriteLine("student name is {0}", Sname);
            Console.WriteLine("student mobile number is {0}", Smobile);
            Console.WriteLine("student college name is {0}", collegename);
            Console.WriteLine("student college address is {0}", collegeaddress);
        }



    }

    internal class Program
    {
        static void Main(string[] args)
        {
            student s = new student(101, "nikesh", 773108546);
            s.sdisplay();
            Console.ReadLine();


        }

    }
}
