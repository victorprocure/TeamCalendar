using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCalendar.Events;

namespace TeamCalendar
{
    /// <summary>
    /// 
    /// </summary>
    public class Calendar
    {
        private DateTime visibleDate;
        private ICollection<ICalendarEvent> events;

        public int Month
        {
            get
            {
                return this.visibleDate.Month;
            }
        }

        public int Year
        {
            get
            {
                return this.visibleDate.Year;
            }
        }

        public int Day
        {
            get
            {
                return this.visibleDate.Day;
            }
        }

        public ICollection<ICalendarEvent> Events
        {
            get
            {
                return this.events;
            }
        }

        public Calendar()
        {
            this.visibleDate = DateTime.Now;
        }

        public Calendar(int month)
        {
            this.visibleDate = new DateTime(DateTime.Now.Year, month, 1);
        }

        public Calendar(DateTime date)
        {
            this.visibleDate = date;
        }

        public ICalendarEvent AddEvent(ICalendarEvent calendarEvent)
        {
            if(this.events == null)
            {
                this.events = new List<ICalendarEvent>();
            }

            this.events.Add(calendarEvent);

            return calendarEvent;
        }

        public bool HasEvent(ICalendarEvent calendarEvent)
        {
            return this.events.First(ce => ce == calendarEvent) != null;
        }

        public bool HasEvent(DateTime dateTime)
        {
            return this.events.Where(ce => dateTime >= ce.EventStartDateTime && dateTime < ce.EventEndDateTime) != null;
        }
    }
}
