using System;
using System.Runtime.InteropServices;

namespace Lab3__ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            String firstName = "Huy";
            Employee s = new Employee(firstName);
            Console.WriteLine("FirstName: {0}", s.FirstName);
            Console.WriteLine("LastName: {0}", s.LastName);
            Console.WriteLine("Address: {0}", s.Address);
            Console.WriteLine("Sin: {0}", s.Sin);
            Console.WriteLine("Salary: {0}", s.Salary);
        }
    }

     class Employee
     {

         private string firstName;
         private string lastName;
         private string address;
         private long sin;
         private double salary;

         public Employee(string s)
         {
             firstName = s;
             lastName = "Nguyen";
             address = "VietNam";
             sin = 3;
             salary = 800 ;

         }

         public string FirstName
         {
             get
             {
                 return firstName;
             }
         }
         public string LastName
         {
             get
             {
                 return lastName;
             }
         }
         public string Address
         {
             get
             {
                 return address;
             }
         }
         public long Sin
         {
             get
             {
                 return sin;
             }
         }
         public double Salary
         {
             get
             {
                 return salary;
             }
         }

         public override string ToString()
         {
             return "fistName + lastName + address + sin +salary".ToString();
         }
     }
    
}