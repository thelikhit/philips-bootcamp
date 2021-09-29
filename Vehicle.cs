using System;

abstract class Vehicle {
}

class Car: Vehicle {
	Engine engine = new Engine();
	Transmission transmission = new Transmission();
}

class Engine {
}

class Transmission {
}
				
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Hello World");
	}
}
