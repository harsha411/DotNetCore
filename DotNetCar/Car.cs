using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetCar
{
    class Car
    {
        string make = "Lamborghini";
        string model = "Diablo";

        int topSpeed = 100;

        DateTime dateCreated = DateTime.Now;

        public string GetMake()
        {
            return $"{make} - {model}";
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
