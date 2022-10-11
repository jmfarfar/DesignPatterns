// See https://aka.ms/new-console-template for more information



// Command: Encapsulates a request as an object, letting you parametrize clients with different requests. 

using Command.Commands;

Account account = new Account(1, 300);

Deposit opDeposit = new Deposit(account, 100);
Withdraw opWithdraw = new Withdraw(account, 150);

Invoker invk = new Invoker();
invk.ReceiveOperation(opDeposit);
invk.ReceiveOperation(opWithdraw);

invk.ExecuteOperations();