using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;


namespace DOTNET_XAM1
{
    public static class Globals //nie można stworzyć instancji klasy static
    {
        public static ObservableCollection<ToDoItem> Items;


        static Globals()
        {
            Items= new ObservableCollection<ToDoItem>();

            Items.Add(new ToDoItem("Powieś pranie","Bo nie zjesz obiadu"));
            Items.Add(new ToDoItem("Zjedz obiad","Bo będziesz głodny"));

        }
    }
}
