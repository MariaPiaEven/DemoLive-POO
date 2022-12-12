using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLive_POO
{
    internal class Lego
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public Lego(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public void WriteSomething(string toWrite)
        {
            Console.WriteLine("Test : {0}",toWrite);

        }
    }
}
