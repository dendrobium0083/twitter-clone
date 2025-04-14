namespace Twitter.Domain.Entities;

using Twitter.Domain.Exceptions;

/// <summary>
/// ユーザー同士のフォロー関係を表すドメインエンティティ
/// </summary>
public class Follow
{
    public long FollowerId { get; private set; } // フォローする側（自分）

    public long FolloweeId { get; private set; } // フォローされる側（相手）

    public DateTime FollowedAt { get; private set; }

    public Follow(long followerId, long followeeId)
    {
        if (followerId <= 0)
            throw new ValidationException("Follower ID は正の値でなければなりません。");

        if (followeeId <= 0)
            throw new ValidationException("Followee ID は正の値でなければなりません。");

        if (followerId == followeeId)
            throw new ValidationException("自分自身をフォローすることはできません。");

        FollowerId = followerId;
        FolloweeId = followeeId;
        FollowedAt = DateTime.UtcNow;
    }
}
