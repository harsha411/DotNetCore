namespace DotNetCar
{
    public interface ICar
    {
        string Model { get; set; }
        int HorsePower { get; set; }
        string GetMake();
        int GetTopSpeed();
        void AdjustTopSpeed(int newTopSpeed);
    }
}