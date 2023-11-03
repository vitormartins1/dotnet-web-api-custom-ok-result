using Microsoft.AspNetCore.Mvc;

namespace CustomOkResult
{
    public class CustomOkResult<T> : IActionResult
    {
        private readonly T _value;

        public CustomOkResult(T value)
        {
            _value = value;
        }

        public async Task ExecuteResultAsync(ActionContext context)
        {
            var objectResult = new ObjectResult(new { Data = _value })
            {
                StatusCode = StatusCodes.Status200OK
            };

            await objectResult.ExecuteResultAsync(context);
        }
    }
}