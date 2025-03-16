using ClassLibrary;

//Piotr Bacior - Informatyka stosowana - I rok WSEI - 15 722 
namespace TestProjectPhone
    
{
    //Poni�ej trzy testy jednostkowe dla klasy Phone - Testy dla w�a�ciciela telefonu (Owner)

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
            //AAA - Arrange, Act, Assert

            //Arrange - przygotowanie danych testowych
            var w�a�ciciel = "Bacior";                              //przypadek kiedy w�a�cicielem telefonu jest Bacior
            var numerTelefonu = "123456789";                        //przypadek kiedy numer telefonu jest poprawny

            //Act - wykonanie testowanego kodu 
            var phone = new Phone(w�a�ciciel, numerTelefonu);       //utworzenie obiektu klasy Phone z�ozo�onej z w�a�ciciela i numeru telefonu 

            //Assert - sprawdzenie poprawno�ci dzia�ania testowanego kodu 
            
            Assert.AreEqual(w�a�ciciel, phone.Owner);               //sprawdzenie czy w�a�cicielem telefonu jest Bacior
            Assert.AreEqual(numerTelefonu, phone.PhoneNumber);      //sprawdzenie czy numer telefonu jest poprawny
        }


        //Test metody konstruktora z niepoprawnymi danymi wej�ciowymi - pusty w�a�ciciel telefonu
        //Atrybut oznaczaj�cy metod� jako testow�
        [TestMethod]

        //Atrybut oznaczaj�cy, �e metoda powinna zako�czy� si� wyj�tkiem ArgumentException
        [ExpectedException(typeof(ArgumentException))]

        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora w przypadku pustego w�a�ciciela telefonu
        public void Test_Konstruktor_Pusty_Wlascicel()
        {
            //Arange - przygotowanie danych testowych 
            var w�a�ciciel = "";                                    //przypadek kiedy w�a�cicielem telefonu jest pusty
            var numerTelefonu = "123456789";                        //przypadek kiedy numer telefonu jest poprawny

            //Act - wykonanie testowanego kodu
            var phone = new Phone(w�a�ciciel, numerTelefonu);       //utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu


            //Assert - sprawdzenie poprawno�ci dzia�ania testowanego kodu
            /* Wymagane jest rzucenie wyj�tku ArgumentException, kt�ry mamy oznaczony
            w ExpectedException powy�ej, b��d wyskoczy gdy w�a�ciciel b�dzie pusty */
        }


        //Test metody konstruktora z nieprawid�owymi danymi wej�ciowymi - w�a�ciciel telefonu null
        //Atrybut oznaczaj�cy metod� jako testow�
        [TestMethod]

        //Atrybut oznaczaj�cy, �e metoda powinna zako�czy� si� wyj�tkiem ArgumentException
        [ExpectedException(typeof(ArgumentException))]

        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora w przypadku null w�a�ciciela telefonu
        public void Test_Konstruktor_Null_Wlascicel()
        {
            //Arrange - przygotowanie danych testowych
            string w�a�ciciel = null;                               //przypadek kiedy w�a�cicielem telefonu jest null
            var numerTelefonu = "123456789";                        //przypadek kiedy numer telefonu jest poprawny

            //Act - wykonanie testowanego kodu
            var phone = new Phone(w�a�ciciel, numerTelefonu);       //utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu

            //Assert - sprawdzenie poprawno�ci dzia�ania testowanego kodu
            /* Wymagane jest rzucenie wyj�tku ArgumentException, kt�ry mamy oznaczony
            w ExpectedException powy�ej, b��d wyskoczy gdy w�a�ciciel b�dzie null */
        }


        //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        //Poni�ej trzy testy jednostkowe dla klasy Phone - Testy dla numeru telefonu (PhoneNumber)


        //Test metody konstruktora z niepoprawnymi danymi wej�ciowymi - niepoprawny numer - za kr�tki numerTelefonu (mniej ni� 9 cyfr)
        //Atrybut oznaczaj�cy metod� jako testow�
        [TestMethod]

        //Atrybut oznaczaj�cy, �e metoda powinna zako�czy� si� wyj�tkiem ArgumentException
        [ExpectedException(typeof(ArgumentException))]

        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora
        public void Test_Konstruktor_Niepoprawny_Numer()
        {
            //Arange - przygotowanie danych testowych
            var w�a�ciciel = "Bacior";                              //przypadek kiedy w�a�cicielem telefonu jest Bacior
            var numerTelefonu = "1234";                             //przypadek kiedy to podany numer telefonu jest za kr�tki (mniejszy ni� 9 cyfr)

            //Act - wykonanie testowanego kodu 
            var phone = new Phone(w�a�ciciel, numerTelefonu);       //utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu


            //Assert - sprawdzenie poprawno�ci dzia�ania testowanego kodu
            /* Wymagane jest rzucenie wyj�tku ArgumentException, kt�ry mamy oznaczony 
            w ExpectedException powy�ej - b��d wyskoczy, gdy numer b�dzie zbyt kr�tki */
        }


        //Test metody konstruktora z niepoprawnymi danymi wej�ciowymi - pusty NumerTelefonu
        //Atrybut oznaczaj�cy metod� jako testow�
        [TestMethod]

        //Atrybut oznaczaj�cy, �e metoda powinna zako�czy� si� wyj�tkiem ArgumentException
        [ExpectedException(typeof(ArgumentException))]

        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora
        public void Test_Konstruktor_Pusty_NumerTelefonu()
        {
            //Arrange - przygotowanie danych testowych
            var w�a�ciciel = "Bacior";                              //przypadek kiedy w�a�cicielem telefonu jest Bacior
            var numerTelefonu = "";                                 //przypadek kiedy numer telefonu jest pusty

            //Act - wykonanie testowanego kodu
            var wynik = new Phone(w�a�ciciel, numerTelefonu);       //utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu


            //Assert - sprawdzenie poprawno�ci wynik�w
            /* Wymagane jest rzucenie wyj�tku ArgumentException, kt�ry mamy oznaczony
            w ExpectedException powy�ej - b��d wyskoczy, gdy numerTelefonu b�dzie pusty */
        }


        //Test metody konstruktora z niepoprawnymi danymi wej�ciowymi - null NumerTelefonu
        //Atrybut oznaczaj�cy metod� jako testow�
        [TestMethod]

        //Atrybut oznaczaj�cy, �e metoda powinna zako�czy� si� wyj�tkiem ArgumentException
        [ExpectedException(typeof(ArgumentException))]

        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora
        public void Test_Konstruktor_Null_NumerTelefonu()
        {
            //Arrange - przygotowanie danych testowych
            var w�a�ciciel = "Bacior";                              //przypadek kiedy w�a�cicielem telefonu jest Bacior
            string numerTelefonu = null;                            //przypadek kiedy numer telefonu jest null

            //Act - wykonanie testowanego kodu
            var wynik = new Phone(w�a�ciciel, numerTelefonu);       //utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu


            //Assert - sprawdzenie poprawno�ci wynik�w
            /* Wymagane jest rzucenie wyj�tku ArgumentException, kt�ry mamy oznaczony
            w ExpectedException powy�ej - b��d wyskoczy, gdy numerTelefonu b�dzie null'em */
        }


        //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        //Poni�ej trzy testy jednostkowe dla klasy Phone - Testy dla dodawania kontakt�w do ksi��ki telefonicznej (AddContact) przy poprawnych danych wej�ciowych


        //Test metody konstruktora z poprawnymi danymi wej�ciowymi AddContact
        //Atrybut oznaczaj�cy metod� jako testow�
        [TestMethod]

        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora
        public void Test_Konstruktor_AddContact_PoprawneDane()
        {
            // Arrange - przygotowanie danych testowych
            var phone = new Phone("Bacior", "123456789");           //Utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu 
            var NazwaKontaktu = "Tomczyk";                            //Przypadek kiedy dodajemy kontakt o nazwie Tomczyk
            var NumerKontaktu = "987654321";                        //Przypadek kiedy dodajemy kontakt o numerze 987654321

            // Act - wykonanie testowanego kodu
            var result = phone.AddContact(NazwaKontaktu, NumerKontaktu);  //Dodanie kontaktu o nazwie Tomczyk i numerze 987654321

            // Assert - sprawdzenie poprawno�ci wynik�w
            Assert.IsTrue(result);                                  //Sprawdzenie, czy kontakt zosta� dodany
            Assert.AreEqual(1, phone.Count);                        //Sprawdzenie, czy liczba kontakt�w wynosi 1
        }


        //Test metody konstruktora z niepoprawnymi danymi wej�ciowymi AddContact - pe�na ksi��ka telefoniczna
        //Atrybut oznaczaj�cy metod� jako testow�
        [TestMethod]

        //Atrybut oznaczaj�cy, �e metoda powinna zako�czy� si� wyj�tkiem ArgumentException
        [ExpectedException(typeof(InvalidOperationException))]

        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora
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
            w ExpectedException powy�ej - b��d wyskoczy, gdy ksi��ka telefoniczna b�dzie pe�na */
        }


        //Test metody konstruktora z niepoprawnymi danymi wej�ciowymi AddContact - istniej�cy kontakt
        //Atrybut oznaczaj�cy metod� jako testow�
        [TestMethod]
        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora
        public void Test_Konstruktor_AddContact_Istniaj�cyKontakt()
        {
            //Arrange - przygotowanie danych testowych
            var phone = new Phone("Bacior", "123456789");           //Utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu
            var kontakt = "Pawe�";
            var numer = "987654321";
            phone.AddContact(kontakt, numer);                       //Dodanie kontaktu o nazwie Pawe� i numerze 987654321

            //Act - wykonanie testowanego kodu
            var wynik = phone.AddContact(kontakt, numer);           //Ponowne dodanie kontaktu o nazwie Pawe� i numerze 987654321 (kontakt ju� istnieje)

            //Assert - sprawdzenie poprawno�ci wynik�w
            Assert.IsFalse(wynik);                                  //Sprawdzenie, czy kontakt nie zosta� dodany
            Assert.AreEqual(1, phone.Count);                        //Sprawdzenie, czy liczba kontakt�w wynosi 1

        }


        //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        //Poni�ej trzy testy jednostkowe dla klasy Phone - Testy dla dzwonienia (Call)


        //Test metody konstruktora z poprawnymi danymi wej�ciowymi Call - istniej�ca osoba
        //Atrybut oznaczaj�cy metod� jako testow�
        [TestMethod]

        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora
        public void Test_Konstruktor_Call_Istniaj�ca_Osoba()
        {
            //Arrange - przygotowanie danych testowych
            var phone = new Phone("Bacior", "123456789");               //Utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu
            phone.AddContact("Tomczyk", "987654321");                   //Dodanie kontaktu o nazwie Tomczyk i numerze 987654321

            //Act - wykonanie testowanego kodu
            var wynik = phone.Call("Tomczyk");                          //Wywo�anie metody Call dla osoby o nazwie Tomczyk

            //Assert - sprawdzenie poprawno�ci wynik�w
            Assert.AreEqual("Calling 987654321 (Tomczyk) ...", wynik);  //Sprawdzenie, czy dzwonimy do osoby o nazwie Tomczyk
        }


        //Test metody konstruktora z niepoprawnymi danymi wej�ciowymi Call - nieistniej�ca osoba
        //Atrybut oznaczaj�cy metod� jako testow�
        [TestMethod]

        //Atrybut oznaczaj�cy, �e metoda powinna zako�czy� si� wyj�tkiem ArgumentException
        [ExpectedException(typeof(InvalidOperationException))]

        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora
        public void Test_Konstruktor_Call_Nieistniej�ca_Osoba()
        {
            //Arrange - przygotowanie danych testowych
            var phone = new Phone("Bacior", "123456789");               //Utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu

            //Act - wykonanie testowanego kodu
            phone.Call("�eu�eu");                                       //Wywo�anie metody Call dla osoby o nieistniej�cej nazwie "�eu�eu"


            //Assert - sprawdzenie poprawno�ci wynik�w
            /* Wymagane jest rzucenie wyj�tku ArgumentException, kt�ry mamy oznaczony 
            w ExpectedException powy�ej - b��d wyskoczy, gdy spr�bujemy zadzowni� do nieistniej�cej osoby */
        }


        //*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*
        //Poni�ej trzy testy jednostkowe dla klasy Phone - Testy dla w�a�ciwo�ci Count oraz PhoneBookCapacity (pojemno�� ksi��ki telefonicznej)


        //Test metody konstruktora z poprawnymi danymi wej�ciowymi Ksi��kaTelefonicznaCapacity
        //Atrybut oznaczaj�cy metod� jako testow�
        [TestMethod]

        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora
        public void Test_KsiazkaTelefonicznaCapacity()
        {
            //Arrange - przygotowanie danych testowych
            var telefon = new Phone("Bacior", "123456789");         //Utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu

            //Act - wykonanie testowanego kodu
            var pojemno�� = telefon.PhoneBookCapacity;              //Pobranie pojemno�ci ksi��ki telefonicznej

            //Assert - sprawdzenie poprawno�ci wynik�w
            Assert.AreEqual(100, pojemno��);                        //Sprawdzenie, czy pojemno�� ksi��ki telefonicznej wynosi 100
        }


        //Test metody konstruktora z poprawnymi danymi wej�ciowymi Count
        //Atrybut oznaczaj�cy metod� jako testow�
        [TestMethod]

        //Metoda testowa sprawdzaj�ca poprawno�� dzia�ania konstruktora
        public void Test_Count()
        {
            //Arrange - przygotowanie danych testowych
            var telefon = new Phone("Bacior", "123456789");         //Utworzenie obiektu klasy Phone z w�a�cicielem i numerem telefonu
            telefon.AddContact("Tomczyk", "987654321");             //Dodanie kontaktu o nazwie Tomczyk i numerze 987654321

            //Act - wykonanie testowanego kodu          
            var wynik = telefon.Count;                              //Pobranie liczby kontakt�w w ksi��ce telefonicznej

            //Assert - sprawdzenie poprawno�ci wynik�w
            Assert.AreEqual(1, wynik);                              //Sprawdzenie, czy liczba kontakt�w wynosi 1
        }
    }
}