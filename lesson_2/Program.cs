namespace lesson_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            Console.WriteLine("Введите тип банковского счёта: ");
            bank.TypeAccount = Console.ReadLine();
            
            Bank bank1 = new Bank(1);

            Console.WriteLine("Номер счёта " + bank.AccountNumber +
                    ", тип банковского счёта: " + bank.TypeAccount +
                    ", баланс: " + bank1.Balance + ".");
            Console.ReadKey();
        }
    }

    public class Bank
    {
        public int AccountNumber { get; set; }
        public int Balance { get; set; }
        public string TypeAccount { get; set; }


        public Bank()
        {
            Console.WriteLine("Номер счета: ");
            Random rnd = new Random();
            AccountNumber = rnd.Next(1000000000, int.MaxValue);
            Console.WriteLine(AccountNumber);
        }
        public Bank(int balance)
        {
            Console.WriteLine("Введите количество денег на счету: ");
            Balance = int.Parse(Console.ReadLine());
        }
        public Bank(string typeaccount)
        {

        }
    }
}