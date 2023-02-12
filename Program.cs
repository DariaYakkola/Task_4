Console.Write("Введите первое число: ");
int numbers1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numbers2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numbers3 = Convert.ToInt32(Console.ReadLine());
if (numbers1 > numbers2)
{ 
  if (numbers1 > numbers3)
  {
    Console.WriteLine("Наибольшее число будет: " + numbers1);
  }
  else
  {
    Console.WriteLine("Наибольшее число будет: " + numbers3);
  }
}
else
{
  if (numbers2 > numbers3)
  {
    Console.WriteLine("Наибольшее число будет: " + numbers2);
  }
  else
  {
    Console.WriteLine("Наибольшее число будет: " + numbers3);
  }
}