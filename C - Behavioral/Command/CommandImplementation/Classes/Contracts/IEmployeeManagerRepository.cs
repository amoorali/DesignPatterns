using CommandImplementation.Classes.Implementations;

namespace CommandImplementation.Classes.Contracts
{
    public interface IEmployeeManagerRepository
    {
        void AddEmployee(int managerId, Employee employee);
        void RemoveEmployee(int managerId, Employee employee);
        bool HasEmployee(int managerId, int employeeId);

    }
}
