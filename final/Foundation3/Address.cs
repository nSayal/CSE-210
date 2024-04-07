using System.Reflection;

public class Address {

        private string _address = "";
        private string _city = "";
        private string _state = "";
        private int _zipCode = 0;    
        private string _country = "";

        private Boolean _inUSA = false;



        public Address(){}
        public Address( string address , string  city, string state , int zipCode , string country ){
            _address = address;
            _city = city;
            _state = state;
            _zipCode = zipCode;
            _country = country;
        }

        
        public string BuildStrCompleateAddress(){
                return ("\n\t\t" + _address + "\t\t\n" +  "\t\t" + _city + "," + _state + " "  + _zipCode + "\t\t\n" + "\t\t" + _country);
        }

}

