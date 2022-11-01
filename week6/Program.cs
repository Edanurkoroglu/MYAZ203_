namespace week6
{
    public class Program
    {
        private static int kHealth;

        public static void Main()
        {
            Knight knight = new Knight("Sir Knight");
            Enemy enemy = new Enemy();

            var kHealth = knight.Healt;
            var eHealth = enemy.Healt;

            while (kHealth > 0)
            {
                knight.Attack(ref eHealth);
                enemy.Attack(ref kHealth);
                Console.WriteLine(
                    $"------------\n" +
                    $"{enemy.Name}Health:{eHealth}\n" +
                    $"{knight.Name}:{kHealth}");
            }
        }
    }
}
