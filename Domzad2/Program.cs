void Zadacha10()
{
    Console.WriteLine("Задача 10 ");
    Console.Write("Введи трёхзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    int n2 = number / 10 % 10;
    Console.Write(" " + n2);
}
void Zadacha13()
{
    Console.WriteLine("Задача 13 ");
    Console.Write("Введи число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 99)
    {
        int n3 = number % 10;
        Console.Write(" " + n3);
    }
    else
    {
        Console.WriteLine("третьей цифры нет");
    }

}
void Zadacha15()
{
    Console.WriteLine("Задача 15 ");

Console.Write("Введи цифру, обозначающую день недели: ");
int number = Convert.ToInt32(Console.ReadLine());

void CheckDay (int number) {
  if (number == 6 || number == 7) 
  {
  Console.WriteLine("этот день выходной");
  }
  else if (number < 1 || number > 7) 
  {
    Console.WriteLine("это не день недели");
  }
  else Console.WriteLine("этот день не выходной");
}
CheckDay(number);

}
//Zadacha10();
//Zadacha13();
//Zadacha15();
