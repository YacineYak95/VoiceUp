using System;
using System.Collections.Generic;
using ImageCircle;
using ImageCircle.Forms.Plugin.Abstractions;
using Xamarin.Forms;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Threading;

namespace Todo
{
	public partial class HomePage : MasterDetailPage
	{
		public HomePage()
		{
			InitializeComponent();

			int photoSize = 180;


			var photo = new CircleImage
			{
				Source = "http://vivrefm.com/img/uploads/uploads_2013_03/2013_03_08__12_23_enfant_autiste.jpg",
				WidthRequest = photoSize,
				HeightRequest = photoSize,
				Aspect = Aspect.AspectFill,
				HorizontalOptions = LayoutOptions.Center,
				VerticalOptions = LayoutOptions.Center,
				Scale = 1
			};


			var Consultation = new Label
			{

				Text = "Score",
				TextColor = Color.FromHex("#FFFFFF"),
				FontSize = 14

			};


			var SeanceScore = new CurvedCornersLabel
			{

				TextColor = Color.FromHex("#FFFFFF"),
				FontSize = 10,
				Text = "20",
				HorizontalTextAlignment = TextAlignment.Center,
				VerticalTextAlignment = TextAlignment.Center,
				CurvedBackgroundColor = Color.FromHex("#088A29"),
				CurvedCornerRadius = 10,
				WidthRequest = 25,
				HeightRequest = 25,
				HorizontalOptions = LayoutOptions.EndAndExpand,
				Margin = new Thickness(150, 0, 0, 0)

			};




			var message = new CurvedCornersLabel
			{

				TextColor = Color.FromHex("#FFFFFF"),
				FontSize = 10,
				Text = "3",
				HorizontalTextAlignment = TextAlignment.Center,
				VerticalTextAlignment = TextAlignment.Center,
				CurvedBackgroundColor = Color.FromHex("#088A29"),
				CurvedCornerRadius = 10,
				WidthRequest = 25,
				HeightRequest = 25,
				HorizontalOptions = LayoutOptions.EndAndExpand,
				Margin = new Thickness(150, 0, 0, 0)

			};


			var HomeWorkslabel = new CurvedCornersLabel
			{

				TextColor = Color.FromHex("#FFFFFF"),
				FontSize = 10,
				Text = "20",
				HorizontalTextAlignment = TextAlignment.Center,
				VerticalTextAlignment = TextAlignment.Center,
				CurvedBackgroundColor = Color.FromHex("#088A29"),
				CurvedCornerRadius = 10,
				WidthRequest = 25,
				HeightRequest = 25,
				HorizontalOptions = LayoutOptions.EndAndExpand,
				Margin = new Thickness(150, 0, 0,0) 
			};


			var LabelMessage = new Label
			{

				Text = "Achievements",
				TextColor = Color.FromHex("#FFFFFF"),
				FontSize = 13

			};

			var LabelAbout = new Label
			{

				Text = "Homeworks",
				TextColor = Color.FromHex("#FFFFFF"),
				FontSize = 13

			};

			var Separator = new BoxView()
			{

				HorizontalOptions = LayoutOptions.FillAndExpand,
				HeightRequest = 1,
				BackgroundColor = Color.White,
			};

			var Separator1 = new BoxView()
			{

				HorizontalOptions = LayoutOptions.FillAndExpand,
				HeightRequest = 1,
				BackgroundColor = Color.White,
			};



			var AlignerContainer = new StackLayout()
			{

				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { Consultation, SeanceScore }

			};

			var AlignerContainer2 = new StackLayout()
			{

				Orientation = StackOrientation.Horizontal,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Children = { LabelMessage, message }

			};

				var AlignerContainer3 = new StackLayout()
				{

					Orientation = StackOrientation.Horizontal,
					HorizontalOptions = LayoutOptions.FillAndExpand,
					Children = { LabelAbout, HomeWorkslabel }			
				};




			var ProfilInformation = new StackLayout()
			{


				Orientation = StackOrientation.Vertical,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				VerticalOptions = LayoutOptions.StartAndExpand,
				Children = {
								AlignerContainer,
								Separator,
								AlignerContainer2,
								Separator1,
								AlignerContainer3


						},
				Padding = new Thickness(16, 8, 8, 16)




			};


			this.Master = new ContentPage
			{
				Title = "Profil",
				Content = new StackLayout()
				{

					Orientation = StackOrientation.Vertical,
					HorizontalOptions = LayoutOptions.FillAndExpand,
					VerticalOptions = LayoutOptions.FillAndExpand,
					BackgroundColor = Color.FromHex("#FFBF00"),
					Padding = new Thickness(5, 40, 5, 10),
					Children =
										{
											photo,
											new Label
											{
												HorizontalOptions = LayoutOptions.Center,
												VerticalOptions = LayoutOptions.Center,
												Text = "sheldon cooper",TextColor = Color.FromHex("#FFFFFF")
											
											},
											ProfilInformation,
										}
				}
			};

			this.Detail = new NavigationPage(new TodoListPage());
		}








	}
}
