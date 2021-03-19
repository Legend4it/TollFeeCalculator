using Nager.Date;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TollFeeCalculator;

namespace NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void IsTollFreeVehicle()
        {
            var mb = new Motorbike("ABC123");
            Assert.IsTrue(mb.IsTollFreeVehicle());
        }

        [Test]
        public void IsWeekEndDay()
        {
            var date = new DateTime(DateTime.Now.Year, 3, 14);
            Assert.IsTrue(DateSystem.IsWeekend(date, CountryCode.SE));
        }
        [Test]
        public void IsPublicHoliday()
        {
            var date = new DateTime(2013, 4, 1); // 1 april was holiday on 2013 and next on 2024.
            Assert.IsTrue(DateSystem.IsPublicHoliday(date, CountryCode.SE));

            date = new DateTime(DateTime.Now.Year, 4, 1); // 1 april is not holiday on current year.
            Assert.IsFalse(DateSystem.IsPublicHoliday(date, CountryCode.SE));
        }

        [Test]
        public void GetMaxFeePerDagIsSuccess()
        {
            var dates = new List<DateTime>(); //date and time of all passes on one day
            dates.Add(new DateTime(2021, 03, 18, 10, 10, 00));
            dates.Add(new DateTime(2021, 03, 18, 10, 15, 00));
            dates.Add(new DateTime(2021, 03, 18, 11, 00, 00));
            dates.Add(new DateTime(2021, 03, 18, 11, 30, 00));
            dates.Add(new DateTime(2021, 03, 18, 12, 00, 00));
            dates.Add(new DateTime(2021, 03, 18, 13, 00, 00));
            dates.Add(new DateTime(2021, 03, 18, 14, 00, 00));
            dates.Add(new DateTime(2021, 03, 18, 14, 30, 00));
            var vehicle = new Car("ABC123");
            var tc = new TollCalculator();
            var actual = tc.GetTollFee(vehicle, dates.ToArray());

            Assert.IsTrue(actual <= 60);
        }

    }
}