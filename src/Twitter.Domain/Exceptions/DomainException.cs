namespace Twitter.Domain.Exceptions;

/// <summary>
/// ドメイン層でのビジネスルール違反を表す例外の基底クラス
/// </summary>
public class DomainException : Exception
{
    public DomainException() { }

    public DomainException(string message) : base(message) { }

    public DomainException(string message, Exception innerException)
        : base(message, innerException) { }
}
