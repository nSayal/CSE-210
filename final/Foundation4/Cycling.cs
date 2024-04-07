public class Cycling  : Activity {

        double _speed;

       public void SetSpeed(double speed){
            _speed = speed;
       } 
       public double GetSpeed(){
            return _speed;
       } 
        public Cycling(){}
        public Cycling(double speed, DateTime date, int length) : base(date, length) {
            _speed = speed;
        }



        public override void DoCalculations(ref double Distance, ref double Speed, ref double Pace){

           
             Speed = _speed;
             Distance =  (_speed / 60 )  * (double) this.GetLength() ;
              Pace = 60 / Speed ;


        }





}