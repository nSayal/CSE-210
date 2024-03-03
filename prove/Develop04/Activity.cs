using System;
using System.Threading;

class Activity{
    private string _name;
    private string _description;
    private int _duration;
    private List<string> _prompts;

    public Activity(){
        _name = "";
        _description = "";
        _duration = 0;
        _prompts = new List<string>();
    }
    public Activity(string name, string description){
        _name = name;
        _description = description;
        _duration = 0;
        _prompts = new List<string>
            {
                "Think of a time when you stood up for someone else.",
                "Think of a time when you did something really difficult.",
                "Think of a time when you helped someone in need.",
                "Think of a time when you did something truly selfless."
            };
    }

    public void ShowLoadingAnimation()
    {
       char[] spinner = { '|', '/', '-', '\\' };
            
            for (int i = 0; i < 20; i++)  // 20 iterations of spinning
            {
                Console.Write(spinner[i % 4]);
                Thread.Sleep(300);  // Pause for 800 milliseconds
                Console.Write('\b');  // Move cursor back
            }

    }

    public void startActivity(){
        Console.Clear();
        Console.WriteLine($"\nWelcome to the {_name} activity.\n");
        Console.WriteLine(_description);
        Console.Write("\nHow long, in seconds, would you like for your sessions? ");
        _duration = Int32.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get Ready!!");
        ShowLoadingAnimation();
    }   

    public int getDuration(){
        return _duration;
    }

    public string getPrompt(){
       
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count-1);
        string _randomPrompt = _prompts[index];

        return _randomPrompt;
    }

    public void EndActivity(){
        Console.WriteLine($"\nWell done!!!");
        ShowLoadingAnimation();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.\n");
        ShowLoadingAnimation();
    }
    
    public void CountDown(int time){
        for (int i = time; i > 0; i -= 1000){
            Console.Write($"{i/1000}  ");
            Thread.Sleep(1000);
        }
    }
    
}