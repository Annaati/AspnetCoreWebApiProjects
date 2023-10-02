namespace CitiesManager.WebAPI.DTO.ViewModels
{
    public class ApiResponseVM<T>
    {
        public bool Success { get; set; }
        public int StatusCode { get; set; }
        public string Title { get; set; }
        public string Message { get; set; }
        public T? Data { get; set; }

        public ApiResponseVM(bool success, int statusCode, string title, string message, T? data)
        {
            Success = success;
            StatusCode = statusCode;
            Title = title;
            Message = message;
            Data = data;
        }
    }
}
