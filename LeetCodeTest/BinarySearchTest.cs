using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using LeetCode.LeetCode;
namespace LeetCodeTest
{
   public class BinarySearchTest
    {

        [Theory]
        [InlineData(new int[] {1,2,3,4,5,7}, 4, 3)]
      //  [InlineData(new[] {9,8,7,6,5,4},7 , 2)]
      public void BinarySearchTestMethod(int[] inputs , int target, int expetctedResult)
        {
            
            var result = BinarySearch.BinarySearch1(inputs, target);

            Assert.Equal(expetctedResult, result);
        }
        [Theory(Skip ="Skip this test")]
        [MemberData(nameof(BinarySearchTest.BinarySearchTestData), MemberType =typeof(BinarySearchTest))]
        public void BinarySearchTestMethodWithMemberData(int[] inputs, int target, int expetctedResult)
        {

            var result = BinarySearch.BinarySearch1(inputs, target);

            Assert.Equal(expetctedResult, result);
        }



        public static TheoryData<object[],int, int> BinarySearchTestData =>
            new TheoryData<object[], int, int>()
            {
                { new object[]{1,2,3,4},1,0 },
                 { new object[]{2,3,4,5},5,3 },
                  


            };
       

    }
}
