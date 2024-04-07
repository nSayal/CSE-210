public class Running : Activity {


        double _distance = 0;


        public Running(){}
        public Running(double distance, DateTime date, int length) : base(date, length) {
            _distance = distance;
        }



        public override void  DoCalculations(ref double Distance, ref double Speed, ref double Pace){

             Distance  = _distance;
             Speed = (_distance / (double) this.GetLength()) * 60 ;
             Pace = 60 / Speed ;
        }


} 