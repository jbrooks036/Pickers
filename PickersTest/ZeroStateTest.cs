using System;
using System.IO;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.Finders;

namespace TestPickers
{ 
    [TestClass]
    public class ZeroStateTest : TestHelper
    {
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
        public void TestZeroStateSearch()
        {
            TextBox search_artist_text_box = window.Get<TextBox>("SearchArtistBox");
            TextBox search_tune_text_box = window.Get<TextBox>("SearchTuneBox");
            Button search_button = window.Get<Button>("SearchButton");
            // TextBox search_notes_text_box = window.Get<TextBox>("SearchNotesTextBox");

            Assert.IsFalse(search_artist_text_box.IsReadOnly);
            Assert.AreEqual(search_artist_text_box.Text, "SearchOnArtist");
            Assert.IsFalse(search_tune_text_box.IsReadOnly);
            Assert.AreEqual(search_tune_text_box.Text, "SearchOnTune");
            Assert.IsFalse(search_button.Enabled);
            // Assert.AreEqual(search_notes_text_box.Text, "Search Notes");
            // Assert.IsFalse(search_notes_text_box.IsReadOnly);
            System.Threading.Thread.Sleep(500);
        }

        [TestMethod]
        public void TestZeroStateAddButton()
        {
            Button button = window.Get<Button>("AddButton");
            Assert.AreEqual("Add", button.Text);
            System.Threading.Thread.Sleep(500);
        }


        [ClassCleanup]
        public static void TearDown()
        {
            window.Close();
            application.Close();
        }
    }
}
