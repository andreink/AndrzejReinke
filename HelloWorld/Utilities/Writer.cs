using HelloWorld.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.Utilities
{
    public class Writer : IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }
    }
}