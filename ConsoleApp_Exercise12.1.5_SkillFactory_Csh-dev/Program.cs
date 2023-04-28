using ConsoleApp_Exercise12._1._5_SkillFactory_Csh_dev;

List<User> users = new List<User>
{
    new User { Login="ali123", Name = "Alice", IsPremium = false },
    new User { Login="bibi98", Name = "Bob", IsPremium = true },
    new User { Login="rituhi76", Name = "Tom", IsPremium = false }
};

foreach (var user in users)
{
    GreetUser(user);
}
Console.ReadKey();

void GreetUser(User user)
{
    Console.WriteLine($"Здравствуйте, {user.Name}!");
    // Остановка на 1 с
    Thread.Sleep(1000);
    if (user.IsPremium != true)
    {
        ShowAds();
    }
}

static void ShowAds()
{
    Console.WriteLine("Посетите наш новый сайт с бесплатными играми free.games.for.a.fool.com");
    // Остановка на 1 с
    Thread.Sleep(1000);

    Console.WriteLine("Купите подписку на МыКомбо и слушайте музыку везде и всегда.");
    // Остановка на 2 с
    Thread.Sleep(2000);

    Console.WriteLine("Оформите премиум-подписку на наш сервис, чтобы не видеть рекламу.");
    // Остановка на 3 с
    Thread.Sleep(3000);
}