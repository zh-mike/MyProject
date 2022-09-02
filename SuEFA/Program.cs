while (true)
{
    Console.WriteLine("Игра камень, ножницы, бумага!!!");
    Console.Write("Введите свой вариант: ");
    string userAnswer = Console.ReadLine();
    string[] variants = { "ножницы", "бумага", "камень" };
    int i = new Random().Next(0, 3);
    string computeAnswer = variants[i];
    userAnswer = userAnswer.ToLower();

    if (userAnswer == "q") break;

    Console.WriteLine(userAnswer + " vs " + computeAnswer);

    if (userAnswer == computeAnswer) Console.WriteLine("Ничья!");

    void comparison(int a, int b, int c)
    {
        if (userAnswer == variants[a] & computeAnswer == variants[b])
        {
            Console.WriteLine("Поздравляю вы победили!!!");
        }
        if (userAnswer == variants[a] & computeAnswer == variants[c])
        {
            Console.WriteLine("Кажется вас размазали!)");
        }
    }
    comparison(0, 1, 2);
    comparison(1, 2, 0);
    comparison(2, 0, 1);
    Console.WriteLine();
}