using ClassLibrary;

//Piotr Bacior - Informatyka stosowana - I rok WSEI - 15 722 
namespace TestProjectPhone
    
{
    //deklaracja klasy UnitTest1
    [TestClass]
    public class UnitTest1
    {
        //Test metody konstruktora z poprawnymi danymi wejœciowymi

        //Atrybut oznaczaj¹cy metodê jako testow¹
        [TestMethod]

        //Metoda testowa sprawdzaj¹ca poprawnoœæ dzia³ania konstruktora
        public void Test_Konstruktor_Dane_poprawne()
        {
            //AAA

            //Arrange - przygotowanie danych testowych
            var wlasciciel = "Bacior";                              //przypadek kiedy w³aœcicielem telefonu jest Bacior
            var numerTelefonu = "123456789";                        //przypadek kiedy numer telefonu jest poprawny

            //Act - wykonanie testowanego kodu 
            var phone = new Phone(wlasciciel, numerTelefonu);       //utworzenie obiektu klasy Phone z³ozo¿onej z w³aœciciela i numeru telefonu 

            //Assert - sprawdzenie poprawnoœci dzia³ania testowanego kodu 
            
            Assert.AreEqual(wlasciciel, phone.Owner);               //sprawdzenie czy w³aœcicielem telefonu jest Bacior
            Assert.AreEqual(numerTelefonu, phone.PhoneNumber);      //sprawdzenie czy numer telefonu jest poprawny
        }


        //Test metody konstruktora z niepoprawnymi danymi wejœciowymi
        //Atrybut oznaczaj¹cy metodê jako testow¹
        [TestMethod]

        //Atrybut oznaczaj¹cy, ¿e metoda powinna zakoñczyæ siê wyj¹tkiem ArgumentException
        [ExpectedException(typeof(ArgumentException))]

        //Metoda testowa sprawdzaj¹ca poprawnoœæ dzia³ania konstruktora
        public void Test_Konstruktor_Pusty_Wlascicel()
        {
            //Arange - przygotowanie danych testowych 
            var wlasciciel = "";                                    //przypadek kiedy w³aœcicielem telefonu jest pusty
            var numerTelefonu = "123456789";                        //przypadek kiedy numer telefonu jest poprawny

            //Act - wykonanie testowanego kodu
            var phone = new Phone(wlasciciel, numerTelefonu);       //utworzenie obiektu klasy Phone z w³aœcicielem i numerem telefonu


            //Assert - sprawdzenie poprawnoœci dzia³ania testowanego kodu
            /* Wymagane jest rzucenie wyj¹tku ArgumentException, który mamy oznaczony
            w ExpectedException powy¿ej, b³¹d wyskoczy gdy w³aœciciel bêdzie pusty */
        }


        //Test metody konstruktora z niepoprawnymi danymi wejœciowymi
        [TestMethod]

        //Atrybut oznaczaj¹cy, ¿e metoda powinna zakoñczyæ siê wyj¹tkiem ArgumentException
        [ExpectedException(typeof(ArgumentException))]

        //Metoda testowa sprawdzaj¹ca poprawnoœæ dzia³ania konstruktora
        public void Test_Konstruktor_Niepoprawny_Numer()
        {
            //Arange - przygotowanie danych testowych
            var wlasciciel = "Bacior";                              //przypadek kiedy w³aœcicielem telefonu jest Bacior
            var numerTelefonu = "1234";                             //przypadek kiedy to podany numer telefonu jest za krótki (mniejszy ni¿ 9 cyfr)

            //Act - wykonanie testowanego kodu 
            var phone = new Phone(wlasciciel, numerTelefonu);       //utworzenie obiektu klasy Phone z w³aœcicielem i numerem telefonu


            //Assert - sprawdzenie poprawnoœci dzia³ania testowanego kodu
            /* Wymagane jest rzucenie wyj¹tku ArgumentException, który mamy oznaczony 
            w ExpectedException powy¿ej - b³¹d wyskoczy, gdy numer bêdzie zbyt krótki */
        }


        //Test metody konstruktora z niepoprawnymi danymi wejœciowymi
        [TestMethod]

        //Metoda testowa sprawdzaj¹ca poprawnoœæ dzia³ania konstruktora
        public void Test_Konstruktor_AddContact_PoprawneDane()
        {
            // Arrange - przygotowanie danych testowych
            var phone = new Phone("Bacior", "123456789");           //Utworzenie obiektu klasy Phone z w³aœcicielem i numerem telefonu 
            var contactName = "Tomczyk";                            //Przypadek kiedy dodajemy kontakt o nazwie Tomczyk
            var contactNumber = "987654321";                        //Przypadek kiedy dodajemy kontakt o numerze 987654321

            // Act - wykonanie testowanego kodu
            var result = phone.AddContact(contactName, contactNumber);  //Dodanie kontaktu o nazwie Tomczyk i numerze 987654321

            // Assert - sprawdzenie poprawnoœci wyników
            Assert.IsTrue(result);                                  //Sprawdzenie, czy kontakt zosta³ dodany
            Assert.AreEqual(1, phone.Count);                        //Sprawdzenie, czy liczba kontaktów wynosi 1
        }


        //Test metody konstruktora z niepoprawnymi danymi wejœciowymi
        [TestMethod]

        //Metoda testowa sprawdzaj¹ca poprawnoœæ dzia³ania konstruktora
        public void Test_Konstruktor_Call_Istniaj¹ca_Osoba()
        {
            //Arrange - przygotowanie danych testowych
            var phone = new Phone("Bacior", "123456789");           //Utworzenie obiektu klasy Phone z w³aœcicielem i numerem telefonu
            phone.AddContact("Tomczyk", "987654321");               //Dodanie kontaktu o nazwie Tomczyk i numerze 987654321

            //Act - wykonanie testowanego kodu
            var wynik = phone.Call("Tomczyk");                      //Wywo³anie metody Call dla osoby o nazwie Tomczyk

            //Assert - sprawdzenie poprawnoœci wyników
            Assert.AreEqual("Calling 987654321 (Tomczyk) ...", wynik); //Sprawdzenie, czy dzwonimy do osoby o nazwie Tomczyk
        }


        //Test metody konstruktora z niepoprawnymi danymi wejœciowymi
        [TestMethod]

        //Metoda testowa sprawdzaj¹ca poprawnoœæ dzia³ania konstruktora
        [ExpectedException(typeof(InvalidOperationException))]

        //Atrybut oznaczaj¹cy, ¿e metoda powinna zakoñczyæ siê wyj¹tkiem ArgumentException
        public void Test_Konstruktor_Call_Nieistniej¹ca_Osoba()
        {
            //Arrange - przygotowanie danych testowych
            var phone = new Phone("Bacior", "123456789");           //Utworzenie obiektu klasy Phone z w³aœcicielem i numerem telefonu

            //Act - wykonanie testowanego kodu
            phone.Call("£eu£eu");                                   //Wywo³anie metody Call dla osoby o nieistniej¹cej nazwie "£eu£eu"


            //Assert - sprawdzenie poprawnoœci wyników
            /* Wymagane jest rzucenie wyj¹tku ArgumentException, który mamy oznaczony 
            w ExpectedException powy¿ej - b³¹d wyskoczy, gdy numer bêdzie zbyt krótki */
        }


        //Test metody konstruktora z niepoprawnymi danymi wejœciowymi
        [TestMethod]

        //Metoda testowa sprawdzaj¹ca poprawnoœæ dzia³ania konstruktora
        [ExpectedException(typeof(InvalidOperationException))]

        //Atrybut oznaczaj¹cy, ¿e metoda powinna zakoñczyæ siê wyj¹tkiem ArgumentException
        public void Test_Konstruktor_AddContact_Pe³na_Ksi¹¿ka()
        {
            //Arrange - przygotowanie danych testowych
            var phone = new Phone("Bacior", "123456789");           //Utworzenie obiektu klasy Phone z w³aœcicielem i numerem telefonu

            //Act - wykonanie testowanego kodu
            for (int i = 0; i < phone.PhoneBookCapacity; i++)       //Dodanie kontaktów do ksi¹¿ki telefonicznej
            {
                phone.AddContact("Kontakt" + i, "12345678");        //Dodanie kontaktów o nazwach Kontakt0, Kontakt1, Kontakt2, itd.
            }

            phone.AddContact("Kontakt", "12345678");                //Dodanie kontaktu o nazwie Kontakt


            //Assert - sprawdzenie poprawnoœci wyników
            /* Wymagane jest rzucenie wyj¹tku InvalidOperationException, który mamy oznaczony
            w ExpectedException powy¿ej - b³¹d wyskoczy, gdy numer bêdzie zbyt krótki */
        }


        [TestMethod]
        public void Test_Konstruktor_AddContact_Istniaj¹cyKontakt()
        {
            //Arrange - przygotowanie danych testowych
            var phone = new Phone("Bacior", "123456789");           //Utworzenie obiektu klasy Phone z w³aœcicielem i numerem telefonu
            var kontakt = "Pawe³";
            var numer = "987654321";
            phone.AddContact(kontakt, numer);                       //Dodanie kontaktu o nazwie Pawe³ i numerze 987654321

            //Act - wykonanie testowanego kodu
            var wynik = phone.AddContact(kontakt, numer);           //Dodanie kontaktu o nazwie Pawe³ i numerze 987654321

            //Assert - sprawdzenie poprawnoœci wyników
            Assert.IsFalse(wynik);                                  //Sprawdzenie, czy kontakt nie zosta³ dodany
            Assert.AreEqual(1, phone.Count);                        //Sprawdzenie, czy liczba kontaktów wynosi 1

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Konstruktor_Pusty_NumerTelefonu()
        {
            //Arrange - przygotowanie danych testowych
            var wlasciciel = "Bacior";                              //przypadek kiedy w³aœcicielem telefonu jest Bacior
            var numerTelefonu = "";                                 //przypadek kiedy numer telefonu jest pusty

            //Act - wykonanie testowanego kodu
            var wynik = new Phone(wlasciciel, numerTelefonu);       //utworzenie obiektu klasy Phone z w³aœcicielem i numerem telefonu


            //Assert - sprawdzenie poprawnoœci wyników
            /* Wymagane jest rzucenie wyj¹tku ArgumentException, który mamy oznaczony
            w ExpectedException powy¿ej - b³¹d wyskoczy, gdy numer bêdzie zbyt krótki */
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Konstruktor_Null_NumerTelefonu()
        {
            //Arrange - przygotowanie danych testowych
            var wlasciciel = "Bacior";                              //przypadek kiedy w³aœcicielem telefonu jest Bacior
            string numerTelefonu = null;                            //przypadek kiedy numer telefonu jest null

            //Act - wykonanie testowanego kodu
            var wynik = new Phone(wlasciciel, numerTelefonu);       //utworzenie obiektu klasy Phone z w³aœcicielem i numerem telefonu


            //Assert - sprawdzenie poprawnoœci wyników
            /* Wymagane jest rzucenie wyj¹tku ArgumentException, który mamy oznaczony
            w ExpectedException powy¿ej - b³¹d wyskoczy, gdy numer bêdzie zbyt krótki */
        }

        [TestMethod]
        public void Test_KsiazkaTelefonicznaCapacity()
        {
            //Arrange - przygotowanie danych testowych
            var telefon = new Phone("Bacior", "123456789");         //Utworzenie obiektu klasy Phone z w³aœcicielem i numerem telefonu

            //Act - wykonanie testowanego kodu
            var pojemnoœæ = telefon.PhoneBookCapacity;              //Pobranie pojemnoœci ksi¹¿ki telefonicznej

            //Assert - sprawdzenie poprawnoœci wyników
            Assert.AreEqual(100, pojemnoœæ);
        }

        [TestMethod]
        public void Test_Count()
        {
            //Arrange - przygotowanie danych testowych
            var telefon = new Phone("Bacior", "123456789");         //Utworzenie obiektu klasy Phone z w³aœcicielem i numerem telefonu

            //Act - wykonanie testowanego kodu
            telefon.AddContact("Tomczyk", "987654321");             //Dodanie kontaktu o nazwie Tomczyk i numerze 987654321
            var wynik = telefon.Count;                              //Pobranie liczby kontaktów w ksi¹¿ce telefonicznej

            //Assert - sprawdzenie poprawnoœci wyników
            Assert.AreEqual(1, wynik);                              //Sprawdzenie, czy liczba kontaktów wynosi 1
        }
    }
}