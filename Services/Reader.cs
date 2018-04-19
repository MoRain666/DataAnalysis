using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;
using System.IO;
using Storage;

namespace Services
{
    static public class Reader
    {
        //энергия интегральная, час это два значения, могут 
        static public bool ReadTxtFileToTemp(string FileName)
        {
            if (FileName.Contains("\\Q"))
            {
                Temp.setTempStringArrayOfEnergy(File.ReadAllLines(FileName));
                return true;
            }
            else if (FileName.Contains("\\T"))
            {
                Temp.setTempStringArrayOfTemperature(File.ReadAllLines(FileName));
                return true;
            }
            else
                return false;
        }
        static public void ReadBinaryFileToStructure()
        {

        }
        


    }
}
