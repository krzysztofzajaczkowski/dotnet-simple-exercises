using System.Collections.Generic;

namespace DocumentFactory
{
    public class Application : IDocument
    {
        public string Title { get; set; }
        public List<Page> Pages { get; set; }
    }
}