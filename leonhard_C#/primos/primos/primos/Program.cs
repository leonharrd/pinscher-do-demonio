using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace primos
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisor, dividendo, divisores;

            Console.Write("Desejo ver os _ primeiros números primos: ");

            var limite = Convert.ToInt32(Console.ReadLine());

            divisor = 1;
            dividendo = 1;
            divisores = 0;

            while (limite > 0)
            {
                if (dividendo == 1)
                {
                    Console.WriteLine(dividendo);
                    dividendo ++;
                    limite --;
                }
                while (dividendo >= divisor) //verificar quantos divisores além de 1 o dividendo possui
                {
                    if (dividendo % divisor == 0)
                    {
                        divisores ++;
                        divisor ++;
                    }
                    else
                    {
                        divisor ++;
                    }

                    if (divisor == dividendo && divisores == 2)
                    {
                        Console.WriteLine(dividendo);
                        dividendo ++;
                        divisor = 1;
                        limite --;
                    }
                    
                }
            }
            Console.ReadKey();
        }
    }
}
