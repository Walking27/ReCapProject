﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilites.Results
{
    public class Result : IResult
    {
        public Result(bool success, string massege):this(success)
        {
            Message = massege;
        }
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
