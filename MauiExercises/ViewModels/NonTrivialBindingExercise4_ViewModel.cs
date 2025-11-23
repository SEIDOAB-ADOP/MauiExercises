using MauiExercises.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace MauiExercises.ViewModels
{
	public class NonTrivialBindingExercise4_ViewModel : BaseViewModel
	{

		private int _cityIdx = 0;
		private List<City> _cities = City.List;
		
		
		private City _shownCity;
        public City ShownCity { get => _shownCity; set => Set<City>(ref _shownCity, value, "ShownCity"); }


		ICommand _next;
		public ICommand Next => _next ?? (_next =
            new Command(() =>
            {
                _cityIdx++;
                if (_cityIdx >= City.List.Count)
					_cityIdx = 0;

                ShownCity = _cities[_cityIdx];                
            }));

        ICommand _prev;
        public ICommand Prev => _prev ?? (_prev =
            new Command(() =>
            {
                _cityIdx--;
                if (_cityIdx < 0)
                    _cityIdx = City.List.Count-1;

                ShownCity = _cities[_cityIdx];
            }));

        public NonTrivialBindingExercise4_ViewModel()
        {
            ShownCity = _cities[_cityIdx];
        }
	}
}
