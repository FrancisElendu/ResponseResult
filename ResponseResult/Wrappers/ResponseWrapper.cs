namespace ResponseResult.Wrappers
{
    public class ResponseWrapper : IResponseWrapper
    {
        public List<string> Messages { get; set; } = [];
        public bool IsSuccessful { get; set; }

        #region Fail Synchronously
        public static IResponseWrapper Fail()
        {
            return new ResponseWrapper()
            {
                IsSuccessful = false
            };
        }

        public static IResponseWrapper Fail(string message)
        {
            return new ResponseWrapper()
            {
                IsSuccessful = false,
                Messages = new List<string>() { message }
            };
        }

        public static IResponseWrapper Fail(List<string> messages)
        {
            return new ResponseWrapper()
            {
                IsSuccessful = false,
                Messages = messages
            };
        }
        #endregion


        #region Fail Asynchronously
        public static async Task<IResponseWrapper> FailAsync()
        {
            return await Task.FromResult(Fail());
        }

        public static async Task<IResponseWrapper> FailAsync(string message)
        {
            return await Task.FromResult(Fail(message));
        }
        public static async Task<IResponseWrapper> FailAsync(List<string> messages)
        {
            return await Task.FromResult(Fail(messages));
        }

        #endregion


        #region Success Synchronously

        public static IResponseWrapper Success()
        {
            return new ResponseWrapper()
            {
                IsSuccessful = true
            };
        }

        public static IResponseWrapper Success(string message)
        {
            return new ResponseWrapper()
            {
                IsSuccessful = true,
                Messages = new List<string>() { message }
            };
        }

        public static IResponseWrapper Success(List<string> messages)
        {
            return new ResponseWrapper()
            {
                IsSuccessful = true,
                Messages = messages
            };
        }
        #endregion


        #region Success Asynchronously
        public static async Task<IResponseWrapper> SuccessAsync()
        {
            return await Task.FromResult(Success());
        }

        public static async Task<IResponseWrapper> SuccessAsync(string message)
        {
            return await Task.FromResult(Success(message));
        }
        public static async Task<IResponseWrapper> SuccessAsync(List<string> messages)
        {
            return await Task.FromResult(Success(messages));
        }

        #endregion

    }

    public class ResponseWrapper<T> : ResponseWrapper, IResponseWrapper<T>
    {
        public T Data { get; set; }

        public ResponseWrapper()
        {

        }

        #region Fail Synchronously
        public new static ResponseWrapper<T> Fail()
        {
            return new ResponseWrapper<T>()
            {
                IsSuccessful = false
            };
        }
        public new static ResponseWrapper<T> Fail(string message)
        {
            return new ResponseWrapper<T>()
            {
                IsSuccessful = false,
                Messages = [message]
            };
        }
        public new static ResponseWrapper<T> Fail(List<string> messages)
        {
            return new ResponseWrapper<T>()
            {
                IsSuccessful = false,
                Messages = messages
            };
        }
        #endregion

        #region Fail Asynchronously
        public new static Task<ResponseWrapper<T>> FailAsync()
        {
            return Task.FromResult(Fail());
        }

        public new static Task<ResponseWrapper<T>> FailAsync(string message)
        {
            return Task.FromResult(Fail(message));
        }
        public new static Task<ResponseWrapper<T>> FailAsync(List<string> messages)
        {
            return Task.FromResult(Fail(messages));
        }

        #endregion

        #region Success Synchronously
        public new static ResponseWrapper<T> Success()
        {
            return new ResponseWrapper<T>()
            {
                IsSuccessful = true
            };
        }
        public new static ResponseWrapper<T> Success(string message)
        {
            return new ResponseWrapper<T>()
            {
                IsSuccessful = true,
                Messages = [message]
            };
        }
        public new static ResponseWrapper<T> Success(List<string> messages)
        {
            return new ResponseWrapper<T>()
            {
                IsSuccessful = true,
                Messages = messages
            };
        }


        public static ResponseWrapper<T> Success(T data)
        {
            return new ResponseWrapper<T>()
            {
                Data = data,
                IsSuccessful = true
            };
        }
        public static ResponseWrapper<T> Success(T data, string message)
        {
            return new ResponseWrapper<T>()
            {
                Data = data,
                IsSuccessful = true,
                Messages = [message]
            };
        }

        public static ResponseWrapper<T> Success(T data, List<string> messages)
        {
            return new ResponseWrapper<T>()
            {
                Data = data,
                IsSuccessful = true,
                Messages = messages
            };
        }

        #endregion

        #region Success Asynchronously
        public new static Task<ResponseWrapper<T>> SuccessAsync()
        {
            return Task.FromResult(Success());
        }
        public new static Task<ResponseWrapper<T>> SuccessAsync(string message)
        {
            return Task.FromResult(Success(message));
        }
        public new static Task<ResponseWrapper<T>> SuccessAsync(List<string> messages)
        {
            return Task.FromResult(Success(messages));
        }


        public static Task<ResponseWrapper<T>> SuccessAsync(T data)
        {
            return Task.FromResult(Success(data));
        }
        public static Task<ResponseWrapper<T>> SuccessAsync(T data, string message)
        {
            return Task.FromResult(Success(data, message));
        }

        public static Task<ResponseWrapper<T>> SuccessAsync(T data, List<string> messages)
        {
            return Task.FromResult(Success(data, messages));
        }

        #endregion
    }
}
