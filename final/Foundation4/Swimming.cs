public class Swimming  : Activity {


        int _numberOfLaps;

       public void SetNumberOfLaps(int numberOfLaps){
            _numberOfLaps = numberOfLaps;
       } 

        public Swimming(){}
        public Swimming(int numberOfLaps, DateTime date, int length) : base(date, length) {
            _numberOfLaps = numberOfLaps;
        }


         public override void  DoCalculations(ref double Distance, ref double Speed, ref double Pace){

        
             Distance =( (double) _numberOfLaps * 50 ) / 1000;

             Speed = (Distance / (double)this.GetLength() ) * 60 ;

           
             Pace = 60 / Speed ;
        }


}