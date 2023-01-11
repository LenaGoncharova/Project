//Написать программу,которая из  имеющегося массива строк формирует
//  массив из строк,длина которых меньше либо равна 3 символам


Console .Write ( " ввдедите значения в консоль через пробел : ");
 
 string[] massiv =Console. ReadLine().Split  (" ") ;
string[] SecondArray(string[] arr)
{
    int count = 0;
    string[] newarr = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
    if(arr[i].Length <= 3)
        {
        newarr[count] = arr[i];
        count++;
        }
    }
    return newarr;
}
// void PrintArray(string[] arr)
// {
//     Console.Write("[");
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i] } " );
//     }
//     Console.WriteLine("]");
// }
 string[]secondArray= SecondArray(massiv );
// PrintArray(secondArray);
 Console.WriteLine("["+ string.Join(" ", massiv)+ "]");
  Console.WriteLine("["+ string.Join(" ", secondArray)+ "]");