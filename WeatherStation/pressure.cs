using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public class pressure : Asensor
    {
        public pressure(double valueSensor)
            : base(valueSensor)
        { }


        public override double realValue()
        {
            if (getSensorValue > 0)
            {
                return base.getSensorValue / 10;
            }
            return 0;
        }
    }
}