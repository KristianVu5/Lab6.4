using System;
using System.Collections.Generic;
using System.Text;

namespace Lab6._4
{
    internal class Class1
    {
        static void Main(string[] args)
        {
            Box box = new Box(10.5f, 5.2f);
            Idimensions dimensions = box; //interface variable

            //interface variable
            Console.WriteLine("Length: {0} inches", dimensions.Length());
            Console.WriteLine("Width: {0} inches", dimensions.Width());


            //Class instance
            Console.WriteLine("Length: {0} inches", box.Length());
            Console.WriteLine("Width: {0} inches", box.Width());
        }
    }
}
