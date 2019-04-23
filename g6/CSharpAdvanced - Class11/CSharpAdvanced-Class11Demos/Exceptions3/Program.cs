using System;

namespace Exceptions3
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherService service = new WeatherService();

            try
            {
                service.GetLatestDataAboutTheWeather();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
