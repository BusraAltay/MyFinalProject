using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }
        public SuccessDataResult(T data) : base(data, true)
        {

        }
        public SuccessDataResult(string message) : base(default, true, message) //default : data'ya karşılık gelir. Örneğin return tipi int'tir ama bir şey döndürmek istemiyorsak o yüzden int'in default'unu geçsin diyebiliriz.
        {

        }
        public SuccessDataResult() : base(default, true)
        {

        }
    }
}
