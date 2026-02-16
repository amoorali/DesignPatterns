using ObserverImplementation.Classes.Implementations;

namespace ObserverImplementation.Classes.Contracts
{
    public interface ITicketChangeListener
    {
        void ReceiveTicketChangeNotification(TicketChange ticketChange);
    }
}
