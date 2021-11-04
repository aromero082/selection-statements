using System;

namespace SelectionStatementsExercise
{
    class Program
    {
        static void Main(string[] args)
        {
              int favoriteNumber = 7;
             Console.WriteLine("Guess the favorite number, Hint: below 10");
              int Userguess = int.Parse(Console.ReadLine());

              if (Userguess < favoriteNumber)
              Console.WriteLine("TOO LOW!!!");


             else if (Userguess > favoriteNumber) ;
             Console.WriteLine("TOO HIGH!!!");

             if (Userguess == favoriteNumber)
             Console.WriteLine("you were correct here is a coockie");


             else
             Console.WriteLine("Nevermind");

           // switch/case statement
            string subject = "Math";

            Console.WriteLine("what is your favorite subject?");

            string usersubject = Console.ReadLine();

            switch (usersubject)
            {
                case "math":

                    Console.WriteLine("math is fun");
                    break;

                case "history":

                    Console.WriteLine("history is interisting");
                    break;

                case "english":

                    Console.WriteLine("I like english");
                    break;

                case "c#":

                    Console.WriteLine("c# is awesome");
                    break;

                case "science":

                    Console.WriteLine("science is the best one");
                    break;
            }  




            










            
        }

    }

}




       

    

            






                
    


        
        

