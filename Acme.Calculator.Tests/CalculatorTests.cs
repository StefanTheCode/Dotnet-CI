namespace Acme.Calculator.Tests
{
    /// <summary>
    /// Calculator Tests.
    /// </summary>
    public class CalculatorTests
    {
        /// <summary>
        /// Add tests.
        /// </summary>
        [Fact]
        public void Add_ReturnsSum()
        {
            int result = Calculator.Add(2, 3);
            Assert.Equal(5, result);
        }
    }
}
