using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritenceDemo.Models
{
    internal class Employee
    {
        public void GetParentMessage()
        {
            Console.WriteLine("hello welcome to inheritence demo");
        }

        protected void ProtParentMessage()
        {
            Console.WriteLine("hello welcome to inheritence demo");
        }

        public Employee() 
        {
            Console.WriteLine("welcome to Default Parent Constructor");
        }

        public Employee(int id)
        {
            Console.WriteLine("parametric Constructor id "+ id);
        }
    }
}
