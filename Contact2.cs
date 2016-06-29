using System;
using System.Collections.Generic;


class Contact
{
  public string Name;
  public string Address;
  public string Phone;
}

class Program
{
  public static void Main()
  {
    Contact luchini = new Contact();
    luchini.Name = "Adam Luchini";
    luchini.Address = "2949 SE Yamhill";
    luchini.Phone = "5033109872";

    List<Contact> AddressBook = new List<Contact> () {luchini};
    foreach (Contact person in AddressBook)
    {
      Console.WriteLine("Name: "+ person.Name);
      Console.WriteLine("Address: "+ person.Address);
      Console.WriteLine("Phone: "+ person.Phone);
    }
  }
}
