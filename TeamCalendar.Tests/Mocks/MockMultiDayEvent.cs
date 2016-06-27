//-----------------------------------------------------------------------
// <copyright file="MockMultiDayEvent.cs" company="Brookfield Residential Properties">
//     Copyright (c) Brookfield Residential Properties. All rights reserved.
// </copyright>
// <author>Victor Procure</author>
//-----------------------------------------------------------------------
namespace TeamCalendar.Tests.Mocks
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Events;

    class MockMultiDayEvent : ICalendarEvent
    {
        private string eventName = "MultiDay Event";
        private ICalendarEventType calendarEventType = new MockCalendarEventType();
        private string imageUrl = string.Empty;
        private string note = string.Empty;
        private DateTime startDate = DateTime.Now;
        private DateTime endDate = DateTime.Now.AddDays(7);

        public string EventName
        {
            get
            {
                return this.eventName;
            }
        }

        public ICalendarEventType EventType
        {
            get
            {
                return this.calendarEventType;
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

        public DateTime EventStartDateTime
        {
            get
            {
                return this.startDate;
            }
        }

        public DateTime EventEndDateTime
        {
            get
            {
                return this.endDate;
            }
        }
    }
}
