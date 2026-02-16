using StateImplementation.Classes.Contracts;

namespace StateImplementation.Classes.Implementations
{
    public class RegularState : BankAccountState
    {
        public RegularState(BankAccount bankAccount, decimal balance)
        {
            BankAccount = bankAccount;
            Balance = balance;
        }

        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, depositing {amount}");
            Balance += amount;

            if (Balance >= 1000)
                BankAccount.State = new GoldState(BankAccount, Balance);
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, withdrawing {amount} from {Balance}");
            Balance -= amount;

            if (Balance < 0)
                BankAccount.State = new OverDrawnState(BankAccount, Balance);
        }
    }
}
