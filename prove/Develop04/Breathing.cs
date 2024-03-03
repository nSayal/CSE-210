using System;
using System.Threading;

class Breathing : Activity {

    public Breathing(string _name, string _description) : base(_name, _description)
    {

    }
    public void breathStartActivity(){
        base.startActivity();

        Random rnd = new Random();
        int _totalTime = getDuration() * 1000;
        while(_totalTime > 0){
            int _breathIn = 4000;
            int _breathOut = 6000;

            if (_totalTime >= (_breathIn + _breathOut))
            {
                // Breathe in
                _totalTime -= _breathIn;
                Console.Write("\n\nBreathe in...");
                base.CountDown(_breathIn);

                // Breathe out
                _totalTime -= _breathOut;
                Console.Write("\nBreathe out...");
                base.CountDown(_breathOut);
                Console.WriteLine();
            }
            else{
                int _new_time = _totalTime / 2;
                Console.Write("\n\nBreathe in...");
                base.CountDown(_breathIn);

                Console.Write("\n\nBreathe out...");
                base.CountDown(_breathOut);
                Console.WriteLine();
                _totalTime = 0;
               }
        }
        
    }

    public void breathEndActivity(){
        base.EndActivity();
    }
    

    

}