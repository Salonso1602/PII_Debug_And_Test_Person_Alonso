using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    [TestFixture]
    public class Tests
    {
        /*[SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        } */

        [Test]
        public void TestNameYCI() // Cambiá el nombre para indicar qué estás probando
        {
            Person john = new Person("John Doe", "5.212.287-6", "16/08/2002");
            string expectedname = "John Doe";
            string expectedci = "5.212.287-6";
            Assert.AreEqual(expectedname, john.Name);
            Assert.AreEqual(expectedci, john.ID);
        }

        [Test]
        public void TestNameYCIErroneo() // Cambiá el nombre para indicar qué estás probando
        {
            Person john = new Person("", "1.234.567-8", "16/08/2002");
            Assert.IsNull(john.Name);
            Assert.IsNull(john.ID);
        }

        [Test]
        public void TestFC() // Cambiá el nombre para indicar qué estás probando
        {
            Person john = new Person("John Doe", "5.212.287-6", "16/08/2002");
            string expected = "16/08/2002";
            Assert.AreEqual(expected, john.FechaNacimiento);
        }

        [Test]
        public void TestFCErroneo() // Cambiá el nombre para indicar qué estás probando
        {
            Person john = new Person("John Doe", "5.212.287-6", "46/97/5");
            string expected = "01/01/1900";
            Assert.AreEqual(expected, john.FechaNacimiento);
        }
    }
}