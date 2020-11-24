using System;

namespace Nova_pasta__2_
{
    class Program
    {
        static void Main(string[] args)
        {
            {          
            Console.WriteLine("Deseja abastecer com Gasolina [G] ou Álcool [A] ?");
            string combustivel = Console.ReadLine();
            Console.WriteLine("");
            Console.WriteLine("Quer quantos litros?");     
            int litro = int.Parse(Console.ReadLine());

            double gasolina1 ( double litro)
            { double ga =  5.3 - 0.2;
              double total = ga * litro;
              return total;
            }
            double gasolina2 ( double litro)
            {   double ga = 5.2 - 0.31;
                double total = ga * litro;
                return total;
            }
            double alcool1 ( double litro)
            {   double al = 4.9 * litro * 0.97;
                return al;
            }
            double alcool2 ( double litro)
            {   double al = 4.9 * litro * 0.95;
                return al;
            }

            Console.WriteLine("");    
              switch(combustivel)
              {   case "G":
                  if( litro <= 20)
                  { Console.WriteLine($"Usando o desconto ficou {gasolina1(litro)}");
                  } else if ( litro > 20)
                  {
                      Console.WriteLine($"Usando o desconto ficou {gasolina2(litro)}");
                  }break;

                  case "A":
                  if( litro <= 20)
                  { Console.WriteLine($"Usando o desconto ficou {alcool1(litro)}");}
                    else if ( litro > 20)
                  { Console.WriteLine($"Usando o desconto ficou {alcool2(litro)}");}
                  break;
                  }
            }
        }
    }
}
    


