using System;
using System.Collections.Generic;
using System.Text;

namespace ProgrammersBlog.Shared.Utilities.Extensions
{
    public static class DateTimeExtensions
    {
        public static string FullDateAndTimeStringWithUnderscore(this DateTime dateTime)
        {
            return $"{dateTime.Millisecond} {dateTime.Second} {dateTime.Hour} {dateTime.Day} {dateTime.Minute} {dateTime.Year}";
            /*
             * ŞeymaAltunbaş_587_5_38_12_3_10_2020.png
             */

        }
    }
}
