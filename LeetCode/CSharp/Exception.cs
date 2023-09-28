using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization;
using System.Linq.Expressions;

namespace LeetCode.CSharp
{

    [Serializable]
    public class ExplicitException :Exception
    {

       public ExplicitException() 
            : base() { 
        
        }

        public ExplicitException(string message ) 
            : base(message) { 
        }

        public ExplicitException(string message, Exception ? innerExcpetion) 
            :base(message, innerExcpetion)
        {

        }

        public ExplicitException (SerializationInfo serializations, StreamingContext streamContent)
            : base(serializations, streamContent)
        {

        }
       

        public void callException()
        {
           throw new ExplicitException();
           throw new ExplicitException("");
            //throw new ExplicitException("", Exception ? exception);
        }



        public void Method1Exception()
        {
            try
            {

            }
           

          

            catch(NullReferenceException ex) 
            {
                try
                {

                }

                catch
                {

                }

               

                finally
                {

                }
            }

            catch(Exception ex)
            {
                try
                {

                }

                catch
                {

                }
                finally
                {

                }
            }

            finally
            {
               
            }
        }

    }
}
