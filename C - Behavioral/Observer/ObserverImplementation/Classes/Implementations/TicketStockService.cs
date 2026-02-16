using ObserverImplementation.Classes.Contracts;

namespace ObserverImplementation.Classes.Implementations
{
    public class TicketStockService : ITicketChangeListener
    {
        public void ReceiveTicketChangeNotification(TicketChange ticketChange)
        {
            Console.WriteLine($"{nameof(TicketStockService)} notified " +
                $"of ticket change: artist {ticketChange.ArtistId}, amount {ticketChange.Amount}");
        }
    }
}
