class Lecutre : Event {


      private string  _speaker = "";
      private int _maxCapacity = 0;


   public void SetSpeaker(string speaker){
      _speaker = speaker;
   }
   public void SetMaxCapacity(int maxCapacity){
      _maxCapacity = maxCapacity ;

   }



      public Lecutre(){}
      public Lecutre(string title, string description, string date, string time, Address address, string speaker, int maxCapacity)  : base(title, description, date, time, address)
      {
       _speaker = speaker;
         _maxCapacity = maxCapacity;
      }
      

      public  string  DisplayEventInfo(){
         return  "Speaker: " + _speaker + ", " + "MaxCapacity: " + _maxCapacity;
      }



}