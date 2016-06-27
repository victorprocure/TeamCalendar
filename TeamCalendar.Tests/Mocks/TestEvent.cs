using System;
using TeamCalendar.Events;

namespace TeamCalendar.Tests.Mocks
{
    internal class TestEvent : ICalendarEvent
    {
        private DateTime eventEndDate = DateTime.Now.AddHours(1);
        private string eventName = "Test Event";
        private DateTime eventStartDate = DateTime.Now;
        private ICalendarEventType eventType = new MockCalendarEventType();
        private string imageUrl = string.Empty;
        private string note = "Test note";

        public TestEvent()
        {
        }

        public TestEvent(DateTime eventDate)
        {
            this.eventStartDate = eventDate;
        }

        public DateTime EventEndDateTime
        {
            get
            {
                return this.eventEndDate;
            }
        }

        public string EventName
        {
            get
            {
                return this.eventName;
            }
        }

        public DateTime EventStartDateTime
        {
            get
            {
                return this.eventStartDate;
            }
        }

        public ICalendarEventType EventType
        {
            get
            {
                return this.eventType;
            }
        }

        public string ImageURL
        {
            get
            {
                return this.imageUrl;
            }
        }

        public string Note
        {
            get
            {
                return this.note;
            }
        }
    }
}