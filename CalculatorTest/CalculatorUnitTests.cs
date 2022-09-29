using AdaCalculator;
using Moq;

namespace CalculatorTest
{
    public class CalculatorUnitTests
    {
        private CalculatorMachine _sut;
        private MockRepository _mockRepository;
        private Mock<Calculator> _mockCalculator;

        public CalculatorUnitTests()
        {
            _mockRepository = new MockRepository(MockBehavior.Strict);
            _mockCalculator = _mockRepository.Create<Calculator>();


        }

        [Theory]
        [InlineData(2, 2, 4)]
        [InlineData(2.5, 7.5, 10.0)]
        public void CalculatorMachine_ValidResultSumNumbers_ResultSum(
             double addend1
            , double addend2
            , double result)
        {

            //_mockCalculator.Setup(x => x.Calculate(It.IsAny<string>()
            //            , It.IsAny<double>()
            //            , It.IsAny<double>())).Returns("sum", result).Verifiable();

            _sut = new CalculatorMachine(_mockCalculator.Object);

            (string operation, double result) calculation = _sut.Calculate("sum", addend1, addend2);

            Assert.Equal("sum", calculation.operation);
            Assert.Equal(result, calculation.result);
            _mockCalculator.VerifyAll();
        }

        [Theory]
        [InlineData(2, 3, 4)]
        [InlineData(1.5, 7.5, 1)]
        public void CalculatorMachine_InvalidResultSumNumbers_ResultFailSum(
            double addend1
            , double addend2
            , double result)
        {

            _sut = new CalculatorMachine(_mockCalculator.Object);

            (string operation, double result) calculation = _sut.Calculate("sum", addend1, addend2);

            Assert.Equal("sum", calculation.operation);
            Assert.NotEqual(result, calculation.result);
            _mockCalculator.VerifyAll();
        }

    }
}