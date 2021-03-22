using Nager.Date;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TollFeeCalculator;

namespace NUnitTestProject
{
    public class Tests
    {
        private List<DateTime> _dates;
        [SetUp]
        public void Setup()
        {
            _dates = GetDates();

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
            var vehicle = new Car("ABC123");
            var tc = new TollCalculator();
            var actual = tc.GetTollFee(vehicle, _dates.ToArray());

            Assert.IsTrue(actual <= 60);
        }
        [Test]
        public void GetTollFreeVehicleIsSuccess()
        {
            var vehicle = new Motorbike("ABC123");
            var tc = new TollCalculator();
            var actual = tc.GetTollFee(vehicle, _dates.ToArray());

            Assert.IsTrue(actual == 0);
        }

        [Test]
        public void GetVehicleTypeIsSuccess()
        {
            var vehicle = new Car("ABC123");
            var actual = vehicle.GetVehicleType();
            var expected = "Car";
            Assert.AreEqual(expected, actual);
        }

        private List<DateTime> GetDates()
        {
            return new List<DateTime>() {
            new DateTime(2021, 03, 18, 06, 20, 00),
            new DateTime(2021, 03, 18, 06, 35, 00),
            new DateTime(2021, 03, 18, 06, 44, 00),
            new DateTime(2021, 03, 18, 06, 45, 00),
            new DateTime(2021, 03, 18, 06, 55, 00),
            new DateTime(2021, 03, 18, 07, 10, 00),
            new DateTime(2021, 03, 18, 07, 55, 00),
            new DateTime(2021, 03, 18, 08, 20, 00),
            new DateTime(2021, 03, 18, 08, 55, 00),
            new DateTime(2021, 03, 18, 14, 50, 00),
            new DateTime(2021, 03, 18, 15, 00, 00),
            new DateTime(2021, 03, 18, 15, 20, 00),
            new DateTime(2021, 03, 18, 16, 55, 00),
            new DateTime(2021, 03, 18, 17, 00, 00),
            new DateTime(2021, 03, 18, 18, 55, 00)
        };
        }
    }
}