// Задача 1: Задайте двумерный массив символов (тип char [,]). 
// Создать строку из символов этого массива.

// Пример a b c => “abcdef” 
//        d e f


char[,] elements = new char[,] 
{
    {'a', 'b', 'c'},
    {'d', 'e', 'f'}
};

string str = "";

for (int i = 0; i < elements.GetLength(0); i++)
{
    for (int j = 0; j < elements.GetLength(1); j++)
    {
       str += elements[i,j]; 
    }
}
Console.WriteLine(str);