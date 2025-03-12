using ClassLibrary;

//Piotr Bacior - Informatyka stosowana - I rok WSEI - 15 722 
namespace TestProjectPhone
    
{
    [TestClass]
    public class UnitTest1
    {
        //Test metody konstruktora z poprawnymi danymi wejœciowymi
        [TestMethod]
        public void Test_Konstruktor_Dane_poprawne()
        {
            //AAA

            //Arrange - przygotowanie danych testowych
            var wlasciciel = "Bacior";
            var numerTelefonu = "123456789";

            //Act - wykonanie testowanego kodu 
            var phone = new Phone(wlasciciel, numerTelefonu);

            //Assert - sprawdzenie poprawnoœci dzia³ania testowanego kodu
            Assert.AreEqual(wlasciciel, phone.Owner);
            Assert.AreEqual(numerTelefonu, phone.PhoneNumber);

        }

        //Test metody konstruktora z niepoprawnymi danymi wejœciowymi
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Konstruktor_Pusty_Wlascicel()
        {
            //Arange - przygotowanie danych testowych 
            var wlasciciel = "";
            var numerTelefonu = "123456789";

            //Act - wykonanie testowanego kodu
            var phone = new Phone(wlasciciel, numerTelefonu);

            //Assert - sprawdzenie poprawnoœci dzia³ania testowanego kodu

            //Wymagane jest rzucenie wyj¹tku ArgumentException, który mamy oznaczone w ExpectedException powy¿ej

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Konstruktor_Niepoprawny_Numer()
        {
            //Arange - przygotowanie danych testowych
            var wlasciciel = "Bacior";
            var numerTelefonu = "1234"; //przypadek kiedy to podany numer telefonu jest za krótki (mniejszy ni¿ 9 cyfr)

            //Act - wykonanie testowanego kodu 
            var phone = new Phone(wlasciciel, numerTelefonu);

            //Assert - sprawdzenie poprawnoœci dzia³ania testowanego kodu

        }
    }
}