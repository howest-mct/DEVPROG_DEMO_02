using System;
using System.Collections.Generic;
using System.Text;

namespace DEVPROG_DEMO_02_v2.Models
{
    // 1 make class public
    class Bier
    {
        // 2 voeg kenmerken toe en ga naar slide
        //string naam;
        //string brouwerij;
        //double alcoholpercentage;
        //string kleur;
        // 3 instantieer object
        /* We weten nu wat een klasse is. Maar wat zijn dan objecten? 
            Een object is een instantie van een klasse. Met andere woorden, 
            een object is een mogelijke invulling van een klasse. 
            Je kan nu objecten aanmaken van de klasse die je hebt gedefinieerd. 
            Je doet dit door eerst een variabele te definiëren en vervolgens een object 
            te instantiëren met behulp van het new keyword */


        // 4 maak velden public en ga dan naar 5 in MainPage
        public string naam;
        public string brouwerij;
        public double alcoholpercentage;
        public string kleur;


        //6 CONSTRUCTORS 
        // Wanneer je een het sleutelwoord new gebruikt, geef je de opdracht om een nieuw object
        // of nieuwe instantie te maken van een klasse. Met een constructor in een klasse
        // is het mogelijk velden(of properties : zie verder) van een nieuw object
        // onmiddellijk te initialiseren.Wanneer je geen constructor voorziet in je klasse,
        // dan genereert de compiler een standaardconstructor (default constructor) voor je klasse.
        // Elk veld van de klasse moet nu eenmaal geïnitialiseerd worden.

        // Gezien we in onze klasse Bier nog geen constructor hebben geschreven,
        // werd dus telkens wij een object van het type Bier maakten deze (onzichtbare)
        // standaardconstructor uitgevoerd.

        //7 Maak default constructor
        //public Bier()
        //{
        //    naam = null;
        //    brouwerij = null;
        //    alcoholpercentage = 0;
        //    kleur = null;
        //}


        // Wanneer een nieuw Nier -object gemaakt wordt,
        // worden de naam en het brouwerij op null (standaardwaarde bij declaratie van variabelen van datatype string) geplaatst
        // en de alcoholpercentage op 0 (standaardwaarde bij declaratie van getallen).
        // Dit zal ook zo zijn wanneer we zelf geen (default) constructor voorzien.

        // Dus conclusie:
        // - Een constructor is een methode die wordt uitgevoerd wanneer een nieuwe instantie van de klasse
        //   wordt aangemaakt(new)
        // - Een constructor heeft exact dezelfde naam als de klasse en geen returnwaarde
        // - In elke klasse is minstens 1 constructor aanwezig.
        //   Desnoods wordt die automatisch door de compiler aangemaakt.

        // TIP
        // Voor het aanmaken van een constructor kun je de code-snippet ctor gebruiken.
        // Na ingeven van ctor en 2 x de tab-toets indrukken zorgt voor een
        // automatische aanmaak van een constructor.


        //8 Constructors overloaden
        // Gezien constructors eigenlijk speciale methoden zijn,
        // kunnen we deze net zoals gewone methoden “overloaden” (overladen).
        // Een constructor heeft (en geeft) nooit een returnwaarde.
        // Overloads van een constructor zullen dus enkel verschillen in de parameterlijst.
        //public Bier(string naam) 
        //{
        //    // Opgepast, zowel in de tweede, derde en vierde constructor worden de argumenten
        //    // ontvangen in een variabele met dezelfde naam als een bestaand field.
        //    // Nu moet je het sleutelwoord this gebruiken om te verwijzen naar het field :
        //    this.naam = naam;
        //    // Wanneer we deze aanpassing hebben gedaan kunnen we in de codebehind van ons
        //    // MainPage bij het initialiseren gaan kiezen tussen de constructors die we hebben aangemaakt

        //}
        //public Bier(string name, string brewery, double alcoholPerc, string color)
        //{
        //    this.naam = name;
        //    this.kleur = color;
        //    this.alcoholpercentage = alcoholPerc;
        //    this.brouwerij = brewery;
        //}

        // ga naar 9 in mainpage


        // 10 static fields
        // We kunnen binnen klassen velden static maken.
        // Dit betekent dat dit static field data zal bevatten die hetzelfde is voor
        // elke instantie van de klasse.
        // Een voorbeeld is het bijhouden van het aantal instanties dat voor een klasse gemaakt werd.
        // Declareer een static field met de naam bierCount. 
        public static int bierCount;
        // Een static field van het type int met de naam bierCount werd public gedeclareerd..
        // In de parameterloze constructor zorgen we ervoor dat bierCount met 1 wordt opgehoogd
        // als een Bier object wordt geïnstantieerd.
        // We willen natuurlijk dat dit ook gebeurt wanneer we een andere constructor gebruiken.
        // Hier zou je de opdracht bierCount++; kunnen hernemen.
        // Beter is echter de constructors aan elkaar te ketenen. (constructor-chaining).
        // Dit doen we door vanuit een constructor een andere constructor aan te roepen met behulp van :this()
        // syntax. Waar dit vermeld staat zeggen we eigenlijk dat eerst de defaultconstructor (parameterloos)
        // moet worden uitgevoerd vooraleer de constructor met deze verwijzing wordt uitgevoerd.

        public Bier()
        {
            naam = null;
            brouwerij = null;
            alcoholpercentage = 0;
            kleur = null;
            bierCount++;
            //let op de shorthand operator
        }

        public Bier(string naam) : this()
        {
            // Opgepast, zowel in de tweede, derde en vierde constructor worden de argumenten
            // ontvangen in een variabele met dezelfde naam als een bestaand field.
            // Nu moet je het sleutelwoord this gebruiken om te verwijzen naar het field :
            this.naam = naam;
            // Wanneer we deze aanpassing hebben gedaan kunnen we in de codebehind van ons
            // MainPage bij het initialiseren gaan kiezen tussen de constructors die we hebben aangemaakt

        }

        public Bier(string name, string brewery, double alcoholPerc, string color) : this()
        {
            this.naam = name;
            this.kleur = color;
            this.alcoholpercentage = alcoholPerc;
            this.brouwerij = brewery;
        }

        // De werking ervan kunnen we demonstreren in onze applicatie:
        // ga naar 11 in MainPage


        // 12 static methods
        // Niet alleen fields kunnen static zijn, ook methoden binnen de klasse kunnen static zijn.
        // Willen we bijvoorbeeld het alcoholverschil weten tussen 2 Bier-objecten,
        // dan zouden we dit zonder static methods op volgende manier kunnen oplossen:
        public double Alcoholverschil(Bier someBier)
        {
            return Math.Abs(this.alcoholpercentage - someBier.alcoholpercentage);
        }
        // In de methode Alcoholverschil wordt als parameter (someBier)
        // een object van het type Bier meegegeven. We berekenen het Alcoholverschil (in absolute cijfers)
        // tussen het huidige object en het object dat als parameter werd doorgegeven en retourneren een double-waarde.
        // ga naar 13 in MainPage


        // 14
        public static double Alcoholverschil(Bier b1, Bier b2)
        {
            return Math.Abs(b1.alcoholpercentage - b2.alcoholpercentage);
        }// We overladen hier de methode Alcoholverschil,
         // wat geen probleem is gezien deze nieuwe versie 2 parameters verwacht

        // 15 Pas de code in de  applicatie aan als volgt:
        // ga naar MainPage


        // 17 override TOSTRING
        // Er bestaat in C# echter een mogelijk om de standaard-return tegen te houden
        // en te vervangen door een andere return. Dit doen we via een override.
        // We maken in de classe Bier een methode aan: public override string ToString();
        // - public: ze moet toegankelijk zijn van buiten de class
        // - override: ze vervangt de standaard return van een methode met dezelfde naam.Het is dus geen overload.
        // - string: de return is van het type string
        // In de methode stellen we dan de tekst samen die we willen tonen op basis
        // van één of meerdere velden (of eigenschappen, zie verder). Deze tekst wordt dan geretourneerd.
        public override string ToString()
        {
            return naam + " (" + brouwerij + " - " + alcoholpercentage + ")";
        }
        //Via de override ToString() methode geven we aan dat,
        //wanneer we een object van het type Bier willen afbeelden,
        //we de inhoud van de velden naam en brouwerij zullen tonen.
        //ga terug naar MainPage om item te tonen


        //19 DATA AFSCHERMEN MET EEN METHODE (GETTERS & SETTERS)
        // kan in de klasse Bier het field alcoholpercentage afschermen door het private te maken
        // en een public methode SetAlcoholpercentage te voorzien die voor de controle zorgt.
        // Voorzie volgende wijzigingen in de klasse Bier .
        // We veranderen hier dus het publieke veld(field) Alcoholpercentage in een private veld(field) 
        // voor fre: aandacht!!!! hier werk ik met alcoholpercentage2, in demo niet
        private double alcoholpercentage2;
        public void SetAlcoholpercentage(int alcoholpercentage)
        {
            if (alcoholpercentage < 0)
            {
                this.alcoholpercentage2 = 0;
            }
            else
            {
                this.alcoholpercentage2 = alcoholpercentage;
            }
        }
        // Omdat we nu geen publiek veld (field) alcoholpercentage meer hebben kunnen
        // we de topsnelheid van onze wagen nu enkel nog instellen via de
        // zonet gecreëerde methode SetAlcoholpercentage(). Wanneer de opgegeven alcoholpercentage  die via een argument
        // doorgegeven wordt aan de methode SetAlcoholpercentage kleiner is dan 0, dan stellen we die in op 0.
        // ga naar MainPage en demonstreer 20


        //21
        public double GetAlcoholpercentage() { return alcoholpercentage2; }
        //demonstreer in BIER 22


        // 23 PROPERTIES
        // Een ideale oplossing voor dit probleem vormen properties of eigenschappen:
        // je hebt de afscherming zoals met methoden(de getter en setter van daarnet),
        // maar naar de buitenwereld toe(dus buiten de klasse) kan je de data manipuleren
        // zoals een publiek veld(field).
        // Vervang de methoden GetAlcoholpercentage en SetAlcoholpercentage in de klasse BIER
        // door onderstaande code(of zet beide methoden in commentaar) 
        private double alcoholpercentage3;

        public double Alcoholpercentage3
        {
            get { return alcoholpercentage3; }
            set {
                if (value < 0)
                {
                    this.alcoholpercentage3 = 0;
                }
                else
                {
                    this.alcoholpercentage3 = value;
                }
            }
        }
        //Hier hebben we de eigenschap/property Alcoholpercentage3 gedeclareerd.
        //Het onderdeel get geeft aan wat er gebeurt wanneer de property wordt gelezen.
        //Laat je dit onderdeel weg, dan kan de eigenschap niet uitgelezen worden ;
        //de property is dan write-only.
        //Het onderdeel set geeft aan hoe de eigenschap wordt ingesteld en veranderd.
        //In dit onderdeel kan je gebruik maken van het sleutelwoord value om te verwijzen
        //naar de waarde waarop de property ingesteld zou moeten worden.Laat je dit onderdeel weg,
        //dan kan de eigenschap niet gebruikt worden om een waarde te veranderen;
        //de property is dan read-only.
        //De naam van een privaat veld(field) begint met een kleine letter,
        //die van properties met een Hoofdletter.

        //Opgepast, het private veld (field) alcoholpercentage is hier nog steeds nodig,
        //de property Alcoholpercentage gaat dit (private) field enkel afschermen tegen oneigenlijk gebruik.
        //ga naar MainPage 24


        //25
        //Voor het aanmaken van een dergelijke property kun je de code-snippet
        //propfull gebruiken. Na ingeven van propfull en 2 * de tab-toets indrukken,
        //zorgt die voor een automatische aanmaak van een property met get en set accessor en private field.
        //TIP!!!!!!
        //Vanaf nu gebruik je properties die private fields afschermen.
        // Het is dan ook een goede attitude om, zelfs wanneer je voorlopig
        // geen extra controle of andere bijkomstige code bij een field nodig hebt,
        // elk field toch private te maken en een public property te voorzien:

        //VERKORTE NOTATIE
        //Bij het gebruik van een private field en public property zou men in
        //feite bovenstaande code  moeten schrijven voor elke property van een object.
        //Een beetje omslachtig als er geen controles of manipulaties moeten gebeuren
        //met de property.
        //Sinds C# 3.0 kunnen we bovenstaande code inkorten door volgende code:

        public int Waarde { get; set; }
        // Dit codefragement maakt de property Waarde aan. Intern wordt deze verkorte schrijfwijze
        // vertaald tot het voorbeeld erboven het private field en de get en set-implementatie
        // van de property worden dus automatisch voorzien. Het field waarde (de private variabele dus) is niet zichtbaar.
        // De property kan even eenvoudig worden aangemaakt als een field,
        // maar je beschikt over een property die je later kan uitbreiden zonder de notatie
        // in bestaande code te moeten aanpassen.
        // Starten met een field, en later overschakelen naar een property kan omslachtiger zijn.


        //26 NULLABLE PROPERTIES
        // Soms wensen we NULL toe te kennen aan een property.
        // Bij value-type (int, decimal, DateTime, …) properties is dit standaard niet mogelijk.
        // Neem onderstaand voorbeeld (je hoeft dit in je applicatie niet aan te maken):

        //public class Calendar
        //{
        //    public DateTime Date { get; set; }
        //    public Calendar() // Default constructor
        //            { Date = null; } 
        //    }
        //26 
        // Wensen we de property Date toch nullable te maken,
        // dan kunnen we dit doen door na het datatype (DateTime) een vraagteken (?) te plaatsen:
        public DateTime? Date { get; set; }


        //27 AUTO-PROPERTY INITIALIZER
        // Soms wensen we een property reeds een standaard waarde te geven. Bekijk onderstaand voorbeeld
        //public class PepperoniPizza
        //{
        //    public decimal ExtraPrice { get; set; }
        //    public PepperoniPizza()
        //    {
        //        ExtraPrice = 0.25m;
        //    }
        //}
        // In de constructor van deze klasse initialiseren we de property ExtraPrice
        // met een waarde van 0,25. Dus elk geïnstantieerd object van dezeklasse zal
        // een property ExtraPrice hebben met een waarde van 0,25.
        // Sinds C# 6.0 kunnen we dit in deze verkorte versie schrijven:
        // public class PepperoniPizza { public decimal ExtraPrice { get; set; } = 0.25m; }
        // We kennen automatisch een waarde toe aan de property.
        // We hebben in dit geval de constructor hiervoor dus niet meer nodig.
        // Uiteraard kan je deze eigenschap – omwille van de get en set - via het object nog een
        // andere waarde geven (het is dus GEEN constante of GEEN read-only waarde,
        // het gaat hier enkel om een initiele waardetoekenning).


        //28 XAML
        public static List<Bier> GetBeers()
        {
            return new List<Bier>
                {
                    new Bier("Rodenbach Grand Cru", "Rodenbach", 6, "brown"),
                    new Bier("Jupiler", "InBev", 5.2, "blond"),
                    new Bier("Omer", "Bockor", 8, "blond"),
                    new Bier("Duvel", "Duvel Moortgat", 8.5, "")
                };
        }

        /// <summary>
        /// Get the list of beers back filtered on alcohol percentage.
        /// </summary>
        /// <param name="beers">The full list of beers to be filtered.</param>
        /// <param name="min">The minimum alcohol percentage of the beer.</param>
        /// <param name="max">The maximum alcohol percentage of the beer.</param>
        /// <returns>The filtered list of beers.</returns>
        public static List<Bier> SearchByAlcohol(List<Bier> beers, double min, double max)
        {
            //create empty list to hold filtered beers 
            List<Bier> results = new List<Bier>();

            //loop through each beer in the beers list
            //  (Python: for beer in beers: )
            foreach (Bier beer in beers)
            {
                //check if alcohol percentage of the beer is between boundaries
                if (beer.Alcoholpercentage3 >= min && beer.Alcoholpercentage3 <= max)
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
        public static List<Bier> SearchByName(List<Bier> beers, string searchTerm)
        {
            //create empty list to hold filtered beers 
            List<Bier> results = new List<Bier>();

            //loop through each beer in the beers list
            //  (Python: for beer in beers: )
            foreach (Bier beer in beers)
            {
                //check if the name in lowercase contains the lowercase characters in searchterm 
                if (beer.naam.ToLower().Contains(searchTerm.ToLower()))
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

    

