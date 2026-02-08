namespace CorrectBridgeImplementation
{
    public abstract class Vehicle
    {
        private Make make;

        public void Start()
        {
            make.PerformRitual();
            make.StartCar();
        }

        public abstract bool AllowedToDrive(string person);
    }
}
