namespace CorrectBridgeImplementation.Classes
{
    public class Truck : Vehicle
    {
        public override bool AllowedToDrive(string person)
        {
            return person == "has special truck license";
        }
    }
}
