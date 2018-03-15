using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            TextField txt = new TextField(20,20);
            BorderDecorator bord = new BorderDecorator(txt);
            ScrollDecorator scroll = new ScrollDecorator(bord);
            scroll.Draw();
            Console.ReadKey();
        }
    }
}
