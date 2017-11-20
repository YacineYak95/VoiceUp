using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Todo;

namespace Todo
{
	public partial class TodoListPage : ContentPage
	{
		public TodoListPage()
		{
			InitializeComponent();
			this.BackgroundColor = Color.FromHex("#FFFFFF");


		}

		protected override async void OnAppearing()
		{
			base.OnAppearing();
			listView.ItemsSource = await App.TodoManager.GetAllItemsAsync();

			listView.ItemsSource = new List<TodoItem> {
				new TodoItem() { Name = "Speaking", Done = false,Picture = "pronounce.png",Description = "These exercises target speech disorders. Content is tailored to the profile of the patient accordingly" },
				new TodoItem() { Name = "Listening", Done = false,Picture = "listening.png",Description = "These exercises target language troubles and the ability of the kid to listen and understand. Content is tailored to the profile of the patient accordingly"},
				new TodoItem(){ Name = "Blowing", Done = false,Picture = "souffle.png",Description = "These exercises target breathing and swallowing difficulties. Content is tailored to the profile of the patient accordingly"}
											};


		}

		async void OnItemAdded(object sender, EventArgs e)
		{


			await Navigation.PushAsync(new TodoItemPage(new TodoItem()));

		}

		async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = (TodoItem)e.SelectedItem;

			if (item.Name.Contains("Speaking"))
			{
				var list = new List<TodoItem>() {
						new TodoItem() { Picture = "cat.png",Name = "Cat", Done = false},
						new TodoItem() { Picture = "store.png",Name = "Store", Done = false},
						new TodoItem() { Picture = "thermometer.png",Name = "Thermometer", Done = false}
					};
				;
				await Navigation.PushAsync(new ExosPage(list));

			}
			else if (item.Name.Contains("Blowing"))
			{


				var list = new List<TodoItem>() {
						new TodoItem() { Picture = "ban.png",Name = "Banana", Done = false},
						new TodoItem() { Picture = "bal.png",Name = "Ball", Done = false},
					};


			await Navigation.PushAsync(new ExosPage(list));
		}else{
			await Navigation.PushAsync(new ExosPage());
		
		}
		}

		async void OnRateApplication(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new RateAppPage());
		}
	}
}
