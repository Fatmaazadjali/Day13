using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13In
{
	internal class Creature : INature
	{
		public void Eat()
		{
            Console.WriteLine("You can eat");
        }
		public void Sleep()
		{
            Console.WriteLine("U can sleep");
        }
		public void Move()
		{
			Console.WriteLine("U can Move!");
		}
	}
}
