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
        public void TestFC() // Cambiá el nombre para indicar qué estás probando
        {
            Person john = new Person("John Doe", "5.212.287-6", "16/08/2002");
            string expected = "16/08/2002";
            Assert.AreEqual(expected, john.FechaNacimiento);

        }
    }
}