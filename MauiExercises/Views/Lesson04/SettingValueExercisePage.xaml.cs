using MauiExercises.Models;

namespace MauiExercises.Views.Lesson04
{
    public partial class SelectingValueExercisePage : ContentPage
    {
        public SelectingValueExercisePage()
        {
            InitializeComponent();
            picker.ItemsSource = Friend.Factory.CreateRandom(10);
        }
        private void checkbox_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "IsChecked") return;
            if (lblPropChanged == null) return;

            var s = (CheckBox)sender;
            lblPropChanged.Text = $"CheckBox PropertyChanged: {s.IsChecked}";
        }

        private void slider_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "Value") return;
            if (lblPropChanged == null) return;

            var s = (Slider)sender;
            lblPropChanged.Text = $"Slider PropertyChanged: {s.Value}";
        }

        private void stepper_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "Value") return;
            if (lblPropChanged == null) return;

            var s = (Stepper)sender;
            lblPropChanged.Text = $"Stepper PropertyChanged: {s.Value}";
        }

        private void switch_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "IsToggled") return;
            if (lblPropChanged == null) return;

            var s = (Switch)sender;
            lblPropChanged.Text = $"Switch PropertyChanged: {s.IsToggled}";
        }

        private void DatePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "Date") return;
            if (lblPropChanged == null) return;

            var s = (DatePicker)sender;
            lblPropChanged.Text = $"DatePicker PropertyChanged: {s.Date}";
        }

        private void TimePicker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "Time") return;
            if (lblPropChanged == null) return;

            var s = (TimePicker)sender;
            lblPropChanged.Text = $"TimePicker PropertyChanged: {s.Time}";
        }

        private void picker_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var s = (Picker)sender;
            if (s.SelectedIndex == -1) return;

            lblOtherChanged.Text = $"Picker SelectedIndexChanged: {s.SelectedItem}";
            bwPropChanged.Color = ((Friend)s.ItemsSource[s.SelectedIndex]).FavoriteColor.Color;
        }

        private void picker_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if (e.PropertyName != "SelectedIndex") return;
            if (lblPropChanged == null) return;

            var s = (Picker)sender;
            lblPropChanged.Text = $"Picker PropertyChanged: {s.SelectedIndex}";
        }
    }
}
