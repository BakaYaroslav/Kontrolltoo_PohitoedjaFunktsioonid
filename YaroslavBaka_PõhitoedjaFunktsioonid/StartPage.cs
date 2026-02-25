using System;
using System.Collections.Generic;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Channels;

namespace YaroslavBaka_PõhitoedjaFunktsioonid
{
    internal class StartPage
    {
        public static void Main()
        {
            while (true)
            {

           
            Console.WriteLine("1.  KytuseKalkulaator");
            Console.WriteLine("2.  HindaIsikukood");
            Console.WriteLine("3. TaringuMang");
            Console.WriteLine("4. ArvutaPalk");
            Console.WriteLine("0. Väljapääs");
            Console.Write("Valik:   ");


            string valik = Console.ReadLine();
            if (valik == "1")
            {

                Alamfunktsioonid.KytuseKalkulaator();

            }
            else if (valik == "2")
            {

                Alamfunktsioonid.HindaIsikukood();

            }
            else if (valik == "3")
            {

                Alamfunktsioonid.TaringuMang();

            }
            else if (valik == "4")
            {
                    while (true)
                    {
                        try
                        {
                            Console.Write("Siseta sinu palk:  ");
                            double brutto_palk = double.Parse(Console.ReadLine());
                            Alamfunktsioonid.ArvutaPalk(brutto_palk);
                            break;
                        }
                        catch (Exception)
                        {
                            Console.WriteLine("Vale andmetüüp");

                        }
                    }
                   
               
            }
                else if (valik == "0")
                {
                    break;
                }


            }




        }

    }
}
