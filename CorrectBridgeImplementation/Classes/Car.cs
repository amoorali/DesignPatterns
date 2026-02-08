namespace CorrectBridgeImplementation.Classes
{
    public class Car : Vehicle
    {
        public override bool AllowedToDrive(string person)
        {
            return person == "has license";
        }
    }
}
