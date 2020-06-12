using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            // create tuples (number, emptyBuilder)
            var numberBuilderTuples = Enumerable.Range(1, 100).Select(n => (number: n, builder: new StringBuilder())).ToList();

            // append "Fiku" to each builder where number is divisible by 3
            numberBuilderTuples.Where(t => t.number % 3 == 0).ToList()
                .ForEach(t => t.builder.Append("Fiku"));

            // append "Miku" to each builder where number is divisible by 5
            numberBuilderTuples.Where(t => t.number % 5 == 0).ToList()
                .ForEach(t => t.builder.Append("Miku"));

            // append number to each empty builder
            numberBuilderTuples.Where(t => t.builder.Length == 0).ToList().ForEach(t => t.builder.Append(t.number));

            numberBuilderTuples.ForEach(t => Console.WriteLine(t.builder));

        }
    }
}
