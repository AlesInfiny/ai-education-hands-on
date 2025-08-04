# 設計者向けハンズオン

GitHub トレーニング 初級編 設計者向けハンズオンで使用する教材の入ったリポジトリです。

## リポジトリのフォルダー構成

```plaintext
root
│  README.md ................................................... このファイル
│
├─appendix
│  │  99.how-to-fork-repository-and-create-pull-request.md .... 付録「リポジトリをフォークしてプルリクエストを作成する手順」
│  │
│  └─images .................................................. 付録が使用する画像のフォルダー
│
├─code-examples ............................................... 各ハンズオンで使用するコード例のフォルダー
│
├─design-specification-templates .............................. COBOL コードをモダナイズするための設計書テンプレートを配置したフォルダー
│
├─hands-on-steps
│  │  01.how-to-use-GitHub-Copilot-Chat.md .................... ハンズオン解説「GitHub Copilot Chat の基本的な使い方」
│  │  02.analyzing-legacy-code-dependency-analysis.md ......... ハンズオン解説「レガシーコードを分析する - 依存関係の分析」
│  │  03.analyzing-legacy-code-processing-details.md .......... ハンズオン解説「レガシーコードを分析する - 処理詳細の解析」
│  │  04.reversing-design-from-legacy-code.md ................. ハンズオン解説「レガシーコードから設計書をリバースする」
│  │  05.create-test-spec-from-design-spec.md ................. ハンズオン解説「設計書からテスト仕様書を作成する」
│  │  06.create-test-data-from-test-spec.md ................... ハンズオン解説「設計書とテスト仕様書からテストデータを作成する」
│  │  07.how-to-do-code-review-with-copilot-vscode.md ......... ハンズオン解説「コードレビューで GitHub Copilot を活用する - VS Code 編 -」
│  │
│  └─images ................................................... ハンズオン解説が使用する画像のフォルダー
│
└─legacy-codes ................................................. GitHub Copilot を使ってモダナイズする COBOL コードのフォルダー
```

## コントリビュートについて / Contributing

本リポジトリは外部からのコントリビュートを受け付けていません。
外部から送信されたプルリクエストは、自動的にクローズされます。
あらかじめご了承ください。

This repository does not accept contributions from external users.
Pull requests submitted by external contributors are automatically closed by our workflow.
Thank you for your understanding.

## ライセンス / License

- `legacy-codes` ディレクトリ以外のコンテンツは、 [CC BY-NC-ND 4.0](https://creativecommons.org/licenses/by-nc-nd/4.0/deed.ja) で提供されています。
- `legacy-codes` ディレクトリのコンテンツは [MIT ライセンス](./legacy-codes/LICENSE) で提供されています。

詳細は [LICENSE](/LICENSE.md) を参照してください。

- Except for the `legacy-codes` directory, all contents are distributed under [CC BY-NC-ND 4.0](https://creativecommons.org/licenses/by-nc-nd/4.0/).
- The contents of the `legacy-codes` directory are provided under the [MIT License](./legacy-codes/LICENSE).

See [LICENSE](/LICENSE.md) for details.
