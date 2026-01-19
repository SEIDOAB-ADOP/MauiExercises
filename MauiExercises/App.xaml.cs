using MauiExercises.Globals;

namespace MauiExercises
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState activationState)
        {
            return new Window(new AppShell());
        }

        protected override void OnStart()
        {
            //Demonstrate State management
            //using Global variables
            Global.Data.Message = "Application Started";
            Global.Data.Time = DateTime.Now;
        }
    }
}