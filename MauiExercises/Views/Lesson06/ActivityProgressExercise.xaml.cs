using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MauiExercises.Models;
using MauiExercises.Services;

namespace MauiExercises.Views.Lesson06
{
    public partial class ActivityProgressExercise : ContentPage
    {
        PrimeNumberService service = new PrimeNumberService();

        public ActivityProgressExercise()
        {
            InitializeComponent();
        }
        public ActivityProgressExercise(int NrBatches) : this()
        {
            enNrBatches.Text = NrBatches.ToString();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            //Code here will run right before the screen appears
            //You want to set the Title or set the City

            //This is making the first load of data
            MainThread.BeginInvokeOnMainThread(async () => { await LoadPrimes(); });
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await LoadPrimes();
        }
        private async Task LoadPrimes()
        {
            if (!int.TryParse(enNrBatches.Text, out int result)) return;
            int nrbatches = result;

            var progressReporter = new Progress<float>(async value =>
            {
                //Ex1. Code here to set the progressBars to new values
            });


            //Ex1. Code here to initialize the progressBars values

            //Ex2. Code here to make indikators visible or not
 
            //The the new primes values and assign them to the ListView
            lvPrimes.ItemsSource = await service.GetPrimeBatchCountsAsync(nrbatches, progressReporter);

            //Ex2. Code here to make indikators visible or not
        }

        //Ex3. Code here to implement the ItemTapped event handler
    }
}