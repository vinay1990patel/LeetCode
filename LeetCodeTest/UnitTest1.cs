using LeetCode.LeetCode;
using LeetCode.CSharp;
using System.Reflection;
using Xunit.Abstractions;

namespace LeetCodeTest
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(2,1)]

        
        public void Test1(int x, int expectedResult)
        {
            // arrange

            Sqrt_x_ sqrt_X_ = new Sqrt_x_();

             MethodInfo methodInfo = sqrt_X_.GetType().GetMethod("SqureRoot", BindingFlags.NonPublic | BindingFlags.Instance);

            // Act 

             object[] obj = new Object[1] { x };

             var result = methodInfo.Invoke(sqrt_X_, obj);

             Assert.Equal(expectedResult, result);


               
        }
    }
}