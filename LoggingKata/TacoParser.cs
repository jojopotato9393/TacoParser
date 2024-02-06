﻿using System.Runtime.CompilerServices;

namespace LoggingKata
{
    /// <summary>
    /// Parses a POI file to locate all the Taco Bells
    /// </summary>
    public class TacoParser
    {
        readonly ILog logger = new TacoLogger();
        
        public ITrackable Parse(string line)
        {
            logger.LogInfo("Begin parsing");

            // Take your line and use line.Split(',') to split it up into an array of strings, separated by the char ','
            var cells = line.Split(',');

            // If your array's Length is less than 3, something went wrong
            if (cells.Length < 3)
            {
                // Log error message and return null
                return null; 
            }
            double lat = double.Parse(cells[0]);
            double lon = double.Parse(cells[1]);

            var location = new Point
            {
                Latitude = lat,
                Longitude = lon
            };

            var name = cells[2];

            var tacoBell = new TacoBell
            {
                Name = name,
                Location = location
            };
        
            
            return tacoBell;
            // TODO: Grab the name from your array at index 2
            

            // TODO: Create a TacoBell class
            // that conforms to ITrackable
            
            // TODO: Create an instance of the Point Struct
            // TODO: Set the values of the point correctly (Latitude and Longitude) 

            // TODO: Create an instance of the TacoBell class
            // TODO: Set the values of the class correctly (Name and Location)

            // TODO: Then, return the instance of your TacoBell class,
            // since it conforms to ITrackable

        }
    }
}
