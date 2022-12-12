using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLive_POO
{
    public class Orange : Fruit
    {
        public Orange(string color)
        {
            Color = color;
        }
        public override void Eat()
        {
            Console.WriteLine("Orange is eaten");
        }
    }

}
