using ClassLibrary;

//Piotr Bacior - Informatyka stosowana - I rok WSEI - 15 722 
namespace TestProjectPhone
    
{
    //deklaracja klasy UnitTest1
    [TestClass]
    public class UnitTest1
    {
        //Test metody konstruktora z poprawnymi danymi wej�ciowymi

        //Atrybut oznaczaj�cy metod� jako testow�
        [TestMethod]

        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora
        public void Test_Konstruktor_Dane_poprawne()
        {
            //AAA

            //Arrange - przygotowanie danych testowych
            var wlasciciel = "Bacior";                              //przypadek kiedy w�a�cicielem telefonu jest Bacior
            var numerTelefonu = "123456789";                        //przypadek kiedy numer telefonu jest poprawny

            //Act - wykonanie testowanego kodu 
            var phone = new Phone(wlasciciel, numerTelefonu);       //utworzenie obiektu klasy Phone z�ozo�onej z w�a�ciciela i numeru telefonu 

            //Assert - sprawdzenie poprawno�ci dzia�ania testowanego kodu 
            
            Assert.AreEqual(wlasciciel, phone.Owner);               //sprawdzenie czy w�a�cicielem telefonu jest Bacior
            Assert.AreEqual(numerTelefonu, phone.PhoneNumber);      //sprawdzenie czy numer telefonu jest poprawny
        }


        //Test metody konstruktora z niepoprawnymi danymi wej�ciowymi
        //Atrybut oznaczaj�cy metod� jako testow�
        [TestMethod]

        //Atrybut oznaczaj�cy, �e metoda powinna zako�czy� si� wyj�tkiem ArgumentException
        [ExpectedException(typeof(ArgumentException))]

        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora
        public void Test_Konstruktor_Pusty_Wlascicel()
        {
            //Arange - przygotowanie danych testowych 
            var wlasciciel = "";                                    //przypadek kiedy w�a�cicielem telefonu jest pusty
            var numerTelefonu = "123456789";                        //przypadek kiedy numer telefonu jest poprawny

            //Act - wykonanie testowanego kodu
            var phone = new Phone(wlasciciel, numerTelefonu);       //utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu


            //Assert - sprawdzenie poprawno�ci dzia�ania testowanego kodu
            /* Wymagane jest rzucenie wyj�tku ArgumentException, kt�ry mamy oznaczony
            w ExpectedException powy�ej, b��d wyskoczy gdy w�a�ciciel b�dzie pusty */
        }


        //Test metody konstruktora z niepoprawnymi danymi wej�ciowymi
        [TestMethod]

        //Atrybut oznaczaj�cy, �e metoda powinna zako�czy� si� wyj�tkiem ArgumentException
        [ExpectedException(typeof(ArgumentException))]

        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora
        public void Test_Konstruktor_Niepoprawny_Numer()
        {
            //Arange - przygotowanie danych testowych
            var wlasciciel = "Bacior";                              //przypadek kiedy w�a�cicielem telefonu jest Bacior
            var numerTelefonu = "1234";                             //przypadek kiedy to podany numer telefonu jest za kr�tki (mniejszy ni� 9 cyfr)

            //Act - wykonanie testowanego kodu 
            var phone = new Phone(wlasciciel, numerTelefonu);       //utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu


            //Assert - sprawdzenie poprawno�ci dzia�ania testowanego kodu
            /* Wymagane jest rzucenie wyj�tku ArgumentException, kt�ry mamy oznaczony 
            w ExpectedException powy�ej - b��d wyskoczy, gdy numer b�dzie zbyt kr�tki */
        }


        //Test metody konstruktora z niepoprawnymi danymi wej�ciowymi
        [TestMethod]

        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora
        public void Test_Konstruktor_AddContact_PoprawneDane()
        {
            // Arrange - przygotowanie danych testowych
            var phone = new Phone("Bacior", "123456789");           //Utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu 
            var contactName = "Tomczyk";                            //Przypadek kiedy dodajemy kontakt o nazwie Tomczyk
            var contactNumber = "987654321";                        //Przypadek kiedy dodajemy kontakt o numerze 987654321

            // Act - wykonanie testowanego kodu
            var result = phone.AddContact(contactName, contactNumber);  //Dodanie kontaktu o nazwie Tomczyk i numerze 987654321

            // Assert - sprawdzenie poprawno�ci wynik�w
            Assert.IsTrue(result);                                  //Sprawdzenie, czy kontakt zosta� dodany
            Assert.AreEqual(1, phone.Count);                        //Sprawdzenie, czy liczba kontakt�w wynosi 1
        }


        //Test metody konstruktora z niepoprawnymi danymi wej�ciowymi
        [TestMethod]

        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora
        public void Test_Konstruktor_Call_Istniaj�ca_Osoba()
        {
            //Arrange - przygotowanie danych testowych
            var phone = new Phone("Bacior", "123456789");           //Utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu
            phone.AddContact("Tomczyk", "987654321");               //Dodanie kontaktu o nazwie Tomczyk i numerze 987654321

            //Act - wykonanie testowanego kodu
            var wynik = phone.Call("Tomczyk");                      //Wywo�anie metody Call dla osoby o nazwie Tomczyk

            //Assert - sprawdzenie poprawno�ci wynik�w
            Assert.AreEqual("Calling 987654321 (Tomczyk) ...", wynik); //Sprawdzenie, czy dzwonimy do osoby o nazwie Tomczyk
        }


        //Test metody konstruktora z niepoprawnymi danymi wej�ciowymi
        [TestMethod]

        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora
        [ExpectedException(typeof(InvalidOperationException))]

        //Atrybut oznaczaj�cy, �e metoda powinna zako�czy� si� wyj�tkiem ArgumentException
        public void Test_Konstruktor_Call_Nieistniej�ca_Osoba()
        {
            //Arrange - przygotowanie danych testowych
            var phone = new Phone("Bacior", "123456789");           //Utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu

            //Act - wykonanie testowanego kodu
            phone.Call("�eu�eu");                                   //Wywo�anie metody Call dla osoby o nieistniej�cej nazwie "�eu�eu"


            //Assert - sprawdzenie poprawno�ci wynik�w
            /* Wymagane jest rzucenie wyj�tku ArgumentException, kt�ry mamy oznaczony 
            w ExpectedException powy�ej - b��d wyskoczy, gdy numer b�dzie zbyt kr�tki */
        }


        //Test metody konstruktora z niepoprawnymi danymi wej�ciowymi
        [TestMethod]

        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora
        [ExpectedException(typeof(InvalidOperationException))]

        //Atrybut oznaczaj�cy, �e metoda powinna zako�czy� si� wyj�tkiem ArgumentException
        public void Test_Konstruktor_AddContact_Pe�na_Ksi��ka()
        {
            //Arrange - przygotowanie danych testowych
            var phone = new Phone("Bacior", "123456789");           //Utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu

            //Act - wykonanie testowanego kodu
            for (int i = 0; i < phone.PhoneBookCapacity; i++)       //Dodanie kontakt�w do ksi��ki telefonicznej
            {
                phone.AddContact("Kontakt" + i, "12345678");        //Dodanie kontakt�w o nazwach Kontakt0, Kontakt1, Kontakt2, itd.
            }

            phone.AddContact("Kontakt", "12345678");                //Dodanie kontaktu o nazwie Kontakt


            //Assert - sprawdzenie poprawno�ci wynik�w
            /* Wymagane jest rzucenie wyj�tku InvalidOperationException, kt�ry mamy oznaczony
            w ExpectedException powy�ej - b��d wyskoczy, gdy numer b�dzie zbyt kr�tki */
        }


        [TestMethod]
        public void Test_Konstruktor_AddContact_Istniaj�cyKontakt()
        {
            //Arrange - przygotowanie danych testowych
            var phone = new Phone("Bacior", "123456789");           //Utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu
            var kontakt = "Pawe�";
            var numer = "987654321";
            phone.AddContact(kontakt, numer);                       //Dodanie kontaktu o nazwie Pawe� i numerze 987654321

            //Act - wykonanie testowanego kodu
            var wynik = phone.AddContact(kontakt, numer);           //Dodanie kontaktu o nazwie Pawe� i numerze 987654321

            //Assert - sprawdzenie poprawno�ci wynik�w
            Assert.IsFalse(wynik);                                  //Sprawdzenie, czy kontakt nie zosta� dodany
            Assert.AreEqual(1, phone.Count);                        //Sprawdzenie, czy liczba kontakt�w wynosi 1

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Konstruktor_Pusty_NumerTelefonu()
        {
            //Arrange - przygotowanie danych testowych
            var wlasciciel = "Bacior";                              //przypadek kiedy w�a�cicielem telefonu jest Bacior
            var numerTelefonu = "";                                 //przypadek kiedy numer telefonu jest pusty

            //Act - wykonanie testowanego kodu
            var wynik = new Phone(wlasciciel, numerTelefonu);       //utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu


            //Assert - sprawdzenie poprawno�ci wynik�w
            /* Wymagane jest rzucenie wyj�tku ArgumentException, kt�ry mamy oznaczony
            w ExpectedException powy�ej - b��d wyskoczy, gdy numer b�dzie zbyt kr�tki */
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Konstruktor_Null_NumerTelefonu()
        {
            //Arrange - przygotowanie danych testowych
            var wlasciciel = "Bacior";                              //przypadek kiedy w�a�cicielem telefonu jest Bacior
            string numerTelefonu = null;                            //przypadek kiedy numer telefonu jest null

            //Act - wykonanie testowanego kodu
            var wynik = new Phone(wlasciciel, numerTelefonu);       //utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu


            //Assert - sprawdzenie poprawno�ci wynik�w
            /* Wymagane jest rzucenie wyj�tku ArgumentException, kt�ry mamy oznaczony
            w ExpectedException powy�ej - b��d wyskoczy, gdy numer b�dzie zbyt kr�tki */
        }

        [TestMethod]
        public void Test_KsiazkaTelefonicznaCapacity()
        {
            //Arrange - przygotowanie danych testowych
            var telefon = new Phone("Bacior", "123456789");         //Utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu

            //Act - wykonanie testowanego kodu
            var pojemno�� = telefon.PhoneBookCapacity;              //Pobranie pojemno�ci ksi��ki telefonicznej

            //Assert - sprawdzenie poprawno�ci wynik�w
            Assert.AreEqual(100, pojemno��);
        }

        [TestMethod]
        public void Test_Count()
        {
            //Arrange - przygotowanie danych testowych
            var telefon = new Phone("Bacior", "123456789");         //Utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu

            //Act - wykonanie testowanego kodu
            telefon.AddContact("Tomczyk", "987654321");             //Dodanie kontaktu o nazwie Tomczyk i numerze 987654321
            var wynik = telefon.Count;                              //Pobranie liczby kontakt�w w ksi��ce telefonicznej

            //Assert - sprawdzenie poprawno�ci wynik�w
            Assert.AreEqual(1, wynik);                              //Sprawdzenie, czy liczba kontakt�w wynosi 1
        }
    }
}