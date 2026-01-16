using MauiExercises.Models;

namespace MauiExercises.Globals
{
    public class Global

    {
        #region singleton implementation
        private static Global _instance = null;
        Global() { } // just to avoid any direct instantiations
        public static Global Data => (_instance == null) ? _instance = new Global() : _instance;
        #endregion

        #region Data implementation 
        // accessible as Global.Message and Global.Time 
        public string Message { get; set; }
        public DateTime Time { get; set; }
        #endregion

        #region Lazy Data implementation 

        //Exercise:
        // Add properties so Global.Data contain a list of Friend,
        // a list of City, and a list on NamedColor

        #endregion
    }
}
