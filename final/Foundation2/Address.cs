class Address {


        private string _address = "";
        private string _city = "";
        private string _state = "";
        private int _zipCode = 0;
        private string _country = "";
       


        public string GetCountry(){
            return _country;
        }


        public Address(){
            
        }
        public Address( string address , string  city, string state , int zipCode , string country ){
            _address = address;
            _city = city;
            _state = state;
            _zipCode = zipCode;
            _country = country;
        }



        public Boolean IsAddressInUSA(){
            return ( _country.ToLower() =="us" || _country.ToLower() == "usa" ? true :false);
        }

        public string BuildStrCompleateAddress(){
            return ("\t" + _address + "\t\n" +  "\t" + _city + "," + _state + " "  + _zipCode + "\t\n" + "\t" + _country);
        }



}