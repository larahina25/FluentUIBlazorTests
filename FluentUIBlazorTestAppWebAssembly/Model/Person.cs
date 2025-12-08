namespace FluentUIBlazorTestAppWebAssembly.Model
{
	public class Person(string name, Country country)
	{
		public string Name { get; set; } = name;

		public Country Country { get; set; } = country;

		public override string ToString() => $"{Name} from {Country}";

		#region Sample data
		private static List<Person>? _people;

		public static List<Person> People
		{
			get
			{
				if (_people == null)
				{
					_people = new List<Person>()
				{
					new("Alice", Country.Countries[0]),
					new("Bob", Country.Countries[1]),
					new("Charlie", Country.Countries[2]),
					new("Diana", Country.Countries[3]),
					new("Ethan", Country.Countries[4]),
					new("Fiona", Country.Countries[5]),
					new("George", Country.Countries[6]),
					new("Hannah", Country.Countries[7]),
					new("Ian", Country.Countries[8]),
					new("Julia", Country.Countries[9]),
					new("Kevin", Country.Countries[10]),
					new("Laura", Country.Countries[11])
				};
				}
				return _people;
			}
		}
		#endregion
	}
}
