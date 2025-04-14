namespace Twitter.Domain.Interfaces;

using Twitter.Domain.Entities;

public interface ITweetRepository
{
    /// <summary>
    /// ツイートをIDで取得します（存在しない場合は null）
    /// </summary>
    Task<Tweet?> GetByIdAsync(long tweetId);

    /// <summary>
    /// 指定ユーザーのツイートを新しい順で取得します（ページング対応可）
    /// </summary>
    Task<IEnumerable<Tweet>> GetByUserIdAsync(long userId, int limit, int offset);

    /// <summary>
    /// ユーザーのタイムライン（フォロー中ユーザー＋自分の投稿）を取得します
    /// </summary>
    Task<IEnumerable<Tweet>> GetTimelineAsync(long userId, int limit, int offset);

    /// <summary>
    /// 新しいツイートを追加します
    /// </summary>
    Task AddAsync(Tweet tweet);

    /// <summary>
    /// ツイートを更新します（編集や論理削除）
    /// </summary>
    Task UpdateAsync(Tweet tweet);
}
