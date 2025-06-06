# GitHub Copilot Chat の基本的な使い方

## 前提

- GitHub Copilot へのアクセス権が必要です。
- あらかじめ Visual Studio Code および拡張機能 GitHub Copilot をインストールしてください。

## チャットウィンドウを開く

Visual Studio Code の上部のタイトルバーで ![GitHub Copilot アイコン](./images/github-copilot-icon.svg) アイコンをクリックします。

![GitHub Copilot チャットウィンドウ](./images/github-copilot-chat-window.png)

## プロンプトを送信する

チャットウィンドウ下部のプロンプトボックスにプロンプトを入力し、 `Enter` キーを押下するか送信ボタンをクリックします。
プロンプトボックス内で改行したい場合は、 `Shift` + `Enter` キーを押下します。

## プロンプトで markdown を使用する

プロンプトでは markdown 形式を使用できます。

たとえば、コード例を挙げて複数の項目を質問したい場合、以下のようにプロンプトを記述できます。

```markdown

    以下の Java コードについて教えてください。

    ```Java
    public void DoSomething(String name) {
        // Do Something...
    }
    ```

    1. 〇〇は××ですか？
    1. △△は□□ですか？
```

コードブロックや箇条書きによって情報を整理することで、 AI に質問の意図や文脈が伝わりやすくなります。

## プロンプトにチャット参加者を含める

> チャット参加者は、支援を受けることができる専門知識を持つドメイン専門家のようなものです。

（ [IDE で GitHub Copilot に質問する - GitHub Docs](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#submitting-prompts) より）

本研修で主に使用するチャット参加者は `@workspace` です。これは、現在のプロジェクト（ワークスペース）全体の情報を AI に参照させるための指定です。

通常の質問では、開いているファイルや選択中のコードなど、限定的な情報だけが AI のコンテキストになりますが、`@workspace` を指定すると、プロジェクト内の他のファイルや設定、関連コードも含めて AI が回答を生成します。

その他のチャット参加者の説明は [GitHub Copilot Chat チート シート - GitHub Docs](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/github-copilot-chat-cheat-sheet?tool=vscode#chat-participants) を参照してください。

## プロンプトにチャット変数を含める

チャット変数とは、プロンプトに埋め込むことで、特定の情報や状況を AI に伝えるためのキーワードです。

たとえば、`@file` や `@selection` などのチャット変数を使うと、  
「今開いているファイル」や「選択中のコード」など、その時点の具体的な情報を AI に渡すことができます。

主なチャット変数の例：

- `@file` … 現在開いているファイル全体
- `@selection` … 選択中のテキスト部分
- `@workspace` … プロジェクト全体

これらをプロンプトに含めることで、 AI がより正確に状況を把握し、適切な回答や提案をしてくれます。

その他のチャット変数の説明は [GitHub Copilot Chat チート シート - GitHub Docs](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/github-copilot-chat-cheat-sheet?tool=vscode#chat-variables) を参照してください。
