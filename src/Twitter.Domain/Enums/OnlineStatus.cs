namespace Twitter.Domain.Enums;

/// <summary>
/// ユーザーのオンライン状態を表す列挙型
/// </summary>
public enum OnlineStatus
{
    Offline = 0,       // オフライン
    Online = 1,        // オンライン
    Suspended = 2,     // 利用停止中（BANなど）
    Deactivated = 3    // 退会済み
}
