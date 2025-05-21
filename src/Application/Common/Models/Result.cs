namespace CleanArchitecture.Application.Common.Models;

public class Result
{
    public bool Succeeded { get; set; }

    public string[] Errors { get; set; } = Array.Empty<string>();

    public static Result Success()
    {
        return new Result { Succeeded = true };
    }

    public static Result Failure(IEnumerable<string> errors)
    {
        return new Result { Succeeded = false, Errors = errors.ToArray() };
    }
}

public class Result<T> : Result
{
    public T Data { get; set; } = default!;

    public static Result<T> Success(T data)
    {
        return new Result<T> { Succeeded = true, Data = data };
    }

    public static new Result<T> Failure(IEnumerable<string> errors)
    {
        return new Result<T> { Succeeded = false, Errors = errors.ToArray() };
    }
}