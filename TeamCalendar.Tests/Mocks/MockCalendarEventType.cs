using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeamCalendar.Events;

namespace TeamCalendar.Tests.Mocks
{
    class MockCalendarEventType : ICalendarEventType
    {
        private string eventTypeName = "Test Type";

        public string EventTypeName
        {
            get
            {
                return this.eventTypeName;
            }

        }
    }
}
