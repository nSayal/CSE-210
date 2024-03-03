using System;

class Program
{
    static void Main(string[] args)
    {   
        List<string> _user_activity = new List<string> {"Breathing", "Reflecting", "Listing", "Quit"};
        List<string> _user_description = new List<string> {"This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",
                                            "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",
                                            "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",
                                            "Quit"};

        List<int> _log = new List<int>{0,0,0};

        bool _program_on = true;

        while(_program_on){
            Console.Clear();
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit\n");

            Console.Write("Select a choice from the menu: ");
            int _choice = Int32.Parse(Console.ReadLine());

            string _chosen_activity = _user_activity[_choice-1];
            string _chosen_description = _user_description[_choice -1];
            if (_choice == 1){
                Breathing breath = new Breathing(_chosen_activity, _chosen_description);
                breath.breathStartActivity();
                breath.breathEndActivity();
                _log[_choice-1] += 1;
            }
            else if (_choice == 2){
                Reflecting reflect = new Reflecting(_chosen_activity, _chosen_description);
                reflect.reflectStartActivity();
                reflect.displayQuestion();
                reflect.reflectEndActivity();
                _log[_choice-1] += 1;
            }
            else if (_choice == 3){
                Listing reflect = new Listing(_chosen_activity, _chosen_description);
                reflect.listStartActivity();
                reflect.listEndActivity();
                _log[_choice-1] += 1;
            }

            else if (_choice == 4){
                Console.WriteLine("\nActivity Log:");
                for(int i =0; i < 3; i++){
                    Console.WriteLine($"{_user_activity[i]}: Performed {_log[i]} time(s)");
                }
                _program_on = false;
            }
            else {
                Console.WriteLine("Invalid option. Please select a valid option.");
            }
        }
            
    }
}