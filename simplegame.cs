using System;

namespace TrueOrFalse
{
  class Program
  {
		static void Main(string[] args)
    {
      // Do not edit these lines
      Console.WriteLine("Welcome to 'True or False?'\nPress Enter to begin:");
      string entry = Console.ReadLine();
      Tools.SetUpInputStream(entry);

      // Type your code below
      string[] questions = {"have you five balls?", "did you work hard?", "Do you like me?"," will you get job?"};
      bool[] answers = {false, true, false, true};
      bool[] responses = new bool[answers.Length];
      if( questions.Length != answers.Length){
        Console.WriteLine("Oh NO!! Its not equal");
      }

        int askingIndex = 0;
        
    foreach(string question in questions ){
          string input;
          bool isBool;
          bool inputBool;
          Console.WriteLine(question);
          Console.WriteLine("True or false?");
          input = Console.ReadLine();
          isBool = Boolean.TryParse(input, out inputBool);

          while(isBool == false){
            Console.WriteLine("Please respond with 'true' or 'false'.");
            input= Console.ReadLine();
            isBool = Boolean.TryParse(input, out inputBool);
            }
            //Console.WriteLine(isBool);
            //Console.WriteLine(inputBool);
            responses[askingIndex] = inputBool;
            askingIndex++;
        }
        foreach(bool response in responses){
            Console.WriteLine(response);
        }
        int scoringIndex =0;
        int score =  0;
        foreach( bool answer in answers ){
          bool temp =responses[scoringIndex];
          Console.WriteLine($"1.Input: {temp} | Answer: {answer}");
          if(temp == answer){
            score++;
          }
          scoringIndex++;
        }
        Console.WriteLine($"You got {score} out of {scoringIndex} correct!");
      
      
      
    }
  }
}
