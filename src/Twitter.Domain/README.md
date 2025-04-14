## 📦 Twitter.Domain

`Twitter.Domain` は、Twitter風アプリケーションにおける**ビジネスルールの中心**となるドメイン層です。  
エンティティ、値オブジェクト、ドメインサービス、例外、インターフェースなどを定義します。

---

## 📁 フォルダ構成

```
Twitter.Domain/
├── Entities/                 # ドメインエンティティ（User, Tweet など）
├── ValueObjects/            # 値オブジェクト（UserName, TweetContent など）
├── Interfaces/              # リポジトリやUoWなどの契約インターフェース
├── Enums/                   # 状態や区分値の列挙型
├── Exceptions/              # ドメイン層で使う例外クラス
└── Twitter.Domain.csproj    # プロジェクトファイル
```

---

## 🧩 主な構成要素

| 種別         | 説明 |
|--------------|------|
| **Entity**   | 永続化対象のドメインモデル（例：User、Tweet） |
| **ValueObject** | 不変・比較可能な値型（例：UserName、TweetContent） |
| **Interface** | Application 層から依存される契約（リポジトリなど） |
| **Exception** | ドメインルール違反やバリデーション失敗の明示 |
| **Enum**     | 状態やタイプの列挙（例：OnlineStatus） |

---

## 🔄 他層との関係

- `Application` 層は、この `Domain` 層に依存します
- `Domain` 層は他の層に一切依存しません（＝クリーンアーキテクチャの内側）
- `Interface` は `Infrastructure` 層で実装されます

```
Infrastructure → Application → Domain
         [依存の方向：内側に向かう]
```

---

## ✅ 今後の拡張予定

- ドメインサービスの追加
- より細かいバリデーション付きの値オブジェクト
- テスト可能な仕様書としてのユースケース明文化（Application層連携）

---

## 🧪 ユニットテスト方針

- `Domain.Tests` プロジェクトで、EntityやValueObjectのロジックを検証予定
- 特に「等価性」「バリデーション失敗時の例外」などを重点的に確認
