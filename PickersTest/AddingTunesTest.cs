using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Pickers.Model;

namespace PickersTest
{
    [TestClass]
    public class AddingTunesTest : TestHelper
    {
        // As a user
        // In order to add a bluegrass tune to my collection
        // I want to create a new tune and add it to the DB
        // so that it shows in the list
        // * Select TuneNameBox to begin entering
        // * Tune name must contain at least one character
        // * Click "Add" to add the tune
        // * The tune shows up in the tunes list grid and the Add button is disabled

        [ClassInitialize]
        public static void SetupTests(TestContext _context)
        {
            TestHelper.SetupClass(_context);
        }

        [TestInitialize]
        public void SetupTests()
        {
            TestHelper.TestPrep();
        }

        [TestCleanup]
        public void CleanUp()
        {
            TestHelper.CleanThisUp();
        }


        [TestMethod]
        public void ScenarioHappyPathTuneCreation()
        {
            WhenIFillInTuneNameWith("Little Maggie");
            AndIClick("Add");
            ThenIShouldSeeNTunes(1);
        }
    }
}
