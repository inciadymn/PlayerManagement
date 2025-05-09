using PlayerManagement.Model.Exceptions;
using System.Net;
using System.Text.Json;

namespace PlayerManagement.Api.Middlewares
{
    public class ErrorHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public ErrorHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                await HandleErrorAsync(context, exception);
            }
        }

        private static Task HandleErrorAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";

            object response;

            if (exception is CustomException customException)
            {
                context.Response.StatusCode = customException.StatusCode;

                response = new { Message = exception.Message.ToString() };
            }
            else
            {
                context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;

                response = new
                {
                    Message = exception.ToString()
                };
            }

            return context.Response.WriteAsync(JsonSerializer.Serialize(response));
        }
    }
}
