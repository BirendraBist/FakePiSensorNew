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
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Broadcast, 7890);
            //udpSender.Connect(endPoint);
            Console.WriteLine("Broadcast ready. Get started Press Enter");
            Console.ReadLine();
            while (true)
            {
                RandomGenerator _rand = new RandomGenerator();

               double _temperature = _rand.GetTemperature();
                double _pressure = _rand.GetPressure();
                double _humidity = _rand.GetHumidity();
                int _userId = _rand.GetUserId();

                string sensorData = $"UserId:{_userId}\n Temperature: {_temperature}\n Pressure:{_pressure}\n Humidity:{_humidity}\n ";

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
                Console.WriteLine("Temperature:" + _temperature);
                Console.WriteLine("Pressure:" + _pressure);
                Console.WriteLine("Humidity:" + _humidity);
                
                Console.WriteLine("Broadcasting data on Port no: 7890");
                Thread.Sleep(2000);
            }
        }
    }
}