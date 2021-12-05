using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Degisken_boyutlu_ucgen_cizimi
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, n;

            Console.Write("Üçgenin boyutunu yazınız: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= n; i++)
            {
                for (j = 1; j < 2 * n; j++)
                {
                    if (j == (n - i + 1)
                        || j == (n + i - 1))
                    {
                        Console.Write("* ");
                    }

                    else if (i == n || (i == n))

                    {

                        Console.Write("* ");
                    }

                    else
                    {
                        Console.Write(" " + " ");
                    }
                }
                Console.Write("\n"); 
            }

            Console.ReadLine();
        }
    }
}
