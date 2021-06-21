using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetRidOfPolishCharacters
{
    class Program
    {
        private static string GetRidOfPolishChars(string givenSentence)
        {
            var sb = new StringBuilder();
            foreach(char c in givenSentence)
            {
                switch(c)
                {
                    case ('ą'):
                        sb.Append('a');
                        break;
                    case ('Ą'):
                        sb.Append('A');
                        break;
                    case ('ć'):
                        sb.Append('c');
                        break;
                    case ('Ć'):
                        sb.Append('C');
                        break;
                    case ('ę'):
                        sb.Append('e');
                        break;
                    case ('Ę'):
                        sb.Append('E');
                        break;
                    case ('ł'):
                        sb.Append('l');
                        break;
                    case ('Ł'):
                        sb.Append('L');
                        break;
                    case ('ń'):
                        sb.Append('n');
                        break;
                    case ('Ń'):
                        sb.Append('N');
                        break;
                    case ('ó'):
                        sb.Append('o');
                        break;
                    case ('Ó'):
                        sb.Append('O');
                        break;
                    case ('ś'):
                        sb.Append('s');
                        break;
                    case ('Ś'):
                        sb.Append('S');
                        break;
                    case ('ź'):
                        sb.Append('z');
                        break;
                    case ('Ź'):
                        sb.Append('Z');
                        break;
                    case ('ż'):
                        sb.Append('z');
                        break;
                    case ('Ż'):
                        sb.Append('Z');
                        break;
                    default:
                        sb.Append(c);
                        break;
                }                  
            }      

            return sb.ToString();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\nCześć, wpisz zdanie, a pozbędę się z niego polskich znaków.\n");
            string sentence = Console.ReadLine();
            Console.WriteLine(GetRidOfPolishChars(sentence));
        }
    }
}
