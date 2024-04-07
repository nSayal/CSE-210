using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Event> events = new List<Event>();
        
        CreateDataEvents();

        int i = 1;
        Console.Clear();
        Console.WriteLine("------------------------------------------------------------------------------");
        foreach(Event e in events){
                Console.ResetColor();
                Console.WriteLine($"[Event No {i}] [{e.GetType().ToString()}]\n\n");

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"* STANDARD MESSAGAE:\n");
                e.DisplayStandardMessage();
                
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\n\n* FULL DETAIL MESSAGAE:\n");
                e.DisplayFullMessage();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\n\n* SHORT MESSAGAE:\n");
                e.DisplayShortShortMessage(e);
                Console.WriteLine("----------------------------------------------------------------------------");
                i++;
        } 
        Console.ResetColor();
        


        void CreateDataEvents(){
            Address address1 = new Address("364 S 1st W", "Idaho Falls", "ID", 83440, "US");
            Address address2 = new Address("457 Oak St", "Rexburg", "ID", 67890, "US");
            Address address3 = new Address("814 Hudson Random", "City", "", 00578, "Country");
            
            Reception er = new Reception("Family Fun Day at the Park","Join us for games, music, and delicious snacks. Fun for all ages!","08/05/24","10:00 AM",address1,"events@cityparks.org");
            Lecutre   el = new Lecutre("Annual Charity Gala","Join us for an elegant evening of dining and dancing in support of local charities.","05/20/23","07:30 PM",address2,"events@charitygala.org",8000);
            Outdoor   eo = new Outdoor("Adventure Film Festival","Experience thrilling outdoor adventures on the big screen. Films from around the world!","09/15/23","05:00 PM",address3,"tickets@adventurefilmfest.com");
          
            events.Add(er);
            events.Add(eo);
            events.Add(el);
        }
        
    } 
}