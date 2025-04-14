namespace Twitter.Domain.Exceptions;

/// <summary>
/// 値の検証やビジネスルールに違反した場合にスローされる例外
/// 例：空のユーザー名、280文字超えのツイート内容など
/// </summary>
public class ValidationException : DomainException
{
    public ValidationException() { }

    public ValidationException(string message) : base(message) { }

    public ValidationException(string message, Exception innerException)
        : base(message, innerException) { }
}
