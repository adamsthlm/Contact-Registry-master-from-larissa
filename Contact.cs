/*
Denna fil har skapats som en del av kursen [C# I] på Malmö University 2020
Namn: Carl-Adam Berglund
e-mail: ak7764@mau.se
*/


namespace Contact_Registry
{
    class Contact
    {
        // Fields
        private string _firstname = string.Empty;
        private string _lastname = string.Empty;
        private Address address = null;

        // Properties or encapsulated fields - auto generated  (Ctrl-R
        public string Firstname { get => _firstname; set => _firstname = value; }
        public string Lastname { get => _lastname; set => _lastname = value; }

        public string GetLastname() { return Lastname.ToUpper(); }


        public string Fullname
        {
            get { return Firstname + " " + GetLastname(); }
        }

        // constructor w. 1 params.
        public Contact(Contact contact)
        {
            this._firstname = contact._firstname;
            this._lastname = contact._lastname;
            this.address = contact.address;
        }
        
        // constructor w. 3 params.
        public Contact(string firstname, string lastname, Address adr)
        {
            this._firstname = firstname; // Field _firstname is set via property Firstname
            this._lastname = lastname; // Field _lastname is set via property Lastname
            this.address = adr; // one Address object

        }
    
        public bool ValidateData()
        {

            bool ok = true;

            if (ok)
            {
                if (Firstname.Equals(string.Empty))
                {
                    ok = false;
                    return ok;
                } else

                if (Lastname.Equals(string.Empty))
                {
                    ok = false;
                    return ok;
                } else

                if (!address.Equals(this.address))
                {
                    ok = false;
                }
                return ok;
            }
            return ok;
        }

        public override string ToString()
        {
            string strOut = string.Format("{0,-20} {1}", Fullname, address.ToString());
            return strOut;
        }  

        private string ToUpper(string lastname)
        {
            string outString = lastname.ToUpper();
            return outString;
        }

    } // class 
}// namespace 
