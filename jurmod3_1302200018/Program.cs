namespace  jurmod3_1302200018
{

    class program
    {
        static void main(string [] args)
        {
            Kodebuah buah1 = new Kodebuah();

            Kodebuah.NamaBuah inputBuah = Kodebuah.NamaBuah.Apel;
            Console.WriteLine(buah1.GetKodeBuah(inputBuah));

        }
    }
    
}



