using System;

namespace Oszczednosci
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal d = 200.75m;
            Console.WriteLine("d={0}", d);
            Console.WriteLine("odsetki: {0}",odsetki(d));
            Console.WriteLine(AktualizacjaSaldaRocznego(d));

        }
        static float StopaProcentowa(decimal saldo)
        {
            if (saldo < 0)
            {
                return 3.213f;
            }
            else if (saldo < 1000)
            {
                return 0.5f;
            }
            else if (saldo < 5000)
            {
                return 1.621f;
            }
            else
            {
                return 2.475f;
            }
        }
        static decimal AktualizacjaSaldaRocznego(decimal saldo)
        {
            float stopaProcentowa = StopaProcentowa(saldo) / 100;
            decimal rocznaAktualizacja = saldo * (decimal)stopaProcentowa;
            return saldo + rocznaAktualizacja;
        }
        static decimal odsetki(decimal saldo)
        {
            return AktualizacjaSaldaRocznego(saldo) - saldo;
        }
        static int IleLatPrzedOczekiwanymSaldem(decimal saldo, decimal oczekiwaneSaldo)
        {
            int lata = 0;
            while (saldo < oczekiwaneSaldo)
            {
                saldo = AktualizacjaSaldaRocznego(saldo);
                lata += 1;
            }
            return lata;
        }
    }
}