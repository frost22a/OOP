using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Lamp:Item
    {
        //public int Height { get; set; }
        // zmiana na private powoduje, że ni możemy zmieniać wprwadzonych przez konstruktor danych
        
        //private int Height { get; set; } -> jest dziedziczony z Item - > Lapm rozszerza Item

        //public int Power { get; set; }
        private int Power { get; set; }
        public void LightItSelf() 
        {
            Console.WriteLine(Height);
            Console.WriteLine(Power);
        }

        public Lamp(int height, int power)
        {
            Height = height;
            Power = power;

        }

    }
}
