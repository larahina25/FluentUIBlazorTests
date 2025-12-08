using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;

namespace FluentUIBlazorTestAppWebAssembly.Components
{
	/// <summary>
	/// This custom component is just use to hook into the lifecycle methods of FluentAutocomplete for testing purposes.
	/// </summary>
	public class CustomAutocomplete<TOption> : FluentAutocomplete<TOption>
		where TOption : notnull
	{
		protected override void OnInitialized()
		{
			Console.WriteLine($"Autocomplete initialized");
		}

		public override async Task SetParametersAsync(ParameterView parameters)
		{
			bool isSetSelectedOption = false;
			bool isSetItems = false;

			foreach (var parameter in parameters)
			{
				switch (parameter.Name)
				{
					case nameof(SelectedOption):
						isSetSelectedOption = true;
						break;
					case nameof(Items):
						isSetItems = true;
						break;
					default:
						break;
				}
			}
			await base.SetParametersAsync(parameters);

			Console.WriteLine($"SetParametersAsync: isSetSelectedOption={isSetSelectedOption}, isSetItems={isSetItems}");
			Console.WriteLine($"Items: {(Items is null ? "null" : string.Join(", ", Items))}");
		}
	}
}
