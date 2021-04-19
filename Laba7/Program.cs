using System;
using Laba7.Two;

namespace Laba7
{
    class Program
    {
        static void Main(string[] args)
        {
            One();
            // Two();
        }

        static void One()
        {
            Console.WriteLine("------------STUDENT------------");
            Student student = new Student("Volodymyr",
                                          "Moisei",
                                          19,
                                          new DateTime(2019, 08, 24),
                                          4.2,
                                          true);
            Console.WriteLine(student.Show());
            student.GetCourse();

            Console.WriteLine("------------TEACHER------------");
            Teacher teacher = new Teacher("Vasyl", 
                                          "Pypkin",
                                          42,
                                          "Assembler",
                                          new DateTime(2000, 01, 01),
                                          true);
            Console.WriteLine(teacher.Show());

            Console.WriteLine("------------DEPARTMENT_HEAD------------");
            DepartmentHead departmentHead = new DepartmentHead("Ivan",
                "Ivanov",
                54,
                "Pascal",
                new DateTime(1993, 7, 12),
                true,
                "ПЗКС",
                ScientificDegree.PhilosphyDoctor,
                "some info");
           Console.WriteLine(departmentHead.Show());
        }

        static void Two()
        {
            Console.WriteLine("-------------------AUTOMOBILE-------------------");
            Automobile automobile = new Automobile("Volkswage", 
                                                   220, 
                                                   "Black");
            Console.WriteLine(automobile.GetInfo());
            automobile.Update();
            Console.WriteLine(automobile.GetInfo());
            Console.WriteLine("-------------------SPORTCAR-------------------");
            Sportcar sportcar = new Sportcar("Lamborghini",
                                             350, 
                                             "Yellow", 
                                             2);
            Console.WriteLine(sportcar.GetInfo());                              
            sportcar.Update();
            Console.WriteLine(sportcar.GetInfo());
            Console.WriteLine("-------------------EXECUTIVECAR-------------------");
            ExecutiveCar executiveCar = new ExecutiveCar("BMW", 250, 
                                                         "Grey",true);
            Console.WriteLine(executiveCar.GetInfo());
            executiveCar.Update();
            Console.WriteLine(executiveCar.GetInfo());
        }
    }
}