using MauiExercises.ViewModels;

namespace MauiExercises.Views
{

    public partial class Lesson05a : ContentPage
    {
        public Lesson05a()
        {
            InitializeComponent();
        }
        private async void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            (sender as ListView).SelectedItem = null;

            if (args.SelectedItem != null)
            {
                Lesson05aViewModel pageData = args.SelectedItem as Lesson05aViewModel;
                Page page = (Page)Activator.CreateInstance(pageData.Type);
                //await Navigation.PushAsync(page);
                await Shell.Current.GoToAsync(pageData.Route);
            }
        }
    }
}