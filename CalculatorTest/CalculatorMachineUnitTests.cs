using AdaCalculator;
using Moq;

namespace CalculatorTest
{
    public class CalculatorMachineUnitTests
    {
        public static Mock<ICalculator> _mockCalculator = new Mock<ICalculator>();
        private CalculatorMachine _sut = new CalculatorMachine(_mockCalculator.Object);

        [Fact]
        public void CalculatorMachine_ValidResultSumNumbers_ResultSum()
        {
            _mockCalculator.Setup(x => x.Calculate(It.IsAny<string>()
                        , It.IsAny<double>()
                        , It.IsAny<double>())).Returns(("sum", 7.0));

            (string operation, double result) calculation = _sut.Calculate("sum", 3.5, 3.5);

            Assert.Equal("sum", calculation.operation);
            Assert.Equal(7.0, calculation.result);
            _mockCalculator.Verify(x => x.Calculate("sum", 3.5, 3.5),Times.Once);
        }

        [Fact]
        public void CalculatorMachine_ValidResultSumNumbers_ResultSubtract()
        {
            _mockCalculator.Setup(x => x.Calculate(It.IsAny<string>()
                        , It.IsAny<double>()
                        , It.IsAny<double>())).Returns(("subtract", 10.5));

            (string operation, double result) calculation = _sut.Calculate("subtract", 11, 0.5);

            Assert.Equal("subtract", calculation.operation);
            Assert.Equal(10.5, calculation.result);
            _mockCalculator.Verify(x => x.Calculate("subtract", 11, 0.5), Times.Once);
        }


        [Fact]
        public void CalculatorMachine_ValidResultSumNumbers_ResultMultiply()
        {
            _mockCalculator.Setup(x => x.Calculate(It.IsAny<string>()
                        , It.IsAny<double>()
                        , It.IsAny<double>())).Returns(("multiply", 25.0));

            (string operation, double result) calculation = _sut.Calculate("multiply", 5.0, 5.0);

            Assert.Equal("multiply", calculation.operation);
            Assert.Equal(25.0, calculation.result);
            _mockCalculator.Verify(x => x.Calculate("multiply", 5.0, 5.0), Times.Once);
        }


        [Fact]
        public void CalculatorMachine_ValidResultSumNumbers_ResultDivide()
        {
            _mockCalculator.Setup(x => x.Calculate(It.IsAny<string>()
                        , It.IsAny<double>()
                        , It.IsAny<double>())).Returns(("divide", 8.0));

            (string operation, double result) calculation = _sut.Calculate("divide", 16.0, 2.0);

            Assert.Equal("divide", calculation.operation);
            Assert.Equal(8.0, calculation.result);
            _mockCalculator.Verify(x => x.Calculate("divide", 16.0, 2.0), Times.Once);
        }


    }
}