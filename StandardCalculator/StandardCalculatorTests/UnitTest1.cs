using StandardCalculator;
using Xunit;

namespace StandardCalculatorTests
{
    public class StandardCalculatorfunctionchecker
    {
        [Fact]
        public void CheckAddingfunction()
        //Arrange
        {
            StandardFunctions standardFunctions = new StandardFunctions();
            int addends1 = 8;
            int addends2 = 2;
            int totalexpected = 10;
            //Act

            int totalactual = standardFunctions.AddingFunction(addends1, addends2);

            //Assert
            Assert.Equal(totalexpected, totalactual);

        }
        [Fact]
        public void CheckSubtraactionfunction()
        //Arrange
        {
            StandardFunctions standardFunctions = new StandardFunctions();
            int minuend = 8;
            int subtrahend = 2;
            int totalexpected = 6;
            //Act

            int totalactual = standardFunctions.SubtractingFunction(minuend,subtrahend);

            //Assert
            Assert.Equal(totalexpected, totalactual);
        }
        [Fact]
        public void CheckMultiplicationfunction()
        //Arrange
        {
            StandardFunctions standardFunctions = new StandardFunctions();
            int factor1 = 8;
            int factor2 = 2;
            int totalproductexpected = 16;
            //Act

            int totalproductactual = standardFunctions.MultiplicationFunction(factor1, factor2);

            //Assert
            Assert.Equal(totalproductexpected, totalproductactual);
        }

        [Fact]
        public void CheckDivisionfunction()
        //Arrange
        {
            StandardFunctions standardFunctions = new StandardFunctions();
            int dividend = 8;
            int divisor = 2;
            int totalexpected = 4;
                   //Act

            int totalactual = standardFunctions.DivisionFunction(dividend, divisor);

            //Assert
            Assert.Equal(totalexpected, totalactual);
        }
        [Fact]
        public void CheckIfDivisorIsZero_trowexeption()
        //Arrange
        {
            StandardFunctions standardFunctions = new StandardFunctions();
            int dividend = 7;
            int divisor = 0;

            //Act and Assert

            Assert.Throws<System.Exception>(() => standardFunctions.DivisionFunction(dividend, divisor));       
         }

        [Fact]
        
        public void CheckifproductOverflow_Multiplicationfunction_trowexeption()
        //Arrange
        {
            StandardFunctions standardFunctions = new StandardFunctions();
            int factor1 = 780000000;
            int factor2 = 780000000;

            //Act and Assert

            Assert.Throws<System.Exception>(() => standardFunctions.MultiplicationFunction(factor1, factor2));

          
        }
    }
}