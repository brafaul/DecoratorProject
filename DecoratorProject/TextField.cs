using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorProject
{
    class TextField : IWidget
    {
        int Width;
        int Height;
        public TextField(int W, int H)
        {
            Width = W;
            Height = H;
        }
        public void Draw()
        {
            Console.WriteLine("Textfield with height " + Height + " and width " + Width);
        }

    }
}
