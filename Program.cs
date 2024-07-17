using InheritenceDemo.Models;

namespace InheritenceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            Console.WriteLine("==============");
            Manager m1 = new Manager();
            
            Employee m2 = new Employee(54);
            Console.WriteLine("==============");
            Manager m3 = new Manager(45);

        }
    }
}
