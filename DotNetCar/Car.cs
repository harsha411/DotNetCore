using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCar
{
    //First implementation
    //class Car
    //{
    //    string make = "Lamborghini";
    //    string model = "Diablo";

    //    int topSpeed = 100;

    //    DateTime dateCreated = DateTime.Now;

    //    public string GetMake()
    //    {
    //        return $"{make} - {model}";
    //    }

    //    public int GetTopSpeed()
    //    {
    //        return topSpeed;
    //    }

    //    public void AdjustTopSpeed(int newTopSpeed)
    //    {
    //        topSpeed = newTopSpeed;
    //    }
    //}

    //Second implementation
    public class Car
    {
        private string make = "Lamborgini";
        private string model = "Diablo";
        private int topSpeed = 100;
        private DateTime dateCreated = DateTime.Now;

        public virtual string Model
        {
            get
            {
                return model;
            }

            set
            {
                model = value;
            }
        }

        public string GetMake()
        {
            return make;
        }

        public int GetTopSpeed()
        {
            return topSpeed;
        }

        public void AdjustTopSpeed(int newTopSpeed)
        {
            topSpeed = newTopSpeed;
        }
    }
}
