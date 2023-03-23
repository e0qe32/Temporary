// Написать программу, которая из имеющегося массива строк формирует массив из 
// строк, длина которых меньше, либо равна три символа. Первоначальный массив можно
// ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении
// обойтись исключительно массивами.

string[] InputArray(int size)
{
  string[] arr = new string[size];
  for(int i = 0; i < arr.Length; i = i + 1)
  {
    System.Console.WriteLine("Введите строку: ");
    arr[i] = Console.ReadLine() !;
  }
  return arr;

}


void PrintArray(string[] array)
{
  System.Console.WriteLine("[" + string.Join(" ",array) + "]");
}

string[] NewArray(int size, string[] array)
{
  string[] newarray = new string[size];
  for(int i = 0; i < array.Length; i = i + 1)
  {
    if(array[i].Length <= 3)
    {
      newarray[i] = array[i];
    }
  }
  return newarray;
}


int M = 3;
int N = M;
string[] array = InputArray(M);
PrintArray(array);
string[] newarray = NewArray(N, array);
PrintArray(newarray);

