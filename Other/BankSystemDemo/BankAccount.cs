using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using BankAccountTask.Helpers;
using BankAccountTask.Interfaces;

namespace BankAccountTask
{
    public class BankAccount
    {
        private string _fullName;
        
        public string Owner
        {
            get => _fullName;

            set
            {
                try
                {
                    if (value is null || value == "")
                    {
                        throw new ArgumentNullException(nameof(Owner),
                            "ФИО Владельца счета не было введенно!");
                    }

                    if (Helper.ContainsOnlyLetters(value))
                    {
                        _fullName = value;
                        return;
                    }

                    throw new ArgumentException(nameof(Owner),
                        "Введено некорректное ФИО владельца пользователя!");
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                    Helper.ValidateOwnerName(ref value);
                }    
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Helper.ValidateOwnerName(ref value);
                }

                _fullName = value;
            }
        }

        private string _number;

        public string Number
        {
            get => _number;
            
            set
            {
                try
                {
                    if (value is null || value == "")
                    {
                        throw new ArgumentNullException(nameof(Number),
                            "Номер счета не был проиницилизирован!");
                    }

                    if (Helper.ContainsOnlyDigits(value))
                    {
                        _number = value;
                        return;
                    }

                    throw new ArgumentException(nameof(Number),
                        "Введен некорректный номер банковского счета!");
                }
                catch (ArgumentNullException ex)
                {
                    Console.WriteLine(ex.Message);
                    Helper.ValidateBankAccountNumber(ref value);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    Helper.ValidateBankAccountNumber(ref value);
                }

                _number = value;
            }
        }
        private decimal _balance;
        public decimal Balance
        {
            get => _balance;
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new ArgumentOutOfRangeException(nameof(Balance),
                            "Баланс не может быть отрицательным!");
                    }

                    _balance = value;
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                    Helper.ValidateBankAccountBalance(ref value);
                }
                
                
            }
        }

        private List<IDeposit> _deposits = new List<IDeposit>();
        
        public IEnumerable<IDeposit> Deposits => _deposits;

        /// <summary>
        /// Creates deposit by string that must have the same name as concrete deposit type
        /// and money.
        /// </summary>
        /// <param name="depositType"></param>
        /// <param name="moneyToDeposit"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        /// <exception cref="ArgumentException"></exception>
        public void CreateDeposit(string depositType, decimal moneyToDeposit)
        {
            try
            {
                if (moneyToDeposit < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(CreateDeposit),
                        "Депозит не может быть меньше ноля!");
                }

                switch (depositType)
                {
                    case "SavingDeposit":
                        _deposits.Add(new SavingDeposit(DateTime.Now, moneyToDeposit));
                        break;
                    case "CurrentDeposit":
                        _deposits.Add(new CurrentDeposit(DateTime.Now, moneyToDeposit));
                        break;
                    case "FixedDeposit":
                        _deposits.Add(new FixedDeposit(DateTime.Now, moneyToDeposit));
                        break;
                    case "RecurringDeposit":
                        _deposits.Add(new RecurringDeposit(DateTime.Now, moneyToDeposit));
                        break;
                    default:
                        throw new ArgumentException(nameof(CreateDeposit),
                            "Не удалось определить тип депозита!");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Helper.ValidateBankAccountBalance(ref moneyToDeposit);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Helper.ValidateDepositType(ref depositType);
            }
        }
        
        /// <summary>
        /// Takes money from balance.
        /// </summary>
        /// <param name="count"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void TakeMoneyFromBalance(int count)
        {
            try
            {
                if ((Balance - count) >= 0)
                {
                    Balance -= count;
                    return;
                }
                throw new ArgumentOutOfRangeException(nameof(TakeMoneyFromBalance), 
                        "Вы не можете списать с баланса больше денег, чем там есть!");
            }
            catch(ArgumentOutOfRangeException ex) 
            {
                Console.WriteLine(ex.Message);
                Balance = _balance;
            }
        }
        
        /// <summary>
        /// Puts money on balance.
        /// </summary>
        /// <param name="count"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void PutMoneyToBalance(decimal count)
        {
            try
            {
                if (count > 0)
                {
                    Balance += count;
                    return;
                }
                if (count < 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(PutMoneyToBalance),
                        "Нельзя положить отрицательное к-во денег на счет");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Helper.ValidateBankAccountBalance(ref count);
                Balance += count;
            }
        }

        /// <summary>
        /// Removes a deposit by index.
        /// </summary>
        /// <param name="indexOfRemovingDeposit"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void RemoveDeposit(int indexOfRemovingDeposit)
        {
            try
            {
                if (indexOfRemovingDeposit < 0 || indexOfRemovingDeposit >= _deposits.Count)
                {
                    throw new ArgumentOutOfRangeException();
                }
                
                _deposits.RemoveAt(indexOfRemovingDeposit);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                var validatedIndex = Convert.ToDecimal(indexOfRemovingDeposit);
                Helper.ValidateBankAccountBalance(ref validatedIndex);

                var correctIndexToRemove = Convert.ToInt32(validatedIndex);
                
                _deposits.RemoveAt(correctIndexToRemove);
            }
        }
        
        public BankAccount(string fullName, string number, decimal balance = 0) =>
            (Owner, Number, Balance) = (fullName, number, balance);

        public BankAccount() : this("UNDEFINED", "UNDEFINED") { }
        
        public override string ToString()
        {
            return $"Owner: {Owner} | Bank account number: {Number}";
        }

        /// <summary>
        /// Returns the sum of current balance and money of each deposit. 
        /// </summary>
        /// <returns></returns>
        public decimal GetTotalMoney()
        {
            return Balance + (_deposits.Select(deposit => deposit.Money).Sum());
        }
        /// <summary>
        /// Increases the deposit rate by index in deposit's list.
        /// </summary>
        /// <param name="depositIndex"></param>
        public void IncreaseDepositRate(int depositIndex)
        {
            try
            {
                if (depositIndex < 0 || depositIndex >= _deposits.Count)
                {
                    throw new ArgumentOutOfRangeException(nameof(IncreaseDepositRate),
                        "Выбранного депозита не существует!");
                }
                _deposits[depositIndex].IncreaseDepositRate();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                var validatedDepositIndex = Convert.ToDecimal(depositIndex);
                Helper.ValidateBankAccountBalance(ref validatedDepositIndex);
                var correctIndex = Convert.ToInt32(validatedDepositIndex);
                _deposits[correctIndex].IncreaseDepositRate();
            }
        }
    } 
}