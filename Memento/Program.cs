// See https://aka.ms/new-console-template for more information



// Memento: Save the state of an operation in your application. Basically as a check point where you can return.

using Memento.Memento;

string gameName = "Mario Bros.";

Game game = new Game();
game.SetName(gameName);
game.SetCheckpoint(1);

Caretaker caretaker = new Caretaker();
Originator originator = new Originator();

game = new Game();
game.SetName(gameName);
game.SetCheckpoint(2);
originator.SetState(game);

game = new Game();
game.SetName(gameName);
game.SetCheckpoint(3);
originator.SetState(game);

caretaker.AddMemento(originator.Save()); // save at position 0

game = new Game();
game.SetName(gameName);
game.SetCheckpoint(4);
originator.SetState(game);

caretaker.AddMemento(originator.Save()); // save at position 1

game = new Game();
game.SetName(gameName);
game.SetCheckpoint(5);
originator.SetState(game);

originator.Restore(caretaker.GetMemento(0));

game = originator.GetState();

Console.WriteLine(game);
