using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multithreadAndAsyncParallel_programming
{
    internal class Class1
    {
        private static int _var3 = 3;
        private static object _loc = new object();


      public  static void Main1()
        {
            Thread firstThread = new Thread(htrfunc);
            Thread SecondThread = new Thread(htrfunc);
            firstThread.Start();
            SecondThread.Start();

            firstThread.Join();
            SecondThread.Join();
        }

        private static void htrfunc()
        {
            for (int i = 0; i < 1000; i++)
            {
                lock (_loc) { 
                if(_var3 == 3)
                {
                    _var3++;
                    if(_var3 != 4)
                    {
                        Console.WriteLine( _var3);
                    }

                    _var3 = 3;
                }
                }
            }
        }


      public static  int FuncFoo(int[] arr1, int arr1Size, int[] arr2, int arr2Size, int[] result)
        {
            int i = 0, j = 0, k = 0;
            while(i < arr1Size && j < arr2Size )
            {
                if (arr1[i] < arr2[j])
                {
                    if (i == 0 || arr1[i] != arr1[i - 1])
                    {
                        result[k++] = arr1[i];
                    }
                    i++;
                }
                   
                        else if (arr1[j] < arr2[i])
                    {
                        if (j == 0 || arr1[j] != arr1[j - 1])
                        {
                            result[k++] = arr1[j];
                        }
                    j++;
                }

                else
                {
                    if (j == 0 || arr1[i] != arr1[i - 1])
                    {
                        result[k++] = arr1[i];
                    }
                    i++;
                    j++;
                }
            }

            while (i < arr1Size)
            {
                if (i == 0 || arr1[i] != arr1[i - 1])
                {
                    result[k++] = arr1[i];
                }
                i++;
            }
            while(j < arr1Size)
            {
                if (j == 0 || arr1[j] != arr1[j - 1])
                {
                    result[k++] = arr1[j];
                }
                j++;
            }

            Console.WriteLine(  k);

            return k;

        }


        public static int FuncFoo1( )
        {
            int[] num = { -5, 2, -6, 8 - 1, 5, 1 - 8, 6 };
            int result = int.MaxValue;
            int currentResult = 0;

            for(int i =0; i < num.Length; i++)
            {
                currentResult += num[i];

                if(currentResult > result)
                {
                    result = currentResult;
                }
                if(currentResult < 0)
                {
                    currentResult = 0;
                }

            }

            Console.WriteLine( result);

            return result;
        }

        public static bool FuncFoo3( ) {

            string s1 = "1234567";
            string s2 = "124567";
            int m = s1.Length;
            int n = s2.Length;
            if(Math.Abs(m-n) != 1)
            {
                return false;
            }
            int i = 0;
            int j = 0;
            int count = 0;

            while(i < m && j <n) {

                if (s1[i] == s2[j])
                {
                    i++;
                    j++;
                }
                else
                {
                    count++;
                    if(m > n)
                    {
                        i++;
                    }
                    else if (n > n)
                    {
                        j++;
                    }
                    else
                    {
                        i++;
                        j++;
                    }

                }
            }

            if(count == 1 || (count == 0 && m!=n))
            {
                return true;
            }
            return false;
        }

        public static bool FuncFoo4()
        {
            string s1 = "34";
            string s2 = "3334";
            bool result = false;
          for(int i =0; i< s1.Length; i++)
            {
                string ModifiedString1 = s1.Remove(i, 1);
                for(int j =0; j <= s2.Length; j++)
                {
                    string ModifiedString2 = s2.Insert(j, ModifiedString1[i].ToString());
                    if(ModifiedString1.Length == ModifiedString2.Length && ModifiedString1.Equals(ModifiedString2))
                    {
                        result = true;
                        break;
                    }
                }
                if (result)
                {
                    break;
                }
            }
          return result;
        }
    }

   


    public abstract class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine(  "animal Speeck");
        }
    }


    public class Dog:Animal
    {
        public override void Speak()
        {
            Console.WriteLine("barck");
        }
    }

    public class Cat : Animal
    {

    }

    public class AnimalOwner
    {
        public void makeAnimalSpeek(Animal animal)
        {
            animal.Speak();
        }
    }

   


}
