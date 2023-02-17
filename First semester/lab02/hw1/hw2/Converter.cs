using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw2
{
    public class Converter
    {
        public Converter(double usd, double eur, double rub)
        {
            _usd = usd;
            _eur = eur;
            _rub = rub;
        }
        
        private double _usd;
        private double _eur;
        private double _rub;
        
        private void Checker(string message , bool fork, int value)
        {
            Console.WriteLine("what currency do you want  to " + message + " usd/eur/rub ");
            string choise = Console.ReadLine().ToLower();
            switch (choise)
            {
                case "usd":
                    if (fork)
                    {
                        Console.WriteLine($"your result from USD to UAH  = {_usd * value}");
                        break;
                    }

                    Console.WriteLine($"your result from USD to UAH  = {value/_usd}");
                    break;

                case "eur":
                    if (fork)
                    {
                        Console.WriteLine($"your result from USD to UAH  = {_eur * value}");
                        break;
                    }

                    Console.WriteLine($"your result from USD to UAH  = {value / _eur}");
                    break;

                case "rub":
                    if (fork)
                    {
                        Console.WriteLine($"your result from USD to UAH  = {_rub * value}");
                        break;
                    }

                    Console.WriteLine($"your result from USD to UAH  = {value / _rub}");
                    break;

                default:
                    throw new Exception("wrong currency");

            }
        }

        public void ConvertToUah(int Yourcurency)
        {
            Checker("Echenge" , true , Yourcurency) ;

        }

        public void ConvertFromUah(int Yourcurency)
        {
            Checker("Get", false , Yourcurency);

        }
    }
}
