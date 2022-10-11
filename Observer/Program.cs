// See https://aka.ms/new-console-template for more information


using Observer.Observer;

Subject subject = new Subject();

new SolObserver(subject);
new PesoArgObserver(subject);
new PesoMXObserver(subject);

Console.WriteLine("Changing $10 you will obtain... ");
subject.SetState(10);
Console.WriteLine("================================");
Console.WriteLine("Changing $100 you will obtain... ");
subject.SetState(100);
