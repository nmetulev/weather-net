#region

using System;
using WeatherNet.Model;

#endregion

namespace WeatherNet.Model
{
    /// <summary>
    ///     FiveDaysForecastResult result type.
    /// </summary>
    public class FiveDaysForecastResult : WeatherResult
    {
        /// <summary>
        ///     Time of data receiving in unixtime GMT.
        /// </summary>
        public int DateUnixFormat { get; set; }

        /// <summary>
        ///     Cloudiness in %
        /// </summary>
        public Double Clouds { get; set; }
    }
}