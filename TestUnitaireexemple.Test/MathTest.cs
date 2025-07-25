using TestUnitaireExemple.Exceptions;
using TestUnitaireExemple.Models;

namespace TestUnitaireexemple.Test
{
    public class MathTest
    {
        [Fact]
        [Trait("Category","Sample")]
        public void AddPositiveNumberTest()
        {
            //Arrange
            int a = 1;
            int b = 2;
            //Act
            int retour = MaMathClass.AddPositiveNumber(a, b);
            //Assert 
            Assert.Equal(3, retour);  
        }
        [Fact]
        [Trait("Category", "Sample")]
        public void AddPositiveNumberOtherTest()
        {
            //Arrange
            int a = 4;
            int b = 7267;
            //Act
            int retour = MaMathClass.AddPositiveNumber(a, b);
            //Assert
            Assert.Equal(7271, retour);
        }
 
        [Fact]
        [Trait("Category", "Sample")]
        public void AddTooLargeANumberWithCorrectExceptionTest()
        {
            //Arrange
            int a = int.MaxValue;
            int b = 1;

            //Act && //Assert
            Assert.Throws<TooLargeNumberException>(() => MaMathClass.AddPositiveNumber(a, b));
        }
        [Fact]
        [Trait("Category", "Sample")]

        public void AddTooLargeBNumberWithCorrectExceptionTest()
        {
            //Arrange
            int a = 1;
            int b =int.MaxValue ;

            //Act && //Assert
            Assert.Throws<TooLargeNumberException>(() => MaMathClass.AddPositiveNumber(a, b));
        }

        [Fact]
        [Trait("Category", "Sample")]
        public void AddNegativeATest()
        {
            int a = -1;
            int b = 2;

            Assert.Throws<NegativeNumberException>(()=>MaMathClass.AddPositiveNumber(a, b));
        }

        [Fact]
        [Trait("Category", "Sample")]
        public void AddNegativeBTest()
        {
            int a = 1;
            int b = -2;

            Assert.Throws<NegativeNumberException>(() => MaMathClass.AddPositiveNumber(a, b));
        }

        [Fact]
        [Trait("Category", "Sample")]
        public void AddNegativeAAndBTest()
        {
            int a = -1;
            int b = -2;

            Assert.Throws<NegativeNumberException>(() => MaMathClass.AddPositiveNumber(a, b));
        }

        [Fact]
        [Trait("Category", "Sample")]
        public void AddNumberResultErrorTest()
        {
            //Arrange
            int a = int.MaxValue-1;
            int b = 10;

            //Act
            int retour = MaMathClass.AddPositiveNumber(a, b);
            //Assert
            Assert.Equal(-2147483640, retour);
        }

    }
}