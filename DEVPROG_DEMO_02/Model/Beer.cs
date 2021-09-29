using System;
using System.Collections.Generic;
using System.Text;

namespace DEVPROG_DEMO_02.Model
{
    //make class public
    public class Beer
    {
        //1. PROPERTIES
        //public string Name { get; set; } //: Simple property "prop"

        //Simple property alternative "propfull":
        private string _name;

        public string Name
        {
            get { return _name; }
            set {
                if (value != "")
                {
                    _name = value.ToUpper();
                }
                else { 
                    _name = "unknown";
                }
            }
        }

        public string Brewery { get; private set; } //Readonly property

        public double Alcohol { get; set; } //required type double

        //Extra logic in set using "propfull"
        private string _color;

        public string Color
        {
            get { return _color; }
            set
            {
                if (value != "")
                {
                    this._color = value;
                }
                else
                {
                    this._color = "unknown";
                }
            }
        }


        //2. CONSTRUCTORS

        //each parameter has an explicit type
        public Beer(string name, string brewery, double alcoholPerc, string color)
        {
            this.Name = name;
            this.Color = color;
            this.Alcohol = alcoholPerc;
            this.Brewery = brewery;
        }

        //3. METHODS

        //default ToString (Python: def __str__(self): )
        public override string ToString()
        {
            return Name + " (" + Brewery + ")";
        }

        /// <summary>
        /// Get a hard coded list of beer objects
        /// </summary>
        /// <returns>the list of beer objects</returns>
        public static List<Beer> GetBeers()
        {
            return new List<Beer>
                {
                    new Beer("Rodenbach Grand Cru", "Rodenbach", 6, "brown"),
                    new Beer("Jupiler", "InBev", 5.2, "blond"),
                    new Beer("Omer", "Bockor", 8, "blond"),
                    new Beer("Duvel", "Duvel Moortgat", 8.5, "")
                };
        }


        /// <summary>
        /// Get the list of beers back filtered on alcohol percentage.
        /// </summary>
        /// <param name="beers">The full list of beers to be filtered.</param>
        /// <param name="min">The minimum alcohol percentage of the beer.</param>
        /// <param name="max">The maximum alcohol percentage of the beer.</param>
        /// <returns>The filtered list of beers.</returns>
        public static List<Beer> SearchByAlcohol(List<Beer> beers, double min, double max)
        {
            //create empty list to hold filtered beers 
            List<Beer> results = new List<Beer>();

            //loop through each beer in the beers list
            //  (Python: for beer in beers: )
            foreach (Beer beer in beers)
            {
                //check if alcohol percentage of the beer is between boundaries
                if (beer.Alcohol >= min && beer.Alcohol <= max)
                {
                    //if so, add the beer to the list of results
                    results.Add(beer);
                }
            }

            //return the list of results
            return results;
        }

        /// <summary>
        /// Get the list of beers back filtered on (part of the) name.
        /// </summary>
        /// <param name="beers">Full list of beers to be filtered.</param>
        /// <param name="searchTerm">(Part of) the name of the beer(s) to search for</param>
        /// <returns></returns>
        public static List<Beer> SearchByName(List<Beer> beers, string searchTerm)
        {
            //create empty list to hold filtered beers 
            List<Beer> results = new List<Beer>();

            //loop through each beer in the beers list
            //  (Python: for beer in beers: )
            foreach (Beer beer in beers)
            {
                //check if the name in lowercase contains the lowercase characters in searchterm 
                if (beer.Name.ToLower().Contains(searchTerm.ToLower()))
                {
                    //if so, add the beer to the list of results
                    results.Add(beer);
                }
            }

            //return the list of results
            return results;
        }


    }
}
