using MultiLevelDemo.Models;

namespace MultiLevelDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sedan hondaCity = new Sedan();
            hondaCity.Drive();  //inherits Vehicle class
            hondaCity.GetWheel();  //inherits Car Class
            hondaCity.GetSeats();  

            Sedan hyundaiVerna = new Sedan();
            hyundaiVerna.GetSeats();
        }
    }
}
