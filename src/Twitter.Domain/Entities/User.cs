namespace Twitter.Domain.Entities;

using Twitter.Domain.ValueObjects;
using Twitter.Domain.Exceptions;

public class User
{
    public long Id { get; private set; }

    public UserName Name { get; private set; }

    public EmailAddress Email { get; private set; }

    public DateTime CreatedAt { get; private set; }

    public bool IsDeleted { get; private set; }

    // コンストラクタ
    public User(long id, UserName name, EmailAddress email)
    {
        if (id <= 0) throw new ValidationException("IDは正の値でなければなりません。");

        Id = id;
        Name = name ?? throw new ArgumentNullException(nameof(name));
        Email = email ?? throw new ArgumentNullException(nameof(email));
        CreatedAt = DateTime.UtcNow;
        IsDeleted = false;
    }

    // 名前を変更するメソッド
    public void ChangeName(UserName newName)
    {
        if (newName == null) throw new ArgumentNullException(nameof(newName));
        Name = newName;
    }

    // 退会（論理削除）
    public void Delete()
    {
        IsDeleted = true;
    }
}
