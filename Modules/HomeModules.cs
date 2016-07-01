using Nancy;
using System.Collections.Generic;
using AddressBook.Objects;

namespace AddressBook
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Get["/add_contact"] = _ => {
        return View["add_new_contact.cshtml"];
      };
      Get["/contacts"] = _ => {
        List<Contact> allContacts = Contact.GetAll();
        allContacts.Sort((c1, c2) => c1.GetName().CompareTo(c2.GetName()));
        return View["list_all_contacts.cshtml", allContacts];
      };
      Post["/contacts/new"] = _ => {
      Contact newContact = new Contact(Request.Form["name"], Request.Form["address"], Request.Form["phone"]);
      return View["/show_added_contact.cshtml", newContact];
      };
      Get["/contacts/new"] = _ => {
        return View["show_added_contact.cshtml"];
      };
    }
  }
}
