using System;

namespace Part1
{
    class BankAccount
    {
        public enum AccountType
        {
            Current,
            Savings
        }

        private static int generatedAccountNumber = 1;
        private int accountNumber;
        private decimal accountBalance;
        private AccountType accountType;

        public BankAccount(decimal accountBalance, AccountType accountType)
        {
            this.accountNumber = GenerateAccountNumber();
            this.accountBalance = accountBalance;
            this.accountType = accountType;
        }
        public static int GenerateAccountNumber()
        {
            return generatedAccountNumber++;
        }

        public int GetAccountNumber()
        {
            return accountNumber;
        }
        public decimal GetAccountBalance()
        {
            return accountBalance;
        }
        public AccountType GetAccountType()
        {
            return accountType;
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= accountBalance)
            {
                accountBalance -= amount;
                Console.WriteLine($"Со счёта {accountNumber} было успешно снято {amount}₽!\nТеперь баланс данного счёта составляет {accountBalance}₽\n");
            }
            else if (amount < 0)
            {
                Console.WriteLine("Снятие отрицательной суммы невозможно!");
            }
            else
            {
                Console.WriteLine($"Невозможно снять {amount}₽, так как текущий баланс составляет {accountBalance}₽!\nНедостаточно средств!\n");
            }
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                accountBalance += amount;
                Console.WriteLine($"Со счёта {accountNumber} было успешно снято {amount}₽!\nТеперь баланс данного счёта составляет {accountBalance}₽\n");
            }
            else
            {
                Console.WriteLine("Внесение отрицательной суммы невозможно!\n");
            }
        }
        public void TransferMoney(BankAccount recipient, decimal amount)
        {
            if (accountBalance >= amount && accountNumber != recipient.accountNumber)
            {
                accountBalance -= amount;
                recipient.accountBalance += amount;
                Console.WriteLine($"Пользователь со счётом {accountNumber} успешно перевёл {amount}₽ на счёт {recipient.accountNumber}!\nТеперь на его счету {accountBalance}₽\n");
            }
            else if (accountNumber.Equals(recipient.accountNumber))
            {
                Console.WriteLine("Перевод самому себе невозможен!");
            }
            else
            {
                Console.WriteLine("Перевод невозможен, на счету отправителя недостаточно средств!\nПополните счёт и повторите попытку\n");
            }
        }
    }
}
