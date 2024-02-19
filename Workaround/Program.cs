global using global::System;
using Business.Concrete;
using Entities.Concrete;


namespace Workaround
{
    class Program
    {
        private static void Main(string[] args)
        {

            Person person1 = new Person();
            person1.FirstName = "ENGİN";
            person1.LastName = "DEMİROĞ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Murat";

            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1);




            Console.ReadLine();
        }




        //resharper eklenti araştır
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
//Stringler referans türlü değişkendir, fakat değer türlü davranır. Kısaca char array'i diyebiliriz. 