﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Pet : INameable, IBirthdate
    {
        public Pet(string name, string birthdate)
        {
            this.Name = name;
            this.Birthdate = birthdate;
        }

        public string Name { get; }

        public string Birthdate { get; }
    }
}
