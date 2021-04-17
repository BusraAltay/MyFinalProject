using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class DataResult<T> : Result, IDataResult<T>
    {
        //Result'dan inheritance aldık. Result'ın ctor'ları olduğu için bunları burada implemente etmeliyiz. Result DataResult'un base'i olmuş oldu.
        public DataResult(T data, bool success, string message) : base(success, message)
        {
            Data = data;
        }
        public DataResult(T data, bool success) : base(success)
        {
            Data = data;
        }
        public T Data { get; }
    }
}
