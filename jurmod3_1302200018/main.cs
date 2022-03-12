using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jurmod3_1302200018
{
    class test
    {
        static void Main(string[] args)
        {
            Kodebuah buah1 = new Kodebuah();
            Kodebuah.NamaBuah inputBuah = Kodebuah.NamaBuah.Apel;
            Console.WriteLine(buah1.GetKodeBuah(inputBuah));

        }
    }
}
