//importowanie bibliotek: System, System.Collections.Generic, System.Linq
using System;
using System.Collections.Generic;
using System.Linq;

//deklaracja przestrzeni nazw: ClassLibrary
namespace ClassLibrary
{
    //deklaracja publicznej klasy: Phone
    public class Phone
    {
        //deklaracja prywatnych pola owner - przechowuje nazw� w�a�ciciela telefonu
        private string owner;

        //deklaracja prywatnych pola phoneNumber - przechowuje numer telefonu, kt�ry sk�ada si� z 9 cyfr
        // string of 9 digits
        private string phoneNumber;

        //deklaracja prywatnego pola phoneBook, s�owiek przechowuj�cy ksi�zk� telefoniczn� z kontaktami, w formie par <nazwa, numer>  
        // Dictionary of <name, number>
        private readonly Dictionary<string, string> phoneBook;

        //deklaracja publicznej w�a�ciwo�ci PhoneBookCapacity, kt�ra zwraca pojemno�� ksi��ki telefonicznej
        public int PhoneBookCapacity => 100;

        //deklaracja konstruktora klasy Phone, kt�ry przyjmuje dwa argumenty: owner - nazwa w�a�ciciela telefonu, phoneNumber - numer telefonu
        public Phone(string owner, string phoneNumber)
        {
            //przypisanie warto�ci polu owner
            Owner = owner;
            //przypisanie warto�ci polu phoneNumber
            PhoneNumber = phoneNumber;
            //inicjalizacja s�ownika (naszej ksi��ki telefonicznej) phoneBook
            phoneBook = new Dictionary<string, string>();
        }

        public string Owner
        {
            get => owner;
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException($"Owner name is empty or null!");

                owner = value;
            }
        }

        private bool IsCorrectPhoneNumber(string number)
            => (number != null) && number.Length == 9 && number.All(c => char.IsDigit(c));

        public string PhoneNumber
        {
            get => phoneNumber;
            private set
            {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentException($"Phone number is empty or null!");

                if (!IsCorrectPhoneNumber(value))
                    throw new ArgumentException($"Invalid phone number!");

                phoneNumber = value;
            }
        }

        public int Count => phoneBook.Count;

        public bool AddContact(string name, string number)
        {
            if (Count == PhoneBookCapacity)
                throw new InvalidOperationException("Phonebook is full!");

            if (!phoneBook.ContainsKey(name))
            {
                phoneBook.Add(name, number);
                return true;
            }

            return false;
        }

        public string Call(string name)
        {
            if (phoneBook.ContainsKey(name))
            {
                var number = phoneBook[name];
                return $"Calling {number} ({name}) ...";
            }

            throw new InvalidOperationException("Person doesn't exists!");
        }
    }
}
