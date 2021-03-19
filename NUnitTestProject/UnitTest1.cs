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

        //Tullavgifter varierar mellan 8kr och 18kr beroende p� tidpunkt p� dagen
        //Summerade tullavgifter per dag kan maximalt bli 60kr per fordon
        //Ett fordon betalar endast en tullavgift (den h�gsta) per timme
        //Vissa fordonstyper �r befriade ifr�n tullavgifter
        //Helger, helgdagar samt hela juli �r tullfria

        [Test]
        public void IsTollFreeVehicle()
        {
            var mb = new Motorbike();

            Assert.IsTrue(mb.IsTollFreeVehicle());
        }

    }
}