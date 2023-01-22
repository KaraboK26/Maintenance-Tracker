using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BusinessLayer
{
    class Simulator
    {
        private static string callnumber;
        public string CallNumber { get; set; }
        private static string duration;
        public string Duration { get; set; }

        private static DateTime callstart;
        private static DateTime callend;

        string[] numbers = new string[] { "0815556762", "0714449803", "0637771234", "0848345092", "0821239966", "0734569901"};

        public void StartCall()
        {
            callnumber = numbers[new Random().Next(numbers.Length)];
            callstart = DateTime.Now;
        }

        public void EndCall()
        {
            callend = DateTime.Now;
            TimeSpan time = callend.Subtract(callstart);
            duration = $"{time.Hours}:{time.Minutes}:{time.Seconds}";
        }

        public Simulator callinfo()
        {
            Simulator simulator = new Simulator();

            simulator.CallNumber = callnumber;
            simulator.Duration = duration;

            return simulator;
        }
    }
}
