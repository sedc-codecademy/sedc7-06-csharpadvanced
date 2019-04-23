using System;

namespace Exceptions3
{
    /// <summary>
    /// We are creatimng a custom exception called WeatherCustomException
    /// which needs to derive from Exception class
    /// </summary>
    public class WeatherCustomException : Exception
    {
        /// <summary>
        /// Constructor that takes two parameters message and innerException
        /// and with this constructor we are calling base constructor of 
        /// Exception class and just pass the message and innerException 
        /// </summary>
        public WeatherCustomException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
