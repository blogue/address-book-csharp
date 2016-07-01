using System.Collections.Generic;

namespace AddressBook.Objects
{
  public class Contact
  {
    //Contact object variables
    private string _name;
    private string _address;
    private string _phone;
    private int _id;
    private static List<Contact> _instances = new List<Contact> {};

    //Contact object constructor
    public Contact(string name, string address, string phone)
    {
      _name = name;
      _address = address;
      _phone = phone;
      _instances.Add(this);
      _id = _instances.Count;
    }

    // Getters for object
    public string GetName()
    {
      return _name;
    }
    public string GetAddress()
    {
      return _address;
    }
    public string GetPhone()
    {
      return _phone;
    }
    public static List<Contact> GetAll()
    {
      return _instances;
    }
    public int GetId()
    {
      return _id;
    }

    //Settings for object
    public void SetName(string newName)
    {
      _name = newName;
    }
    public void SetAddress(string newAddress)
    {
      _address = newAddress;
    }
    public void SetPhone(string newPhone)
    {
      _phone = newPhone;
    }
    //Delete all contacts
    public static void ClearAll()
    {
      _instances.Clear();
    }

  }
}
