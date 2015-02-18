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

namespace PickersTest
{
    public class TestHelper
    {
        private static TestContext test_context;
        protected static Window window;
        private static Application application;
        private static TuneRepository repo = new TuneRepository();
        private static TuneContext context;
        private static String applicationPath;

        public static void SetupClass(TestContext _context)
        {
            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\TestPickers\\bin\\Debug\\Pickers");
        }

        public static void TestPrep()
        {
            application = Application.Launch(applicationPath);
            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
            context = repo.Context();
        }

        public static void CleanThisUp()
        {
            window.Close();
            application.Close();
            repo.Clear();
        }

        public void WhenIFillInTuneNameWith(string value)
        {
            var textBox = window.Get<TextBox>("TuneNameBox");
            textBox.SetValue(value);
        }

        public void ThenIShouldSeeNumberTunes(int num)
        {
            Assert.IsNotNull(window);
            SearchCriteria searchCriteria = SearchCriteria.ByAutomationId("TunesGrid").AndIndex(0);
            DataGrid data_grid = window.Get<DataGrid>(searchCriteria);
            Assert.AreEqual(num, tunes_grid.Items.Count);
        }

    }
}
