using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerManagement.Model.Exceptions
{
    public class CustomException : Exception
    {
        public int StatusCode {  get; set; }

        public CustomException(string message, int code = 400) : base(message) 
        {
            StatusCode = code;  
        }
    }
}
