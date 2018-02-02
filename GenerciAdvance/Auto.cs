using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerciAdvance
{
    abstract class Auto
    {
        public int VykonMotoru //rychle vtvorena property
        {
            get;
            set;
        }
        public void VypisVykon()
        {
            Console.WriteLine("Vykon motoru je: ", VykonMotoru);
        }
    }
}
