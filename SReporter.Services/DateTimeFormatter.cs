using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using SReporter.Services.Interfaces;

namespace SReporter.Services
{
    public class DateTimeFormatter : IDateTimeFormatter
    {
        #region Services

        public string GetMonthName(int monthDate)
        {
            var dateTimeFormat = CultureInfo.CurrentCulture.DateTimeFormat;
            string monthName = dateTimeFormat.GetMonthName(monthDate);

            return monthName;
        }

        #endregion
    }
}
