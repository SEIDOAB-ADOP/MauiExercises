using System.Collections.Generic;
using System.Linq;

namespace MauiExercises.Models
{
    public class City
    {
        public string Name { get; set; }
        public string Continent { get; set; }
        public int Population { get; set; }
        public string ImageSrc { get; set; }
        public override string ToString() => $"Name: {Name} Continent: {Continent} Population: {Population}";

        public static List<City> List => GetList().ToList<City>(); //Doing a ToList forces Linq to execute
        static IEnumerable<City> GetList() //use when doing Group
        {
            var list1 = CityContinent.List.Join(CityPopulation.List, c => c.Name, p => p.Name, 
                (c, p) => new City { Continent = c.Continent, Name = c.Name, 
                    Population = p.Population});

            var list2 = list1.Join(CityPicture.List, c => c.Name, p => p.Name,
                (c, p) => { c.ImageSrc = p.ImageSrc; return c; });

            return list2;
        }
    }
    public class CityContinent
    {
        public string Name { get; set; }
        public string Continent { get; set; }
        public override string ToString() => $"Name: {Name} Continent: {Continent}";

        public static IEnumerable<CityContinent> List => new List<CityContinent>()
            {
                new CityContinent() { Name = "Uppsala", Continent = "Europe", },
                new CityContinent() { Name = "Stockholm", Continent = "Europe"},
                new CityContinent() { Name = "New York", Continent = "North America"},
                new CityContinent() { Name = "Los Angeles", Continent = "North America"},
                new CityContinent() { Name = "Bombay", Continent = "Asia"},
                new CityContinent() { Name = "Bangkok", Continent = "Asia"},
                new CityContinent() { Name = "São Paulo", Continent = "South America"},
                new CityContinent() { Name = "Buenos Aires", Continent = "South America"},
                new CityContinent() { Name = "Tunis", Continent = "Africa"},
                new CityContinent() { Name = "Cape Town", Continent = "Africa"},
                new CityContinent() { Name = "Sydney", Continent = "Oceania"},
                new CityContinent() { Name = "Canberra", Continent = "Oceania"},
            };
    }
    public class CityPopulation
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public override string ToString() => $"Name: {Name} Population: {Population}";

        public static IEnumerable<CityPopulation> List => new List<CityPopulation>
            {
                new CityPopulation() { Name = "Uppsala", Population = 164_535},
                new CityPopulation() { Name = "Stockholm", Population = 975_551},
                new CityPopulation() { Name = "New York", Population = 8_200_000},
                new CityPopulation() { Name = "Los Angeles", Population = 3_990_000 },
                new CityPopulation() { Name = "Bombay", Population = 18_410_000},
                new CityPopulation() { Name = "Bangkok", Population = 8_300_000 },
                new CityPopulation() { Name = "São Paulo", Population = 12_330_000},
                new CityPopulation() { Name = "Buenos Aires", Population = 2_900_000},
                new CityPopulation() { Name = "Tunis", Population = 638_845},
                new CityPopulation() { Name = "Cape Town", Population = 3_700_000},
                new CityPopulation() { Name = "Sydney", Population = 5_312_000},
                new CityPopulation() { Name = "Canberra", Population = 395_790},
            };
    }
    public class CityPicture
    {
        public string Name { get; set; }
        public string ImageSrc { get; set; }

        public override string ToString() => $"Name: {Name} Picture: {ImageSrc}";

        public static IEnumerable<CityPicture> List => new List<CityPicture>()
            {
                new CityPicture() { Name = "Uppsala", ImageSrc = "uppsala.jpg"},
                new CityPicture() { Name = "Stockholm", ImageSrc = "stockholm.jpg"},
                new CityPicture() { Name = "New York", ImageSrc = "newyork.jpg"},
                new CityPicture() { Name = "Los Angeles", ImageSrc = "losangeles.jpg"},
                new CityPicture() { Name = "Bombay", ImageSrc = "bombay.jpg"},
                new CityPicture() { Name = "Bangkok", ImageSrc = "bangkok.jpg"},
                new CityPicture() { Name = "São Paulo", ImageSrc = "saopaulo.jpg"},
                new CityPicture() { Name = "Buenos Aires", ImageSrc = "buenosaires.jpg"},
                new CityPicture() { Name = "Tunis", ImageSrc = "tunis.jpg"},
                new CityPicture() { Name = "Cape Town", ImageSrc = "capetown.jpg"},
                new CityPicture() { Name = "Sydney", ImageSrc = "sydney.jpg"},
                new CityPicture() { Name = "Canberra", ImageSrc = "canberra.jpg"},
            };
    }
}
