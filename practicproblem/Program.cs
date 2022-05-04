using practicproblem.ClassandObject;
using practicproblem.Constructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace practicproblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car car1 = new car("Lamborghini", "Black");
            car1.CarDetails();

            car car2 = new car("Jaguar", "White");
            car2.CarDetails();


            student s1 = new student();
            s1.studentid = 1;
            s1.studentName = "suraj";

            var name = s1.GetStudentName();
            Console.WriteLine(name);

            student s2 = new student();
            s1.studentid = 2;
            s1.studentName = "sur";

            var name2 = s1.GetStudentName();
            Console.WriteLine(name2);




            // an object is created, 
            // constructor is called
            multiplication mul = new multiplication();
           
             Console.WriteLine(mul.a);
            Console.WriteLine(mul.b);
            
            




            Console.WriteLine("The result of multiplication is: " + (mul.a * mul.b));
        }
    }
}
