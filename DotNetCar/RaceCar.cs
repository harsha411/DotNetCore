using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCar
{
    public class RaceCar : Car, ICar
    {
        private int horsePower;

        public override string Model
        {
            get
            {
                return base.Model + " GTR";
            }

            set
            {
                base.Model = value;
            }
        }

        public bool TintedWindows = true;

        public int HorsePower
        {
            get
            {
                return horsePower;
            }

            set
            {
                horsePower = value;
            }
        }
    }
}
