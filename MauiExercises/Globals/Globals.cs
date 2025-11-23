using MauiExercises.Models;

namespace MauiExercises.Globals
{
    public class Global

    {
        #region Lazy implementation
        Global() { } // just to avoid any direct instantiations

        private static Lazy<Global> _instance = new Lazy<Global>(() => new Global());
        public static Global Data => _instance.Value;
        #endregion

        #region Data implementation 
        // accessible as GlobalData.Data.xx 
        public string Message { get; set; }
        public DateTime Time { get; set; }

        //Exercise:
        // Add properties so Global.Data contain a list of Friend,
        // a list of City, and a list on NamedColor
        #endregion
    }
}
