using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_PersonelUygulamasi
{
    public static class Helper
    {
        //Static olarak işaretlemiş classlar örneklenemez...
        //Helper H1 = new Helper();

        /*
        public void Test()
        {

        }
        *
        *
        *Statik olan class lar içerisinde standart metotlar kullanılamaz. (static olmayan metotlar)
        *

        public string Tanim { get; set; }

        *Statik olan class lar içerisinde static olmayan field tanımları yapılamaz.
        *
        */

       // public Helper()
        //{
        // Her nesne örneği alındığında uygulama standart yapıcı metotu çalıştırır.
       // }

        static Helper()
        {
            //Uygulama içerisinde istenildiği kadar çağrılsınlar sadece ilk çağrılmada çalışırlar...
            Console.WriteLine("Helper => Static class => static CTOR");
        }

        public static void emailGonder(string aliciEmailAdres, string konu, string icerik)
        {
            // Email gönderme işlemleri devam edecek...
            Console.WriteLine("Mail gönderim işlemi başarılı");
        }

    }
}
