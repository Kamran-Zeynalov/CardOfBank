namespace CardOfBanks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UniBank kapitalBank = new()
            {
                Name = "Kamran",
                Surname = "Zeynalov",
                CardCode = "123456789999",
                CVV = 123,
                Balance = 200
            };
            //var kIncrease = kapitalBank.Income(100, 0);
            //Console.WriteLine(kIncrease);

            //var kDecrease = kapitalBank.Expense(100, 1.5);
            //Console.WriteLine(kDecrease);

            AccessBank access = new()
            {
                Name = "Kamran",
                Surname = "Zeynalov",
                CardCode = "123456789999",
                CVV = 123,
                Balance = 200
            };
            //var aIncrease = access.Income(100, 0.3);
            //Console.WriteLine(aIncrease);

            //var aDecrease = access.Expense(100, 1.6);
            //Console.WriteLine(aDecrease);

            PashaBank pasha = new()
            {
                Name = "Kamran",
                Surname = "Zeynalov",
                CardCode = "123456789999",
                CVV = 123,
                Balance = 200
            };
            //var pIncrease = pasha.Income(100, 0.6);
            //Console.WriteLine(pIncrease);

            //var pDecrease = pasha.Expense(100, 1.1);
            //Console.WriteLine(pDecrease);

            LeoBank leo = new()
            {
                Name = "Kamran",
                Surname = "Zeynalov",
                CardCode = "123456789999",
                CVV = 123,
                Balance = 200
            };
            //var lIncrease = leo.Income(100, 0);
            //Console.WriteLine(lIncrease);

            //var lDecrease = leo.Expense(100, 0);
            //Console.WriteLine(lDecrease);

        }
    }
}