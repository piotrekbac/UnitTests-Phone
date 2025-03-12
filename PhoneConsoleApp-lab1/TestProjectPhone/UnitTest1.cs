using ClassLibrary;

namespace TestProjectPhone
    
{
    [TestClass]
    public class UnitTest1
    {
        //Test metody konstruktora z poprawnymi danymi wej�ciowymi
        [TestMethod]
        public void Test_Konstruktor_Dane_poprawne()
        {
            //AAA

            //Arrange - przygotowanie danych testowych
            var wlasciciel = "Molenda";
            var numerTelefonu = "123456789";

            //Act - wykonanie testowanego kodu 
            var phone = new Phone(wlasciciel, numerTelefonu);

            //Assert - sprawdzenie poprawno�ci dzia�ania testowanego kodu
            Assert.AreEqual(wlasciciel, phone.Owner);
            Assert.AreEqual(numerTelefonu, phone.PhoneNumber);

        }

        //Test metody konstruktora z niepoprawnymi danymi wej�ciowymi
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Test_Konstruktor_EmptyOwner()
        {
            //Arange - przygotowanie danych testowych 
            var owner = "";
            var phoneNumber = "123456789";

            //Act - wykonanie testowanego kodu
            var phone = new Phone(owner, phoneNumber);

            //Assert - sprawdzenie poprawno�ci dzia�ania testowanego kodu

            //Wymagane jest rzucenie wyj�tku ArgumentException, kt�ry mamy oznaczone w ExpectedException powy�ej

        }


    }
}