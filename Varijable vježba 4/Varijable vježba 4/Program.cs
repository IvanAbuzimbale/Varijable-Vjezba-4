using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varijable_vježba_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string glavni;
            Console.Write("Unesi neku rečenicu: ");
            glavni = Console.ReadLine();
            string sVelika = glavni.ToUpper();
            string sMala = glavni.ToLower();
            string sPrvaTri = glavni.Substring(0, 3);
            string sZadnjihPet = glavni.Substring(glavni.Length-5);
            string s8_11 = glavni.Substring(7, 4);
            Console.WriteLine(sVelika);
            Console.WriteLine(sMala);
            Console.WriteLine(sPrvaTri);
            Console.WriteLine(sZadnjihPet);
            Console.WriteLine(s8_11);
            Console.ReadKey();
        }
    }
}
