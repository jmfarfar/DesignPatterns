// See https://aka.ms/new-console-template for more information



// Prototype: crear una nueva instancia con los valores clonados o copiados de otra instancia

using Prototype.Interfaces;
using Prototype.Models;

SavingAccount savingAccount = new SavingAccount();
savingAccount.SetAmmount(300);
SavingAccount cloneSavingAcc = (SavingAccount)savingAccount.Clone();

if (savingAccount != null)
{
    Console.WriteLine(cloneSavingAcc);
}

Console.WriteLine(savingAccount == cloneSavingAcc);
