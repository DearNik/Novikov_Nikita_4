using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_4
{
    public class Systemblock : Gadget
    {
        static double SystemblockPrice { get; set; }

        static bool ConnectB;

        static string i = "Removed";
        public Systemblock(int Price,bool Connect) : base(Price)
        {
            SystemblockPrice = Price;
            ConnectB = Connect;
        }
        public static void Add()
        {
            if (ConnectB == false) { Console.WriteLine("Systemblock is Add"); ConnectB = true; i = "Added"; }
            else { Console.WriteLine("Systemblock is Remove"); ConnectB = false; i = "Removed"; }
        }
        public void ChangePrice()
        {
            Console.WriteLine("Change SystemBlock Price to : ");
            SystemblockPrice = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n{SystemblockPrice} - SystemBlock Price");
        }
        public string ShowInfo()
        {
            return $"System block Price = {SystemblockPrice} and this device is {i}\n";
        }
    }
}
