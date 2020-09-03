using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Desk :Item
    {
        //private int Height { get; set; } -> jest dziedziczony z Item - > Lapm rozszerza Item
        private int Width { get; set; }
        

        public Desk(int height, int width)
        {
            Height = height;
            Width = width;

        }
    }
}
