namespace Twitter.Domain.ValueObjects;

using Twitter.Domain.Exceptions;

/// <summary>
/// ユーザー表示名（1〜50文字以内）を表す値オブジェクト
/// </summary>
public sealed class UserName : IEquatable<UserName>
{
    public const int MaxLength = 50;

    public string Value { get; }

    public UserName(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ValidationException("ユーザー名は必須です。");

        if (value.Length > MaxLength)
            throw new ValidationException($"ユーザー名は最大 {MaxLength} 文字までです。");

        Value = value;
    }

    public override string ToString() => Value;

    public override bool Equals(object? obj) =>
        obj is UserName other && Equals(other);

    public bool Equals(UserName? other) =>
        other is not null && Value == other.Value;

    public override int GetHashCode() => Value.GetHashCode();

    public static bool operator ==(UserName left, UserName right) =>
        Equals(left, right);

    public static bool operator !=(UserName left, UserName right) =>
        !Equals(left, right);
}
