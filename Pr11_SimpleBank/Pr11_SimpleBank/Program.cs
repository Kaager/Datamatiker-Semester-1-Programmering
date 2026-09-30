namespace Pr11_SimpleBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba_1 = new(100);
            BankAccount ba_2 = new("LarsAllan", 300000);
            BankAccount ba_3 = new("Larsine", 9001, true);

            ba_2.Withdraw(50000);
            ba_3.Deposit(1000);
            ba_1.Withdraw(200);

            Console.WriteLine(ba_1.ToString());
            Console.WriteLine(ba_2.ToString());
            Console.WriteLine(ba_3.ToString());

        }
    }
}
