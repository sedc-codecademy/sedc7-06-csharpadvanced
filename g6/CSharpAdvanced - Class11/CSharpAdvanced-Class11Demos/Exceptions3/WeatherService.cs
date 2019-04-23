using System;

namespace Exceptions3
{
    public class WeatherService
    {
        public void GetLatestDataAboutTheWeather()
        {
            try
            {
                //Logic for getting the data from some URL (Api)

                throw new Exception("Something wrong on low level...");

            }
            catch (Exception ex)
            {
                throw new WeatherCustomException("Something is wrong with fetching the weather info", ex);
            }
        }
    }
}
