global using global::System;

namespace Workaround
{
    class Program
    {
        private static void Main(string[] args)
        {

            SelamVer(isim:"ali");
            SelamVer(isim:"doğancan");
            SelamVer();

            int sonuc = Topla();

            Console.ReadLine();
        }

        static void SelamVer(string isim="isimsiz") //Default parametre deniyor
        {
            Console.WriteLine("Merhaba " + isim);
        }

        static int Topla()
        {
            return 5;
        }

       





    }






}