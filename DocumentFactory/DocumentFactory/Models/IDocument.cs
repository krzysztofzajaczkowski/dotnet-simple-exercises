using System;
using System.Collections.Generic;

namespace DocumentFactory
{
    public interface IDocument
    {
        public string Title { get; set; }
        List<Page> Pages { get; set; }

        // C# 8.0 interface method implementation, for shared action of each document
        public void Print()
        {
            Console.WriteLine($"Document title: {Title}");
            Pages.ForEach(Console.WriteLine);
        }
    }
}