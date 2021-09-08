using NUnit.Framework;

using UnitTestAndDebug;

namespace Tests
{
    public class Tests
    {
        [TestFixture]
        /*[SetUp]
        public void Setup()
        {
            // Insertá tu código de inicialización aquí
        } */

        [Test]
        public void TestName() // Cambiá el nombre para indicar qué estás probando
        {
            Person john = new Person("John Doe", "5.212.287-6");
            string expected = "John Doe";
            Assert.AreEqual(expected, john.Name);

        }
    }
}