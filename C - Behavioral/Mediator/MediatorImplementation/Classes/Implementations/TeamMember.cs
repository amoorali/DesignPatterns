using MediatorImplementation.Classes.Contracts;

namespace MediatorImplementation.Classes.Implementations
{
    public abstract class TeamMember
    {
        private IChatRoom _chatRoom;
        public string Name { get; set; }

        public TeamMember(string name)
        {
            Name = name;
        }

        public void SetChatRoom(IChatRoom chatRoom)
        {
            _chatRoom = chatRoom;
        }

        public void Send(string message)
        {
            _chatRoom.Send(Name, message);
        }

        public virtual void Receive(string from, string message)
        {
            Console.WriteLine($"Message {from} to {Name}: {message}");
        }
    }
}
