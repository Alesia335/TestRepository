using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testas
{
    internal class Geometry
    {
        public double firstVar;
        public double secondVar;
        public double thirdVar;

        public void Task1()
        {
            int r = 6371;
            firstVar = 4 * Math.PI * (r * r);
            Console.WriteLine($"firstvar: {firstVar}");

        }
        public void Task2()
        {
            int r = 6371;
            secondVar = 4 / 3 * Math.PI * r * r * r;
            Console.WriteLine($"secondvar: {secondVar}");
        }
        public void Task3()
        {
            int a = 10;
            int b = 15;
            thirdVar = Convert.ToInt32(Math.Sqrt(Math.Pow(10, 2) + Math.Pow(15, 2)));
        }
        public void Task4()
        {
            double suma = firstVar + secondVar + thirdVar;
            Console.WriteLine($"Suma: {suma}");
        }
        public void Task5()
        { 
            double vidurkis = (firstVar + secondVar + thirdVar) / 3;
            Console.WriteLine($"Vidurkis: {vidurkis}");
        }
    }
}
