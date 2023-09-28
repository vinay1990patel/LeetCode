using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{
    internal class GarbageCollector
    {
        private const long maxGarbage = 1000;
        public static int count =0 ;
        public GarbageCollector() { 
        
          count = count +1  ;
        }

        public static void GetGarbageCollectionMethod()
        {
            // Create a strong reference to an object.
            GarbageCollector myGCCol = new GarbageCollector();

            // Put some objects in memory.
            myGCCol.MakeSomeGarbage();

            // Get the generation of managed memory where myGCCol is stored.
            Console.WriteLine($"The object is in generation: {GC.GetGeneration(myGCCol)} Nnumber of Object {count}");

            // Perform a full garbage collection.
            // Because there is a strong reference to myGCCol, it will
            // not be garbage collected.

            GC.SuppressFinalize(myGCCol);
            
            GC.Collect(1, GCCollectionMode.Forced,true);

            // Get the generation of managed memory where myGCCol is stored.
            Console.WriteLine($"The object is in generation: {GC.GetGeneration(myGCCol)} Nnumber of Object {count}" );

            // Create a WeakReference to myGCCol.
            WeakReference wkref = new WeakReference(myGCCol);
            // Remove the strong reference to myGCCol.
            myGCCol = null;

            // Get the generation of managed memory where wkref is stored.
            Console.WriteLine($"The WeakReference to the object is in generation: {GC.GetGeneration(wkref)}  Nnumber of Object {count}");

            // Perform another full garbage collection.
            // A WeakReference will not survive a garbage collection.
            GC.Collect();

            // Try to get the generation of managed memory where wkref is stored.
            // Because it has been collected, an exception will be thrown.
            try
            {
                Console.WriteLine($"The WeakReference to the object is in generation: {GC.GetGeneration(wkref)} Nnumber of Object {count} ");
                Console.Read();
            }
            catch (Exception e)
            {
                Console.WriteLine("The WeakReference to the object has been garbage collected: '{0}'", e);
                Console.Read();
            }
        }

        void MakeSomeGarbage()
        {
            Version vt;

            for (int i = 0; i < maxGarbage; i++)
            {
                // Create objects and release them to fill up memory
                // with unused objects.
                vt = new Version();
            }
        }
    }
}
