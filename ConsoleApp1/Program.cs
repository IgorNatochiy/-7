using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static double Geron(double x, double y, double z)
        {
            double p = (x + y + z) / 2;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину сторон первого треугольника");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double z1 = Convert.ToDouble(Console.ReadLine());
            double S1 = Geron(x1,y1,z1);
            Console.WriteLine("Введите длину сторон второго треугольника");
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double z2 = Convert.ToDouble(Console.ReadLine());
            double S2 = Geron(x2, y2, z2); ;

            Console.WriteLine("S1 = {0}, S2 = {1}", Geron(x1, y1, z1), Geron(x2, y2, z2));
            if (S1 > S2)
                Console.WriteLine("Площадь первого треугольника больше");
            else
                if (S1 < S2)
                Console.WriteLine("Площад второго треугольника больше");
            else
                Console.WriteLine("Площади равны");
            Console.ReadKey();
        }
    }
}
