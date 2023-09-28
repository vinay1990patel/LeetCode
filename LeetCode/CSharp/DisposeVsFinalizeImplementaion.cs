using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.CSharp
{

    // To Dispose implecetly use using block and it is used for unmanged Code . to call it explicilty call should be inherited from IDisposible interface


    class MyObject : IDisposable
    {
        private const long maxGarbage = 1000;
        public static int count = 0;


        public MyObject() { 
        
          count =count + 1;
        }
        //indicates if dispose has already been called
        private bool _disposed = false;

        //Finalize method for the object, will call Dispose for us
        //to clean up the resources if the user has not called it
        ~MyObject()
        {
            //Indicate that the GC called Dispose, not the user
            Dispose(false);
        }

        //This is the public method, it will HOPEFULLY but
        //not always be called by users of the class
        public void Dispose()
        {
            //indicate this was NOT called by the Garbage collector
            Dispose(true);

            //Now we have disposed of all our resources, the GC does not
            //no need to do anything, stop the finalizer being called
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            //Check to see if we have already disposed the object
            //this is necessary because we should be able to call
            //Dispose multiple times without throwing an error
            if (!_disposed)
            {
                if (disposing)
                {
                    //clean up managed resources
                    
                }

                //clear up any unmanaged resources - this is safe to
                //put outside the disposing check because if the user
                //called dispose we want to also clean up unmanaged
                //resources, if the GC called Dispose then we only
                //want to clean up managed resources
            }
        }


        class DumpObjectCreation
        {


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

}
