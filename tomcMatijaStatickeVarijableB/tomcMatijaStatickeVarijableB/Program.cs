using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tomcMatijaStatickeVarijableB
{
    class Program
    {
        static void Main(string[] args)
        {
            PrvaKlasa x = new PrvaKlasa("Leni", "Kuso");
            Console.WriteLine(x.ToString());

            PrvaKlasa y = new PrvaKlasa("Nik", "Sime");
            Console.WriteLine(y.ToString());

            PrvaKlasa z = new PrvaKlasa("Matija", "Tomc");
            Console.WriteLine(z.ToString());

            Console.ReadKey();
        }
    }
}
