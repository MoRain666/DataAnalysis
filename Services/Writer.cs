using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Storage;

namespace Services
{
    class Writer
    {
        static public void WriteInBinaryFileFromStructures()
        {
            Encoding.GetEncoding(1251);
            //File.WriteAllLines();
            //DateTime.try
        }
        static public void WriteInStructuresFromTemp()
        {
            if(Temp.getTempStringArrayOfEnergy() != null && Temp.getTempStringArrayOfTemperature() != null)
            {

            }
            else
            {

            }
        }
        
    }
}
