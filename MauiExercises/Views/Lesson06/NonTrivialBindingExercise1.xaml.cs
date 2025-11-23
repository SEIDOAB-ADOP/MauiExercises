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
    public partial class NonTrivialBindingExercise1 : ContentPage
    {

        private NonTrivialBindingExercise1_ViewModel _viewModel = null;

        public NonTrivialBindingExercise1()
        {
            InitializeComponent();
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await DisplayAlert("Instance Values", 
                $"SliderValue {_viewModel?.SliderValue}\nStepperValue {_viewModel?.StepperValue}", "OK");

        }
    }

    public class NonTrivialBindingExercise1_ViewModel //: BaseViewModel //Inheritance Step 4, BaseViewModel in namespace MauiExercises.ViewModels
    {        
        public float SliderValue { get; set; }
        public int StepperValue { get; set; }
        
        #region Step 4
        /*
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
        */
        #endregion
    }
}