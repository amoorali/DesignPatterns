using StateImplementation.Classes.Contracts;

namespace StateImplementation.Classes.Implementations
{
    public class GoldState : BankAccountState
    {
        public GoldState(BankAccount bankAccount, decimal balance)
        {
            BankAccount = bankAccount;
            Balance = balance;
        }

        public override void Deposit(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, depositing {amount} " +
                $"+ 10% bonus: {amount / 10}");

            Balance += amount + (amount / 10);
        }

        public override void Withdraw(decimal amount)
        {
            Console.WriteLine($"In {GetType()}, withdrawing {amount} from {Balance}");
            Balance -= amount;

            if (Balance < 1000 && Balance >= 0)
                BankAccount.State = new RegularState(BankAccount, Balance);
            else if (Balance < 0)
                BankAccount.State = new OverDrawnState(BankAccount, Balance);
        }
    }
}
