using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShiftSchedule.Domain.Entities;

namespace ShiftSchedule.UnitTests.Domain.Entities
{
    [TestClass]
    public class EmployeeTests
    {
        [TestMethod]
        [TestCategory("SimpleGet")]
        public void GetFullName()
        {
            var emp = new Employee("Amir","Fransis","blad@gmail.com");
            string fullname = emp.GetFullName();
            Assert.AreEqual("Amir Fransis",fullname);
        }
    }
}
