using System;
using System.Diagnostics;

class Listing : Activity{
    private List<string> _questions;
    private List<string> _userResponse;
    public Listing() : base(){
        _questions = new List<string>();
        _userResponse = new List<string>();
    }

    public Listing(string _name, string _description): base(_name, _description){
        _questions = new List<string>{
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
         _userResponse = new List<string>();
    }

    public void listStartActivity(){
        base.startActivity();

        Console.WriteLine("List as many responses you can to the following prompt:\n");

        displayPrompt();
        

    }

    public void listEndActivity(){
        base.EndActivity();
    }


    public void displayPrompt(){

        Random rnd = new Random();
        int _rand_question_index = rnd.Next(_questions.Count-1);
        string _rand_question = _questions[_rand_question_index];

        Console.WriteLine(" ---"+_rand_question+"---\n");

        Console.Write("You may begin in 5 seconds.\n");
        base.ShowLoadingAnimation();

        int time = base.getDuration();

        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        Console.WriteLine($"Begin:");

        while (stopwatch.Elapsed.Seconds < time) {
            if (Console.KeyAvailable) {
                string _userInput = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(_userInput)){
                    _userResponse.Add(_userInput);
                }
            }
            // Give a small delay to prevent the loop from consuming too much CPU
            Thread.Sleep(100); // 100ms delay
        }
        Console.Write($"\nYou listed {_userResponse.Count} items!\n");

        
    }
}