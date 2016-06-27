using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCalendar.Events
{
    public interface ICalendarEventType
    {
        string EventTypeName { get; }
    }
}
