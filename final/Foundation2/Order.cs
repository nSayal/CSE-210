using System.Net.Http.Headers;

class Order {



        private int _customerID;
        List<Product> _products = new List<Product>{};

        public void SetCustomerID(int customerID){
            _customerID = customerID;
        }
        public  void SetProducts(List<Product> products){
            _products = products ;
        }
    
        public int GetCustomerID(){
            return _customerID;
        }
        public List<Product> GetProducts(){
            return _products;
        }


        public Order(){ }
        public Order(int customerID , List<Product> products ){
            _customerID = customerID;
            _products = new List<Product>();
        }





        public double SubTotalCostOfTheOrder(){
                double subTotal = 0;
                foreach(Product p in GetProducts()){
                    subTotal +=   p.GetTotalPrice();                              
                }
               return subTotal;
        } 
     
        public string PackingList(){
            string PackingStr = "";
            Console.WriteLine("   PROD ID" +  "\t" + "NAME"  + "\t\t\t" + "QTY" + "\t" + "UNIT PRICE"  );

            foreach(Product p in GetProducts()){
                PackingStr += "\t" +  p.GetProductID() +"\t" + p.GetProductName() + "\t\t" + p.GetProductQty() + "\t" + p.GetProductPrice() +  "\n";
            }
            return PackingStr;
        }

        public string ShippingLabel(Customer c){
            string shippingStr = "";
            shippingStr += "\t*****************************\n";
            shippingStr += "\t" + c.GetCustomerName() + "\n";
            shippingStr += c.DisplayAddress() + "\n";
            shippingStr += "\t*****************************\n";
            return shippingStr;

        }

        public double  GetShippingCost(Customer customer){
            return (customer.GetCustomerAddress().IsAddressInUSA() ? 5 : 35);
        }    

        public double SubTotalCostOfTheOrder_(){
                double subTotal = 0;
                foreach(Product p in GetProducts()){
                    subTotal += p.GetTotalPrice() ;                              
                }
               return subTotal;
        } 
} 