using System.Collections.Generic;

namespace DocumentFactory
{
    public class CurriculumVitaeFactory : DocumentFactory
    {
        public override IDocument CreateDocument()
        {
            var pageNumber = 1;
            var cv = new CurriculumVitae
            {
                Title = "Curriculum Vitae",
                Pages = new List<Page>
                {
                    CreatePage("Introduction", pageNumber++),
                    CreatePage("Skills", pageNumber++),
                    CreatePage("Experience", pageNumber++),
                    CreatePage("Education", pageNumber++),
                    CreatePage("Personal data", pageNumber),
                }
            };

            return cv;
        }
    }
}