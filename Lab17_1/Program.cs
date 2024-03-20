// See https://aka.ms/new-console-template for more information


using Lab17_1;

BankAccount<int> account1 = new BankAccount<int>
{
    Num = 1,
    Balance = 0,
    Name = "Иванов И.И.",    
};



BankAccount<string> account2 = new BankAccount<string>
{
    Num = "account_1",
    Balance = 100,
    Name = "Петров П.П.",
};


Console.WriteLine("На счету {0} баланс {1}, владалец: {2}", account1.Num, account1.Balance, account1.Name);
Console.WriteLine("На счету {0} баланс {1}, владалец: {2}", account2.Num, account2.Balance, account2.Name);
