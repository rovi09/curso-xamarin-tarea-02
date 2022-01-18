using System;
using Xamarin.Forms;

namespace MobileApp
{
	public partial class App : Application
	{
		public App()
		{
			MainPage = new ContentPage {
				Content = BuildCalculator(),
				BackgroundColor= Color.Blue,
			};
		}

		private View BuildCalculator()
        {
			var entryField = new Xamarin.Forms.Entry() { Text="123" };
			entryField.IsReadOnly = true;

			var container = new StackLayout();
			container.BackgroundColor = Color.AntiqueWhite;

			container.Children.Add(
					new StackLayout
                    {
						Orientation = StackOrientation.Horizontal,
						Children =
                        {
							new Button { Text = "7" },
							new Button { Text = "8" },
							new Button { Text = "9" },
						}
                    }
				);

			container.Children.Add(
					new StackLayout
					{
						Orientation = StackOrientation.Horizontal,
						Children =
						{
							new Button { Text = "4" },
							new Button { Text = "5" },
							new Button { Text = "6" },
						}
					}
				);
			container.Children.Add(
					new StackLayout
					{
						Orientation = StackOrientation.Horizontal,
						Children =
						{
							new Button { Text = "1" },
							new Button { Text = "2" },
							new Button { Text = "3" },
						}
					}
				);

			return new StackLayout
			{
				Orientation = StackOrientation.Vertical,
				VerticalOptions = LayoutOptions.Center,
				HorizontalOptions = LayoutOptions .Center,
				Children =
				{
					entryField,
					container,

				}
			};
        }
		
	}
}