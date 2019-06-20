using System;
using System.Collections;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Currency
{
    class Program
    {
        public static void NorthAmericanCurrency(double money)
        {
            Console.WriteLine("The total Value in US Currency is: " + money.ToString("C"));
        }
        public static void SwedishCurrency(double money)
        {
            Console.WriteLine("The total Value in Swedish Currency is: " + money.ToString("C", CultureInfo.CreateSpecificCulture("sv-FV")));
        }
        public static void JapaneseCurrency(double money)
        {
            Console.WriteLine("The total Value in Japanese Currency is: " + money.ToString("C", CultureInfo.CreateSpecificCulture("ja-JP")));
        }
        public static void ThaiCurrency(double money)
        {
            Console.WriteLine("The total Value in Thai Currency is: " + money.ToString("C", CultureInfo.CreateSpecificCulture("th-TH")));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter First currency value ");
            string money1 = Console.ReadLine();
            Console.WriteLine("Please enter Second currency value ");
            string money2 = Console.ReadLine();
            Console.WriteLine("Please enter Third currency value ");
            string money3 = Console.ReadLine();

            ArrayList a1 = new ArrayList();
            a1.Add(money1);
            a1.Add(money2);
            a1.Add(money3);

            string[] cur1 = a1.ToArray(typeof(string)) as string[];

            Console.WriteLine();
            Console.WriteLine("The Maximum value is: " + cur1.Max());
            Console.WriteLine("The Minimum value is: " + cur1.Min());

            {
                double money11 = double.Parse(money1);
                double money22 = double.Parse(money2);
                double money33 = double.Parse(money3);

                Console.WriteLine("The Average value is: " + (money11 + money22 + money33) / 3);


                double total = (money11 + money22 + money33);

                Console.WriteLine();

                NorthAmericanCurrency(total);
                SwedishCurrency(total);
                JapaneseCurrency(total);
                ThaiCurrency(total);

            }
            Console.WriteLine();
            Console.WriteLine("Thanks for paying");
            Console.ReadLine();
        }
    }
}
