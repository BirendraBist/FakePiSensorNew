using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FakePiSensor
{
    class Program
    {
        static void Main(string[] args)
        {
            UdpClient udpSender = new UdpClient(0) { EnableBroadcast = true };
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, 7000);
            //udpSender.Connect(endPoint);
            Console.WriteLine("Broadcast ready. Get started Press Enter");
            Console.ReadLine();
            while (true)
            {
                RandomGenerator _rand = new RandomGenerator();

               double _healthId = _rand.GetHealthId();
                double _location = _rand.GetLocation();
                double _bodyTemperature = _rand.GetBodyTemperature();
                double _upperbloodPressure = _rand.GetUpperbloodPressure();
                double _lowerbloodPressure = _rand.GetLowerbloodPressure();
                double _heartBeat = _rand.GetHeartBeat();
                int _userId = _rand.GetUserId();

                string sensorData = $"UserId:{_userId}\n HealthId: {_healthId}\n Location:{_location}\n Body Temperature:{_bodyTemperature}\n Upper blood pressure: {_upperbloodPressure}\n Low Blood Pressure:{_lowerbloodPressure}\n Heart Beat:{_healthId}\n userid:{_userId}\n";

                Byte[] sendBytes = Encoding.ASCII.GetBytes(sensorData);

                try
                {
                    udpSender.Send(sendBytes, sendBytes.Length, endPoint);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
                Console.WriteLine("UserId:" + _userId);
                Console.WriteLine("HealthId:" + _healthId);
                Console.WriteLine("Location:" + _location);
                Console.WriteLine("Upper blood Pressure:" + _upperbloodPressure);
                Console.WriteLine("Lowe Blood Pressure:" + _lowerbloodPressure);
                Console.WriteLine("Heart beat:" + _heartBeat);
                Console.WriteLine("Location:" + _location);
                Console.WriteLine("Broadcasting data on Port no: 7000");
                Thread.Sleep(2000);
            }
        }
    }
}