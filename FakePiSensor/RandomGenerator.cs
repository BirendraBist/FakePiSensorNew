using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakePiSensor
{
     public  class RandomGenerator
    {
        private Random _healthIdRandom;
        private Random _locationRandom;
        private Random _bodyTemperatureRandom;
        private Random _upperbloodPressureRandom;
        private Random _lowerbloodPressureRandom;
        private Random _heartBeatRandom;
        private Random _userIdRandom;

        public RandomGenerator()
        {
            _healthIdRandom =new Random();
            _bodyTemperatureRandom = new Random();
            _locationRandom=new Random();
            _upperbloodPressureRandom= new Random();
            _lowerbloodPressureRandom=new Random();
            _heartBeatRandom=new Random();
            _userIdRandom=new Random();
        }

          public double GetHealthId()
            {
                return _healthIdRandom.Next(95, 140);
            }
        public double GetLocation()
        {
            return _locationRandom.Next(95, 140);
        }

        public double GetBodyTemperature()
            {
                return _bodyTemperatureRandom.Next(50, 85);
            }

        public double GetUpperbloodPressure()
        {
            return _upperbloodPressureRandom.Next(70, 130);

        }

        public double GetLowerbloodPressure()
        {
            return _lowerbloodPressureRandom.Next(70, 130);
        }
        public double GetHeartBeat()
        {
            return _heartBeatRandom.Next(70, 100);
        }
        public int GetUserId()
        {
            return _userIdRandom.Next(1, 100);
        }

    }
}
