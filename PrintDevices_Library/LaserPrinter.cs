using System;
using System.Collections.Generic;
using System.Text;

namespace PrintDevices_Library
{
    public class LaserPrinter : Printer, IPrintDevice
    {
        bool isWireless;
        public bool IsWireless  //  беспроводной ли
        {
            get { return isWireless; }
            set { isWireless = value; }
        }

        int incCapacity;
        public int IncCapacity  //  объём хранилища чернил
        {
            get { return incCapacity; }
            set
            {
                if (value > 0)
                    incCapacity = value;
            }
        }

        public override void Print()
        {
            // какие то действия, приводящие к печати
        }
        public override void Shutdown()
        {
            // какие-то действия, приводящие к выключению устройства
        }
        public override void State()
        {
            // какие-то действия, отображающие текущее состояние принтера
        }

        public void Restart()
        {
            // какие-то действия для перезапуска принтера
        }
        public void CleanLaser()
        {
            // действия по очистке лазера(почему бы и нет)
        }

        public LaserPrinter (string name, bool isColor, int maxSheetCount, bool isWireless, int incCapacity) : base(name, isColor, maxSheetCount)
        {
            this.isWireless = isWireless;
            this.IncCapacity = incCapacity;
        }
    }
}
