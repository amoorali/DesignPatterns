using StateImplementation.Classes.Contracts;

namespace StateImplementation.Classes.Implementations
{
    public class OverDrawnState : BankAccountState
    {
        public OverDrawnState(BankAccount bankAccount, decimal balance)
        {
            BankAccount = bankAccount;
            Balance = balance;
        }

        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, depositing {amount}");
            Balance += amount;

            if (Balance >= 0)
                BankAccount.State = new RegularState(BankAccount, Balance);
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, cannot withdraw, balance {Balance}");
        }
    }
}
