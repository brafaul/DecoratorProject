using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProject
{
    abstract class Decorator : IWidget
    {
        IWidget wid;
        public Decorator(IWidget w)
        {
            wid = w;
        }
        public void Draw()
        {
            wid.Draw();
            Console.WriteLine("It is being decorated");
           
        }

    }
}
