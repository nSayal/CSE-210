    class Outdoor : Event {

        private string _weather = "" ;





      public Outdoor(){}
      public Outdoor(string title, string description, string date, string time, Address address, string weather)  : base(title, description, date, time, address)
      {
            _weather = weather;
      }


      public  string  DisplayEventInfo(){
        return   "Weather: " +  _weather;;
      }



} 

