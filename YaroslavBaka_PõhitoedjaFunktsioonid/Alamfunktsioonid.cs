using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace YaroslavBaka_PõhitoedjaFunktsioonid
{
    internal class Alamfunktsioonid
    {
        public static void KytuseKalkulaator()
        {
            double km;
            double liitrit;
            double hind;
            while (true)
            {
                try
                {
                    Console.WriteLine("Läbitud teepikkus (km).  ");
                    km = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Vale andmetüüp");

                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Kütusekulu 100km kohta (liitrit).  ");
                    liitrit = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Vale andmetüüp");

                }

            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Kütuse liitri hind (€).  ");
                    hind = double.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Vale andmetüüp");

                }

            }

           

            double kulu = (km / 100) * liitrit;
            double kokku = kulu * hind;
            Console.WriteLine($"Kulund kütus: {kulu}");
            Console.WriteLine($"Sinu sõiduhind on: {kokku}");
        }

        public static void HindaIsikukood()
        {
            long ik = 0;
            string ikstring;
            string aasta="";
            string kuu= "";
            string paev= "";

            while (true)
            {
                try
                {
                    Console.Write($"Sisesta isikukood:  ");
                    ik = long.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Vale andmetüüp, {e}");
                }
                 
            }
            ikstring = ik.ToString();


            if (ikstring.Length != 11)
            {
                Console.WriteLine("Viga! Isikukood peab olema 11-kohaline.");
                //return;
            }

            string sugu;
            char esimene = ikstring[0];

            if (esimene == '1' || esimene == '3' || esimene == '5')
                sugu = "Mees";
            else if (esimene == '2' || esimene == '4' || esimene == '6')
                sugu = "Naine";
            else
                sugu = "Tundmatu";

            if (int.Parse(ikstring.Substring(1, 2)) > 0 || int.Parse(ikstring.Substring(1, 2)) < 100)
            { aasta = ikstring.Substring(1, 2); }
            else
            {
                Console.WriteLine("vale isikukood");
            }
            if (int.Parse(ikstring.Substring(3, 2)) > 0 || int.Parse(ikstring.Substring(3, 2)) < 12) kuu = ikstring.Substring(3, 2);
            else
            {
                Console.WriteLine("vale isikukood");
            }
            if (int.Parse(ikstring.Substring(5, 2)) > 0 || int.Parse(ikstring.Substring(5, 2)) < 31) paev = ikstring.Substring(5, 2);
            else
            {
                Console.WriteLine("vale isikukood");
            }


            Console.WriteLine($"Oled {sugu} sündinud {0}{1}{2}", paev,kuu,aasta);
        }
        public static void TaringuMang()
        {
            Random rnd = new Random();
            List<int> summad = new List<int>();

            int duublid = 0;
            int kogusumma = 0;

            for (int i = 0; i < 10; i++)
            {
                int t1 = rnd.Next(1, 7);
                int t2 = rnd.Next(1, 7);
                Console.WriteLine($"{t1} + {t2}; ");

                if (t1 == t2)
                    duublid++;

                int summa = t1 + t2;
                summad.Add(summa);
                kogusumma += summa;

            }

            Console.WriteLine("Kõik viskad:");
            foreach (int s in summad)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine($"Duubleid visati: {duublid}");
            Console.WriteLine($"Kõikide visete kogusumma: {kogusumma}");
        }

        
            public static Tuple<double, double> ArvutaPalk(double brutopalk)
        {
            double maksuvaba = 0;

            if (brutopalk < 1200)
                maksuvaba = 654;

            double tulumaksuAlus = brutopalk - maksuvaba;
            if (tulumaksuAlus < 0)
                tulumaksuAlus = 0;

            double tulumaks = tulumaksuAlus * 0.20;
            double tootuskindlustus = brutopalk * 0.016;
            double pension = brutopalk * 0.02;

            double netopalk = brutopalk - tulumaks - tootuskindlustus - pension;
            Console.WriteLine($"maksuvaba on: {maksuvaba} ja netopalk on:  {netopalk}");
            return new Tuple<double, double>(maksuvaba, netopalk);
        }
    }
}



