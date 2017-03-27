﻿using System;

namespace KoenZomers.Tools.SunSetRiseLib
{
    class Program
    {
        static void Main(string[] args)
        {
            // Date for which to calculate the sunrise and sunset
            var date = DateTime.Today;

            // Latitude for which to calculate the sunrise/sunset
            var latitude = 52.3702157;

            // Longitude for which to calculate the sunrise/sunset
            var longitude = 4.8951679;
            
            // Hours from UTC which this location is in
            var utcOffset = TimeZone.CurrentTimeZone.GetUtcOffset(DateTime.Now).Hours;

            // Write the output to the screen
            Console.WriteLine("Date: " + date.ToLongDateString());
            Console.WriteLine("UTC Offset: " + utcOffset);
            Console.WriteLine("Coordinates: LONG " + longitude + " LAT " + latitude);
            Console.WriteLine("Sunrise: " + SunSetRiseLib.SunriseAt(latitude, longitude, date, utcOffset));
            Console.WriteLine("SunSet: " + SunSetRiseLib.SunsetAt(latitude, longitude, date, utcOffset));
        }
    }
}
