using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerciAdvance
{
    class Swapper
    {

        public static void Swap<T>(ref T a, ref T b)  //ked je tam ref tak nebezi hodnotovo, ale premenna bude odovzana odkazom 
                                                      // aby vnutro funkcie ovlyvnil povodne premenne
        {
            
            T c = a;
            a = b;
            b = c;


        }
    }
}
