using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiExercises.ViewModels;

namespace MauiExercises.Views.Lesson06
{
    public partial class NonTrivialBindingExercise2 : ContentPage
    {
        private NonTrivialBindingExercise2_ViewModel _viewModel;

        public NonTrivialBindingExercise2()
        {
            InitializeComponent();

            BindingContext = _viewModel = new NonTrivialBindingExercise2_ViewModel { SliderValue = 0.2F, StepperValue = 2 };
        }


        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await DisplayAlert("Instance Values", 
                $"SliderValue {_viewModel.SliderValue}\nStepperValue {_viewModel.StepperValue}", "OK");


        }
    }

    public class NonTrivialBindingExercise2_ViewModel : BaseViewModel
    {       
        float _slidervalue;
        public float SliderValue
        {
            set => Set<float>(ref _slidervalue, value, "SliderValue");
            get => _slidervalue;
        }

        int _steppervalue;
        public int StepperValue
        {
            set => Set<int>(ref _steppervalue, value, "StepperValue");
            get => _steppervalue;
        }

        Command _SetMiddleCommand;
        public Command SetMiddleCommand => _SetMiddleCommand ?? (_SetMiddleCommand =
            new Command(() =>
            {
                //Step 1. Set your Slider and Stepper values here
            }));
    }
}