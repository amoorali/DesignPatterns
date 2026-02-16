using StateImplementation.Classes.Contracts;

namespace StateImplementation
{
    public class BankAccount
    {
        public BankAccountState State { get; set; }
        public decimal Balance { get => State.Balance; }

        public void Deposit(decimal amount)
        {
            State.Deposit(amount);
        }

        public void Withdraw(decimal amount)
        {
            State.Withdraw(amount);
        }
    }
}
