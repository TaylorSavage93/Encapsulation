using BankEncapsulation;

var account = new BankAccount();

Console.WriteLine("Enter amount for deposit.");

var ammountToDeposit = double.Parse(Console.ReadLine());

account.Deposit(ammountToDeposit);

Console.WriteLine($"Thank you for your deposit, your balance is now {account.GetBalance()}.");


Console.WriteLine("How much would you like to withdrawl?");

var ammountToWithdrawl = double.Parse(Console.ReadLine());

account.Withdraw(ammountToWithdrawl);


Console.WriteLine($"Thank you for your service, your balance is now {account.GetBalance()}.");
