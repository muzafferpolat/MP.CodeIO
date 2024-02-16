using MpEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestUI
{
    internal class Program
    {

        static void Main(string[] args)
        {
            MpBll.CourseBusinessLogicLayer mpBll=new MpBll.CourseBusinessLogicLayer();
            Course course = new Course(1, "dsfsd", "dsf", "dfds", 2);
            int result = mpBll.Add(course);
            if (result==1)
            {
                Console.WriteLine("Kurs eklendi");
            }
            else { Console.WriteLine("Kurs eklenmedi"); }

            Console.ReadLine();
        }
    }
}
