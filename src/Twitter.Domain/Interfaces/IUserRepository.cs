namespace Twitter.Domain.Interfaces;

using Twitter.Domain.Entities;

public interface IUserRepository
{
    /// <summary>
    /// 指定されたIDのユーザーを取得します（存在しない場合は null）
    /// </summary>
    Task<User?> GetByIdAsync(long userId);

    /// <summary>
    /// ユーザーを新規追加します
    /// </summary>
    Task AddAsync(User user);

    /// <summary>
    /// ユーザー名またはメールアドレスで既存ユーザーが存在するか確認します
    /// </summary>
    Task<bool> ExistsAsync(string email);

    /// <summary>
    /// ユーザー情報を更新します
    /// </summary>
    Task UpdateAsync(User user);
}
