using System;

namespace Delegate
{
    public delegate void AreaDelegate(double x, double y);
    class Rectangle
    {
        public void GetArea(double width, double height)
        {
            Console.WriteLine("Area of rectangle" + width * height);
        }
        static void Main(string[] args)
        {
            Rectangle p = new Rectangle();
            AreaDelegate obj = delegate (double width, double height)
            {
                Console.WriteLine("Area of rectangle " + width * height);
            };
            obj.Invoke(12, 43);
        }
    }
}
