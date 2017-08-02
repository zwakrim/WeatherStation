using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
     public class humiditys : Asensor
    {
         public humiditys( double valueSensor)
            :base(valueSensor)
        {

        }
        public override double realValue()
        {
            if (getSensorValue > 0)
            {
                return base.getSensorValue * 1;
            }
            return 0;
        }
    }
}
    

