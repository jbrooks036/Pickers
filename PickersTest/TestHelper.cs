using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
// using Pickers.Model;
using TestStack.White.UIItems.WindowItems;
using TestStack.White;
using System.IO;
using System.Reflection;
using TestStack.White.Factory;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.Finders;
// using Pickers.Repository;
using Pickers;
// using System.Windows.Automation;
using TestStack.White.UIItems;

namespace PickersTest
{
    class TestHelper
    {
        private static TestContext test_context;
        protected static Window window;
        private static Application application;
        // private static TuneRepository repo = new TuneRepository();
        // private static TuneContext context;

        public static void Setup(TestContext _context)
        {
            test_context = _context;

            var applicationDir = _context.DeploymentDirectory;
            var applicationPath = Path.Combine(applicationDir, "..\\..\\..\\TestPickers\\bin\\Debug\\Pickers");

            application = Application.Launch(applicationPath);

            window = application.GetWindow("MainWindow", InitializeOption.NoCache);
         //    context = repo.Context();
        }



        public static void CleanThisUp()
        {
            window.Close();
            application.Close();
         //   repo.Clear();
        }
    }
}
