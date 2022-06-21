using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_4
{
    public class Monitor : Gadget
    {
        static double MonitorPrice { get; set; }
        static bool ConnectM = false;

        static string i = "Disonnect";
        public Monitor(int Price, bool Connect) : base(Price)
        {
            MonitorPrice = Price;
            ConnectM = Connect;
        }
        public static void Connect()
        {
            if(ConnectM == false) { Console.WriteLine("Minitor is Conected"); ConnectM = true; i = "Connect"; }
            else{ Console.WriteLine("Minitor is Disconected"); ConnectM = false; i = "Disonnect"; }
        }
        public void ChangePrice()
        {
            Console.WriteLine("Change Monitor Price to : ");
            MonitorPrice = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n{MonitorPrice} - Monitor Price");
        }
        public string ShowInfo()
        {
            return $"Monitor Price = {MonitorPrice} and this device is {i}\n";
        }
    }
}
