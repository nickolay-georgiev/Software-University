﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes.Models
{
    public class MyRequiredAttribute : MyValidationAttribute
    {
        public override bool IsValid(object obj)
        {
            if(obj == null )
            {
                return false;
            }

            return true;
        }
    }
}