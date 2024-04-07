
using System;
using System.Data;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        CreateEvents();

        Console.Clear();
        Console.WriteLine("************************************************************************************************************");
        foreach(Activity a in activities){
            a.GetSummary();
            Console.WriteLine("************************************************************************************************************");

        }


        void CreateEvents(){
            var eventDate1 = new DateTime(2019, 7, 4, 14, 14, 01, 001); 
            var eventDate2 = new DateTime(2022, 11, 10, 12, 01, 01, 001); 
            var eventDate3 = new DateTime(2024, 11, 4, 17, 01, 01, 001); 
 

            Running activityRunning = new( 4.8 , eventDate1 , 30 );  
            Cycling activityCycling = new( 2 , eventDate2 , 45);     
            Swimming activitySwimming = new( 10 , eventDate3 , 30 ); 

            activities.Add(activityRunning);
            activities.Add(activityCycling);
            activities.Add(activitySwimming);
        }


    } 
}