using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int number1;
             int number2;
             int number3;
             Console.WriteLine("Enter number from 1-10 :");
             number1 =Int32.Parse( Console.ReadLine());

             Console.WriteLine("Enter number from 1-10 :");
             number2 =Int32.Parse ( Console.ReadLine());

             Console.WriteLine("Enter number from 1-10 :");
             number3 =Int32.Parse( Console.ReadLine());

             if (number1 > number2 && number1 > number3)
             {
                 Console.WriteLine($"{number1} on suurim ");

             }

             else if (number2 > number1 && number2 > number3)
             {
                 Console.WriteLine($"{number2} on suurim ");

             }
             else if (number3 > number1 && number3 > number2)
             {
                 Console.WriteLine($"{number3} on suurim ");

             }


             Console.ReadLine(); */


            //Random number generator
            /* int userNumber;
             Console.WriteLine($"Choose your number from 1-6 ");
             userNumber = Int32.Parse(Console.ReadLine());

             Console.WriteLine("Console choose your number");
             Console.ReadLine();  //siis saab klahvi vajutust, ei tule kogu info valja

             Random randomGenerator = new Random();
              int randomNumber = randomGenerator.Next(1,7); //1 on kaasaarvatud ja 7 tähendab 6 kaasaarvatud!
              Console.WriteLine(randomNumber);

             if (userNumber > randomNumber)
             {
                 Console.WriteLine("User you are winner!");

             }
             else if (userNumber < randomNumber)
             {
                 Console.WriteLine("User you are looser!");
             }
             else
             {

                 Console.WriteLine("Congrats! You are both winners!");
             }



              Console.ReadLine(); */

            /*  int userRoll;
              int cpuRoll;
              int rolls = 0; //katsete arv
              int userScore = 0;
              int cpuScore = 0;
              Random rnd = new Random(); //objekt mis genereerib juhusliku numbri


              while (rolls < 3) //3 näitab et toimub 3 tegevust et välju kui 3 on tehtud ehk 0,1,2 on tehtud va 3
              {
                  userRoll = rnd.Next(1, 7); //user viskab 1-6
                  cpuRoll = rnd.Next(1, 7); //arvuti viskab 1-6

                  Console.WriteLine($"You rolled {userRoll}, CPU rolled {cpuRoll}");

                  if (userRoll > cpuRoll)

                  {
                      //userScore = userScore + 1; // sama mis järgmine
                      userScore++; // see tähendab userScore +1 punkt (saab punktui võidu eest)


                  }

                  else if (userRoll < cpuRoll)
                  {

                      cpuScore++; //kui cpu võidab siis ta saab 1punkti
                  }

                  else
                  {
                      continue; //kood jookseb edasi hakkab uuesti kui viik on
                  }

                  rolls++; //loeb punkte
                  Console.ReadLine();
              }

              if (userScore > cpuScore) // kui kasutaja sai rohkem punkte
              {
                  Console.WriteLine("Congratulations! You won!");
              }

              else if (userScore < cpuScore) // kui kasutaja sai vähem punkte
              {
                  Console.WriteLine("Oops, you lost. Try again!");
              }
                  else
              {
                  Console.WriteLine("Tie. Nobody wins or loses");
              }

              Console.WriteLine($"You scored {userScore}, CPU scored {cpuScore}");


              Console.ReadLine();*/


            /*  Random rnd = new Random();
              int randomNumber = rnd.Next(1, 6); // 1-5 vahemik
              Console.WriteLine($"CPU generated {randomNumber}");

              switch(randomNumber)
              {
                  case 1: //esimene vastus oli 1
                      Console.WriteLine("One");
                      break; //välju! peab kindlasti väljuma
                  case 2: //teine vastus
                      Console.WriteLine("Two");
                      break;
                  case 3:
                      Console.WriteLine("Three");
                      break;
                  case 4:
                      Console.WriteLine("Four");
                      break;
                  case 5:
                      Console.WriteLine("Five");
                      break;

                  default: //vaikimisi, kui mitte midagi nt ei genereerita
                      Console.WriteLine("CPU generated nothing");
                      break;
              }

              Console.ReadLine(); */

            Console.WriteLine("Pick a color (red, black, blue");
            string answer = Console.ReadLine();

            switch(answer)
            {
                case "red":
                    Console.WriteLine("You are a romantic type");
                    break;
                case "black":
                    Console.WriteLine("You are a loner");
                    break;
                case "blue":
                    Console.WriteLine("You are in love");
                    break;
                default:
                    Console.WriteLine("Cannot recognize the color");
                    break;
                
            }

            Console.ReadLine();

            





          
            







        }
    }
}
