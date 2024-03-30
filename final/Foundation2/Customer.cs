class Customer {


        private int _customerID = 0;
        private string _customerName = "";
        private Address _customerAddress = new Address();


       


        public string GetCustomerName(){
        return  _customerName;
        }
        public Address GetCustomerAddress(){
            return _customerAddress;
        }



        public Customer(){
            _customerAddress = new Address();
        }
        public Customer(int customerID , string customerName, Address customerAddress){
            _customerID = customerID;
            _customerName = customerName;
            _customerAddress = customerAddress;
        }



        public Boolean LiveInUSA()  {
            return (_customerAddress.IsAddressInUSA() ? true  : false );
        }

        public string DisplayAddress(){
            return _customerAddress.BuildStrCompleateAddress();
        }




}