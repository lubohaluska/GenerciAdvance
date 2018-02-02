using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerciAdvance
{
    class SpravceAut<T> where T : Auto //to T je len z oboru Auto
    {
        //implementujeme metodu na vymenu motoru medzi dvomi motormi
        public  void ProhodMotory(T a1, T  a2)  //ked je tam ref tak nebezi hodnotovo, ale premenna bude odovzana odkazom 
                                                      // aby vnutro funkcie ovlyvnil povodne premenne
        {
            int Temp = a1.VykonMotoru;
            a1.VykonMotoru = a2.VykonMotoru;
            a2.VykonMotoru = Temp;
        }
    }
}
