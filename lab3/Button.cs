using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    class Button : window
    {
        public Button(int top, int left) : base(top, left)
        {
        }
        // an overridden version (note keyword) because in the
        // derived method we change the behavior
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0}, {1}\n", top, left);
        }
    }
}
