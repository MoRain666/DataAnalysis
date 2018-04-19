using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Storage
{
    static public class Temp
    {
        //временное хранилище для данных энергии
        static private string[] TempStringArrayOfEnergy;
        //временное хранилище для данных температуры
        static private string[] TempStringArrayOfTemperature;
        //возвращает данные энергии
        static public string[] getTempStringArrayOfEnergy()
        {
            return TempStringArrayOfEnergy;
        }
        //заполнение данных энергии
        static public void setTempStringArrayOfEnergy(string[] value)
        {
            TempStringArrayOfEnergy = value;
        }
        //возвращает данные температуры
        static public string[] getTempStringArrayOfTemperature()
        {
            return TempStringArrayOfTemperature;
        }
        //заполнение данных температуры
        static public void setTempStringArrayOfTemperature(string[] value)
        {
            TempStringArrayOfTemperature = value;
        }
    }
}
