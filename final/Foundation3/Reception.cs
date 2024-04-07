class Reception : Event {


      private string _emailRSVP = "";


      public Reception(){}  
      public Reception(string title, string description, string date, string time, Address address, string emailRSVP)  : base(title, description, date, time, address)
      {
          _emailRSVP = emailRSVP;
      }

      
      public void SetEmailRSVP(string emailRSVP){
         _emailRSVP = emailRSVP;
      }



      public  string  DisplayEventInfo(){
         return   ( "Registered by (RSVP) email: " + _emailRSVP);
      }
 

}