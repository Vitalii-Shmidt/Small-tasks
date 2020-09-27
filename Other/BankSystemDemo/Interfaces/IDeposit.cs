using System;

namespace BankAccountTask.Interfaces
{
    public interface IDeposit
    {  
         public decimal Money { get; set; }
         public DateTime Created { get; set; }
         public string Type { get; }
         public IDeposit CreateDeposit(DateTime created, decimal money);
         public void IncreaseDepositRate();
    }
}