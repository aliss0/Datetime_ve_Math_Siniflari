using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datetime_ve_Math_Siniflari
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****DateTime*****");
            Console.WriteLine(DateTime.Now); // günün tarihini getirir.
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);

            Console.WriteLine("--------------------");

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine("--------------------");

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine("--------------------");

            Console.WriteLine(DateTime.Now.AddYears(10));
            Console.WriteLine(DateTime.Now.AddMonths(5));
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(3));
            Console.WriteLine(DateTime.Now.AddMinutes(3));
            Console.WriteLine(DateTime.Now.AddSeconds(30));
            Console.WriteLine(DateTime.Now.AddMilliseconds(50));

            Console.WriteLine("--------------------");

            // DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); 
            Console.WriteLine(DateTime.Now.ToString("ddd")); // "Paz"
            Console.WriteLine(DateTime.Now.ToString("dddd"));  // "Pazar"

            Console.WriteLine("--------------------");

            Console.WriteLine(DateTime.Now.ToString("MM"));  //"11"
            Console.WriteLine(DateTime.Now.ToString("MMM"));  //"Kas"
            Console.WriteLine(DateTime.Now.ToString("MMMM"));  //"Kasım"

            Console.WriteLine("--------------------");

            Console.WriteLine(DateTime.Now.ToString("yy"));  // "22
            Console.WriteLine(DateTime.Now.ToString("yyyy"));  // "2022

            Console.WriteLine("*****Math*****");

            // Math Kütüphanesi

            Console.WriteLine(Math.Abs(-25));
            Console.WriteLine(Math.Sin(10));
            Console.WriteLine(Math.Cos(10));
            Console.WriteLine(Math.Tan(10));

            Console.WriteLine("--------------------");

            Console.WriteLine(Math.Ceiling(22.3)); 
            Console.WriteLine(Math.Round(22.3));   
            Console.WriteLine(Math.Round(22.7));   
            Console.WriteLine(Math.Floor(22.7));

            Console.WriteLine("--------------------");

            Console.WriteLine(Math.Max(2, 6));
            Console.WriteLine(Math.Min(2, 6));

            Console.WriteLine("--------------------");

            Console.WriteLine(Math.Pow(3, 4));// 3 üzeri 4 
            Console.WriteLine(Math.Sqrt(9));  // 9 un karekökünü alır.
            Console.WriteLine(Math.Log(9));  
            Console.WriteLine(Math.Log10(10)); 
            Console.WriteLine(Math.Exp(3));

            Console.ReadLine();
        }
    }
}
