using System.Collections.Generic;

namespace AddressBook.Objects
{
  private class Contact
  {
    //Contact object variables
    private string _name;
    private string _address;
    private string _phone;
    private static List<Contact> _instances = new List<Contact> {};

    //Contact object constructor
    public Contact(string name, string address, string phone)
    {
      _name = name;
      _address = address;
      _phone = phone;
      _instances.Add(this);
    }

    // Getters for object
    public string GetName()
    {
      return _name;
    }
    public string GetAddress()
    {
      return _address
    }
    public string GetPhone()
    {
      return _phone;
    }
    public static List<Contact> GetAll()
    {
      return _instanaces;
    }
  }
}
