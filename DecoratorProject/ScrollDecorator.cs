using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProject
{
    class ScrollDecorator : Decorator
    {
        IWidget wid;
        public ScrollDecorator(IWidget w) : base(w)
        {
            wid = w;
        }
        public void Draw()
        {
            wid.Draw();
            Console.WriteLine("And has a scroll bar");
        }
    }
}
