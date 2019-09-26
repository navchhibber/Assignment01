using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment01
{
    public class Nav
    {
        private int length;
        private int width;


        public Nav()
        {
            length = 1;
            width = 1;
        }

        public Nav(int length, int width)
        {
            this.length = length;
            this.width = width;
        }

        public int Getlength()
        {
            return length;
        }


        public int SetLength(int length)
        {
            this.length = length;
            return this.length;
        }


        public int GetWidth()
        {
            return width;
        }

        public int SetWidth(int width)
        {
            this.width = width;
            return this.width;
        }

        public int GetPerimeter()
        {
            return (width * 2) + (length * 2);
        }


        public int GetArea()
        {
            return length * width;
        }


    }


}
