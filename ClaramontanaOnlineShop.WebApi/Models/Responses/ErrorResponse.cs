﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaramontanaOnlineShop.WebApi.Models.Responses
{
    public class ErrorResponse
    {
        public IEnumerable<string> ErrorMessages { get; set; }
        public ErrorResponse(string errorMessage) : this(new List<string> { errorMessage }) { }

        public ErrorResponse(IEnumerable<string> errorMesssages)
        {
            ErrorMessages = errorMesssages;
        }
    }
}
