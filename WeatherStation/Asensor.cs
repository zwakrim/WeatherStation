using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherStation
{
    public abstract class Asensor : IWeatherValue
    {
        private double valueSensor_;

        public Asensor( double valueSensor)
        {
            this.valueSensor_ = valueSensor;
        }
       
     
        public double getSensorValue
        {
            get
            {
                return this.valueSensor_;
            }
            set
            {
                if (value > 0)
                {
                    this.valueSensor_ = value;
                }
                
            }
        }
        public abstract double realValue();
    }
}
