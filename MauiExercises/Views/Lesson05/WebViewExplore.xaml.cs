using System.Web;
using MauiExercises.Models;

namespace MauiExercises.Views.Lesson05
{
    public partial class WebViewExplore : ContentPage
    {
        List<NewsSource> myNewsSources = NewsSource.All.ToList();
        Random rnd = new Random();
        
        public NewsSource CurrentNewsSource { get; set; }


        public WebViewExplore()
        {
            InitializeComponent();

            CurrentNewsSource = myNewsSources[rnd.Next(0, myNewsSources.Count)];
            BindingContext = this;
        }

        public WebViewExplore(NewsSource newsSource)
        {
            InitializeComponent();

            CurrentNewsSource = newsSource;
            BindingContext = this;

        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);

            //Routing of this page
            Title += $"   ({Shell.Current.CurrentState.Location.ToString()})";
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            Title = $"Viewing {CurrentNewsSource.Name}";
        }
    }
}
