using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakePiSensor
{
     public  class RandomGenerator
    {
        private Random _temperatureRandom;
        private Random _presureRandom;
        private Random _humidityRandom;
       private Random _userIdRandom;

        public RandomGenerator()
        {
            _temperatureRandom = new Random();
            _presureRandom = new Random();
            _humidityRandom = new Random();
            _userIdRandom=new Random();
        }

          public double GetTemperature()
            {
                return -_temperatureRandom.Next(95, 140);
            }
        public double GetPressure()
        {
            return _presureRandom.Next(95, 140);

        }

        public double GetHumidity()
            {
                return _humidityRandom.Next(50, 85);
            }

        public int GetUserId()
        {
            return _userIdRandom.Next(0, 130);

        }

    }
}
