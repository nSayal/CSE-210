using System;

class Reflecting:Activity{
    private List<string> _reflect;

    public Reflecting(): base(){
        _reflect = new List<string>();
    }
    public Reflecting(string _name, string _description) : base(_name, _description){
        _reflect = new List<string>
        {
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?",
            "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?"
        };

    }

    public void reflectStartActivity(){

        base.startActivity();
        string _prompt = base.getPrompt();
        Console.WriteLine("Consider the following prompt:\n");

        Console.WriteLine("  ---"+_prompt+"---\n");

        Console.WriteLine("When you have something in mind, press enter to continue.");
        ConsoleKeyInfo keyInfo;
        do{
            keyInfo = Console.ReadKey(true);
            if(keyInfo.Key == ConsoleKey.Enter){
                break;
            }
        } while (true);

        Console.WriteLine("\nNow ponder on each of the following questions as they related to the experience.");
        Console.Write("You may beign in few seconds.");
        base.ShowLoadingAnimation();
        


    }

    public void displayQuestion(){
        Console.Clear();


        int _time = base.getDuration();

        while(_time > 0 ){

            int _questionTime = Math.Min(10, _time);

            Random rnd = new Random();
            int index = rnd.Next(_reflect.Count-1);
            string _randomPrompt = _reflect[index];

            Console.Write(_randomPrompt);
           
            // Adding a "Loading" animation using periods (dots)
            for (int i = 0; i < _questionTime; i++)  // Displaying 5 dots
            {
                Console.Write(".");
                Thread.Sleep(1000);  // Pauses for 1000 milliseconds
            }
            Console.Write("\n");  // Move to the next line
    
            _time -= _questionTime;
        }

        
    }

    public void reflectEndActivity(){
        base.EndActivity();
    }
}