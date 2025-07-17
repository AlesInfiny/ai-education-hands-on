namespace ExampleCSharpLibrary
{
    public static class PasswordValidator
    {
        /// <summary>
        /// 引数で受け取ったパスワードを検証します。パスワードの要件は以下。<br/>
        /// - 10文字以上
        /// - 英大文字を含む
        /// - 英小文字を含む
        /// - 数字を含む
        /// - それ以外の文字は含まない
        /// </summary>
        /// <param name="password">パスワード</param>
        /// <returns>検証OKの場合はtrue、そうでなければfalse</returns>
        public static bool IsValid(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }

            if (!HasUpperCase(password) || !HasLowerCase(password) || !HasDigit(password))
            {
                return false;
            }

            return true;
        }

        private static bool HasUpperCase(string input)
        {
            foreach (char c in input)
            {
                if (char.IsUpper(c))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool HasLowerCase(string input)
        {
            foreach (char c in input)
            {
                if (char.IsLower(c))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool HasDigit(string input)
        {
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    return true;
                }
            }
            return false;
        }
    }
}