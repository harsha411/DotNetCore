namespace DotNetCar
{
    public class FamilyCar : Car, ICar
    {
        private int horsePower;

        public override string Model
        {
            get
            {
                base.Model = "Urus";
                return base.Model;
            }

            set
            {
                base.Model = value;
            }
        }

        public bool TintedWindows = false;

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