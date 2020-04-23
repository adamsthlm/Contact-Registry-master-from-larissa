/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Namn: Carl-Adam Berglund
e-mail: ak7764@mau.se
*/


namespace Contact_Registry
{
    class Address
    {
        // fields
        private string _city = string.Empty;
        private Countries _country = Countries.EMPTY_NO_COUNTRY;
        private string _street = string.Empty;
        private string _zipCode = string.Empty;

        // properties
        public string City 
        { 
          get { return _city; } 
          set { _city = value; } 
        }
        public Countries Country 
        { 
          get { return _country; }
          set { _country = value; }
        }
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        public string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }
        
        // default constructor
        public Address() { }

        // constructor 3 parameters
        public Address(string street, string zipCode, string city)
        {
            _street = street; // question: capital S in Street or lowercase s in street? 
            _zipCode = zipCode; // and why??
            _city = city;
            this._country = Countries.Sverige;
        }

        // constructor 4 parameters
        public Address(string street, string zipCode, string city, Countries country)
        {
            _street = street;
            _zipCode = zipCode;
            _city = city;
            _country = country;
        }

        public Address(Address addr)
        {
            this._city = addr._city;
            this._country = addr._country;
            this._street = addr._street;
            this._zipCode = addr._zipCode;           
        }

        public override string ToString()
        {
            return _street + "  " + _zipCode + " " + _city + " " + _country;
        }
    } // class 
} // namespace