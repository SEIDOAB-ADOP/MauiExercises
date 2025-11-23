using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using MauiExercises.Models;

namespace MauiExercises.Views.Lesson05
{
    public partial class ListViewExercise1 : ContentPage
    {
        public ListViewExercise1()
        {
            InitializeComponent();
            DataModelList.ItemsSource = CityPopulation.List;
        }

        async void ListViewItemTapped (object sender, ItemTappedEventArgs e)
        {
            CityPopulation item = (CityPopulation)e.Item;
            await DisplayAlert("Tapped", item.ToString(), "OK");
            ((ListView)sender).SelectedItem = null;
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
        }
        private async void Button_Clicked_1(object sender, EventArgs e)
        {
        }
    }
}

