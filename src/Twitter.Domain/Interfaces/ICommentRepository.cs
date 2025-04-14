namespace Twitter.Domain.Interfaces;

using Twitter.Domain.Entities;

public interface ICommentRepository
{
    /// <summary>
    /// コメントをIDで取得します（存在しない場合は null）
    /// </summary>
    Task<Comment?> GetByIdAsync(long commentId);

    /// <summary>
    /// 指定ツイートに対するコメント一覧を取得します（新しい順）
    /// </summary>
    Task<IEnumerable<Comment>> GetByTweetIdAsync(long tweetId, int limit, int offset);

    /// <summary>
    /// コメントを新規追加します
    /// </summary>
    Task AddAsync(Comment comment);

    /// <summary>
    /// コメントを更新します（編集や論理削除）
    /// </summary>
    Task UpdateAsync(Comment comment);
}
