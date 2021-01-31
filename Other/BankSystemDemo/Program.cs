using System;

namespace BankAccountTask
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // Будь-якi збiги з реальними особами випадковi 
            var petya = new BankAccount("Petro Oleksiyovich Poroshenko", "12345678", 1488);
            petya.CreateDeposit("SavingDeposit", 228);
            petya.CreateDeposit("FixedDeposit", 322);
            petya.CreateDeposit("SavingDeposit", 282);

            Console.WriteLine("Информация об аккаунте");
            Console.WriteLine(petya);
            
            Console.WriteLine("Начальные депозиты:");
            foreach (var deposit in petya.Deposits)
            {
                Console.WriteLine($"{deposit.Type} | {deposit.Money}");
            }

            Console.WriteLine("Насчитали проценты за первый");
            petya.IncreaseDepositRate(0);
            foreach (var deposit in petya.Deposits)
            {
                Console.WriteLine($"{deposit.Type} | {deposit.Money}");
            }

            Console.WriteLine("Удалили последний");
            petya.RemoveDeposit(2);
            foreach (var deposit in petya.Deposits)
            {
                Console.WriteLine($"{deposit.Type} | {deposit.Money}");
            }

            Console.WriteLine("Общее к-во денег на счете");
            Console.WriteLine(petya.GetTotalMoney());

            Console.WriteLine("Сняли со счета 40 гривень на штаны");
            petya.TakeMoneyFromBalance(40);

            Console.WriteLine("Снова проверяем к-во денег на счете");
            Console.WriteLine(petya.GetTotalMoney());

            Console.WriteLine("Положили на счет тысячу");
            petya.PutMoneyToBalance(1000);

            Console.WriteLine("Снова проверяем к-во денег на счете");
            Console.WriteLine(petya.GetTotalMoney());
        }
    }
}
