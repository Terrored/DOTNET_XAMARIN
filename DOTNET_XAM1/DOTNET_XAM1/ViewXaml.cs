using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace DOTNET_XAM1
{
    class ViewXaml:ViewCell
    {
        public ViewXaml()
        {
            Label nameLabel = new Label();
            Label descriptionLabel = new Label();

            Grid mainGrid = new Grid
            {
                Padding = new Thickness(10),
                RowDefinitions = new RowDefinitionCollection
                {
                    new RowDefinition{Height = GridLength.Auto},
                    new RowDefinition{Height = GridLength.Auto}
                },
                ColumnDefinitions = new ColumnDefinitionCollection
                {
                    new ColumnDefinition{Width = new GridLength(1,GridUnitType.Star)}
                }
            };


            mainGrid.Children.Add(nameLabel, 0, 0);
            mainGrid.Children.Add(descriptionLabel, 0, 1);

            View = mainGrid;

            //Bindings

            nameLabel.SetBinding<ToDoItem>(Label.TextProperty, i => i.Name);
            descriptionLabel.SetBinding<ToDoItem>(Label.TextProperty, i => i.Description);
        }
    }
}
