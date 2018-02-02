using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerciAdvance
{
    class Program
    {
        static void Main(string[] args)
        {

            int a = 20;
            int b = 10;

            Console.WriteLine("Povodne cisla {0},{1}", a, b);


            Swapper.Swap<int>(ref a, ref b);  // ked je metoda swap ststic, tak je hned pristupna ked je tam ref tak nebezi hodnotovo, ale odkazom a uz to funguje


            Console.WriteLine("Vymenene cisla {0},{1}", a, b);



            string s1 = "ahoj";
            string s2 = "cau";


            Console.WriteLine("Povodne texty {0},{1}", s1, s2);


            Swapper.Swap<string>(ref s1, ref s2);  // ked je metoda swap ststic, tak je hned pristupna


            Console.WriteLine("Vymenene texty {0},{1}", s1, s2);





            Console.ReadLine();

            

        }
    }
}
