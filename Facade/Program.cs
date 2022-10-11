// See https://aka.ms/new-console-template for more information


// structural pattern
// Facade: hides compexities of the system and provides an interface to the client using which the client can access the system

using Facade.Facade;

CheckFacade client1 = new CheckFacade();
client1.Search("Jerome", "21-Oct", "30-Oct", "Florida", "Pensylvania");

CheckFacade client2 = new CheckFacade();
client2.Search("Sarah", "21-Dec", "31-Dec", "NY", "California");