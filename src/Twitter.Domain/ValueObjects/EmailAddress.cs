namespace Twitter.Domain.ValueObjects;

using System.Text.RegularExpressions;
using Twitter.Domain.Exceptions;

/// <summary>
/// メールアドレスを表す値オブジェクト（形式チェックあり）
/// </summary>
public sealed class EmailAddress : IEquatable<EmailAddress>
{
    private static readonly Regex EmailRegex =
        new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", RegexOptions.Compiled | RegexOptions.IgnoreCase);

    public string Value { get; }

    public EmailAddress(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ValidationException("メールアドレスは必須です。");

        if (!EmailRegex.IsMatch(value))
            throw new ValidationException("メールアドレスの形式が不正です。");

        Value = value;
    }

    public override string ToString() => Value;

    public override bool Equals(object? obj) =>
        obj is EmailAddress other && Equals(other);

    public bool Equals(EmailAddress? other) =>
        other is not null && Value.Equals(other.Value, StringComparison.OrdinalIgnoreCase);

    public override int GetHashCode() =>
        Value.ToLowerInvariant().GetHashCode();

    public static bool operator ==(EmailAddress left, EmailAddress right) =>
        Equals(left, right);

    public static bool operator !=(EmailAddress left, EmailAddress right) =>
        !Equals(left, right);
}
