using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiLevelDemo.Models
{
    public class Car:Vehicle
    {
        public void GetWheel()
        {
            Console.WriteLine("A car have 4 wheels.");
        }
    }
}
