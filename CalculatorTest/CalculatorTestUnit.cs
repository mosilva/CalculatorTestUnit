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
        private Calculator _sut = new Calculator();

        [Theory]
        [InlineData("sum", 2.0, 3.1, 5.1)]
        [InlineData("sum", 1.5, 7.5, 9.0)]
        public void CalculatorMachine_InvalidResultSumNumbers_ResultSum(string opetation
            , double addend1
            , double addend2
            , double result)
        {

            (string operation, double result) calculation = _sut.Calculate(opetation, addend1, addend2);

            Assert.Equal(opetation, calculation.operation);
            Assert.Equal(result, calculation.result);
        }


        [Theory]
        [InlineData("subtract", 8.1, 3.0, 5.1)]
        [InlineData("subtract", 1.5, 10.5, -9.0)]
        public void CalculatorMachine_InvalidResultSumNumbers_ResultSubtract(string opetation
            , double addend1
            , double addend2
            , double result)
        {

            (string operation, double result) calculation = _sut.Calculate(opetation, addend1, addend2);

            Assert.Equal(opetation, calculation.operation);
            Assert.Equal(result, calculation.result);
        }
        [Theory]
        [InlineData("multiply", 10.1, 1, 10.1)]
        [InlineData("multiply", 5.4, 3.6, 19.44)]
        public void CalculatorMachine_InvalidResultSumNumbers_ResultMultiply(string opetation
            , double addend1
            , double addend2
            , double result)
        {

            (string operation, double result) calculation = _sut.Calculate(opetation, addend1, addend2);

            Assert.Equal(opetation, calculation.operation);
            Assert.Equal(result, calculation.result);
        }

        [Theory]
        [InlineData("divide", 5.4, 2.0, 2.7)]
        [InlineData("divide", 18.6, 3.0, 6.2)]
        public void CalculatorMachine_InvalidResultSumNumbers_ResultDivide(string opetation
            , double addend1
            , double addend2
            , double result)
        {

            (string operation, double result) calculation = _sut.Calculate(opetation, addend1, addend2);

            Assert.Equal(opetation, calculation.operation);
            Assert.Equal(result, calculation.result);
        }



    }
}
