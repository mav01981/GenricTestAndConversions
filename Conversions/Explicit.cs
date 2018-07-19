﻿namespace Conversions
{
    class Celsius
    {
        public Celsius(float temp)
        {
            degrees = temp;
        }
        public static explicit operator Fahrenheit(Celsius c)
        {
            return new Fahrenheit((9.0f / 5.0f) * c.degrees + 32);
        }
        public float Degrees
        {
            get { return degrees; }
        }
        private float degrees;
    }

    class Fahrenheit
    {
        public Fahrenheit(float temp)
        {
            degrees = temp;
        }
        // Must be defined inside a class called Fahrenheit:
        public static explicit operator Celsius(Fahrenheit fahr)
        {
            return new Celsius((5.0f / 9.0f) * (fahr.degrees - 32));
        }
        public float Degrees
        {
            get { return degrees; }
        }
        private float degrees;
    }

}
