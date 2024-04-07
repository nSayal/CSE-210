public class Event {


        private string _title = "";
        private string _description = "";
        private string _date;
        private string  _time = "";    
        private Address _address;


        public void SetTitle(string title){
            _title = title;
        }
        public void SetDescription(string description){
           _description = description;
        }     
        public void SetDate(string date){
           _date = date;
        }             
        public void SetTime(string time){
           _time = time;
        } 
        public void SetAddress(Address address){
           _address = address;
        }         
    
        public string GetTitle( ){
             return _title ;
        }
  
        public string GetDate(){
            return _date;
        }


        public Event(){}
        public Event(string title, string description,string date ,  string time, Address address){
            _title = title;
            _description = description;
            _date = date;
            _time = time;
            _address = address;
         }

        public void DisplayStandardMessage(){
            Console.WriteLine($"\tTitle: {_title},  Description: {_description}\n\tDate: {_date}, Time: { _time}\n\tAddress: {_address.BuildStrCompleateAddress()}");
        }

        
        public void DisplayFullMessage(){
            DisplayStandardMessage();
            Console.WriteLine("\t* * * * * * * * * * * * * * * * * * * * * * * * * * * * * * ");
            if (this is Reception receptionEvent){
                    Console.WriteLine($"\t{receptionEvent.DisplayEventInfo()}");
                }
                else if (this is Outdoor outdoorEvent){
                     Console.WriteLine($"\t{outdoorEvent.DisplayEventInfo()}");
                }
                else if (this is Lecutre lectureEvent){
                    Console.WriteLine($"\t{lectureEvent.DisplayEventInfo()}");
                }
                Console.WriteLine("\t* * * * * * * * * * * * * * * * * * * * * * * * * * * * * *");
            }
        
        
        public  void  DisplayShortShortMessage(Event e){
                Console.WriteLine($"\tType of Event: {e.GetType().ToString()},   Title: {e.GetTitle()},    Date: {e.GetDate()}");
        }

}