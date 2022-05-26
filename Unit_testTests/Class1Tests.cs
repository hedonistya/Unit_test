using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_test.Tests
{
  [TestClass()]
  public class Class1Tests
  {
    [TestMethod()]
    public void Check_10Symbols_ReturnTrue()
    {
      //arrange
      string password = "ASqw12$$";
      bool expected = true;

      //act
      bool actual = Class1.ValidatePassword(password);

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Check_4Symbols_ReturnFalse()
    {
      //arrange
      string password = "Aq1$";
      bool expected = false;

      //act
      bool actual = Class1.ValidatePassword(password);

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Check_30Symbols_ReturnFalse()
    {
      //arrange
      string password = "ASDqwe123$ASDqwe123$ASDqwe123$";
      bool expected = false;

      //act
      bool actual = Class1.ValidatePassword(password);

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Check_PasswordWithDigit_ReturnTrue()
    {
      //arrange
      string password = "ASDqwe1$";
      bool expected = true;

      //act
      bool actual = Class1.ValidatePassword(password);

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Check_PasswordWithoutDigit_ReturnFalse()
    {
      //arrange
      string password = "ASDqweASD$";
      bool expected = false;

      //act
      bool actual = Class1.ValidatePassword(password);

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Check_PasswordWithSpecSymbol_ReturnTrue()
    {
      //arrange
      string password = "Aqwe123$";
      bool expected = true;

      //act
      bool actual = Class1.ValidatePassword(password);

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Check_PasswordWithoutSpecSymbol_ReturnFalse()
    {
      //arrange
      string password = "ASDqwe123";
      bool expected = false;

      //act
      bool actual = Class1.ValidatePassword(password);

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Check_PasswordWithCapsSymbol_ReturnTrue()
    {
      //arrange
      string password = "Aqwe123$";
      bool expected = true;

      //act
      bool actual = Class1.ValidatePassword(password);

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Check_PasswordWithoutCapsSymbol_ReturnFalse()
    {
      //arrange
      string password = "asdqwe123$";
      bool expected = false;

      //act
      bool actual = Class1.ValidatePassword(password);

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Check_PasswordWithLowerSymbol_ReturnTrue()
    {
      //arrange
      string password = "ASDq123$";
      bool expected = true;

      //act
      bool actual = Class1.ValidatePassword(password);

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod()]
    public void Check_PasswordWithoutLowerSymbol_ReturnFalse()
    {
      //arrange
      string password = "ASDQWE123$";
      bool expected = false;

      //act
      bool actual = Class1.ValidatePassword(password);

      //assert
      Assert.AreEqual(expected, actual);
    }
  }
}