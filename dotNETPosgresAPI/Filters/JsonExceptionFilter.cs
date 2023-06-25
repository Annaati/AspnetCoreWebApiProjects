using dotNETPosgresAPI.DTO.ViewModel;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;

namespace dotNETPosgresAPI.Filters
{
    public class JsonExceptionFilter : IExceptionFilter
    {
        [Obsolete]
        private readonly Microsoft.Extensions.Hosting.IHostingEnvironment _env;

        [Obsolete]
        public JsonExceptionFilter(Microsoft.Extensions.Hosting.IHostingEnvironment env)
        {
            _env = env;
        }

        public void OnException(ExceptionContext context)
        {
            var error = new ApiErrorResVM();

            if (_env.IsDevelopment())
            {
                error.Message = context.Exception.Message;
                error.Detail = context.Exception.StackTrace;
            }
            else
            {
                //error.Message = context.Exception.Message;
                //error.Detail = context.Exception.StackTrace;
                error.Message = "A Server or Exception occured";
                error.Detail = context.Exception.Message;
            }

            context.Result = new ObjectResult(error)
            {
                StatusCode = 500
            };
        }
    
    
    
    
    
    }
}
