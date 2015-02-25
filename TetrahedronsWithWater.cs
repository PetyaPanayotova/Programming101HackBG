using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrahedronsWithWater
{
    class TetrahedronsWithWater
    {
        static double fill_tetrahedron(int num)
        {
            double ammount = 1d / 12d * Math.Sqrt(2) * Math.Pow((num / 10), 3);
            return ammount;
        }
        static int tetrahedron_filled(List<int> tetrahedrons, int water)
        {
            int count = 0;
            double[] volumes = new double[tetrahedrons.Count];
            for(int i = 0; i < tetrahedrons.Count; i++)
            {
                
                volumes[i] = fill_tetrahedron(tetrahedrons[i]);
            }
            Array.Sort(volumes);
            for (int i = 0; i < volumes.Length; i++)
            {
                if (volumes[i] < water)
                {
                    water = water - i;
                    count = count + 1;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            List<int> example = new List<int>{100, 20, 30};
            int water = 10;
            Console.WriteLine(tetrahedron_filled(example, water));
        }
    }
}
