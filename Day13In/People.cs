using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day13In
{

	public class People
	{
		public int Id;
		public string Name;
		public int Age;
		public int SSN;
		public string Address;



		public People(int Id, string Name, int Age, int SSN, string Address)
		{
			this.Id = Id;
			this.Name = Name;
			this.Age = Age;
			this.SSN = SSN;
			this.Address = Address;
		}

		public override string ToString()
		{
			return $"Your name is :{this.Name}";
		}
	}
}
