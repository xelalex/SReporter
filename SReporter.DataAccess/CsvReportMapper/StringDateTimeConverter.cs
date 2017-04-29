using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using CsvHelper.TypeConversion;

namespace SReporter.DataAccess.CsvReportMapper
{
    public sealed class StringDateTimeConverter : ITypeConverter
    {
        public bool CanConvertFrom(Type type)
        {
            return type == typeof(string);
        }

        public bool CanConvertTo(Type type)
        {
            return type == typeof(string);
        }

        public object ConvertFromString(TypeConverterOptions options, string text)
        {
            return DateTime.ParseExact(text, "d/MM/yy", CultureInfo.InvariantCulture);
        }

        public string ConvertToString(TypeConverterOptions options, object value)
        {
            return ((DateTime)value).ToString("d/MM/yy", CultureInfo.InvariantCulture);
        }
    }
}
