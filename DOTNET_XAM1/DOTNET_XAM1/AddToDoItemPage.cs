using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace DOTNET_XAM1
{
	public class AddToDoItemPage : ContentPage
	{
	    private Entry nameEntry;
	    private Editor descriptionEditor;
	    private Button okButton;
		public AddToDoItemPage ()
		{
            nameEntry = new Entry();
            descriptionEditor = new Editor();
		    descriptionEditor.HeightRequest = 100;
		    okButton = new Button();
		    okButton.Text = "OK";
            okButton.Clicked += OkButton_Clicked;
			Content = new StackLayout {
				Children = {
					new Label { Text = "Add new Item:" },
                    nameEntry,
                    descriptionEditor,
                    okButton
				}
			};
		}

        private async void OkButton_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(nameEntry.Text))
            {
                Globals.Items.Add(new ToDoItem(nameEntry.Text , descriptionEditor.Text));
            }
            await Navigation.PopAsync();
        }
    }
}