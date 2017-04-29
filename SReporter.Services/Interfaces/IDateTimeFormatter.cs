using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SReporter.Services.Interfaces
{
    public interface IDateTimeFormatter
    {
        string GetMonthName(int monthDate);
    }
}
