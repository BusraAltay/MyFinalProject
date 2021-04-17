using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        public ErrorDataResult(T data) : base(data, false)
        {

        }
        public ErrorDataResult(string message) : base(default, false, message) //default : data'ya karşılık gelir. Örneğin return tipi int'tir ama bir şey döndürmek istemiyorsak o yüzden int'in default'unu geçsin diyebiliriz.
        {

        }
        public ErrorDataResult() : base(default, false)
        {

        }
    }
}
