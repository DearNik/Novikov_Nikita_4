using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Лаба_4
{
    public class PC : Gadget
    {
        static double PCPrice { get; set; }
        public PC(int Price) : base(Price)
        {
            PCPrice = Price;
        }
        public static void Reboot()
        {
            Console.Clear();
            Console.WriteLine("Shutdown 0%");
            Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("Shutdown 13%");
            Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("Shutdown 28%");
            Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("Shutdown 45%");
            Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("Shutdown 78%");
            Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("Shutdown 93%");
            Thread.Sleep(300);
            Console.Clear();
            Thread.Sleep(300);
            Console.WriteLine("switching - on 15%");
            Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("switching - on 68%");
            Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("switching - on 93%");
            Thread.Sleep(300);
            Console.Clear();
            Thread.Sleep(300);
            Console.WriteLine("Welcome Back\n    Press ENTER to Continue");
        }
        public static void Off()
        {
            Console.Clear();
            Console.WriteLine("Shutdown 0%");
            Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("Shutdown 13%");
            Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("Shutdown 28%");
            Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("Shutdown 45%");
            Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("Shutdown 78%");
            Thread.Sleep(300);
            Console.Clear();
            Console.WriteLine("Shutdown 93%");
            Thread.Sleep(300);
            Console.Clear();
        }
        public void ChangePrice()
        {
            Console.WriteLine("Change PC Price to : ");
            PCPrice = int.Parse(Console.ReadLine());
            Console.WriteLine($"\n{PCPrice} - PC Price");
        }
        public string ShowInfo()
        {
            return $"PC Price = {PCPrice} and this device is On\n";
        }
    }
}
