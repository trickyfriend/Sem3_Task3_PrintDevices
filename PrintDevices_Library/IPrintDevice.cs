using System;
using System.Collections.Generic;
using System.Text;

namespace PrintDevices_Library
{
    public interface IPrintDevice
    {
        int MaxSheetsCount { get; set; }  // максимальное количество листов, которое можно загрузить в устройство
        void Print();  // печать листа
        void Shutdown();  // выключение
    }
}
