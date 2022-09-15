namespace DivisabilityChecker.Test
{
    public class DivisabilityCheckerTest
    {
        [Fact]
        public void Test_Min_Integer_Input()
        {
            var checker = new Console.DivisabilityChecker();
            var output = checker.GetDivisableText(int.MinValue.ToString());
            Assert.NotEqual("Please enter valid integer next time.", output);
        }

        [Fact]
        public void Test_Max_Integer_Input()
        {
            var checker = new Console.DivisabilityChecker();
            var output = checker.GetDivisableText(int.MaxValue.ToString());
            Assert.NotEqual("Please enter valid integer next time.", output);
        }

        [Fact]
        public void Test_Random_Integer_Input()
        {
            var random = new Random();
            var checker = new Console.DivisabilityChecker();
            var output = checker.GetDivisableText(random.Next(int.MinValue, int.MaxValue).ToString());
            Assert.NotEqual("Please enter valid integer next time.", output);
        }
    }
}