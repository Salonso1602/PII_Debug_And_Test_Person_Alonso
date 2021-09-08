using System;

namespace UnitTestAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "5.212.287-6");
            john.IntroduceYourself();
        }
    }
}
