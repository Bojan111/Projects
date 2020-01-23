using System;
using System.Collections.Generic;
using System.Text;

namespace BoxesProject
{
	class Boxes
	{
        public Box volumen;
        private List<Box> countlist;

        public Boxes(Box calculate)
        {
            volumen = calculate;
            countlist = new List<Box>();
        }
        public void AddBoxes(Box _boxes)
        {
            countlist.Add(_boxes);
        }
        public List<Box> GetBoxess()
        {
            return countlist;
        }
        public string Print()
        {
            return "The result is " + volumen.CalculateVolume();
        }
        public string Biggest()
        {
            return volumen.BiggestBox();
        }
    }
}
