using System;
using System.Linq;

namespace BankAccountTask.Helpers
{
    public static class Helper
    {
        /// <summary>
        /// Checks is source string has only letters without any other tokens.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static bool ContainsOnlyLetters(string source)
        {
            return source.Length == source.Count(ch => char.IsLetter(ch) || ch == ' ');
        }

        /// <summary>
        /// Validates the source string, removing all numers and non-letter tokens.
        /// </summary>
        /// <param name="source"></param>
        /// <returns></returns>
        public static void ValidateOwnerName(ref string source)
        {
            do
            {
                Console.Write("Введите полное ФИО владельца счета!\nФИО: ");
                source = Console.ReadLine();
                    
            } while (!Helper.ContainsOnlyLetters(source));
        }

        public static void ValidateBankAccountNumber(ref string source)
        {
            do
            {
                Console.Write("Введите номер банковского счета!\nНомер: ");
                source = Console.ReadLine();
            } while (!ContainsOnlyDigits(source));
        }

        public static bool ContainsOnlyDigits(string source)
        {
            return source.Length == 8 && (source.Length == source.Count(char.IsDigit));
        }


        public static void ValidateBankAccountBalance(ref decimal balance)
        {
            do
            {
                balance = Convert.ToDecimal(Console.ReadLine());
            } while (balance < 0);
        }

        public static void ValidateDepositType(ref string depositType)
        {
            var depositTypes = new string[]
            {
                 SavingDeposit.GetDepositType(),
                 CurrentDeposit.GetDepositType(), 
                 FixedDeposit.GetDepositType(), 
                 RecurringDeposit.GetDepositType(), 
            };

            do
            {
                var iter = 0;
                Console.WriteLine("Возможные типы депозитов:");
                foreach (var dep in depositTypes)
                {
                    Console.WriteLine($"{++iter}.{dep}");
                }
                Console.Write("Введите тип депозита: ");
                depositType = Console.ReadLine();
            } while (!depositTypes.Contains(depositType));
        }
    }
}