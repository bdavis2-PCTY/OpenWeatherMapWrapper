using System;

namespace OpenWeatherMapWrapper.Helpers
{
    /// <summary>
    /// Collection of methods to assist with DateTime objects
    /// </summary>
    internal static class DateTimeHelpers
    {
        /// <summary>
        /// Converts a Unix timestamp to a DateTime object
        /// </summary>
        /// <param name="unixTimeStamp"></param>
        /// <returns></returns>
        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            return GetUtcUnixTimestamp().AddSeconds(unixTimeStamp);
        }

        /// <summary>
        /// Converts a DateTime object to a Unix timestamp
        /// </summary>
        /// <param name="pDateTime"></param>
        /// <returns></returns>
        public static long DateTimeToUnixTimeStamp(DateTime pDateTime)
        {
            int unixTimestamp = (int)(pDateTime.Subtract(GetUtcUnixTimestamp())).TotalSeconds;
            return unixTimestamp;
        }

        /// <summary>
        /// Returns the offset needed to convert a DateTIme to Unix time and vice-versa
        /// </summary>
        /// <returns></returns>
        private static DateTime GetUtcUnixTimestamp()
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc);
        }
    }
}