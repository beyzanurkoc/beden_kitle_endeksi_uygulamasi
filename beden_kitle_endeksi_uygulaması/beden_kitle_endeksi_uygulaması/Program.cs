using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace beden_kitle_endeksi_uygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // beden kitle endeksi = kilo/ boy*boy 
            // x <= 18 ise zayıf 
            // 18 < x < 25 ise normal 
            // 25 < x ise obez 

            Console.WriteLine("lutfen kilonuzu giriniz ");
            int kilo = Convert.ToInt32(Console.ReadLine()); 

            Console.WriteLine("lutfen boyunuzu giriniz");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (boy * boy) ;

            if (bke < 18)
            {
                Console.WriteLine("Zayifsiniz");
                Console.ReadLine();
            }
            else if ( bke > 18  && bke < 25)
            {
                Console.WriteLine("Normalsiniz");
                Console.ReadLine();
            }
            else if (25 < bke)
            {
                Console.WriteLine("Obezsiniz");
                Console.ReadLine(); 
            }











        }
    }
}
