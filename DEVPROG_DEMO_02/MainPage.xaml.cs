using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

//make beer class accessible 
using DEVPROG_DEMO_02.Model;

//make Debug.WriteLine possible to write to output
using System.Diagnostics;


namespace DEVPROG_DEMO_02
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CreateBeer();   //call the method on creation
            LoadAllBeers();
        }

        /// <summary>
        /// Creates a single beer instance and writes it to the output window.
        /// </summary>
        private void CreateBeer()
        {
            //-> do not forget the extra using statement to make Beer class accessible 
            Beer omer = new Beer("Omer", "Bockor", 8, "blond");

            //-> do not forget the extra using statement to make Debug accessible
            //writes the entire beer object to the output window
            //=> calls/shows the ToString function of the beer object
            Debug.WriteLine(omer);

            ShowDetails(omer);  //show details in GUI
        }


        /// <summary>
        /// Shows the details of this beer object in the associated labels in the GUI (see: MainPage.xaml).
        /// </summary>
        /// <param name="beer">The beer object whose details you wish to show.</param>
        private void ShowDetails(Beer beer)
        {
            //take the value of the name property,
            //  and show it in the text part of the label lblName
            lblName.Text = beer.Name;
            lblBrewery.Text = beer.Brewery;
            lblColor.Text = beer.Color;

            //The text property only allows string objects, therefore
            //  the alcohol percentage (type double) must be converted to a string
            lblAlcohol.Text = beer.Alcohol.ToString();
        }


        /// <summary>
        /// Uses the static GetBeers method of the Beer class to:
        /// - get a hard coded list of beers
        /// - print the beers in the list to the output window
        /// </summary>
        private void LoadAllBeers()
        {
            //call static method GetBeers of Beer class
            List<Beer> allBeers = Beer.GetBeers();


            //Show all beers in listview using ItemSource property
            lstBeers.ItemsSource = allBeers;
            //print all beers to output window using PrintBeers method
            PrintBeers(allBeers);
        }

        /// <summary>
        /// Prints all beers in a given list of beers one by one to the output window.
        /// </summary>
        /// <param name="beers">List of beers to be printed.</param>
        private void PrintBeers(List<Beer> beerlist)
        {
            //loop through all Beer objects in beerlist
            foreach (Beer beer in beerlist)
            {
                //create spaces for variables using {x}
                //-> add the actual variables to the string format
                //-> the order is associated with the index mentioned between {}
                Debug.WriteLine("* {0} -> alcohol percentage: {1}", beer, beer.Alcohol);
            }
        }

    }
}
