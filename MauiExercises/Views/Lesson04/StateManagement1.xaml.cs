using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using MauiExercises.Globals;
using MauiExercises.Models;

namespace MauiExercises.Views.Lesson04
{
    public partial class StateManagement1 : ContentPage
    {
        public List<Friend> MyFriends;
        public List<City> MyCities;
        public List<NamedColor> MyColor;
        public StateManagement1()
        {
            InitializeComponent();
            BindingContext = this;

            var startMessage = Global.Data.Message;
            var startTime = Global.Data.Time;

        }

        //Exercise modify the Globals lazy added lists
        //a.	list of friends who’s favorite color contains the word “Blue”
        //b.	list of cities in Africa
        //c.	list of named colors with a friendly name that contain the word “Red”  

    }
}

