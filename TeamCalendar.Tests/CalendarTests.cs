using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TeamCalendar.Tests.Mocks;

namespace TeamCalendar.Tests
{
    [TestClass]
    public class CalendarTests
    {
        [TestMethod]
        public void LoadCurrentMonthIfNoneSpecified()
        {
            var calendar = new Calendar();

            Assert.AreEqual(DateTime.Now.Month, calendar.Month);
        }

        [TestMethod]
        public void LoadSpecificMonthAsVisible()
        {
            var calendar = new Calendar(3);

            Assert.AreEqual(new DateTime(DateTime.Now.Year, 3, DateTime.Now.Day).Month, calendar.Month);
        }

        [TestMethod]
        public void LoadSpecificDateAsVisible()
        {
            var calendar = new Calendar(new DateTime(1966, 3, 1));

            Assert.AreEqual(3, calendar.Month);
        }

        [TestMethod]
        public void CanCreateEvent()
        {
            var calendar = new Calendar();

            var calendarEvent = calendar.AddEvent(new TestEvent());

            Assert.IsTrue(calendar.HasEvent(calendarEvent));
        }

        [TestMethod]
        public void CalendarHasEventForWhenOneSpansMultipleDays()
        {
            var calendar = new Calendar();

            var calendarEvent = calendar.AddEvent(new MockMultiDayEvent());

            Assert.IsTrue(calendar.HasEvent(DateTime.Now.AddDays(3)));
        }


    }
}
