using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DOTNET_XAM1
{
	public partial class MainPage : ContentPage
	{
	    private ListView listView;
	    private Button addNewItemButton;

		public MainPage ()
		{
            listView = new ListView();
		    listView.ItemsSource = Globals.Items;
            listView.ItemSelected += ListView_ItemSelected;
            listView.ItemTemplate = new DataTemplate(typeof(ViewXaml));

            addNewItemButton = new Button();
		    addNewItemButton.Text = "Add new ToDoItem!";
            addNewItemButton.Clicked += AddNewItemButton_Clicked;

            Content = new ScrollView() { 
            Content = new StackLayout {
				Children = {
					addNewItemButton,
                    listView
				}}
			};
            
		}

        private async  void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new ToDoItemView((sender as ListView).SelectedItem as ToDoItem));

        }

        private async void AddNewItemButton_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new AddToDoItemPage());
        }
    }
}