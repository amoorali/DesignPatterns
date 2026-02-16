namespace ObserverImplementation.Classes.Implementations
{
    public class OrderService : TicketChangeModifier
    {
        public void CompleteTicketSale(int artistId, int amount)
        {
            Console.WriteLine($"{nameof(OrderService)} is changing its state...");

            Console.WriteLine($"{nameof(OrderService)} is notifying observers...");
            Notify(new TicketChange(artistId, amount));
        }
    }
}
