using System;

namespace MarsQA_1
{
    public class ExtentHtmlReporter
    {
        private string reportpath;

        public ExtentHtmlReporter(string reportpath)
        {
            this.reportpath = reportpath;
        }

        internal object Configuration()
        {
            throw new NotImplementedException();
        }

        internal void LoadConfig(string v)
        {
            throw new NotImplementedException();
        }
    }
}