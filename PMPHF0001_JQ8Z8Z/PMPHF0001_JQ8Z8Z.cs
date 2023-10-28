using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMPHF0001_JQ8Z8Z
{
    internal class PMPHF0001_JQ8Z8Z
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int x = int.Parse(Console.ReadLine());
            if (x > max)
            {
                max = x;
            }
            int y = int.Parse(Console.ReadLine());
            if (y > max)
            {
                max = y;
            }
            int z = int.Parse(Console.ReadLine());
            if (z > max)
            {
                max = z;
            }
            Console.WriteLine(max);
            Console.ReadLine();
        }
    }
}
