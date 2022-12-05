string[] array1 = {"Hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};
string[] SthreeСharacters(string[] array)
{
    string[] newarray = new string[array.Length];
    int count=0;
        for (int i = 0; i < array.Length; i++) //выборка элементов
        {
            if(array[i].Length <= 3)
            {
            newarray[count] = array[i];
            count++;
            }
        } 
    string[] finalarray = new string[count];// обрезаем хвостик
     for (int i = 0; i < count; i++)
        finalarray[i]=newarray[i];
            
        return finalarray;
}
void PrintArray (string[] array) //вывод массива на экран
{
Console.Write($"[");    
for (int i = 0; i < array.Length; i++)
    {Console.Write($"\"{array[i]}\"");
      if (i< array.Length-1) Console.Write($", ");
    }
Console.WriteLine($"]");     
}
string[] newarray1 = SthreeСharacters(array1);
string[] newarray2 = SthreeСharacters(array2);
string[] newarray3 = SthreeСharacters(array3);
PrintArray (newarray1);
PrintArray (newarray2);
PrintArray (newarray3);