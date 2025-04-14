using System;
using System.Data;
using System.Threading.Tasks;

namespace Twitter.Domain.Interfaces
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        /// <summary>
        /// トランザクションの開始
        /// </summary>
        Task BeginTransactionAsync(IsolationLevel isolationLevel = IsolationLevel.ReadCommitted);

        /// <summary>
        /// トランザクションのコミット
        /// </summary>
        Task CommitAsync();

        /// <summary>
        /// トランザクションのロールバック
        /// </summary>
        Task RollbackAsync();

        /// <summary>
        /// 現在の接続を取得（Dapper用）
        /// </summary>
        IDbConnection Connection { get; }

        /// <summary>
        /// 現在のトランザクションを取得（Dapper用）
        /// </summary>
        IDbTransaction? Transaction { get; }
    }
}
