/*
Denna fil har skapats som en del av kursen [C# I] på Malmö Universitet 2020
Namn: Carl-Adam Berglund
e-mail: ak7764@mau.se
*/
using System.Collections.Generic;

namespace Contact_Registry
{
    class ContactManager
    {
        /// <summary>
        /// Create a list object called ContactList
        /// </summary>
        List<Contact> ContactList = null;

        // default constructor use a list of contacts
        public ContactManager()
        {
            ContactList = new List<Contact>();
        }



        // hämtar ett Contact objekt i ContactList at index
        public Contact GetContact(int index)
        {
            if (index < 0 || index >= ContactList.Count)
            {
                return null;
            }
            if (index >= 0 && index < ContactList.Count)
                return ContactList[index]; // spit out the copy
            else
                return null;
        }

     
        // lägger till en contact i slutet på listan
        public bool AddContact(Contact contactIN)
        {
            ContactList.Add(contactIN);
            return true;
        }
       

        // Re-factored by Visual Studio (Ctrl + R, M)
        private static bool CheckIfNamesIsValid(string firstName, string lastName, Address addressIN)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || addressIN == null)
            {
                return false;
            }
            else return true;
        }

        // Testvalues 
        public void TestValues()
        {
            Contact tmp1 = new Contact("Apu", "Simpsson", new Address("Simpsson North Avenue", "123 45", "Johanneshov", Countries.Sverige));
            AddContact(tmp1);
            Contact tmp2 = new Contact("Nisse", "Lundström", new Address("Lundgatan 32", "543 21", "Kalmar"));
            AddContact(tmp2);


        }

        public string[] GetContactsInfo()
        {
            string[] strInfoStrings = new string[ContactList.Count];
            int i = 0;

            foreach (Contact contactItem in ContactList)
            {
                strInfoStrings[i++] = contactItem.ToString();
            }
            return strInfoStrings;
        }

    } // class
} // namespace 

