foreach (var n in SortearNumero())
{
    System.Console.Write($"{n}\t");
}

static IEnumerable<int> SortearNumero()
{
    var randonInt = new Random();
    for (int i = 0; i < 6; i++)
    {
        yield return randonInt.Next(1, 60);
    }
}