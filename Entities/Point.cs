using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    class Point
    {
        private double temperature;
        public double Temperature
        {
            get { return temperature; }
            set { temperature = value; }
        }
        private double energy;
        public double Energy
        {
            get { return energy; }
            set { energy = value; }
        }
        private DateTime yearMonthDayTime;
        public DateTime YearMonthDayTime
        {
            get { return yearMonthDayTime; }
            set { yearMonthDayTime = value; }
        }

    }
}
