using System;
using System.IO;
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
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\WPFSimpleTest\\bin\\Debug\\WPFSimple");
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
        }
        [TestMethod]
        public void TestZeroState()
        {
            TextBox search_artist_box = window.Get<TextBox>("SearchArtistBox");
            TextBox search_tune_box = window.Get<TextBox>("SearchTuneBox");
            TextBox search_notes_box = window.Get<TextBox>("SearchNotesBox");
            Button all_button = window.Get<Button>("AllButton");
            Button search_button = window.Get<Button>("SearchButton");

            Assert.AreEqual(search_artist_box.Text, "");
            Assert.AreEqual(search_tune_box.Text, "");
            Assert.AreEqual(search_notes_box.Text, "");
            Assert.IsFalse(search_artist_box.IsReadOnly);
            Assert.IsFalse(search_tune_box.IsReadOnly);
            Assert.IsFalse(search_notes_box.IsReadOnly);
            Assert.IsFalse(all_button.Enabled);
            Assert.IsFalse(search_button.Enabled);

        }

        [ClassCleanup]
        public static void TearDown()
        {
            window.Close();
            application.Close();
        }
    }
}
