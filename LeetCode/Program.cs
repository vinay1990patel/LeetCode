﻿// See https://aka.ms/new-console-template for more information
using LeetCode;
using LeetCode.CSharp;
using LeetCode.DesginPattern;

using LeetCode.LeetCode;
using Microsoft.Data.SqlClient;
using System.Data;

using ReverseStringAndInteger = LeetCode.LeetCode.ReverseStringAndInteger;




//int[,] matrix =
//       {
//            {1,7,8,9 },
//            {10,11,12,13,},
//            {14,15,16,17,},
//            {18,19,21,22,}

//        };

//int[][] matrix1 =  
//{
//         new int[]   {1,3,5,7 },
//         new int  []  {10,11,16,20},
//         new int []  {23,30,34,60},
//       //  new int [] {18,19,21,22,}

//  //  new int []{1,3 }
//};
//int target = 17;

//MatrixSearch.matrixSearch(matrix, 4, target);   // O(n2)


// MatrixSearch.matrixSearch(matrix, target);

//MatrixSearch.matrixSearch(matrix1, target);

//int[] nums = { 5 };   // -1, 0, 3, 5, 9, 12
//int target1 = 5;

// BinarySearch.BinarySearch1(nums, target1);


//int[] array = { 5, 2, 3, 1 };
//ArrayShortClass.arrayShort(array);

//int[] input = {2,2};

//int target = 2;


//FindFirstandLastPositionofElementinSortedArray.firstAndLast(input, target);

//int[] nums = { 0,6,2,3,4,0 };

//PeakIndexinaMountainArray.peakIndex(nums);
//PeakIndexinaMountainArray.PeakMountainByLiner(nums);


//int[] nums = { 1, 2, 3 };   // 1, 7, 3, 6, 5, 6
//FindPivotIndex.Pivot(nums);

//int [] nums = { 5,1,3 };

//SearchinRotatedSortedArray.RotedArraySearch(nums, 3);

// ********************************************//

//int input = 2147395599;
//Sqrt_x_.SqureRoot(input);

// ********************************************//


// ********************************************//
int [] input = { 3, 30, 34, 5, 9 };
//LargestNumber.LargestNumbers(input);
//PalimDromeOfintegerAndString.IntergerPlimdrome();

//PalimDromeOfintegerAndString.StringPalimdrome();
// DupicateInIntegerOrStringAndCount.DuplicateItegerAndCount();
//DupicateInIntegerOrStringAndCount.DuplicateWordInString();
// ReverseStringAndInteger.ReverseWordsOfString();
ReverseStringAndInteger.ReverseWord();
// ********************************************//

//int[] ints = { 1, 3, 5, 6, 7, 8, 11, 13, 14, 16, 17, 18, 19, 20, 21, 23, 24, 25, 26, 28, 29, 30, 31, 34, 35, 36, 37, 38, 41, 43, 44, 47, 50, 51, 53, 54, 56, 57, 58, 59, 60, 62, 63, 65, 67, 68, 69, 70, 71, 72, 73, 74, 76, 78, 80, 81, 83, 84, 85, 88, 89, 90, 91, 92, 93, 95, 97, 98, 102, 103, 104, 105, 108, 109, 110, 111, 112, 113, 114, 117, 120, 123, 124, 125, 127, 128, 129, 130, 131, 132, 133, 135, 136, 137, 138, 139, 141, 142, 145, 146, 148, 149, 150, 151, 153, 154, 155, 156, 161, 162, 164, 167, 168, 169, 170, 171, 172, 175, 176, 178, 179, 181, 182, 184, 191, 193, 195, 196, 199, 201, 202, 204, 205, 208, 210, 214, 215, 217, 219, 221, 222, 224, 226, 228, 229, 230, 231, 232, 234, 235, 236, 240, 242, 246, 248, 249, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 265, 267, 269, 272, 273, 275, 278, 279, 280, 281, 282, 283, 284, 285, 286, 287, 289, 291, 292, 293, 296, 297, 298, 299, 303, 305, 306, 308, 312, 313, 315, 316, 318, 320, 323, 324, 327, 330, 332, 335, 337, 340, 342, 343, 344, 346, 349, 350, 352, 353, 354, 356, 357, 359, 360, 362, 366, 367, 369, 370, 374, 375, 376, 377, 378, 379, 382, 384, 386, 390, 392, 393, 394, 395, 396, 399, 400, 401, 403, 406, 411, 413, 415, 416, 420, 424, 425, 426, 427, 429, 430, 432, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 446, 447, 448, 449, 452, 455, 456, 458, 459, 460, 461, 462, 463, 464, 465, 466, 467, 469, 470, 471, 472, 477, 479, 480, 483, 484, 486, 488, 489, 490, 491, 492, 493, 494, 495, 500, 501, 503, 504, 506, 508, 510, 513, 514, 515, 516, 517, 527, 531, 533, 534, 535, 536, 542, 543, 546, 547, 548, 549, 550, 553, 556, 559, 561, 562, 563, 566, 567, 569, 571, 572, 576, 578, 579, 581, 582, 583, 584, 586, 589, 591, 592, 593, 594, 595, 598, 600, 601, 602, 603, 605, 606, 607, 609, 611, 612, 613, 614, 616, 617, 621, 622, 624, 625, 626, 627, 630, 631, 633, 635, 636, 637, 639, 640, 643, 644, 646, 647, 648, 649, 650, 651, 652, 654, 658, 660, 661, 662, 663, 664, 665, 667, 668, 669, 672, 673, 678, 679, 683, 685, 686, 687, 689, 690, 691, 692, 693, 695, 696, 697, 701, 702, 703, 704, 707, 709, 711, 714, 717, 718, 719, 720, 721, 723, 724, 725, 726, 728, 729, 730, 733, 735, 736, 737, 738, 740, 742, 745, 746, 747, 750, 754, 755, 757, 759, 761, 763, 765, 768, 771, 773, 774, 775, 776, 779, 780, 781, 782, 783, 784, 787, 788, 789, 790, 791, 792, 794, 795, 797, 798, 800, 801, 805, 806, 808, 810, 811, 812, 814, 816, 819, 822, 824, 825, 826, 828, 831, 833, 835, 838, 841, 842, 844, 845, 846, 847, 849, 853, 854, 855, 857, 858, 861, 862, 866, 868, 869, 870, 874, 878, 882, 884, 885, 888, 889, 890, 892, 893, 897, 900, 903, 905, 906, 907, 908, 911, 913, 916, 918, 920, 921, 922, 924, 925, 926, 928, 929, 930, 932, 933, 934, 936, 937, 938, 940, 942, 944, 946, 949, 953, 954, 956, 957, 958, 961, 962, 964, 965, 966, 969, 972, 973, 974, 976, 977, 978, 979, 980, 981, 982, 984, 985, 986, 988, 993, 996, 997, 999 };
//int k = 724;

//KthMissingPositiveNumber.kthMissing(ints, k);

// ******************************************************* //

//string haystack = "leetcode";
//string needle = "leeto";

//FindtheIndexoftheFirstOccurrenceinaString.StrStr(haystack, needle);

// ******************************************************* //


//int[] input = { 6,5, 2, 3, 4};

//ThirdHighestNumber.NthHighestSalary(input);

// ************************************************************//

//int[] input = { 8, 1, 4, 6, 2, 5 };

//SelectionSort.SelectionSortMethod(input);

//*******************************************************************************************//

//DuplicateNumber.ContainsDuplicate();











// ********************************************************** Design Pattern ***********************************************************


// Singlton singtls = Singlton.getInstance;



//Console.ReadLine();


//IlivingBeing ilivingBeing = null;
//AbstractLivingBeingCreater creater = new LivingBeingCreaterFactory();
//ilivingBeing = creater.CreateObject("Four");

//ilivingBeing.EatingHabit();
//ilivingBeing.HaveLegs();




// ****************************************************************  C#   *********************************************************************


//HelloDelegate helloDelegate = new HelloDelegate(delegates.Add);
//helloDelegate(3, 4);

// MulticastDelegates dl1, dl2, dl3, dl4, dl5;
//dl1 = new MulticastDelegates(delegates.Add);
//dl2 = new MulticastDelegates(delegates.Del);
//dl3 = new MulticastDelegates(delegates.Mul);
//dl4 = new MulticastDelegates(delegates.Div);

//dl1(2, 3);
//dl2(3, 4);
//dl3(4, 5); 
//dl4(5, 6);


//dl1(3, 2);
//dl2(3, 2);
//dl3(4, 5);
//dl4(10, 5);

//dl5 = dl1 + dl2 + dl3 + dl4 -dl1;   // Delegate Chaining 

//dl5(10, 2);


//Reflection.reflectionData();

//genricT.equals<string>("vinay", "vinay");
//genricT.equals<int>(10, 12);

//testGenric<int>.equals(10, 12);
//testGenric<string>.equals("", "");


int[] input1 = { 1, 2, 3, 4, 3, 4, 3, 4, 3, 5, 7, 8, 9 };

//HasSetDemo.findDulticateInArray(input1);

/***************************************************** Ref abd out *****************************************************/

//int result ;
//RefAndOut.Sum(1, 2, out result);

//Console.WriteLine(result);

//int i=0;
//RefAndOut.increment(ref i);


//Console.WriteLine("Ref ==>" + i);



/**************************************************************  multi threading   *******************************************************************************/

//Thread t1 = new Thread(MultiThreading.Numbers);
//Thread t2 = new Thread(MultiThreading.Numbers);
//Thread t3 = new Thread(MultiThreading.Numbers);
//Thread t4 = new Thread(MultiThreading.Numbers);



//t1.Start ();
//t2.Start ();
//t3.Start ();
//    t4.Start ();


//using (SqlConnection conn = new SqlConnection())
//{
//    conn.ConnectionString = "Data Source=10.188.101.127, 114;Integrated Security=True;MultipleActiveResultSets=True; TrustServerCertificate=True";
//    // .\\SQLExpress  
//    // @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\inetpub\wwwroot\eSuite\App_Data\localdb.mdf;Integrated Security=True;MultipleActiveResultSets=True"
//    if (conn.State != ConnectionState.Open)
//    {
//        conn.Open();
//    }

//    if (conn.State == ConnectionState.Open)
//    {
//        Console.WriteLine("Success");
//    }



//}
// use the connection here  


//if(conn. == true)
//{

//}




//PalimDromicString.solve("archit", "ar");

//OrderSubString.OrderSubStrings("eren");

// EventAndDelegates.Main();

//mainClass.Main();


//ObjectCamparision.Compare();

//Console.WriteLine("***************************** Garbage Collector ***********************************");
//// GarbageCollector.GetGarbageCollectionMethod();

//Console.WriteLine("***************************** Object Camparison ***********************************");
//EqualsOps.EqualityOpaerator();


//B b = new B();
//b.Method1();
//Console.WriteLine(ConstructorType.p);;

// int result = Class1.solve();

// OnlyOnceOccured.FindOnlyOnceOccurance();
//SomeOfInteger.SomeOfIntegers();
//int result = SomeOfInteger.SomeOfIntegersUsingRecurtion(12345);

// DecialToBinary.DecimalToBinaries();

// DupicateInIntegerOrStringAndCount.DuplicateCharInString();



Console.ReadLine();