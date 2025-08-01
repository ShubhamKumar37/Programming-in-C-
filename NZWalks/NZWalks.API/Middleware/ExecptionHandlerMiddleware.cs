namespace NZWalks.API.Middleware
{
    public class ExecptionHandlerMiddleware
    {
        private readonly RequestDelegate next;

        public ExecptionHandlerMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await next(context);
            }
            catch (Exception ex)
            {
                // Log the exception (logging logic not shown here)
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;

                var errorResponse = new { 
                    StatusCode = context.Response.StatusCode,
                    Message = "An unexpected error occurred. Please try again later.",
                    Details = ex.Message, // In production, avoid exposing detailed error messages
                    stackTrace= ex.StackTrace // Optional: Include stack trace for debugging purposes
                };
                await context.Response.WriteAsJsonAsync(errorResponse, new System.Text.Json.JsonSerializerOptions
                {
                    PropertyNamingPolicy = System.Text.Json.JsonNamingPolicy.CamelCase,
                    WriteIndented = true // Optional: For better readability in development
                });
            }
        }
    }
}
