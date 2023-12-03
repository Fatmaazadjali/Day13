using System.Security.Cryptography.X509Certificates;

namespace Day13In
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Employee emp= new Employee(1, "Aaa", 23, 653, "Oman", "CS dev", 6, 5.6);
            Console.WriteLine(emp);

			
			Creature cr1 = new Creature();
			cr1.Sleep();
			cr1.Move();
			cr1.Eat();
        }
	}
}