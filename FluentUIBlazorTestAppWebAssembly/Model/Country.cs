namespace FluentUIBlazorTestAppWebAssembly.Model
{

	public record Country(string Name, string Code)
	{
		public override string ToString() => $"{Name} ({Code})";

		#region Sample data
		private static List<Country>? _countries;
		public static List<Country> Countries
		{
			get
			{
				if (_countries == null)
				{
					_countries = new List<Country>()
				{
					new("Australia", "AU"),
					new("United States","US"),
					new("Canada","CA" ),
					new("Mexico","MX" ),
					new("Brazil","BR" ),
					new("Argentina","AR" ),
					new("United Kingdom","GB" ),
					new("France",  "FR" ),
					new("Germany", "DE" ),
					new("Italy", "IT" ),
					new("Spain", "ES" ),
					new("Portugal", "PT" ),
					new("Netherlands",  "NL")
				};
				}
				return _countries;
			}
		}
		#endregion
	}
}
