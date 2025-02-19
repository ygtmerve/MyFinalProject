﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class Result : IResult  //IResult ın somut sınıfıdır.
    {

        public Result(bool success, string messsage):this(success)
        {
            Message = messsage;
        }

        public Result(bool success)
        {
            Success = success;
        }

        public bool Success  {get;}

        public string Message { get; }
    }
}
