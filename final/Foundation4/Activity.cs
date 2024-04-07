using System.Reflection.Metadata.Ecma335;

public abstract  class Activity {

        private DateTime _date;
        private int _length; // minutes

 
        public int GetLength(){
            return _length;
        }


        public Activity(){}
        public Activity(DateTime date, int length) {
            _date = date;
            _length = length;
        }


        public  void GetSummary(){
                double Distance = 0;
                double Speed = 0; 
                double Pace = 0;

                if (this is Swimming activitySwimming) {
                    activitySwimming.DoCalculations(ref Distance, ref Speed, ref Pace);
                }

                else if (this is Running activityRunning){
                    activityRunning.DoCalculations(ref Distance, ref Speed, ref Pace);
                }


                else if (this is Cycling activityCycling){
                    activityCycling.DoCalculations(ref Distance, ref Speed, ref Pace);
                }

          
                
                Console.WriteLine($" {this._date.ToString("dd MMM yyyy")} - {this.GetType().ToString().ToUpper()} ({this._length} min): Distance {Distance.ToString("N3")}  km, Speed: {Speed.ToString("N3")} kph, Pace: {Pace.ToString("N1")} min per km" );

        }

        public abstract void  DoCalculations(ref double Distance, ref double Speed, ref double Pace);


}