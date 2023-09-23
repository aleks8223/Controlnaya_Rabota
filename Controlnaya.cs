/*Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []*/


Console.Write("Введите количество элементов: ");
int m = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[m];
void array(string[] stringArray)

{
  for (int i = 0; i < stringArray.Length; i++)
  {
    Console.Write($"Введите {i + 1} элемент: ");
    stringArray[i] = Console.ReadLine()!;
  }
}

string[] symbol(string[] stringArray)
{
  int n = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length <= 3)
      n++;
  }
  string[] rezult = new string[n];
  int j = 0;
  for (int i = 0; i < stringArray.Length; i++)
  {
    if (stringArray[i].Length <= 3)
    {
      rezult[j] = stringArray[i];
      j++;
    }
  }
  return rezult;
}

void printA(string[] stringArray)
{
  Console.Write("[");
  for (int i = 0; i < stringArray.Length; i++)
  {
    Console.Write($"\"{stringArray[i]}\", ");
  }
  Console.Write("]");
}

array(stringArray);
printA(symbol(stringArray));