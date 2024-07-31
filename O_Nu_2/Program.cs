using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace O_Nu_2
{
    class Parent
    {
        public int Id { get; set; }
        public void print()
        {
            Console.WriteLine("Hello I'm parent");
        }
    }

    class Child : Parent
    {
        public string Name { get; set; }
        // hiding data
        public new void print()
        {
            Console.WriteLine("Hello I'm Child");
        }
    }

    class A       // Poco class [concrete class] -> Plain Old CLR Object.
    {
        public int Id { get; set; }
    }

    class B : A 
    {
        public string Name { get; set; }
    }

    class C : B
    {
        public string Address { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CalcSalary of PT & FT inputed by user (non static data)

            Console.Write("Enter the number of employees: ");
            int numEmployees = int.Parse(Console.ReadLine());

            Emp[] employees = new Emp[numEmployees];

            for (int i = 0; i < numEmployees; i++)
            {
                Console.WriteLine($"Enter employee {i + 1} details:");
                Console.Write("ID: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Salary: ");

                float salary = float.Parse(Console.ReadLine());

                Console.Write("Employee type (FT or PT): ");
                string type = Console.ReadLine();

                if (type.Equals("FT"))
                {
                    Console.Write("Bonus: ");
                    float bonus = float.Parse(Console.ReadLine());
                    Console.Write("Deduction: ");
                    float deduction = float.Parse(Console.ReadLine());
                    employees[i] = new FT_Emp { Id = id, Name = name, Salary = salary, Bonus = bonus, Deduction = deduction };
                }
                else if (type.Equals("PT"))
                {
                    Console.Write("Hours: ");
                    int hours = int.Parse(Console.ReadLine());
                    Console.Write("Rate per hour: ");
                    float rateHour = float.Parse(Console.ReadLine());
                    employees[i] = new PT_Emp { Id = id, Name = name, Salary = salary, Hours = hours, RateHour = rateHour };
                }
                else
                {
                    Console.WriteLine("Invalid employee type.");
                    i--; // Repeat the input for the current employee
                }
            }

            Console.WriteLine("\nEmployee Salaries:");
            foreach (Emp emp in employees)
            {
                Console.WriteLine($"ID: {emp.Id}, Name: {emp.Name}, Salary: {emp.CalcSalary()}");
            }
            #endregion

            








            #region Collection Expression
            //            Emp[] emps =
            //{
            //            // new PT_Emp(){Id= 1, Name="Pt_Emp_1", Salary = 5000 , Hours = 21, RateHour= 200},
            //            //  new PT_Emp(){Id= 2, Name="Pt_Emp_2", Salary = 5050 , Hours = 27, RateHour= 270},
            //            //   new PT_Emp(){Id= 3, Name="Pt_Emp_3", Salary = 5040 , Hours = 26, RateHour= 260},
            //            //    new PT_Emp(){Id= 4, Name="Pt_Emp_4", Salary = 5500 , Hours = 23, RateHour= 250},
            //            //     new PT_Emp(){Id= 5, Name="Pt_Emp_5", Salary = 5800 , Hours = 20, RateHour= 240},

            //            //    new FT_Emp() {Id =  6, Name= "FT_Emp_6",Salary= 10080, Bonus= 1000, Deduction= 500},
            //            //    new FT_Emp() {Id =  7, Name= "FT_Emp_7",Salary= 11000, Bonus= 1900, Deduction= 900},
            //            //    new FT_Emp() {Id =  8, Name= "FT_Emp_8",Salary= 10700, Bonus= 1700, Deduction= 600},
            //            //    new FT_Emp() {Id =  9, Name= "FT_Emp_9",Salary= 18000, Bonus= 8000, Deduction= 800},
            //            //};
            #endregion

            Console.WriteLine($"Finished on :  { DateTime.Now.ToShortTimeString()}"); 
        }
    }



    
}
