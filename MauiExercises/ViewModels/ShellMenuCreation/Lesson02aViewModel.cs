using MauiExercises.Views.Lesson02;
using Microsoft.Maui.Controls;
using System.Text.RegularExpressions;

namespace MauiExercises.ViewModels
{
    public class Lesson02aViewModel
    {
        private static string RoutePrefix = "//lesson2/";
        public Type Type { private set; get; }
        public string Title { private set; get; }
        public string Description { private set; get; }
        public string Route { private set; get; }

        public Lesson02aViewModel(Type type, string title, string description, string route = null)
        {
            Type = type;
            Title = title;
            Description = description;
            Route = route ?? RoutePrefix + Regex.Replace(title.ToLower(), @"\W", "");
        }

        static Lesson02aViewModel()
        {
            All = new List<Lesson02aViewModel>
            {
                
                new Lesson02aViewModel(typeof(SetProperties1), "Set properties1",
                                      "Togle a BoxView color"),

                new Lesson02aViewModel(typeof(SetProperties2), "Set properties2",
                                      "Add elements using various syntax"),

                new Lesson02aViewModel(typeof(MarkupExtension1), "MarkupExtension1",
                                      "using x:Static"),

                new Lesson02aViewModel(typeof(MarkupExtension2), "MarkupExtension2",
                                      "using OnPlatform"),
                
                new Lesson02aViewModel(typeof(MarkupExtension3), "MarkupExtension3",
                                      "using OnIdiom"),

                new Lesson02aViewModel(typeof(BindingExercise1), "BindingExercise1",
                                      "Databinding to multiple properties"),

                new Lesson02aViewModel(typeof(BindingExercise2), "BindingExercise2",
                        "Databinding using BindingContext"),
            };

            foreach (var item in All)
            {
                Routing.RegisterRoute(item.Route, item.Type);
            }
        }

        public static IList<Lesson02aViewModel> All { private set; get; }
    }
}
