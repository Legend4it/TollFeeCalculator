using NUnit.Framework;
using TollFeeCalculator;

namespace NUnitTestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        //Tullavgifter varierar mellan 8kr och 18kr beroende på tidpunkt på dagen
        //Summerade tullavgifter per dag kan maximalt bli 60kr per fordon
        //Ett fordon betalar endast en tullavgift (den högsta) per timme
        //Vissa fordonstyper är befriade ifrån tullavgifter
        //Helger, helgdagar samt hela juli är tullfria

        [Test]
        public void IsTollFreeVehicle()
        {
            var mb = new Motorbike();

            Assert.IsTrue(mb.IsTollFreeVehicle());
        }

    }
}