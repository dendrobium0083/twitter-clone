namespace Twitter.Domain.Entities;

using Twitter.Domain.ValueObjects;
using Twitter.Domain.Exceptions;

public class Tweet
{
    public long Id { get; private set; }

    public long UserId { get; private set; }

    public TweetContent Content { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public bool IsDeleted { get; private set; }

    // コンストラクタ
    public Tweet(long id, long userId, TweetContent content)
    {
        if (id <= 0)
            throw new ValidationException("Tweet ID は正の値でなければなりません。");

        if (userId <= 0)
            throw new ValidationException("User ID は正の値でなければなりません。");

        Id = id;
        UserId = userId;
        Content = content ?? throw new ArgumentNullException(nameof(content));
        CreatedAt = DateTime.UtcNow;
        IsDeleted = false;
    }

    // ツイート内容の編集
    public void Edit(TweetContent newContent)
    {
        if (newContent == null) throw new ArgumentNullException(nameof(newContent));
        Content = newContent;
    }

    // 削除（論理削除）
    public void Delete()
    {
        IsDeleted = true;
    }
}
