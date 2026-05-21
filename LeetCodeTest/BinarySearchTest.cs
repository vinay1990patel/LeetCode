using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using LeetCode.LeetCode;
namespace LeetCodeTest
{
    [TestClass]
    public class BinarySearchTest
    {
        // Use DynamicData so we can pass an int[] as a parameter
        [DataTestMethod]
        [DynamicData(nameof(InlineTestData), DynamicDataSourceType.Property)]
        public void BinarySearchTestMethod(int[] inputs, int target, int expectedResult)
        {
            var result = BinarySearch.BinarySearch1(inputs, target);
            Assert.AreEqual(expectedResult, result);
        }

        // Skipped data-driven test (equivalent of xUnit [Theory(Skip=...)])
        [Ignore("Skip this test")]
        [DataTestMethod]
        [DynamicData(nameof(BinarySearchTestData), DynamicDataSourceType.Property)]
        public void BinarySearchTestMethodWithMemberData(int[] inputs, int target, int expectedResult)
        {
            var result = BinarySearch.BinarySearch1(inputs, target);
            Assert.AreEqual(expectedResult, result);
        }

        // Single inline dataset
        public static IEnumerable<object[]> InlineTestData =>
            new List<object[]>
            {
                    new object[] { new int[] { 1, 2, 3, 4, 5, 7 }, 4, 3 },
                // add more cases here if needed
            };

        // Member-style dataset used by the second test
        public static IEnumerable<object[]> BinarySearchTestData =>
            new List<object[]>
            {
                    new object[] { new int[] { 1, 2, 3, 4 }, 1, 0 },
                    new object[] { new int[] { 2, 3, 4, 5 }, 5, 3 },
            };
    }
}
