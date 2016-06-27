using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamCalendar.Events
{
    public interface ICalendarEvent
    {
        string EventName { get; }

        ICalendarEventType EventType { get; }

        string ImageURL { get; }

        string Note { get; }

        DateTime EventStartDateTime { get; }

        DateTime EventEndDateTime { get; }
    }
}
