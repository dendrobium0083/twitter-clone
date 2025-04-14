namespace Twitter.Domain.Interfaces;

using Twitter.Domain.Entities;

public interface IFollowRepository
{
    /// <summary>
    /// フォロー関係を追加します
    /// </summary>
    Task AddAsync(Follow follow);

    /// <summary>
    /// フォロー関係を削除します（アンフォロー）
    /// </summary>
    Task RemoveAsync(long followerId, long followeeId);

    /// <summary>
    /// 指定ユーザーが特定ユーザーをフォローしているか確認します
    /// </summary>
    Task<bool> ExistsAsync(long followerId, long followeeId);

    /// <summary>
    /// フォローしているユーザー一覧を取得します
    /// </summary>
    Task<IEnumerable<long>> GetFolloweeIdsAsync(long followerId);

    /// <summary>
    /// フォロワー一覧（自分をフォローしているユーザー）を取得します
    /// </summary>
    Task<IEnumerable<long>> GetFollowerIdsAsync(long followeeId);
}
