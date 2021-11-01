﻿using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_953506_Bortnovskiy.Extensions
{
    public static class RequestExtensions 
    { public static bool IsAjaxRequest(this HttpRequest request) 
        { 
            return request.Headers["x-requested-with"].Equals("XMLHttpRequest"); 
        } 
    }
}