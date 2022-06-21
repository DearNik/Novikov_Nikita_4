using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_4
{
    public class Smartphone : Gadget
    {
        static double SmartphonePrice { get; set; }
        static bool ConnectS = false;

        static string i = "Disonnect";
        public Smartphone(int Price, bool Connect) : base(Price)
        {
            SmartphonePrice = Price;
            ConnectS = Connect;
        }
        public static void Connect()
        {

            if (ConnectS == false) { Console.WriteLine("Smartphone is Conected"); ConnectS = true; i = "Connect"; }
            else { Console.WriteLine("Smartphone is Disconected"); ConnectS = false; i = "Disonnect"; }
        }
        public void ChangePrice()
        {
            Console.WriteLine("Change Smartphone Price to : ");
            SmartphonePrice = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n{SmartphonePrice} - SmartPhone Price");
        }
        public string ShowInfo()
        {
            return $"Smartfone Price = {SmartphonePrice} and this device is {i}\n";
        }
    }
}
