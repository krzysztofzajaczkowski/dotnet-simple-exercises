namespace DocumentFactory
{
    public abstract class DocumentFactory
    {
        public abstract IDocument CreateDocument();

        protected Page CreatePage(string title, int pageNumber)
        {
            var page = new Page
            {
                Name = title,
                Number = pageNumber
            };
            return page;
        }

    }
}