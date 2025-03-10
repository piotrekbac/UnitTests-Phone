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
        //deklaracja prywatnego pola owner - przechowuje ono nazwê w³aœciciela telefonu
        private string owner;

        //deklaracja prywatnego pola phoneNumber - przechowuje numer telefonu, który musi byæ ci¹giem z³o¿onym z 9 cyfr
        // string of 9 digits
        private string phoneNumber;

        //deklaracja prywatnego pola phoneBook - przechowuje ksi¹¿kê telefoniczn¹ z kontaktami, w formie par stringów <nazwa, numer>  
        // Dictionary of <name, number>
        private readonly Dictionary<string, string> phoneBook;

        //deklaracja publicznej w³aœciwoœci PhoneBookCapacity, która zwraca maksymaln¹ pojemnoœæ ksi¹¿ki telefonicznej
        public int PhoneBookCapacity => 100;

        //deklaracja publicznego konstruktora klasy Phone, który przyjmuje dwa argumenty: owner - nazwa w³aœciciela telefonu, phoneNumber - numer telefonu 
        public Phone(string owner, string phoneNumber)
        {
            //przypisanie wartoœci polu owner - ustawianie w³aœciciela telefonu
            Owner = owner;
            //przypisanie wartoœci polu phoneNumber - ustawianie numeru telefonu
            PhoneNumber = phoneNumber;
            //inicjalizacja s³ownika (naszej ksi¹¿ki telefonicznej) phoneBook - utworzenie pustej ksi¹¿ki telefonicznej
            phoneBook = new Dictionary<string, string>();
        }
        //deklaracja w³aœciwoœci Owner, która zwraca nazwê w³aœciciela telefonu typu public string
        public string Owner
        {
            //getter w³aœciwoœci Owner - pobieranie wartoœci w³aœciciela
            get => owner;
            //setter w³aœciwoœci Owner
            private set
            {
                //jeœli wartoœæ jest pusta lub null rzucamy wyj¹tek ArgumentException z odpowiedni¹ informacj¹
                if (string.IsNullOrEmpty(value))
                    //rzucenie wyj¹tku ArgumentException z odpowiedni¹ informacj¹, jeœli nazwa w³aœciciela jest pusta lub null
                    throw new ArgumentException($"Owner name is empty or null!");

                //przypisanie wartoœci polu owner - ustawianie wartoœci w³aœciciela 
                owner = value;
            }
        }

        //deklaracja prywatnej metody IsCorrectPhoneNumber, która sprawdza czy numer telefonu jest poprawny (czy jest to ci¹g 9 cyfr)
        private bool IsCorrectPhoneNumber(string number)
            => (number != null) && number.Length == 9 && number.All(c => char.IsDigit(c));

        //deklaracja w³aœciwoœci PhoneNumber, do pobierania i ustawiania numeru telefonu
        public string PhoneNumber
        {
            //getter w³aœciwoœci PhoneNumber - pobieranie wartoœci numeru telefonu 
            get => phoneNumber;
            //setter w³aœciwoœci PhoneNumber 
            private set
            {
                //jeœli wartoœæ jest pusta lub null rzucamy wyj¹tek ArgumentException z odpowiedni¹ informacj¹
                if (string.IsNullOrEmpty(value))
                    //rzucenie wyj¹tku ArgumentException z odpowiedni¹ informacj¹, jeœli numer telefonu jest pusty lub null
                    throw new ArgumentException($"Phone number is empty or null!");

                //jeœli numer telefonu nie jest poprawny (nie sk³ada siê z 9 cyfr) rzucamy wyj¹tek ArgumentException z odpowiedni¹ informacj¹
                if (!IsCorrectPhoneNumber(value))
                    //rzucenie wyj¹tku ArgumentException z odpowiedni¹ informacj¹, jeœli numer telefonu jest niepoprawny
                    throw new ArgumentException($"Invalid phone number!");

                //przypisanie wartoœci polu phoneNumber - ustawianie wartoœci numeru telefonu
                phoneNumber = value;
            }
        }

        //deklaracja publicznej w³aœciwoœci Count, która zwraca iloœæ kontaktów w ksi¹¿ce telefonicznej
        public int Count => phoneBook.Count;

        //deklaracja publicznej metody AddContact, która dodaje kontakt do ksi¹¿ki telefonicznej
        public bool AddContact(string name, string number)
        {
            //jeœli ksi¹¿ka telefoniczna jest pe³na (iloœæ kontaktów równa pojemnoœci ksi¹¿ki telefonicznej) rzucamy wyj¹tek InvalidOperationException z odpowiedni¹ informacj¹
            if (Count == PhoneBookCapacity)
                //rzucenie wyj¹tku InvalidOperationException z odpowiedni¹ informacj¹, jeœli ksi¹¿ka telefoniczna jest pe³na
                throw new InvalidOperationException("Phonebook is full!");

            //jeœli ksi¹¿ka telefoniczna nie zawiera kontaktu o podanej nazwie, dodajemy kontakt do ksi¹¿ki telefonicznej
            if (!phoneBook.ContainsKey(name))
            {
                //dodanie kontaktu do ksi¹¿ki telefonicznej
                phoneBook.Add(name, number);

                //zwrócenie wartoœci true, jeœli kontakt zosta³ dodany
                return true;
            }

            //zwrócenie wartoœci false, jeœli kontakt o danej nazwie ju¿ istnieje w ksi¹¿ce telefonicznej
            return false;
        }

        //deklaracja publicznej metody Call do dzownienia, do osoby na podstawie podanej nazwy
        public string Call(string name)
        {
            //jeœli ksi¹¿ka telefoniczna zawiera kontakt o podanej nazwie, dzwonimy do osoby
            if (phoneBook.ContainsKey(name))
            {
                //pobranie numeru telefonu osoby o podanej nazwie
                var number = phoneBook[name];
                //zwrócenie informacji o dzwonieniu do osoby o podanej nazwie
                return $"Calling {number} ({name}) ...";
            }

            //rzucenie wyj¹tku InvalidOperationException z odpowiedni¹ informacj¹, jeœli osoba o podanej nazwie nie istnieje w ksi¹¿ce telefonicznej
            throw new InvalidOperationException("Person doesn't exists!");
        }
    }
}
