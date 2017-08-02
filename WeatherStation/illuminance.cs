using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class illuminance : Asensor
    {

        public  illuminance(double valueSensor)
            :base(valueSensor)
        {}


        public override double realValue()
        {
            if (getSensorValue > 0)
            {
                return Math.Round((base.getSensorValue/ 1023) * 100) ;
            }
            return 0;
        }
    }
}

