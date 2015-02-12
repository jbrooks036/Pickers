using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pickers.Model;

namespace PickersTest
{
    [TestClass]
    public class TuneModelTest
    {
/*
        [TestMethod]
        public void CreatingATuneStoresItInTunes()
        {
            Tune LittleMaggie = new Tune("LittleMaggie");
            CollectionAssert.Contains(Tune.Tunes, LittleMaggie);
        }
*/

        [TestMethod]
        public void CreatingATuneStoresItsProperties()
        {
            Tune LittleMaggie = new Tune("LittleMaggie");
            Assert.AreEqual("Little Maggie", LittleMaggie.Name);
        }

    }
}
