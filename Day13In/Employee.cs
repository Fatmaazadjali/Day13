

namespace Day13In
{
	internal class Employee : People
	{
		string role;
		int workHours;
		double Wage;

		public Employee(int Id, string Name, int Age, int SSN, string Address, string role, int workHours, double Wage) : base(Id, Name, Age, SSN, Address)
		{
			this.role = role;
			this.workHours = workHours;
			this.Wage = Wage;
		}

		public override string ToString()
		{
			return base.ToString() + $"Your role is: {this.role}";
		}
	}
}
