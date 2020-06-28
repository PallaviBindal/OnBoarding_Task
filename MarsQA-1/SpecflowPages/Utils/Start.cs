using MarsQA_1.Helpers;
using MarsQA_1.Pages;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.CommonMethods;

namespace MarsQA_1.Utils
{
    [Binding]
    public class Start : Driver
    {

        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();
          //ExcelLibHelper.PopulateInCollection(@"C:\repo\onboarding.specflow\MarsQA-1\SpecflowTests\Data\Data.xlsx", "Credentials");
          //ExcelLibHelper.PopulateInCollection(@"C:\repo\onboarding.specflow\MarsQA-1\SpecflowTests\Data\Data.xlsx", "FieldValues");

            //call the SignIn class
            // SignIn.SigninStep()
        }
        

        [AfterScenario]
        public void TearDown()
        {

            // Screenshot
            string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            //
            //Close the browser
            Close();

            // end test. (Reports)
            //CommonMethods.Extent.EndTest(test);

            // calling Flush writes everything to the log file (Reports)
           // CommonMethods.Extent.Flush();


        }
    }
}






