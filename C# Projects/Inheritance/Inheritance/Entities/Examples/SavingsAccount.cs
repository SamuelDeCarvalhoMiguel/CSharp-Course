namespace Inheritance.Entities.Examples
{
    internal class SavingsAccount : Account
    {

        public double InterestRate { get; set; }

        public SavingsAccount() { }

        public SavingsAccount(int number, string holder, double balance, double InteresRate)
            : base(number, holder, balance)
        {
            InterestRate = InteresRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }
    }
}
