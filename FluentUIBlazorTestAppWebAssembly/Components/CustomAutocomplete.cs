using Microsoft.AspNetCore.Components;
using Microsoft.FluentUI.AspNetCore.Components;

namespace FluentUIBlazorTestAppWebAssembly.Components
{
	public class CustomAutocomplete<TOption> : FluentAutocomplete<TOption>
		where TOption : notnull
	{
		private TOption? _current;

		protected override void OnInitialized()
		{
			Console.WriteLine($"Autocomplete initialized");
		}

		public override async Task SetParametersAsync(ParameterView parameters)
		{
			bool isSetSelectedOption = false;
			bool isSetValue = false;
			bool isSetItems = false;


			TOption? selectedOption = default;

			foreach (var parameter in parameters)
			{
				switch (parameter.Name)
				{
					case nameof(SelectedOption):
						isSetSelectedOption = true;
						selectedOption = (TOption?)parameter.Value;
						break;
					case nameof(Value):
						isSetValue = true;

						break;
					case nameof(Items):
						if (Items is not null && OptionSelected is not null)
						{
							isSetItems = true;
						}
						break;
					default:
						break;
				}
			}
			await base.SetParametersAsync(parameters);

			Console.WriteLine($"SetParametersAsync: isSetSelectedOption={isSetSelectedOption}, isSetValue={isSetValue}, isSetItems={isSetItems}");
			Console.WriteLine($"Items: {(Items is null ? "null" : string.Join(", ", Items))}");
		}
	}
}
