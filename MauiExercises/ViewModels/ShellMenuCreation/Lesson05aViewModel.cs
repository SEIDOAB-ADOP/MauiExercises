using MauiExercises.Views.Lesson05;
using Microsoft.Maui.Controls;
using System.Text.RegularExpressions;

namespace MauiExercises.ViewModels
{
    public class Lesson05aViewModel
    {
        private static string RoutePrefix = "//lesson5/";
        public Type Type { private set; get; }
        public string Title { private set; get; }
        public string Description { private set; get; }
        public string Route { private set; get; }

        public Lesson05aViewModel(Type type, string title, string description, string route = null)
        {
            Type = type;
            Title = title;
            Description = description;
            Route = route ?? RoutePrefix + Regex.Replace(title.ToLower(), @"\W", "");
        }

        static Lesson05aViewModel()
        {
            All = new List<Lesson05aViewModel>
            {
               new Lesson05aViewModel(typeof(ListViewExercise1), "ListView Exercise1",
                        "Connect a ListView to Datamodel"),

                new Lesson05aViewModel(typeof(ListViewExercise2), "ListView Exercise2",
                        "Customize the ListView by adding images"),

                new Lesson05aViewModel(typeof(ListViewExercise3), "ListView Exercise3",
                        "Customize the ListView by adding buttons"),

                new Lesson05aViewModel(typeof(ListViewExercise4), "ListView Exercise4",
                        "Use Linq to group items"),
                
                new Lesson05aViewModel(typeof(WebViewExplore), "WebView Explore",
                        "Use WebView to read som newspapers"),
            };

            foreach (var item in All)
            {
                Routing.RegisterRoute(item.Route, item.Type);
            }
        }

        public static IList<Lesson05aViewModel> All { private set; get; }
    }
}
