namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>
            {
                "Halo",
                "XCOM",
                "Divinity 2 Original Sin",
                "Minecraft",
                "Walking Dead Saints and Sinners",
                "Half Life 2",
                "Borderlands 3",
                "Elden Ring",
                "Fallout New Vegas",
                "The Forest"
            };

            Console.WriteLine(string.Join(Environment.NewLine, games.OrderBy(game => game.Length)));
        }
    }
}
