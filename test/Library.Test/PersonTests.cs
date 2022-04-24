using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {

        [Test]
        public void TestCorrectName() 
        {
            Person santiago = new Person("Santiago Severo", "5.219.678-2");
            string expected = "Soy Santiago Severo y mi cédula es 5.219.678-2";
            string actual = $"Soy {santiago.Name} y mi cédula es {santiago.ID}";

            Assert.AreEqual(expected,actual);
        }
        [Test]
        public void TestCedula1()
        {
            string cedula = "52196782";
            bool actual = IdUtils.IdIsValid(cedula);
            bool expected = true;
            Assert.AreEqual(expected,actual);    
        }
        [Test]
        public void TestCedula2()
        {
            string cedula = "5.219.678-2";//Con puntos y guión
            bool actual = IdUtils.IdIsValid(cedula);
            bool expected = true;
            Assert.AreEqual(expected,actual);    
        }
        [Test]
        public void TestCedula3()
        {
            string cedula = "521967823";//Mas de 8 dígitos
            bool actual = IdUtils.IdIsValid(cedula);
            bool expected = false;
            Assert.AreEqual(expected,actual);    
        }
        [Test]
        public void TestCedula4()
        {
            string cedula = "";// Cédula vacía
            bool actual = IdUtils.IdIsValid(cedula);
            bool expected = false;
            Assert.AreEqual(expected,actual);    
        }
    }
}