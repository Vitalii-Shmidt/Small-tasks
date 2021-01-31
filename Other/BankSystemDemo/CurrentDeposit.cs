using System;
using BankAccountTask.Interfaces;

namespace BankAccountTask
{
    public class CurrentDeposit : IDeposit
    {        
        public CurrentDeposit(DateTime created, decimal money) => (Created, Money) = (created, money);
        public CurrentDeposit() : this(DateTime.Now, 0) { }
        private decimal _money;
        public decimal Money
        {
            get => _money;
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(Money), "Депозит не может быть меньше нуля!");
                    }

                    _money = value;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    Helpers.Helper.ValidateBankAccountBalance(ref value);
                }
            }
        }

        public DateTime Created { get; set; }
        private static string _type = "CurrentDeposit";
        public string Type => _type;
        public static string GetDepositType()
        {
            return "CurrentDeposit";
        }

        public IDeposit CreateDeposit(DateTime created, decimal money)
        {
            return new CurrentDeposit(created, money);
        }

        public void IncreaseDepositRate()
        {
            Money += Money * (decimal)0.3;
        }
    }
}