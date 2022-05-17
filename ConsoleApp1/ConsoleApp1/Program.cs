using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            //
            //            Tapşırıq, stringdə olan adları tərs çevirib yeni bir string kimi geriyə qaytaran method yazın. Məsələn:
            //“Nurlan Faiq Emil Tural Yusif” ->
            //“nalruN qaiF limE laruT fisuY

            //Not(hazır metodlardan kömək almaq olar, amma reverse metodundan istifadə etmək olmaz)

            string name = "Nurlan Faiq Emil Tural Yusif";
            Console.WriteLine(Revers(name));
        }

        static string Revers(string name)
        {
            string reversedName = "";
            for (int i = name.Length - 1; i >= 0; i--)
            {
                reversedName += name[i];

            }
            return reversedName;


        }

    }
}
  
