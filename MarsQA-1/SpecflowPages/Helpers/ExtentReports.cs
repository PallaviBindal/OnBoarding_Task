using System;

namespace MarsQA_1.Helpers
{
    public class ExtentReports
    {
        private object reportsPath;
        private bool v;
        private object newestFirst;

        public ExtentReports(string reportsPath, bool v)
        {
            this.reportsPath = reportsPath;
            this.v = v;
        }

        public ExtentReports(object reportsPath, bool v, object newestFirst)
        {
            this.reportsPath = reportsPath;
            this.v = v;
            this.newestFirst = newestFirst;
        }

        public ExtentReports()
        {
        }

        internal void LoadConfig(string reportXMLPath)
        {
            throw new NotImplementedException();
        }

        internal void EndTest(ExtentTest test)
        {
            throw new NotImplementedException();
        }

        internal void Flush()
        {
            throw new NotImplementedException();
        }

        internal void AttachReporter(ExtentHtmlReporter htmlReporter)
        {
            throw new NotImplementedException();
        }

        internal void AddSystemInfo(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        internal ExtentTest createTest(string v)
        {
            throw new NotImplementedException();
        }
    }
}