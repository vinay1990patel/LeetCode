using LeetCode.LeetCode;
using LeetCode.CSharp;
using System.Reflection;


namespace LeetCodeTest
{
    [TestClass]
    public class UnitTest1
    {
        [DataTestMethod]
        [DataRow(2, 1)]
        public void Test1(int x, int expectedResult)
        {
            // arrange
            Sqrt_x_ sqrt_X_ = new Sqrt_x_();

            MethodInfo methodInfo = sqrt_X_.GetType().GetMethod("SqureRoot", BindingFlags.NonPublic | BindingFlags.Instance);

            Assert.IsNotNull(methodInfo, "Method 'SqureRoot' not found via reflection.");

            // Act 
            object[] obj = new object[1] { x };

            var result = methodInfo.Invoke(sqrt_X_, obj);

            // Assert
            Assert.AreEqual(expectedResult, (int)result);
        }
    }
}