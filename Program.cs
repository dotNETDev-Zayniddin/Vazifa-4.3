using System;
namespace Vazifa
{
    class Program
    {
        static void Main(){
            System.Console.Write("Hafta kunini o'zbek tilida kiriting: ");
            string day = Console.ReadLine().ToLower();


            switch(day){
                case "dushanba": System.Console.WriteLine("Monday");
                break;
                case "seshanba": System.Console.WriteLine("Tuesday");
                break;
                case "chorshanba": System.Console.WriteLine("Wednesday");
                break;
                case "payshanba": System.Console.WriteLine("Thursday");
                break;
                case "juma": System.Console.WriteLine("Friday");
                break;
                case "shanba": System.Console.WriteLine("Sunday");
                break;
                default: System.Console.WriteLine("Error input! Try again!");
                break;
            }
        }
    }
}