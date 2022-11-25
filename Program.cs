using System;

namespace OPERATORLER
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Atama ve İşlemli Atama
            /*
            Console.WriteLine("************* Atama ve İşlemli Atama *************");
            
            int x = 3;
            Console.WriteLine("x  = 3");

            int y = 2;
            Console.WriteLine("y = 2");

            y = y + 2;
            Console.WriteLine("Atama -- y = y + 2  ");
            Console.WriteLine("Sonuç = " + y);

            y += 2;//işlemli atama

            Console.WriteLine("İşlemli Atama --   y += 2  ");
            Console.WriteLine("Sonuç = " + y);

            y /= 1;//işlemli atama

            Console.WriteLine("İşlemli Atama -- y /= 2  ");
            Console.WriteLine("Sonuç = " + y);

            x *= 2;//işlemli atama

            Console.WriteLine("İşlemli Atama -- x *= 2  ");
            Console.WriteLine("Sonuç = " + x);
            
            */
            #endregion
            #region Mantıksal Operatörler
            /*
            Console.WriteLine("************* Mantıksal Operatörler *************");
            
            Console.WriteLine("|| = ve , && = veya , ! = değil");
            
            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted)
                Console.WriteLine("Perfect !");
            if (isSuccess || isCompleted)
                Console.WriteLine("Great !");
            if (isSuccess && !isCompleted)
                Console.WriteLine("Fine !");
            */

            #endregion
            #region İlişkisel Operatörler
            /*
            Console.WriteLine("************* İlişkisel Operatörler *************");
            
            Console.WriteLine("<, >, <= , >=, ==, !=");

            int a = 3;
            Console.WriteLine("a = 3");
            int b = 4;
            Console.WriteLine("b = 4");
            bool sonuc = a < b;
            Console.WriteLine("a < b = " + sonuc);
            sonuc = a > b;
            Console.WriteLine("a > b = " + sonuc);
            sonuc = a <= b;
            Console.WriteLine("a <= b = " + sonuc);
            sonuc = a >= b;
            Console.WriteLine("a >= b = " + sonuc);
            sonuc = a == b;
            Console.WriteLine("a == b = " + sonuc);
            sonuc = a != b;
            Console.WriteLine("a != b = " + sonuc);
            */
            #endregion
            #region Aritmatik Operatörler
            /*
            Console.WriteLine("************* Aritmatik Operatörler *************");

            Console.WriteLine("+, -, *, /, %");

            int sayi1 = 10;
            Console.WriteLine("sayi1 = 10");
            int sayi2 = 5;
            Console.WriteLine("sayi2 = 5");

            int sonuc = sayi1 + sayi2;
            Console.WriteLine("sayi1 + sayi2 = " + sonuc);

            sonuc = sayi1 - sayi2;
            Console.WriteLine("sayi1 - sayi2 = " + sonuc);

            sonuc = sayi1 * sayi2;
            Console.WriteLine("sayi1 * sayi2 = " + sonuc);

            sonuc = sayi1 / sayi2;
            Console.WriteLine("sayi1 / sayi2 = " + sonuc);

            sonuc = sayi1++;
            Console.WriteLine("sayi1++ = " + sonuc);

            sonuc = sayi2++;
            Console.WriteLine("sayi2++ = " + sonuc);

            // % Mod Alma
            Console.WriteLine("% Mod Alma");

            int sonuc3 = 20 % 3;
            Console.WriteLine("20 % 3 = " + sonuc3);
            */
            #endregion
        }
    }
}