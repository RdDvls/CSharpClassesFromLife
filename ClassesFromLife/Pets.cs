using System;
namespace ClassesFromLife
{
	public class Pets
	{
		private int petCount;
		private int numDogs;
		private int numCats;
		private string dogBreeds;
		private string catBreed;
		private string samName;
		private int samAge;
		private string jacksonName;
		private int jacksonAge;
		private string lucyName;
		private int lucyAge;
		private string kurtName;
		private int kurtAge;



		public Pets(int petCount, int numDogs, int numCats, string dogBreeds, string catBreed, string samName, int samAge, string jacksonName, int jacksonAge, string lucyName, int lucyAge, string kurtName, int kurtAge)
		{
			this.petCount = petCount;
			this.numDogs = numDogs;
			this.numCats = numCats;
			this.dogBreeds = dogBreeds;
			this.catBreed = catBreed;
			this.samName = samName;
			this.samAge = samAge;
			this.jacksonName = jacksonName;
			this.jacksonAge = jacksonAge;
			this.lucyName = lucyName;
			this.lucyAge = lucyAge;
			this.kurtName = kurtName;
			this.kurtAge = kurtAge;
		}
		public void printInfo()
		{
			Console.WriteLine("****************************************");
			Console.WriteLine("I have " + petCount + " pets.");
			Console.WriteLine(numCats + " cat and " + numDogs + " dogs");
			Console.WriteLine("My dog is " + samName + " and he is " + samAge + " years old");
			Console.WriteLine("My sister's dog is " + jacksonName + " and he is " + jacksonAge + " years old");
			Console.WriteLine(samName + " and " + jacksonName + " are brothers!");
			Console.WriteLine("My brother-in-law's dog is " + lucyName + " and she is " + lucyAge + " years old");
			Console.WriteLine("All the dogs are " + dogBreeds + "s .");
			Console.WriteLine("The cat's name is " + kurtName);
			Console.WriteLine("He is also a " + catBreed + " and he is " + kurtAge + " months old.");
			Console.WriteLine("****************************************");
		}
	}
}
