Console.WriteLine("Игра камень, ножницы, бумага!!!");
Console.Write("Введите свой вариант: ");
string? userAnswer = Console.ReadLine();
string[] variants = { "ножницы", "бумага", "камень"};
int i = new Random().Next(0, 3);
string computeAnswer = variants[i];
Console.WriteLine(userAnswer + " vs " + computeAnswer);

if (userAnswer == computeAnswer) Console.WriteLine("Ничья!");


if (userAnswer == variants[0] & computeAnswer == variants[1]) 
{
    Console.WriteLine("Поздравляю вы победили!!!");
}
if (userAnswer == variants[0] & computeAnswer == variants[2]) 
{
    Console.WriteLine("Кажется вас размазали!)");
}


if (userAnswer == variants[1] & computeAnswer == variants[0]) 
{
    Console.WriteLine("Кажется вас размазали!)");
}
if (userAnswer == variants[1] & computeAnswer == variants[2]) 
{
    Console.WriteLine("Поздравляю вы победили!!!");
}


if (userAnswer == variants[2] & computeAnswer == variants[0]) 
{
    Console.WriteLine("Поздравляю вы победили!!!");
}
if (userAnswer == variants[2] & computeAnswer == variants[1]) 
{
    Console.WriteLine("Кажется вас размазали!)");
}