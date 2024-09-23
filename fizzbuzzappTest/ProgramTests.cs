namespace fizzbuzzappTest
{
    using fizzbuzzapp;
    public class ProgramTests
    {
        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        [InlineData(7, "7")]
        public void GetFizzBuzz_ReturnsExpectedResult(int input, string expected)
        {
            // Act
            var result = Program.GetFizzBuzz(input);

            // Assert
            Assert.Equal(expected, result);
        }
    }
}