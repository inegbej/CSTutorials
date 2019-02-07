using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Parts.Part41_00_Labs
{
    [Serializable]
    public class UserAlreadyLoggedInException : Exception
    {
        // ctor
        public UserAlreadyLoggedInException() : base()
        {
        }

        public UserAlreadyLoggedInException(string message) : base(message)   
        {
        }

        public UserAlreadyLoggedInException(string message, Exception innerException) : base(message, innerException)  
        {
        }

        public UserAlreadyLoggedInException(SerializationInfo info, StreamingContext context) : base(info, context)   
        {
        }

    }

    public class Part42_00_CustomExceptions
    {
        public static void Part42_Lab()
        {
            Console.WriteLine($"Custom exception Demo");

            try
            {
                throw new UserAlreadyLoggedInException("User is logged in - no duplicate session allowed");
            }
            catch (UserAlreadyLoggedInException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
