using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public interface IWeatherValue
    {
        double realValue();
        double getSensorValue { get; set; }

    }
}
