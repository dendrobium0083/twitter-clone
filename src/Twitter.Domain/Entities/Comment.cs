namespace Twitter.Domain.Entities;

using Twitter.Domain.ValueObjects;
using Twitter.Domain.Exceptions;

public class Comment
{
    public long Id { get; private set; }

    public long TweetId { get; private set; }

    public long UserId { get; private set; }

    public TweetContent Content { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public bool IsDeleted { get; private set; }

    public Comment(long id, long tweetId, long userId, TweetContent content)
    {
        if (id <= 0)
            throw new ValidationException("Comment ID は正の値でなければなりません。");

        if (tweetId <= 0)
            throw new ValidationException("Tweet ID は正の値でなければなりません。");

        if (userId <= 0)
            throw new ValidationException("User ID は正の値でなければなりません。");

        Content = content ?? throw new ArgumentNullException(nameof(content));

        Id = id;
        TweetId = tweetId;
        UserId = userId;
        CreatedAt = DateTime.UtcNow;
        IsDeleted = false;
    }

    public void Edit(TweetContent newContent)
    {
        if (newContent == null) throw new ArgumentNullException(nameof(newContent));
        Content = newContent;
    }

    public void Delete()
    {
        IsDeleted = true;
    }
}
