//написать программу, которая будет находить максимальное число из 3 введеных.

int userFirstNumb = new int();
int userSecondNumb = new int();
int userThirdNumb = new int();

Console.WriteLine("Введите первое число  ");
userFirstNumb = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число  "); 
userSecondNumb =Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число  "); 
userThirdNumb = Convert.ToInt32(Console.ReadLine());

int max = userFirstNumb;

if (userSecondNumb>max)
{
max = userSecondNumb;
}
if (userThirdNumb>max) 
{
max = userThirdNumb;
}
Console.WriteLine($" max = {max}");
