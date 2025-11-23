using MauiExercises.ViewModels;

namespace MauiExercises.Views
{

    public partial class Lesson02a : ContentPage
    {
        public Lesson02a()
        {
            InitializeComponent();
        }
        private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            (sender as ListView).SelectedItem = null;

            if (args.SelectedItem != null)
            {
                Lesson02aViewModel pageData = args.SelectedItem as Lesson02aViewModel;
                Page page = (Page)Activator.CreateInstance(pageData.Type);
                await Shell.Current.GoToAsync(pageData.Route);
            }
        }
    }
}