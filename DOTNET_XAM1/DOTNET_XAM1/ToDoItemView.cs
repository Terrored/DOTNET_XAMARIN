using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DOTNET_XAM1
{
	public class ToDoItemView : ContentPage
	{
	    private ToDoItem item;
	    private Button deleteButton;
		public ToDoItemView (ToDoItem item)
		{
		    this.item = item;
            deleteButton = new Button();
            deleteButton.Clicked += DeleteButton_Clicked;
		    deleteButton.Text = " Delete this item !";

			Content = new StackLayout {
				Children = {
					new Label { Text = item.Name },
					new Label { Text = item.Description},
                    deleteButton
				}
			};
		}

        private async void DeleteButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            Globals.Items.Remove(item);
        }
    }
}