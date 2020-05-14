using System;

namespace bai2
{
    class window
    {
        public window (int top, int left)
        {
            this.top = top;
            this.left = left;
        }
        // simulates drawing the window
        public virtual void DrawWindow()
        {
            Console.WriteLine("Window: drawing Window at {0}, {1}",top, left);
        }
        // these members are protected and thus visible
        // to derived class methods. We'll examine this
        // later in the chapter
        protected int top;
        protected int left;
    }
}
