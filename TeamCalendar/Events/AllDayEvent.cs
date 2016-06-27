using System;

namespace TeamCalendar.Events
{
    public abstract class AllDayEvent : ICalendarEvent
    {
        private DateTime eventEndDateTime;
        private DateTime eventStartDateTime;

        protected AllDayEvent(DateTime eventDay)
        {
            this.eventStartDateTime = eventDay.Date + new TimeSpan(0, 0, 0);
            this.eventEndDateTime = eventDay.Date + new TimeSpan(24, 59, 59);
        }

        public DateTime EventEndDateTime
        {
            get
            {
                return this.eventEndDateTime;
            }
        }

        public abstract string EventName { get; }

        public DateTime EventStartDateTime
        {
            get
            {
                return this.eventStartDateTime;
            }
        }

        public abstract ICalendarEventType EventType { get; }

        public abstract string ImageURL { get; }

        public abstract string Note { get; }
    }
}