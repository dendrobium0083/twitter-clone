namespace Twitter.Domain.Entities;

using Twitter.Domain.Exceptions;
using Twitter.Domain.Enums;

/// <summary>
/// ツイートまたはコメントへの「いいね」を表すエンティティ
/// </summary>
public class Like
{
    public long UserId { get; private set; }

    public long TargetId { get; private set; }

    public LikeTargetType TargetType { get; private set; }

    public DateTime LikedAt { get; private set; }

    public Like(long userId, long targetId, LikeTargetType targetType)
    {
        if (userId <= 0)
            throw new ValidationException("User ID は正の値でなければなりません。");

        if (targetId <= 0)
            throw new ValidationException("対象IDは正の値でなければなりません。");

        UserId = userId;
        TargetId = targetId;
        TargetType = targetType;
        LikedAt = DateTime.UtcNow;
    }
}
