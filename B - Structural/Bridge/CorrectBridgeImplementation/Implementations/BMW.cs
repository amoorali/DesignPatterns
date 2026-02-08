namespace CorrectBridgeImplementation.Classes
{
    public class BMW : Make
    {
        public override void PerformRitual()
        {
            Console.WriteLine("Hit the car.");
        }

        public override void StartCar()
        {
            Console.WriteLine(
                "Fix the wiring.\n" +
                "Lube the engine.\n" +
                "Put the key in.\n" +
                "Turn the key.");
        }
    }
}
