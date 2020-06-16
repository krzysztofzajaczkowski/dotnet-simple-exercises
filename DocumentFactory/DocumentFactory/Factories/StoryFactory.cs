using System.Collections.Generic;

namespace DocumentFactory
{
    public class StoryFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            var pageNumber = 1;
            var application = new Story()
            {
                Title = "Story",
                Pages = new List<Page>
                {
                    CreatePage("Introduction", pageNumber++),
                    CreatePage("Development", pageNumber++),
                    CreatePage("Ending", pageNumber),
                }
            };

            return application;
        }
    }
}