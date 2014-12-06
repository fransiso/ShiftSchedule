using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShiftSchedule.Domain.Entities;

namespace UnitTest
{
    [TestClass]
    public class ShiftTests
    {
        [TestMethod]
        [TestCategory("SimpleMath")]
        public void GetDuration()
        {
            var shift = new Shift("NOC", DayOfWeek.Friday, TimeSpan.FromHours(3), TimeSpan.FromHours(4));
            TimeSpan durationSpan = shift.GetDuration();
            Assert.AreEqual(1, durationSpan.Hours);
        }
    }
}
