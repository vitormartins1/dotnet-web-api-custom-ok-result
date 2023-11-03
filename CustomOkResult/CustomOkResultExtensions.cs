using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CustomOkResult;

public static class CustomOkResultExtensions
{
    public static IActionResult CustomOk<T>(this ControllerBase controller, T value)
    {
        return new CustomOkResult<T>(value);
    }
}
