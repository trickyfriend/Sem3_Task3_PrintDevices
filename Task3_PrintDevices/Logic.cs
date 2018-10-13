using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PrintDevices_Library;

namespace Task3_PrintDevices
{
    public class Logic
    {
        private List<IPrintDevice> printDevices = new List<IPrintDevice>();

        void Add(string name, bool isColor, int maxSheetCount, bool isWireless, int incCapacity)
        {
            IPrintDevice newDevice = new LaserPrinter(name, isColor, maxSheetCount, isWireless, incCapacity);
            printDevices.Add(newDevice);
        }


        public void ConsoleInterface()
        {
            int selector = -1;
            int devicesCount = 0;
            while (!(selector == 0))
            {
                Console.WriteLine("Devices count: {0}", devicesCount);
                Console.WriteLine("Your actions: \n 1. Add new device; \n 2. Interact with some device; \n 3. Show all devices; \n 0. Exit.");
                selector = Convert.ToInt32(Console.ReadLine());
                if (selector == 0)
                    break;
                else if(selector == 1)
                {
                    Console.WriteLine("Input device name:");
                    string name = Console.ReadLine();
                    Console.WriteLine("Color print? y/n");
                    bool isColor;
                    if (Console.ReadLine() == "y")
                        isColor = true;
                    else
                        isColor = false;
                    Console.WriteLine("Input max sheet count:");
                    int maxSheetCount = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Wireless print? y/n");
                    bool isWireless;
                    if (Console.ReadLine() == "y")
                        isWireless = true;
                    else
                        isWireless = false;
                    Console.WriteLine("Input inc capacity:");
                    int incCapacity = Convert.ToInt32(Console.ReadLine());

                    Add(name, isColor, maxSheetCount, isWireless, incCapacity);
                    devicesCount++;
                    Console.WriteLine("Device added.\n");
                }
                else if (selector == 2)
                {
                    Console.WriteLine("Input the number of device:");
                    int number = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Choose the action: \n 1. Print; \n 2. Show state; \n 3. Clean laser; \n 4. Restart; \n 5. Shutdown; \n 6. Cancel.");
                    int action = Convert.ToInt32(Console.ReadLine());
                    if (action == 1)
                    {
                        printDevices[number - 1].Print();
                        Console.WriteLine("*Doing print*");
                    }
                    else if (action == 2)
                    {
                        ((LaserPrinter)printDevices[number - 1]).State() ;
                        Console.WriteLine("*Showing state*");
                    }
                    else if (action == 3)
                    {
                        ((LaserPrinter)printDevices[number - 1]).CleanLaser();
                        Console.WriteLine("*Cleaning laser*");
                    }
                    else if (action == 4)
                    {
                        ((LaserPrinter)printDevices[number - 1]).Restart();
                        Console.WriteLine("*Restarting device*");
                    }
                    else if (action == 5)
                    {
                        printDevices[number - 1].Shutdown();
                        Console.WriteLine("*Shutdown*");
                    }
                    else if (action == 6)
                    {
                        //do nothing and continue
                    }
                }
                else if (selector == 3)
                {
                    Console.WriteLine("\n");
                    for (int i = 0; i < printDevices.Count; i++)
                    {
                        Console.WriteLine("  {0}) {1}", (i + 1), ((LaserPrinter)printDevices[i]).Name);
                    }
                    Console.WriteLine("\n");

                }
            }
        }
    }
}
