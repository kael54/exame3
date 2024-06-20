namespace Cifrado.Tests;

public class UnitTest1
{
  [Fact]
   public void CifradoTest()
   {
   // Arrange
   string phrase = "Hola Mundo";
   int displacement = 3;
   string expectedResult = "Krod Pxqgr";
   // Act
   var result = Mathematics.Cifrado(phrase, displacement);
   // Assert
   Assert.Equal(expectedResult, result);
   }
   [Fact]
   public void CifradoTestInvalid()
   {
   // Arrange
   string phrase = "";
   int displacement = 3;
   // Act & Assert
   Assert.Throws<ArgumentException>(() => Mathematics.Cifrado(phrase, displacement));
   }
   [Fact]
   public void CifradoAutoTest()
   {
   // Arrange
   string phrase = "Hola Mundo";
   int displacement = 3;
   string expectedResult = "Krod Pxqgr";
   // Act
   var result = Mathematics.CifradoAuto(phrase, displacement);
   // Assert
   Assert.Equal(expectedResult, result);
   }
   [Fact]
   public void CifradoAutoTestInvalid()
   {
   // Arrange
   string phrase = "";
   int displacement = 3;
   // Act & Assert
   Assert.Throws<ArgumentException>(() => Mathematics.CifradoAuto(phrase, displacement));
   }

   [Fact]
   public void DecifradoTest()
   {
   // Arrange
   string phrase = "Krod Pxqgr";
   int displacement = 3;
   string expectedResult = "Hola Mundo";
   // Act
   var result = Mathematics.Decifrado(phrase, displacement);
   // Assert
   Assert.Equal(expectedResult, result);
   }
   [Fact]
   public void DecifradoTestInvalid()
   {
   // Arrange
   string phrase = "";
   int displacement = 3;
   // Act & Assert
   Assert.Throws<ArgumentException>(() => Mathematics.Decifrado(phrase, displacement));
   }
   [Fact]
   public void DecifradoAutoTest()
   {
   // Arrange
   // Simulamos que ya se han realizado cifrados antes
   Mathematics.CifradoAuto("Hola Mundo", 3);
   int displacement = 3;
   string expectedResult = "Hola Mundo";
   // Act
   var result = Mathematics.DecifradoAuto(displacement);
   // Assert
   Assert.Equal(expectedResult, result);
   }

   [Fact]
   public void DecifradoAutoTestInvalid()
   {
   // Arrange
   // Simulamos que no se ha realizado ningún cifrado antes
   Mathematics.CifradoAuto("Hola Mundo", 3);
   int displacement = 4;
   string expectedResult = "Krod Pxqgr";
   // Act
   var result = Mathematics.DecifradoAuto(displacement);
   // Assert
   Assert.NotEqual(expectedResult, result);
   }

   [Fact]
   public void CifradoTestNum()
   {
   // Arrange
   string phrase = "Hola Mundo123";
   int displacement = 4;
   string expectedResult = "Lspe Qyrhs567";
   // Act
   var result = Mathematics.Cifrado(phrase, displacement);
   // Assert
   Assert.Equal(expectedResult, result);
   }
  
   [Fact]
   public void DecifradoTestNum()
   {
   // Arrange
   string phrase = "Lspe Qyrhs567";
   int displacement = 4;
   string expectedResult = "Hola Mundo123";
   // Act
   var result = Mathematics.Decifrado(phrase, displacement);
   // Assert
   Assert.Equal(expectedResult, result);
   }


   [Fact]
   public void CifradoAutoTestNum()
   {
   // Arrange
   string phrase = "HolaMundo456";
   int displacement = 6;
   string expectedResult = "NurgSatju:;<";
   // Act
   var result = Mathematics.CifradoAuto(phrase, displacement);
   // Assert
   Assert.Equal(expectedResult, result);
   }


   [Fact]
   public void DecifradoAutoTestNum()
   {
   // Arrange
   // Simulamos que ya se han realizado cifrados antes
   Mathematics.CifradoAuto("Hola Mundo123", 3);
   int displacement = 3;
   string expectedResult = "Hola Mundo123";
   // Act
   var result = Mathematics.DecifradoAuto(displacement);
   // Assert
   Assert.Equal(expectedResult, result);
   }

   [Fact]
   public void CifradoTestSpecialChar()
   {
   // Arrange
   string phrase = "Hola Mundo!\"#";
   int displacement = 4;
   string expectedResult = "Lspe Qyrhs%&'";
   // Act
   var result = Mathematics.Cifrado(phrase, displacement);
   // Assert
   Assert.Equal(expectedResult, result);
   }
  
   [Fact]
   public void DecifradoTestSpecialChar()
   {
   // Arrange
   string phrase = "Lspe Qyrhs%&'";
   int displacement = 4;
   string expectedResult = "Hola Mundo!\"#";
   // Act
   var result = Mathematics.Decifrado(phrase, displacement);
   // Assert
   Assert.Equal(expectedResult, result);
   }


   [Fact]
   public void CifradoAutoTestSpecialChar()
   {
   // Arrange
   string phrase = "HolaMundo$%&";
   int displacement = 6;
   string expectedResult = "NurgSatju*+,";
   // Act
   var result = Mathematics.CifradoAuto(phrase, displacement);
   // Assert
   Assert.Equal(expectedResult, result);
   }


   [Fact]
   public void DecifradoAutoTestSpecialChar()
   {
   // Arrange
   // Simulamos que ya se han realizado cifrados antes
   Mathematics.CifradoAuto("Hola Mundo%&/,", 3);
   int displacement = 3;
   string expectedResult = "Hola Mundo%&/";
   // Act
   var result = Mathematics.DecifradoAuto(displacement);
   // Assert
   Assert.Equal(expectedResult, result);
   }
}
