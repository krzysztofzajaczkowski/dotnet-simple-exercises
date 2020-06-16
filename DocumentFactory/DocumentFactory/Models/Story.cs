using System.Collections.Generic;

namespace DocumentFactory
{
    public class Story : IDocument
    {
        public string Title { get; set; }
        public List<Page> Pages { get; set; }
    }
}