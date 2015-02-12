using System;
using System.IO;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;

namespace PickersTest
{ 
    [TestClass]
    public class PickersUITests
    {
        private static TestContext test_context;
        private static Window window;
        private static Application application;

        [ClassInitialize]
        public static void Setup(TestContext _context)
        {
            test_context = _context;
            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\PickersTest\\bin\\Debug\\Pickers");
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
        }
        [TestMethod]
        public void TestZeroState()
        {
            TextBox search_artist_text_box = window.Get<TextBox>("SearchArtistTextBox");
            TextBox search_tune_text_box = window.Get<TextBox>("SearchTuneTextBox");
            Button search_button = window.Get<Button>("SearchButton");
            // TextBox search_notes_text_box = window.Get<TextBox>("SearchNotesTextBox");

            Assert.IsFalse(search_artist_text_box.IsReadOnly);
            Assert.AreEqual(search_artist_text_box.Text, "SearchOnArtist");
            Assert.IsFalse(search_tune_text_box.IsReadOnly);
            Assert.AreEqual(search_tune_text_box.Text, "SearchOnTune");
            Assert.IsFalse(search_button.Enabled);
            // Assert.AreEqual(search_notes_text_box.Text, "Search Notes");
            // Assert.IsFalse(search_notes_text_box.IsReadOnly);
            System.Threading.Thread.Sleep(1000);
        }

        [TestMethod]
        public void TestZeroStateAddButton()
        {
            Button button = window.Get<Button>("AddButton");
            Assert.AreEqual("Add", button.Text);
            System.Threading.Thread.Sleep(1000);
        }


        [ClassCleanup]
        public static void TearDown()
        {
            window.Close();
            application.Close();
        }
    }
}
