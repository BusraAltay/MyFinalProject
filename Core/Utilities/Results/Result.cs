using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {

        public Result(bool success, string message) : this(success)//Success = success; kapattığımız için --> : this(success) kdunu yazdık. Burada this --> Result'ı gösterir.
        {
            Message = message;
            //Success = success; --> aşağıdaki constractor'da success kodu yazıldığı için kod tekrarı olmaması için bu kodu kapattık.
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; } //get = readonly'dir ve readonly'ler constractor'da set edilebilir.

        public string Message { get; }
    }
}
