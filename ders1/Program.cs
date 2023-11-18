//using System;

//namespace ders1
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("merhaba");

//            Console.WriteLine("isminiz ne");
//            string isim = Console.ReadLine();
//            Console.WriteLine("soy ismini nedir");
//            string soyisim = Console.ReadLine();
//            Console.WriteLine("yaşadınız yer");
//            string sehir = Console.ReadLine();
//            Console.Clear();

//            Console.WriteLine("isim:" + isim);
//            Console.WriteLine("soyisim:"+soyisim);
//            Console.WriteLine("sehir:"+sehir);
//            Console.ReadLine();
//        }
//    }
//}


using System;

namespace ders1
{
    class Program
    {
        static void Main(string[] args)
        {
            string metin1 = "100";
            int s1 = int.Parse(metin1);//pars stringi alıp int aktarır
            int s2 = Convert.ToInt32(metin1);//üstekide buda aynı mantıkda

            string metin2 = "true";
            bool b1 = bool.Parse(metin2);
            bool b2 = Convert.ToBoolean(metin2);

            string metin3 = null;

            decimal d1 = decimal.Parse(metin3);
            decimal d2 = Convert.ToDecimal(metin3);

            //convert kullanın parseyi kullanmayın null da parse hata veriyor en iyisi convert


        }
    }
}