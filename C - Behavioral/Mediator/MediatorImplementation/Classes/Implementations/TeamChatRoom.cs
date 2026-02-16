using MediatorImplementation.Classes.Contracts;

namespace MediatorImplementation.Classes.Implementations
{
    public class TeamChatRoom : IChatRoom
    {
        private readonly Dictionary<string, TeamMember> _teamMembers = new();

        public void Register(TeamMember teamMember)
        {
            teamMember.SetChatRoom(this);

            if (!_teamMembers.ContainsKey(teamMember.Name))
                _teamMembers.Add(teamMember.Name, teamMember);
        }

        public void Send(string from, string message)
        {
            foreach (var teamMember in _teamMembers.Values)
                teamMember.Receive(from, message);
        }

        public void Send(string from, string to, string message)
        {
            var teamMember = _teamMembers[to];

            teamMember?.Receive(from, message);
        }
    }
}
