using ObserverImplementation.Classes.Contracts;

namespace ObserverImplementation.Classes.Implementations
{
    public class TicketResellerService : ITicketChangeListener
    {
        public void ReceiveTicketChangeNotification(TicketChange ticketChange)
        {
            Console.WriteLine($"{nameof(TicketResellerService)} notified " +
                $"of ticket change: artist {ticketChange.ArtistId}, amount {ticketChange.Amount}");
        }
    }
}
