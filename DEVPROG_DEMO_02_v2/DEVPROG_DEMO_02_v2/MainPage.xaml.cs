using DEVPROG_DEMO_02_v2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DEVPROG_DEMO_02_v2
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();


            // 3 instantieer object
            /* We weten nu wat een klasse is. Maar wat zijn dan objecten? 
                Een object is een instantie van een klasse. Met andere woorden, 
                een object is een mogelijke invulling van een klasse. 
                Je kan nu objecten aanmaken van de klasse die je hebt gedefinieerd. 
                Je doet dit door eerst een variabele te definiëren en vervolgens een object 
                te instantiëren met behulp van het new keyword */
            Bier b1 = new Bier();
            //Bier is een klasse
            //b1 = een instantie van een object
            //b2 =  een object
            //Bier() betekent dat we de constructor aanroepen vanuit de klasse

            // Wanneer we een nieuw object van de klasse Bier willen maken dat b2 moet heten,
            // doen we dit als volgt:
            Bier b2 = new Bier();

            // we hebben nu twee objecten van het type Bier

            // 4 vul properties in Merk op dat je niet kan benaderen
            // b1.naam = "Augustijn";
            // Onze klasse Bier was private : als er niets voor het sleutelwoord class staat, dan is deze impliciet private.
            // We kunnen deze klasse enkel gebruiken binnen zijn eigen namespace (hier dus ...Models)
            // Om dit op te lossen maken we de klasse Bier en zijn members (in dit geval fields/velden) public.
            // Maak de klasse Bier public en pas de code als volgt aan:
            b1.naam = "Augustijn";
            b1.brouwerij = "Bios";
            b1.alcoholpercentage = 12.0;
            b1.kleur = "Amber";

            // 5 print het object in debug venster
            // aandacht op namespace van debug!!
            // RUN
            // .NET zal nu een stukje geheugen reserveren voor alle members van het nieuwe object.
            // Onder members verstaan we alle eventuele fields, methoden
            // maar – wat we verder in dit hoofdstuk gaan zien – ook properties en
            // constructors van de betrokken klasse.
            Debug.WriteLine($"{b1.naam} {b1.brouwerij} - {b1.alcoholpercentage}");

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
            // ga naar Bier.Cs


            // 9 nieuw object toevoegen
            b2 = new Bier("Jupiler", "", 3.3, "blond");
            Debug.WriteLine($"{b2.naam} {b2.brouwerij} - {b2.alcoholpercentage}");
            // ga naar 10 in Bier.cs            


            // 11 nieuwe object toevoegen om biercount te tonen
            Bier b3 = new Bier("Omer", "Omer Vander Ghinste", 8, "blond");
            Debug.WriteLine($"{b3.naam} {b3.brouwerij} - {b3.alcoholpercentage}");
            Debug.WriteLine($"We hebben nu {Bier.bierCount} bieren");
            // We verwijzen hier niet naar een Bier variabele (b1, b2 of b3) maar naar de klasse Bier.
            // Dit omdat het static field (bierCOunt) door alle Bier-objecten wordt gedeeld!

            //12 ga naar Bier

            //13 
            double alcoholVerschil = b1.Alcoholverschil(b3);
            Debug.WriteLine($"Alcoholverschil tussen {b3.alcoholpercentage} en {b1.alcoholpercentage} is {alcoholVerschil}");
            //14
            // Een andere manier is gebruik maken van static Methods.
            // Die zorgen ervoor dat we niet steeds een instantie nodig hebben om vertrekkende
            // vanuit deze instantie een methode aan te roepen.
            // Pas de code in de klasse Bier aan als volgt:
            // ga naar Bier

            // 15
            double alcoholVerschil2 = Bier.Alcoholverschil(b1, b3);
            Debug.WriteLine($"Alcoholverschil tussen {b3.alcoholpercentage} en {b1.alcoholpercentage} is {alcoholVerschil2}");
            // In de praktijk gebruik je statische methoden niet vaak zoals in het voorbeeld
            // dat hierboven uiteen werd gezet. Je zal eerder klassen tegen komen (of zelf maken)
            // die uit niets anders bestaan dan statische methoden.
            // Bekijk even de .Net klasse die we zopas al even gebruikten 
            // namelijk de klasse Math. Van deze klasse is het zelfs niet mogelijk om een instantie aan te maken :
            //Math math = new Math();
            // Deze klasse biedt alleen een hele batterij aan functionaliteiten
            // aan (statische methoden) die dan ook rechtstreeks aanspreekbaar zijn


            // 16 we willen nu het printen van object makkelijker maken, hoe gaan we dat doen.
            // tonen hoe een default tostring function werkt
            Debug.WriteLine(b1.ToString());
            // ga naar 17 in Bier.cs



            //18 PROPERTIES
            //stel
            Bier b4 = new Bier("Stella", "InBev", -5.2, "Blond");
            b4.ToString();
            //Uiteraard willen we niet werken met een negatiev alcoholpercentage.
            //In deze context kunnen we negatieve waarden dan ook niet toestaan.
            //Door het gebruik van data encapsulation kunnen we dit voorkomen.
            //Er bestaan verschillende manieren om onze data af te schermen of
            //ervoor te zorgen dat onze data niet verkeerdelijk gebruikt wordt.
            //We bespreken enkele mogelijkheden, de één al wat omslachtiger dan de andere.
            // ga naar 19 Bier


            //20
            // Om in onze console applicatie de alcoholpercentage in te stellen
            // van een bier object passen we volgende code aan:
            Bier b5 = new Bier();
            b5.naam = "Augustijn";
            b5.brouwerij = "Bios";
            b5.alcoholpercentage = 12.0; // zal error geven
            b5.kleur = "Amber";
            b5.SetAlcoholpercentage(-5);
            //We stellen nu de alcoholpercentage in via de methode SetAlcoholpercentage.
            //We hebben nog altijd één compileerfout; omdat het field alcoholpercentage private is
            //kunnen we dit ook niet meer opvragen.
            //Omdat het veld(field) alcoholpercentage nu privaat is kan het ook niet meer
            //zomaar gelezen worden van buiten de klasse. Voorzie daarom de methode GetAlcoholpercentage() in de klasse Bier
            //ga naar Bier, 21

            //22
            //Debug.WriteLine($"{b5.naam} {b5.brouwerij} - {b5.alcoholpercentage2}");
            Debug.WriteLine($"{b5.naam} {b5.brouwerij} - {b5.GetAlcoholpercentage()}");
            //• Werken met public fields kan leiden tot een verkeerd gebruik van data
            //• Werken met private velden en publieke getter- en settermethoden kan dit probleem oplossen
            //• De oplossing met deze methoden is wel een beetje omslachtig:
            //  o Je moet voor elk(privaat) field twee methoden toevoegen
            //  o Om een waarde op te vragen moet je steeds een methodeaanroep uitvoeren:
            //      ▪ b5.alcoholpercentage was eigenlijk toch gemakkelijker dan b5.GetAlcoholpercentage()
            //  o Om een waarde aan te passen, moet je ook een methodeaanroep doen:
            //      b5.alcoholpercentage = -12; werd b5.SetAlcoholpercentage(-12);

            //ga naar bier 23, PROPERTIES

            //24 demo prop
            Bier b6 = new Bier();
            b6.naam = "Augustijn";
            b6.brouwerij = "Bios";
            b6.Alcoholpercentage3 = -12.0; // zal error geven
            b6.kleur = "Amber";
            Debug.WriteLine($"{b6.naam} {b6.brouwerij} - {b6.Alcoholpercentage3}");
            //Voor het aanmaken van een dergelijke property kun je de code-snippet
            //propfull gebruiken. Na ingeven van propfull en 2 * de tab-toets indrukken,
            //zorgt die voor een automatische aanmaak van een property met get en set accessor en private field.
            //TIP!!!!!!
            //Vanaf nu gebruik je properties die private fields afschermen.
            // Het is dan ook een goede attitude om, zelfs wanneer je voorlopig
            // geen extra controle of andere bijkomstige code bij een field nodig hebt,
            // elk field toch private te maken en een public property te voorzien:
            //ga naar Beer 25
        }
    }
}
