namespace StaticClasses
{
    public static class TemperatureConvertor
    {
        public static double CelsiusToFahrenheit(string C)
        {
            double celsius = double.Parse(C);
            double fahrenheit = (celsius * 1.8) + 32;
            return fahrenheit;
        }
        public static double FahrenheitToCelsius(string F)
        {
            double fahrenheit = double.Parse(F);
            double celsius = (fahrenheit - 32) / 1.8;
            return celsius;
        }

    }
}