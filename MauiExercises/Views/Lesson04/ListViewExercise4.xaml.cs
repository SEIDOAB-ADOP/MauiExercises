using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MauiExercises.Models;

namespace MauiExercises.Views.Lesson04
{
    public partial class ListViewExercise4 : ContentPage
    {
        public ListViewExercise4()
        {
            InitializeComponent();
            CustomGroupedList.ItemsSource = City.List;
        }

        private async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            City item = (City)e.Item;
            await DisplayAlert("Item Tapped", item.Name, "OK");
            ((ListView)sender).SelectedItem = null;
        }

        private async void MoreButton_Clicked(object sender, EventArgs e)
        {
            var b = (Button)sender;
            var item = (City)b.CommandParameter;
            await DisplayAlert("Button Clicked", $"{item.Name} in {item.Continent} has a population of {item.Population}.", "OK");
        }
    }
}