// Задача 3: Задайте произвольную строку. 
// Выясните, является ли она палиндромом.
// “aBcD1ef!-” => Нет
// “шалаш” => Да
// “55655” => Да

Console.WriteLine("Введите строку: ");
string text = Console.ReadLine();

if (IsPalindrom(text))
    Console.WriteLine("Да");
else
    Console.WriteLine("Нет");

static bool IsPalindrom(string word)
{
  var left = 0;
  var right = word.Length -1;
58
  while (left<right)
  {
    if (word[left] != word[right]) return false;
    left++;
    right--;
  }
  return true;
}