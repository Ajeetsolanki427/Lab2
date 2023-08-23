using System;
namespace Lab21
{
    class Employee
    {
        string name;
        int age;
        double salary;
        public Employee(string name, int age, double salary)
        {
            this.name = name;
            this.age = age; 
            this.salary = salary;
        }
        public void display()
        {
            Console.WriteLine("Employee name : " + name);
            Console.WriteLine("Employe age : " + age);
            Console.WriteLine("Employe salary : " + salary);
        }
        public static void Main(string[] args)
        {
            Employee e1 = new Employee("Raghav", 23, 50000);
            e1.display();
        }
    }
}