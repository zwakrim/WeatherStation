using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class Temp : Asensor
    {
        public Temp(double valueSensor)
            : base(valueSensor)
        {

        }
        public override double realValue()
        {
            if (getSensorValue > 0)
            {
                return (getSensorValue/10) ;
            }
            return 0;
        }
    }
}
