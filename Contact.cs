using System;
using System.Collections.Generic;

class Contact
{
  public string Name;
  public string Phone;
  public string Address;
}

class Program
{
  public static void Main()
  {
    Contact hendrix = new Contact(); //creates contact object using class Contact Creating an object with type Contact, like delcaring a string or int. this is INSTANSIATION, creating an instance of the Contact Class. hendrix is an OBJECT/INSTANCE of Contact Clasa.
    hendrix.Name = "Jimi Hendrix"; //hendrix.Name is looking for the Property "Name" inside the object "hendrix". Declare "Name" property of "hendrix" to the string "Jimi Hendrix".
    hendrix.Phone = "503-310-9871";
    hendrix.Address = "208 SW 5th St. Portland, OR 97204";

    Contact elvis = new Contact(); //creates contact object using class Contact Creating an object with type Contact, like delcaring a string or int. this is INSTANSIATION, creating an instance of the Contact Class. elivs is an OBJECT/INSTANCE of Contact Clasa.
    elvis.Name = "Elvis Presley";
    elvis.Phone = "617-356-9280";
    elvis.Address = "Graceland, TN";

    Contact einstein = new Contact(); //creates contact object using class Contact Creating an object with type Contact, like delcaring a string or int. this is INSTANSIATION, creating an instance of the Contact Class. einstein is an OBJECT/INSTANCE of Contact Clasa.
    einstein.Name = "Albert Einstein";
    einstein.Phone = "893-093-3920";
    einstein.Address = "4920 MLK Blvd. Oakland, CA 97270";

    List<Contact> AddressBook = new List<Contact>() {hendrix, elvis, einstein}; //stores contacts in a list called "AddressBook"

    Contact rock = new Contact(); //Putting another contact after the List is declared is okay.
    rock.Name = "Dwayne Johnson";
    rock.Phone = "654-881-6955";
    rock.Address = "1990 Bay St. Honolulu, HI 19886";

    AddressBook.Add(rock); //It gets added to the list here and will show up.


    foreach (Contact person in AddressBook) //loops through all contacts and lists below info in return.

    {
      Console.WriteLine("Name: " + person.Name);
      Console.WriteLine("Phone number: " + person.Phone);
      Console.WriteLine("Address: " + person.Address);
    }
  }
}
