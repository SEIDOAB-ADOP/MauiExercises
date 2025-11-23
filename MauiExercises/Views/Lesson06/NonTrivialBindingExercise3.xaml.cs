using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using MauiExercises.ViewModels;

namespace MauiExercises.Views.Lesson06
{
    public partial class NonTrivialBindingExercise3 : ContentPage
    {
        private NonTrivialBindingExercise3_ViewModel _viewModel;

        public NonTrivialBindingExercise3()
        {
            InitializeComponent();
            BindingContext = _viewModel = new NonTrivialBindingExercise3_ViewModel { SliderValue = 0.2F, StepperValue = 2 };
        }
    }
}