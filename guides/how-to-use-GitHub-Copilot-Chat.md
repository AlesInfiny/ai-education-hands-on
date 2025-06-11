# ハンズオン：GitHub Copilot Chat の基本的な使い方

## 前提

- GitHub Copilot へのアクセス権が必要です。
- あらかじめ Visual Studio Code （以降、 VS Code と表記）および拡張機能 GitHub Copilot をインストールしてください。

## チャットウィンドウを開く

VS Code の上部のタイトルバーで ![GitHub Copilot アイコン](./images/github-copilot-icon.svg) アイコンをクリックします。

![GitHub Copilot チャットウィンドウ](./images/github-copilot-chat-window.png)

### 【ハンズオン】チャットウィンドウを開く

VS Code を開き、チャットウィンドウを開いてみましょう。

## プロンプトを送信する

チャットウィンドウ下部のプロンプトボックスにプロンプトを入力し、 `Enter` キーを押下するか送信ボタンをクリックします。
プロンプトボックス内で改行したい場合は、 `Shift` + `Enter` キーを押下します。

### 【ハンズオン】プロンプトを送信する

チャットウィンドウに GitHub Copilot への質問を入力し `Enter` キーを押下してみましょう。

> COBOL から Java への変換プロジェクトの範囲を決定する際に、コードベース、モジュール、および移行する必要がある機能の範囲をどのように決定しますか？　関与するステップは何ですか？

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

### 【ハンズオン】プロンプトで markdown を使用する

チャットウィンドウに markdown 形式で質問文を入力して GitHub Copilot に質問してみましょう。

```markdown
以下の COBOL コードについて質問があります。

    ```COBOL
       IDENTIFICATION DIVISION.
       PROGRAM-ID. Sample.
       DATA DIVISION.
       WORKING-STORAGE SECTION.
       01  NUM1        PIC 9(3) VALUE 100.
       01  NUM2        PIC 9(3) VALUE 200.
       01  RESULT      PIC 9(4).
       PROCEDURE DIVISION.
           ADD NUM1 TO NUM2 GIVING RESULT
           DISPLAY RESULT
           STOP RUN.
    ```

1. このプログラムの処理内容を説明してください。
1. NUM1 や NUM2 の値を変更した場合、どのような結果になりますか？
1. 計算結果をファイルに出力するにはどうすればよいですか？

```

## プロンプトでスラッシュコマンドを使用する

スラッシュコマンドとは、プロンプトの先頭に `/` （スラッシュ）を付けて入力することで、特定の機能や操作を AI に指示できるものです。

主なスラッシュコマンドの例：

- `/explain` … 選択したコードや、開いているコードファイルの説明を依頼する
- `/test` … テストコードの生成を依頼する
- `/fix` … バグ修正を依頼する
- `/help` … GitHub Copilot の使い方を確認する

その他のスラッシュコマンドの説明は [GitHub Copilot Chat チート シート - GitHub Docs](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/github-copilot-chat-cheat-sheet?tool=vscode#slash-commands) を参照してください。

### 【ハンズオン】プロンプトでスラッシュコマンドを使用する

スラッシュコマンドを使用して GitHub Copilot に質問してみましょう。

- [Utilities.cpp](./examples/Utilities.cpp) を VS Code で開き、ファイル全体を `/explain` を使用して説明させる
- 上のファイルの任意の範囲を選択し、 `/explain` で説明させる
- `/help` で GitHub Copilot の使い方を確認する

## プロンプトにチャット参加者を含める

> チャット参加者は、支援を受けることができる専門知識を持つドメイン専門家のようなものです。

（ [IDE で GitHub Copilot に質問する - GitHub Docs](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/asking-github-copilot-questions-in-your-ide#submitting-prompts) より）

主なチャット参加者の例：

- `@workspace` … 現在のプロジェクト（ワークスペース）全体の情報を AI に参照させるためのチャット参加者
- `@github` … GitHub 上のリポジトリ情報や、 Web 検索、エンタープライズのナレッジベースなど、外部の情報源を AI に参照させるためのチャット参加者
- `@vscode` … VS Code に関する操作や設定、使い方などを AI に参照させるためのチャット参加者

通常の質問では、開いているファイルや選択中のコードなど、限定的な情報だけが AI のコンテキストになりますが、チャット参加者を使用することで、プロジェクト内の他のコードやファイル、 GitHub 上のリポジトリ情報、外部 Web の情報などを含めて AI が回答を生成します。

その他のチャット参加者の説明は [GitHub Copilot Chat チート シート - GitHub Docs](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/github-copilot-chat-cheat-sheet?tool=vscode#chat-participants) を参照してください。

### 【ハンズオン】プロンプトにチャット参加者を含める

チャット参加者を使用して GitHub Copilot に質問してみましょう。

- `@workspace` を使用して、 `/guides/examples` フォルダーに配置されたコードについて説明させる
- `@github` を使用して、このリポジトリの概要を説明させる

## プロンプトにチャット変数を含める

チャット変数とは、プロンプトに埋め込むことで、特定の情報や状況を AI に伝えるためのキーワードです。

たとえば、`#file` や `#selection` などのチャット変数を使うと、  
「今開いているファイル」や「選択中のコード」など、その時点の具体的な情報を AI に渡すことができます。

主なチャット変数の例：

- `#file` … 現在開いているファイル全体
- `#selection` … 選択中のテキスト部分

チャット変数を使わなくても、 AI はコンテキストからどのファイルを使用するべきかある程度判断できます。しかし、チャット変数を使えば「この情報を使ってほしい」とはっきり指示できるため、より精度の高い回答が得られます。

その他のチャット変数の説明は [GitHub Copilot Chat チート シート - GitHub Docs](https://docs.github.com/ja/copilot/using-github-copilot/copilot-chat/github-copilot-chat-cheat-sheet?tool=vscode#chat-variables) を参照してください。

### 【ハンズオン】プロンプトにチャット変数を含める

チャット変数を使用して GitHub Copilot に質問してみましょう。

- [Utilities.cpp](./examples/Utilities.cpp) を VS Code で開き、 `#file` と `/explain` を使用してファイルの内容を説明させる
- [Utilities.cpp](./examples/Utilities.cpp) を VS Code で開き、任意の範囲を選択して `#selection` と `/explain` で選択範囲の内容を説明させる
