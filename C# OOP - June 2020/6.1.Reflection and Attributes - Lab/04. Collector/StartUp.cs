﻿using System;

//namespace Stealer
//{
    public class StartUp
    {
        static void Main()
        {
            Spy spy = new Spy();

            string result = spy.CollectGettersAndSetters("Hacker");

            Console.WriteLine(result);
        }
    }
//}
