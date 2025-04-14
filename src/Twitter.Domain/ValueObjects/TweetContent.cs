namespace Twitter.Domain.ValueObjects;

using Twitter.Domain.Exceptions;

/// <summary>
/// ツイート本文を表す値オブジェクト（最大280文字）
/// </summary>
public sealed class TweetContent : IEquatable<TweetContent>
{
    public const int MaxLength = 280;

    public string Value { get; }

    public TweetContent(string value)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ValidationException("ツイート内容は必須です。");

        if (value.Length > MaxLength)
            throw new ValidationException($"ツイート内容は最大{MaxLength}文字までです。");

        Value = value;
    }

    public override string ToString() => Value;

    public override bool Equals(object? obj) =>
        obj is TweetContent other && Equals(other);

    public bool Equals(TweetContent? other) =>
        other is not null && Value == other.Value;

    public override int GetHashCode() => Value.GetHashCode();

    public static bool operator ==(TweetContent left, TweetContent right) =>
        Equals(left, right);

    public static bool operator !=(TweetContent left, TweetContent right) =>
        !Equals(left, right);
}
