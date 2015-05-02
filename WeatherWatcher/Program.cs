using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForecastIO;

namespace WeatherWatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var request = new ForecastIORequest("b7c1ba3c892accf81964d6984d626646", 30.079874f, -99.169474f, Unit.si);
            var response = request.Get();
            Console.ReadLine();
        }
    }
}
