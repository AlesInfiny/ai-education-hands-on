class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = null;

        Console.WriteLine("Average: " + CalculateAverage(numbers));

        var list = new List<string> { "a", "b", "c" };
        for (int i = 0; i <= list.Count; i++)  // 範囲外アクセス
        {
            Console.WriteLine("Item: " + list[i]);
        }

        ConnectToDatabase();

        Console.WriteLine("Done");
    }

    static double CalculateAverage(List<int> numbers)
    {
        int sum = 0;
        foreach (var num in numbers)
        {
            sum += num;
        }
        return sum / numbers.Count;  // ゼロ除算 & NullReferenceException の可能性
    }

    static void ConnectToDatabase()
    {
        var connection = new FakeDbConnection();
        connection.Open();
        connection.Query("SELECT * FROM users");  // ダミークラスなので実行不可
        // connection.Close();  ← 閉じてない
    }
}

class FakeDbConnection
{
    public void Open()
    {
        Console.WriteLine("Opening database...");
    }

    public void Query(string sql)
    {
        Console.WriteLine("Running query: " + sql);
    }

    // Close() メソッドが実装されていない
}
