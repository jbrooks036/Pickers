using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.WindowItems;
using Pickers;
using Pickers.Model;
using Pickers.Repository;
// using System.Windows.Automation;

namespace TestPickers
{
    public class TestHelper
    {
        private static TestContext test_context;
        protected static Window window;
        protected static Application application;
        private static TuneRepository repo = new TuneRepository();
        private static TuneContext context;
        private static String applicationPath;

        public static void SetupClass(TestContext _context)
        {
            var applicationDir = _context.DeploymentDirectory;
            applicationPath = Path.Combine(applicationDir, "..\\..\\..\\PickersTest\\bin\\Debug\\Pickers");
        }

        public static void TestPrep()
        {
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
            context = repo.Context();
        }

        public void AndIShouldSeeAnErrorMiessage(string p)
        {
            throw new NotImplementedException();
        }

        public void WhenIFillInTuneNameWith(string value)
        {
            var textBox = window.Get<TextBox>("TuneNameBox");
            textBox.SetValue(value);
        }

        public void AndIClick(string buttonContent)
        {
            WhenIClick(buttonContent);
        }

        public void WhenIClick(string buttonContent)
        {
            Button button = window.Get<Button>(SearchCriteria.ByText(buttonContent));
            button.Click();
        }

        public void ThenIShouldSeeNumberTunes(int num)
        {
            Assert.IsNotNull(window);
            SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("TunesGrid").AndIndex(0);
            ListBox tunes_grid = window.Get<ListBox>(searchCriteria);
            Assert.AreEqual(num, tunes_grid.Items.Count);
        }

        public static void CleanThisUp()
        {
            window.Close();
            application.Close();
            repo.Clear();
        }

    }
}
