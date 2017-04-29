using System;
using System.Globalization;
using CsvHelper.TypeConversion;

namespace SReporter.DataAccess.CsvReportMapper
{
    public sealed class StringTimeSpanConverter : ITypeConverter
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
            return TimeSpan.ParseExact(text, @"h\:mm", CultureInfo.InvariantCulture);
        }

        public string ConvertToString(TypeConverterOptions options, object value)
        {
            return ((TimeSpan)value).ToString(@"h\:mm", CultureInfo.InvariantCulture);
        }
    }
}
