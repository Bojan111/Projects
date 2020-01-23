using System;
using System.Collections.Generic;
using System.Text;

namespace BoxesProject
{
	class Box
	{
        private double Lenght;
        private double Width;
        private double Height;
        public double Volume;

        public Box()
        {

        }
        public void AddBox(double lenght, double width, double height)
        {
            Lenght = lenght;
            Width = width;
            Height = height;
            Volume = lenght * width * height;

        }
        public string CalculateVolume()
        {
            return Volume.ToString();
        }

        public string BiggestBox()
        {
            return $"The Biggest box is: Lenght {Lenght} Width {Width} Height {Height}";
        }
    }
}
