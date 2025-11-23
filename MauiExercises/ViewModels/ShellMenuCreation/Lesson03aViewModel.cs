using MauiExercises.Views.Lesson03;
using System.Text.RegularExpressions;

namespace MauiExercises.ViewModels
{
    public class Lesson03aViewModel
    {
        private static string RoutePrefix = "//lesson3/";
        public Type Type { private set; get; }
        public string Title { private set; get; }
        public string Description { private set; get; }
        public string Route { private set; get; }

        public Lesson03aViewModel(Type type, string title, string description, string route = null)
        {
            Type = type;
            Title = title;
            Description = description;
            Route = route ?? RoutePrefix + Regex.Replace(title.ToLower(), @"\W", "");
        }

        static Lesson03aViewModel()
        {
            All = new List<Lesson03aViewModel>
            {
                new Lesson03aViewModel(typeof(StackLayoutExercise), "StackLayout Exercise",
                                    "Try out StackLayout"),
                new Lesson03aViewModel(typeof(AbsoluteLayoutExercise), "AbsoluteLayout Exercise",
                                    "Try out AbsoluteLayout"),
                new Lesson03aViewModel(typeof(GridLayoutExercise), "GridLayout Exercise",
                                    "Try out GridLayout"),
                new Lesson03aViewModel(typeof(ScrollViewExercise), "ScrollView Exercise",
                                    "Try out ScrollView"),
            };

            foreach (var item in All)
            {
                Routing.RegisterRoute(item.Route, item.Type);
            }
        }

        public static IList<Lesson03aViewModel> All { private set; get; }
    }
}
