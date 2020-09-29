using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //3.feladat
            Random rnd = new Random();
            int[] tomb = new int[20];
            int seged = 9;
            for (int i = 0; i < tomb.Length; i++)
            {
                int plusz = rnd.Next(seged,100);
                tomb[i] = plusz;
                seged = plusz;
                Console.WriteLine(tomb[i]+" ");
            }
            Console.WriteLine("------------------------------");
            //2.feladat
            Random rnd1 = new Random();
            int[] tomb1 = new int[20];
            
            for (int i = 0; i < tomb.Length; i++)
            {
                int plusz = rnd.Next(50,150);
                tomb[i] = plusz;
              
                Console.WriteLine(tomb[i] + " ");
            }
            
            var nevek = new string[] { "Márk,laci,Tomi,Alma,Feri" };
            for (int i = 0; i < nevek.Length; i++)
            {
                Console.WriteLine(nevek[i]);
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("Adj meg 5 ember magasságát");

         
            int[] magassag = new int[5];


            int ossz = 0;
            for (int i = 0; i < magassag.Length; i++)
            {
                int m = Convert.ToInt32(Console.ReadLine());
                magassag[i] = m;
                ossz = ossz + m;
            }
            Console.WriteLine("Átlag magasság: " + ossz / 5);



            Console.ReadKey();
        }
    }
}
