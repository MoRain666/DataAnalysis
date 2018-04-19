using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage;

namespace Services
{
    static public class Parser
    {
        static public int[] TemperatureTable;

        static public void ParseTemp()
        {

            if(Temp.getTempStringArrayOfEnergy()!=null && Temp.getTempStringArrayOfTemperature()!=null)
            {
                
            }
            else
            {
                
            }
        }     
        static public string[] ParseString(string value)
        {
            string[] split = value.Split('\t');
            return split;
        }
        static public bool ParseTemperatureTemp()
        {
            foreach(string str in Temp.getTempStringArrayOfTemperature())
            {
                string[] split = ParseString(str);
                if (Convert.ToInt32(split[5]) >= 8)
                {

                    return true;
                }
                else
                    return false;
            }
        }
    }
}
