// See https://aka.ms/new-console-template for more information


// structural pattern
// Decorator: Allows a user to add new functionality to an existing object without altering its structure.


using Decorator.Decorators;
using Decorator.Implementations;
using Decorator.Interfaces;
using Decorator.Model;

Account account = new Account(1, "Jhon");

IAccount savAcc = new SavingAccount();
IAccount shieldAcc = new ShieldDecorator(savAcc);

shieldAcc.OpenAccount(account);