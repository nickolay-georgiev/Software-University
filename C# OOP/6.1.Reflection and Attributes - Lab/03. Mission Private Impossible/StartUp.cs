using System;

//namespace Stealer
//{
    public class StartUp
    {
        static void Main()
        {
            Spy spy = new Spy();

            string result = spy.RevealPrivateMethods("Hacker");

            Console.WriteLine(result);
        }
    }
//}
