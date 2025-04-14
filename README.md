# 🐦 twitter-clone

Twitter風のSNSアプリケーションを **.NET 8 / クリーンアーキテクチャ** で実装する学習用プロジェクトです。  
投稿、コメント、フォロー、いいねなどの基本的なSNS機能を備え、今後の拡張も見据えたモジュール設計を行っています。

---

## 🧱 プロジェクト構成

```
twitter-clone/
├── twitter-clone.sln          # ソリューションファイル
├── README.md                  # このファイル
│
├── src/                       # アプリケーション本体
│   ├── Twitter.Domain/        # ドメイン層（エンティティ、値オブジェクト、リポジトリIF）
│   ├── Twitter.Application/   # アプリケーション層（ユースケース、DTO、サービス）
│   ├── Twitter.Infrastructure/ # インフラ層（Dapper, DB接続、ログ）
│   └── Twitter.WebAPI/        # プレゼンテーション層（Minimal API, Swagger）
│
└── tests/                     # テスト関連
    ├── Twitter.Domain.Tests/
    ├── Twitter.Application.Tests/
    └── Twitter.Infrastructure.Tests/
```

---

## 🚀 開発環境

- **言語／プラットフォーム**: C#, .NET 8
- **アーキテクチャ**: クリーンアーキテクチャ
- **データベース**: Oracle19c（※ PostgreSQLへの切り替え可能）
- **ログ出力**: Serilog（開発時はコンソール + ファイル、本番はファイルのみ）
- **ライブラリ**:
  - Dapper（軽量ORM）
  - Serilog（ログ）
  - Swagger（APIドキュメント）
- **API設計**: Minimal API + OpenAPI (Swagger)

---

## 📚 主な機能（予定含む）

- ユーザー登録 / 認証
- ツイート投稿 / 一覧 / 編集 / 削除
- コメント機能（リプライ）
- フォロー / フォロー解除 / フォロー一覧
- いいね機能（ツイート、コメント）
- タイムライン表示（自分＋フォロー中ユーザー）

---

## 🛠️ セットアップ手順

1. ソリューションをクローン  
   ```bash
   git clone https://github.com/your_username/twitter-clone.git
   cd twitter-clone
   ```

2. プロジェクトの復元  
   ```bash
   dotnet restore
   ```

3. ドメイン層を起点に開発開始  
   ```bash
   cd src/Twitter.Domain
   ```

※ WebAPI は `dotnet run --project src/Twitter.WebAPI/Twitter.WebAPI.csproj` で起動できます。

---

## ✅ 命名規則・ブランチ戦略（例）

- ブランチ名: `feature/add-〇〇`, `fix/bug-〇〇`, `release/20250415`
- コミットメッセージ: `機能追加: ユーザー登録`, `修正: Tweet内容の最大文字数`

---

## 📌 今後の予定

- JWT 認証実装
- 投稿に画像を添付できる機能
- 通知機能（リアクション、フォロー通知など）
- SPA 対応（React or Vue + WebAPI）
- PostgreSQL 対応モジュールの追加

---

## 📄 ライセンス

MIT

---

## 👤 開発者

- [your name or GitHub](https://github.com/your_username)

