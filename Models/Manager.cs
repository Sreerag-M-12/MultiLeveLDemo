using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceDemo.Models
{
    internal class Manager:Employee
    {
        public Manager()
        {
            Console.WriteLine("Welcome to Default Child Constructor");
        }

        public Manager(int id)
        {
            Console.WriteLine("Welcome to Parametriced Constructor "+ id);
        }
        
        public void DisplayChildMessage()
        {
            Console.WriteLine("welcome to child class");

            Manager manager1 = new Manager();
            manager1.ProtParentMessage();
        }
    }
}
