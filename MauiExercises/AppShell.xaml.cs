using MauiExercises.Models;
using MauiExercises.Views.Lesson05;
using Microsoft.Maui;

namespace MauiExercises;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        //Exercise ShellMenu: Adding an item to a Shell Menu in C#
        var NewsPapers = NewsSource.All;

        Tab aTab;
        foreach (var item in NewsPapers)
        {
            //Create a Tab, set its relevant properties
            //Your code

            //Create a ShellContent , set its relevant properties
            //Your code

            //Add the ShellContent into the Tab
            //Your code

            //Add the Tab into lesson5news2 flyout item from the Xaml page
            //Your code
        }
    }
}
