using System;

namespace FillTetrahedron
{
    class FillTetrahedron
    {
        static double fill_tetrahedron(int num)
        {
            double ammount = 1d / 12d * Math.Sqrt(2) * Math.Pow((num / 10), 3);
            return ammount;
        }
        static void Main(string[] args)
        {
            double ammount = fill_tetrahedron(100);
            Console.WriteLine("The ammount of water that can be filled in a tetrahedron with 100 cm edge length is {0:0.00} litres.", ammount);
        }
    }
}