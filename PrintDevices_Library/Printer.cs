using System;
using System.Collections.Generic;
using System.Text;

namespace PrintDevices_Library
{
    public abstract class Printer : IPrintDevice
    {
        int maxSheetsCount;
        public int MaxSheetsCount  // унаследованное свойство
        {
            get { return maxSheetsCount; }
            set
            {
                if (value > 0 )
                    maxSheetsCount = value;
            }
        }

        string name;  
        public string Name  // имя устройства
        {
            get { return name; }
            set { name = value; }
        }

        bool isColor; 
        public bool IsColor   // цветной ли принтер
        {
            get { return isColor; }
            set { isColor = value; }
        }

        public abstract void Print();  // унаследованный метод
        public abstract void Shutdown();  // унаследованный метод
        public abstract void State();  // вывод информации о состоянии устройства

        public Printer(string name, bool isColor, int maxSheetCount)
        {
            this.Name = name;
            this.IsColor = isColor;
            this.MaxSheetsCount = maxSheetCount;
        }
    }
}
