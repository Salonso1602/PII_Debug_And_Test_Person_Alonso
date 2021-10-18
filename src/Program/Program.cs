using System;

namespace UnitTestAndDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Person john = new Person("John Doe", "5.212.287-6", "16/08/1992");
            john.IntroduceYourself();
        }
    }
}
