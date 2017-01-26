using System;
using System.Threading;

namespace ClassesFromLife
{
	public class Family
	{
		private string fatherName;
		private int fatherAge;

		private string motherName;
		private int motherAge;

		private string sisterName;
		private int sisterAge;

		public Family(string fatherName, int fatherAge, string motherName, int motherAge, string sisterName, int sisterAge)
		{
			//Father info
			//this.fatherName = "Jimmy Strickland";
			this.fatherName = fatherName;
			this.fatherAge = fatherAge;
			//Mother info
			this.motherName = motherName;
			this.motherAge = motherAge;
			//Sister info
			this.sisterName = sisterName;
			this.sisterAge = sisterAge;
		}


		public void printInfo()
		{
			int sleepTimer = 1500;
			Console.WriteLine("My family: ");
			Console.WriteLine("*******************");
			Console.WriteLine("Father:");
			Console.WriteLine("\t" + fatherName);
			Console.WriteLine("\t" + fatherAge);
			Console.WriteLine("\n");
			Console.WriteLine("Mother:");
			Console.WriteLine("\t" + motherName);
			Console.WriteLine("\t" + motherAge);
			Console.WriteLine("\n");
			Console.WriteLine("Sister:");
			Console.WriteLine("\t" + sisterName);
			Console.WriteLine("\t" + sisterAge);
			Console.WriteLine("*******************");
			
		}
	}
}
