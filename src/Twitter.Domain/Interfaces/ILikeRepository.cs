using System.Collections.Generic;
using System.Threading.Tasks;
using Twitter.Domain.Entities;
using Twitter.Domain.Enums;

namespace Twitter.Domain.Interfaces
{
    public interface ILikeRepository
    {
        /// <summary>
        /// 指定のユーザーが指定のターゲットに「いいね」しているか確認
        /// </summary>
        Task<bool> ExistsAsync(long userId, long targetId, LikeTargetType targetType);

        /// <summary>
        /// 「いいね」情報を追加
        /// </summary>
        Task AddAsync(Like like);

        /// <summary>
        /// 「いいね」情報を削除
        /// </summary>
        Task RemoveAsync(long userId, long targetId, LikeTargetType targetType);

        /// <summary>
        /// 指定のターゲットに「いいね」したユーザー一覧を取得
        /// </summary>
        Task<IEnumerable<long>> GetUserIdsByTargetAsync(long targetId, LikeTargetType targetType);
    }
}
