using System;

namespace Лаба_4
{
    using System;

    namespace Лаба_4
    {
        class Program
        {
            static PC Asus = new PC(1500);
            static Smartphone IPhone_10 = new Smartphone(25,false);
            static Monitor Asus_MG248QR = new Monitor(45,false);
            static Systemblock Aerocool = new Systemblock(10,false);
            static void Main(string[] args)
            {
                int choose = 0;
                do
                {
                    Console.WriteLine("Setings :");
                    Console.WriteLine("\n[1] Reboot PC\n");
                    Console.WriteLine("[2] Connect/Disconnect Monitor to/from PC");
                    Console.WriteLine("[3] Connect/Disconnect Smartphone to/from PC");
                    Console.WriteLine("[4] Add/Remove body to/from PC\n");
                    Console.WriteLine("[5] Gadget Info");
                    Console.WriteLine("[6] Change Price");
                    Console.WriteLine("[7] Off PC");

                    choose = int.Parse(Console.ReadLine());

                    switch (choose)
                    {
                        case 1:
                            PC.Reboot();
                            break;
                        case 2:
                            Monitor.Connect();
                            break;
                        case 3:
                            Smartphone.Connect();
                            break;
                        case 4:
                            Systemblock.Add();
                            break;
                        case 5:
                            Console.WriteLine($"\n{IPhone_10.ShowInfo()}{Asus_MG248QR.ShowInfo()}{Aerocool.ShowInfo()}{Asus.ShowInfo()}");
                            break;
                        case 6:
                            Console.WriteLine("Choose Gadget to change Price : \n");
                            Console.WriteLine("[1] Change Price PC");
                            Console.WriteLine("[2] Change Price Monitor");
                            Console.WriteLine("[3] Change Price System block");
                            Console.WriteLine("[4] Change Price SmartPhone");
                            Console.WriteLine("[5] Exit");

                            int chooses = int.Parse(Console.ReadLine());

                            switch (chooses)
                            {
                                case 1:
                                    Asus.ChangePrice();
                                    break;
                                case 2:
                                    Asus_MG248QR.ChangePrice();
                                    break;
                                case 3:
                                    Aerocool.ChangePrice();
                                    break;
                                case 4:
                                    IPhone_10.ChangePrice();
                                    break;
                                case 5:
                                    break;
                            }
                            break;

                    }
                    Console.ReadKey();
                    Console.Clear();
                }
                while (choose != 7);

                PC.Off();
            }
        }
    }
}