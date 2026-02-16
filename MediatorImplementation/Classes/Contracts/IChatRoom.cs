
using MediatorImplementation.Classes.Implementations;

namespace MediatorImplementation.Classes.Contracts
{
    public interface IChatRoom
    {
        void Register(TeamMember teamMember);
        void Send(string from, string mesage);
    }
}
