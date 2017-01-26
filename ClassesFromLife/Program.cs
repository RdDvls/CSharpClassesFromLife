using System;

namespace ClassesFromLife
{
	class Runner
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			var family = new Family("Jimmy Strickland", 56, "Michele Strickland", 54, "Sydney Strickland", 30);
			var pets = new Pets(4,3,1,"mutt","mutt","Sampson",8,"Jackson",8,"Lucy",10,"Kurt",8);
			family.printInfo();
			pets.printInfo();

		}
	}
}
