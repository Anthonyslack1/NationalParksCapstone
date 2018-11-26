using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Web.Models
{
    /// <summary>
    /// Contains daily weather info from the DB
    /// </summary>
    public class WeatherModel
    {
        /// <summary>
        /// Low temperature for the day
        /// </summary>
        public int Low { get; set; }

        /// <summary>
        /// High temperature for the day
        /// </summary>
        public int High { get; set; }

        /// <summary>
        /// Forecast information (cloudy, rain, etc)
        /// </summary>
        public string Forecast { get; set; }
        
    }
}