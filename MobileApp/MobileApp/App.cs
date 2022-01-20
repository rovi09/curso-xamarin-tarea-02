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
						HorizontalOptions = LayoutOptions.End,
						Children =
						{
							new Button { Text = "/"},
						}
					}
				);

			container.Children.Add(
					new StackLayout
                    {
						Orientation = StackOrientation.Horizontal,
						Children =
                        {
							new Button { Text = "7" },
							new Button { Text = "8" },
							new Button { Text = "9" },
							new Button { Text = "*" },
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
							new Button { Text = "+" },
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
							new Button { Text = "-" },
						}
					}
				);
			container.Children.Add(
					new StackLayout
					{
						Orientation = StackOrientation.Horizontal,
						HorizontalOptions = LayoutOptions.End,
						Children =
						{
							new Button { Text = "0" },
							new Button { Text = "." },
							new Button { Text = "=" },
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