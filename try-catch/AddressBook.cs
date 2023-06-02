public class AddressBook 
{
    //key = email value = information
    public Dictionary<string, Contact> _contactList {get; set;} = new Dictionary<string, Contact>() {};

    public void AddContact(Contact singleContact)  
        {
            _contactList.Add(singleContact.Email, singleContact);
            //look up how to add something to a dictionary
        }

    public Contact GetByEmail(string email)
        {
            Contact matchingContact = _contactList[email];
            return matchingContact;

        }

}