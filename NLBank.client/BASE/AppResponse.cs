using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLBank.client.BASE
{
    public class AppResponse<T>
    {
        public bool IsSuccess { get; set; }
        public String Message { set; get; } = ""; 
        public T Result { get; set; }
        public AppResponse(bool isSuccess, string message)
        {
            IsSuccess = isSuccess;
            Message = message;
        }
        public AppResponse(bool isSuccess)
        {
            IsSuccess = isSuccess;
        }
        public AppResponse(T result)
        {
            IsSuccess = true; 
            Result = result;

        }
    }
}
