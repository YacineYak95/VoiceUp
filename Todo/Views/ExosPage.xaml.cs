using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Diagnostics;

namespace Todo
{
	public partial class ExosPage : ContentPage
	{
		public List<TodoItem> list;
		public ExosPage()
		{
			InitializeComponent();
		}

		public ExosPage(List<TodoItem> list)
		{
			InitializeComponent();
			this.list = list;
		}
		protected override async void OnAppearing()
		{
			base.OnAppearing();
					ExoList.ItemsSource = await App.TodoManager.GetAllItemsAsync();
			ExoList.ItemsSource = this.list;

		}

		async void OnItemAdded(object sender, EventArgs e)
		{


			await Navigation.PushAsync(new TodoItemPage(new TodoItem()));

		}

		async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = (TodoItem)e.SelectedItem;
			await Navigation.PushAsync(new TodoItemPage(item));
		}

		async void OnRateApplication(object sender, EventArgs e)
		{
			await Navigation.PushAsync(new RateAppPage());
				}
			}
		}
