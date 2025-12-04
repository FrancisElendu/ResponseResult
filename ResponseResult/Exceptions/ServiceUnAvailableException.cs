using System.Net;

namespace ResponseResult.Exceptions
{
    public class ServiceUnAvailableException : Exception
    {
        public List<string> ErrorMessages { get; set; }
        public string FriendlyErrorMessage { get; set; }
        public HttpStatusCode StatusCode { get; set; }

        public ServiceUnAvailableException(
            string friendlyErrorMessage,
            List<string> errorMessages = default,
            HttpStatusCode statusCode = HttpStatusCode.ServiceUnavailable)
        {
            FriendlyErrorMessage = friendlyErrorMessage;
            ErrorMessages = errorMessages ?? [];
            StatusCode = statusCode;

        }
    }
}
