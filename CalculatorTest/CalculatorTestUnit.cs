using AdaCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdaCalculatorTest
{
    public class CalculatorTestUnit
    {
        [Theory]
        [InlineData(2, 3, 4)]
        [InlineData(1.5, 7.5, 1)]
        public void CalculatorMachine_InvalidResultSumNumbers_ResultFailSum(
    double addend1
    , double addend2
    , double result)
        {
            //_sut = new CalculatorMachine(_mockCalculator.Object);

            //(string operation, double result) calculation = _sut.Calculate("sum", addend1, addend2);

            //Assert.Equal("sum", calculation.operation);
            //Assert.NotEqual(result, calculation.result);
            //_mockCalculator.VerifyAll();
        }

    }
}
