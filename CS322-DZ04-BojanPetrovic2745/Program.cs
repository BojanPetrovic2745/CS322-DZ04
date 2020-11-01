using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS322_DZ04_BojanPetrovic2745
{
    class Program
    {
        static void Main(string[] args)
        {
            NeparniBrojevi(10);
            PrirodniBrojevi();

            Console.WriteLine("Unesi velicinu niza: ");
            RastuciNiz();
        }

        private static void NeparniBrojevi(int n)
        {
            int suma = 0;

            for(int i = 1; i <= n; i++)
            {
                if( i % 2 == 1)
                {
                    suma+=i;
                    Console.WriteLine(" " + i + " ");

                }
                
            }
            
            Console.WriteLine("Suma brojeva je: " + suma);
        }

        private static void PrirodniBrojevi() {

            int[] brojevi = { 8, 9, 10, 11, 12, 13, 14, 15, 16 };
            int[] reverseBrojevi = Enumerable.Reverse(brojevi).ToArray();
                      
            for(int i = 0; i < brojevi.Length; i++)
            {
                Console.WriteLine(reverseBrojevi[i] * 2);
            }
        }

        private static void RastuciNiz()
        {

            int velicina = Convert.ToInt32(Console.ReadLine());

            int[] nizBrojeva = velicina.ToString().ToCharArray().Select(x => (int)Char.GetNumericValue(x)).ToArray();

            for (int i = 0; i < nizBrojeva.Length - 1; i++)
            {
               if(nizBrojeva[i] > nizBrojeva[i+1])
                {
                    Console.WriteLine("Niz nije rastući!");
                    
                }
                else
                {
                    Console.WriteLine("Niz je rastući!");
                   
                }
            }
        }

    }

}
