﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_test
{
    public class Class1
    {
    public static bool ValidatePassword(string password)
    {
      if (password.Length < 8 || password.Length > 20)
        return false;
      if (!password.Any(char.IsLower))
        return false;
      if (!password.Any(char.IsUpper))
        return false;
      if (!password.Any(char.IsDigit))
        return false;
      if (password.Intersect("#$%^&_").Count() == 0)
        return false;

      return true;
    }
    }
}
