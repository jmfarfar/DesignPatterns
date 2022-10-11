// See https://aka.ms/new-console-template for more information


// Proxy: Provide a wrapper for a remote, or expensive or sensitive target. Encapsulates the complexity in the wrapper 

// we have the flexibility to add new implementations through the proxy without modifying the core functionality

using Proxy.Implementations;
using Proxy.Interfaces;
using Proxy.Models;
using Proxy.Proxy;

Account acc = new Account(1, "Jhon", 200);

IAccount proxyAcc = new AccountProxy(new BankBAccount());
proxyAcc.ShowBalance(acc);
acc = proxyAcc.DepositMoney(acc, 100);
acc = proxyAcc.WithdrawMoney(acc, 30);
proxyAcc.ShowBalance(acc);
