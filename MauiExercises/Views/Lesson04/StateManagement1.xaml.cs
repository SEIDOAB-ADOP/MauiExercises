using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using MauiExercises.Globals;
using MauiExercises.Models;

namespace MauiExercises.Views.Lesson04
{
    public partial class StateManagement1 : ContentPage
    {
        public StateManagement1()
        {
            InitializeComponent();

            var startMessage = Global.Data.Message;
            var startTime = Global.Data.Time;

            BindingContext= this;
        }
    }
}

