// See https://aka.ms/new-console-template for more information


// Strategy: Defines family of algorithms, encapsulate each one, and make them interchangeable.

using Strategy.Strategy;

Context context = new Context(new AntivirusAdvanced());
context.Execute();
