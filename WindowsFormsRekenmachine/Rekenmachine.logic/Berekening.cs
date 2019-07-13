using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekenmachineLogic
{
    public class Berekening
    {

        private string _formule;

        public Berekening(string formule)
        {
            _formule = formule;
        }

        public static double Bewerking(double getal1, double getal2, char teken)
        {
            double uitkomst = 0;


            if (teken == '*')
            {
                uitkomst = getal1 * getal2;
            }
            else if (teken == '/')
            {
                uitkomst = getal1 / getal2;
            }
            else if (teken == '+')
            {
                uitkomst = getal1 + getal2;
            }

            else if (teken == '-')
            {
                uitkomst = getal1 - getal2;
            }

            return uitkomst;
        }

        public static bool IsOperator(char letter)
        {
            if (letter == '+' || letter == '-' || letter == '*' || letter == '/')
            {
                return false;
            }

            return true;
        }


        public static string Bewerkingen(string input)
        {


            if (input.Contains('/') && input.Contains('*'))
            {
                int indexDeling = input.IndexOf('/');
                int indexMaal = input.IndexOf('*');
                if (indexMaal > indexDeling)
                {
                    input = Bewerkingen(input, '/');
                }
                else
                {
                    input = Bewerkingen(input, '*');
                }

            }

            input = Bewerkingen(input, '*');
            input = Bewerkingen(input, '/');
            input = Bewerkingen(input, '+');
            input = Bewerkingen(input, '-');

            return input;
        }

        public static string Bewerkingen(string input, char teken)
        {
            string bewerking = input;
            int index = bewerking.IndexOf(teken);

            double totaal;

            double totaal1 = 0;
            while (index > -1)
            {
                int indexOperator1 = bewerking.IndexOf(teken);
                int eerstePositieCijfer1 = indexOperator1 - 1;

                while (eerstePositieCijfer1 > -1 && IsOperator(bewerking[eerstePositieCijfer1]))
                {
                    eerstePositieCijfer1--;
                }

                eerstePositieCijfer1++;

                string getal1 = bewerking.Substring(eerstePositieCijfer1, bewerking.IndexOf(teken) - eerstePositieCijfer1);
                double intgetal1 = double.Parse(getal1);

                int indexOperator = bewerking.IndexOf(teken);
                int laatstePositieCijfer = indexOperator + 1;

                while (laatstePositieCijfer < bewerking.Length && IsOperator(bewerking[laatstePositieCijfer]))
                {
                    laatstePositieCijfer++;
                }
                laatstePositieCijfer--;

                string getal2 = bewerking.Substring(indexOperator + 1, laatstePositieCijfer - indexOperator);
                double intgetal2 = double.Parse(getal2);

                totaal = Bewerking(intgetal1, intgetal2, teken);
                double stringtotaal = totaal;
                string stotaal = stringtotaal.ToString();

                string tekst = bewerking;

                bewerking = bewerking.Replace(getal1 + teken + getal2, stotaal);

                index = bewerking.IndexOf(teken);
                totaal1 = totaal;
            }
            return bewerking;
        }

        public string Main()
        {

            string resultaat = Bewerkingen(_formule);
            return resultaat;

        }

    }
}
