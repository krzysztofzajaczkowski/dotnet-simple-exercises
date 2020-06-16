using System.Collections.Generic;

namespace DocumentFactory
{
    public class ReportFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            var pageNumber = 1;
            var report = new Report()
            {
                Title = "Report",
                Pages = new List<Page>
                {
                    CreatePage("Introduction", pageNumber++),
                    CreatePage("Development", pageNumber++),
                    CreatePage("Conclusion", pageNumber),
                }
            };

            return report;
        }
    }
}