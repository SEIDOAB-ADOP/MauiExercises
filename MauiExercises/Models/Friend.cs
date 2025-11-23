using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiExercises.Models
{
    public class Friend
    {
        public string FirstName { set; get; }
        public string LastName { set; get; }
        public string FullName => $"{FirstName} {LastName}";

        public DateTime Birthday { get; set; }
        public NamedColor FavoriteColor { get; set; }

        public override string ToString() => $"{FirstName} {LastName} was born {Birthday:d}. Favorite color is {FavoriteColor.FriendlyName}";

        public static class Factory
        {
            public static Friend CreateRandom()
            {
                var rnd = new Random();

                var _fnames = "Harry, Lord, Hermione, Albus, Severus, Ron, Draco, Frodo, Gandalf, Sam, Peregrin, Saruman".Split(", ");
                var _lnames = "Potter, Voldemort, Granger, Dumbledore, Snape, Malfoy, Baggins, the Gray, Gamgee, Took, the White".Split(", ");
                var _favoritecolor = NamedColor.All.ToList();

                DateTime _birthday = default;
                bool _dateOK;
                do
                {
                    int _year = rnd.Next(1960, DateTime.Now.Year - 10);
                    int _month = rnd.Next(1, 13);
                    int _day = rnd.Next(1, 32);

                    try
                    {
                        _birthday = new DateTime(_year, _month, _day);
                        _dateOK = true;

                    }
                    catch
                    {
                        _dateOK = false;
                    }
                } while (!_dateOK);

                return new Friend
                {
                    FirstName = _fnames[rnd.Next(0, _fnames.Length)],
                    LastName = _lnames[rnd.Next(0, _lnames.Length)],
                    Birthday = _birthday,
                    FavoriteColor = _favoritecolor[rnd.Next(0, _favoritecolor.Count)]
                };
            }
            public static List<Friend> CreateRandom(int NrOfItems)
            {
                var friends = new List<Friend>();
                for (int i = 0; i < NrOfItems; i++)
                {
                    friends.Add(Friend.Factory.CreateRandom());
                }
                return friends;
            }
        }
    }
}
