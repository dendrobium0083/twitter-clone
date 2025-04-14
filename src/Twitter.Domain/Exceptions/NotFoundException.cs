namespace Twitter.Domain.Exceptions;

/// <summary>
/// 指定されたリソースが見つからなかった場合にスローされる例外
/// 例：UserやTweetのIDが存在しないなど
/// </summary>
public class NotFoundException : DomainException
{
    public NotFoundException() { }

    public NotFoundException(string message) : base(message) { }

    public NotFoundException(string message, Exception innerException)
        : base(message, innerException) { }
}
