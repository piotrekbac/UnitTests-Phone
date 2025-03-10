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
        //deklaracja prywatnego pola owner - przechowuje ono nazw� w�a�ciciela telefonu
        private string owner;

        //deklaracja prywatnego pola phoneNumber - przechowuje numer telefonu, kt�ry musi by� ci�giem z�o�onym z 9 cyfr
        // string of 9 digits
        private string phoneNumber;

        //deklaracja prywatnego pola phoneBook - przechowuje ksi��k� telefoniczn� z kontaktami, w formie par string�w <nazwa, numer>  
        // Dictionary of <name, number>
        private readonly Dictionary<string, string> phoneBook;

        //deklaracja publicznej w�a�ciwo�ci PhoneBookCapacity, kt�ra zwraca maksymaln� pojemno�� ksi��ki telefonicznej
        public int PhoneBookCapacity => 100;

        //deklaracja publicznego konstruktora klasy Phone, kt�ry przyjmuje dwa argumenty: owner - nazwa w�a�ciciela telefonu, phoneNumber - numer telefonu 
        public Phone(string owner, string phoneNumber)
        {
            //przypisanie warto�ci polu owner - ustawianie w�a�ciciela telefonu
            Owner = owner;
            //przypisanie warto�ci polu phoneNumber - ustawianie numeru telefonu
            PhoneNumber = phoneNumber;
            //inicjalizacja s�ownika (naszej ksi��ki telefonicznej) phoneBook - utworzenie pustej ksi��ki telefonicznej
            phoneBook = new Dictionary<string, string>();
        }
        //deklaracja w�a�ciwo�ci Owner, kt�ra zwraca nazw� w�a�ciciela telefonu typu public string
        public string Owner
        {
            //getter w�a�ciwo�ci Owner - pobieranie warto�ci w�a�ciciela
            get => owner;
            //setter w�a�ciwo�ci Owner
            private set
            {
                //je�li warto�� jest pusta lub null rzucamy wyj�tek ArgumentException z odpowiedni� informacj�
                if (string.IsNullOrEmpty(value))
                    //rzucenie wyj�tku ArgumentException z odpowiedni� informacj�, je�li nazwa w�a�ciciela jest pusta lub null
                    throw new ArgumentException($"Owner name is empty or null!");

                //przypisanie warto�ci polu owner - ustawianie warto�ci w�a�ciciela 
                owner = value;
            }
        }

        //deklaracja prywatnej metody IsCorrectPhoneNumber, kt�ra sprawdza czy numer telefonu jest poprawny (czy jest to ci�g 9 cyfr)
        private bool IsCorrectPhoneNumber(string number)
            => (number != null) && number.Length == 9 && number.All(c => char.IsDigit(c));

        //deklaracja w�a�ciwo�ci PhoneNumber, do pobierania i ustawiania numeru telefonu
        public string PhoneNumber
        {
            //getter w�a�ciwo�ci PhoneNumber - pobieranie warto�ci numeru telefonu 
            get => phoneNumber;
            //setter w�a�ciwo�ci PhoneNumber 
            private set
            {
                //je�li warto�� jest pusta lub null rzucamy wyj�tek ArgumentException z odpowiedni� informacj�
                if (string.IsNullOrEmpty(value))
                    //rzucenie wyj�tku ArgumentException z odpowiedni� informacj�, je�li numer telefonu jest pusty lub null
                    throw new ArgumentException($"Phone number is empty or null!");

                //je�li numer telefonu nie jest poprawny (nie sk�ada si� z 9 cyfr) rzucamy wyj�tek ArgumentException z odpowiedni� informacj�
                if (!IsCorrectPhoneNumber(value))
                    //rzucenie wyj�tku ArgumentException z odpowiedni� informacj�, je�li numer telefonu jest niepoprawny
                    throw new ArgumentException($"Invalid phone number!");

                //przypisanie warto�ci polu phoneNumber - ustawianie warto�ci numeru telefonu
                phoneNumber = value;
            }
        }

        //deklaracja publicznej w�a�ciwo�ci Count, kt�ra zwraca ilo�� kontakt�w w ksi��ce telefonicznej
        public int Count => phoneBook.Count;

        //deklaracja publicznej metody AddContact, kt�ra dodaje kontakt do ksi��ki telefonicznej
        public bool AddContact(string name, string number)
        {
            //je�li ksi��ka telefoniczna jest pe�na (ilo�� kontakt�w r�wna pojemno�ci ksi��ki telefonicznej) rzucamy wyj�tek InvalidOperationException z odpowiedni� informacj�
            if (Count == PhoneBookCapacity)
                //rzucenie wyj�tku InvalidOperationException z odpowiedni� informacj�, je�li ksi��ka telefoniczna jest pe�na
                throw new InvalidOperationException("Phonebook is full!");

            //je�li ksi��ka telefoniczna nie zawiera kontaktu o podanej nazwie, dodajemy kontakt do ksi��ki telefonicznej
            if (!phoneBook.ContainsKey(name))
            {
                //dodanie kontaktu do ksi��ki telefonicznej
                phoneBook.Add(name, number);

                //zwr�cenie warto�ci true, je�li kontakt zosta� dodany
                return true;
            }

            //zwr�cenie warto�ci false, je�li kontakt o danej nazwie ju� istnieje w ksi��ce telefonicznej
            return false;
        }

        //deklaracja publicznej metody Call do dzownienia, do osoby na podstawie podanej nazwy
        public string Call(string name)
        {
            //je�li ksi��ka telefoniczna zawiera kontakt o podanej nazwie, dzwonimy do osoby
            if (phoneBook.ContainsKey(name))
            {
                //pobranie numeru telefonu osoby o podanej nazwie
                var number = phoneBook[name];
                //zwr�cenie informacji o dzwonieniu do osoby o podanej nazwie
                return $"Calling {number} ({name}) ...";
            }

            //rzucenie wyj�tku InvalidOperationException z odpowiedni� informacj�, je�li osoba o podanej nazwie nie istnieje w ksi��ce telefonicznej
            throw new InvalidOperationException("Person doesn't exists!");
        }
    }
}
