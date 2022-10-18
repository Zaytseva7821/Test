
int DataEntry(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
void FillStringArray(string[] array)
{
    System.Console.WriteLine("Введите ваш массив, отделяя строки клавишей Enter");
    for(int i=0; i< array.Length; i++)
        array[i] = Console.ReadLine();
}
int size = DataEntry("Введите длину вашего массива:");
string[] array = new string [size];
FillStringArray(array);
System.Console.WriteLine("[{0}]",string.Join(", ", array));
int count = 0;
for(int i=0; i< array.Length; i++)
    if(array[i].Length<4)
    count++;
string[] NewArray = new string [count];
count = 0;
for(int i=0; i< array.Length; i++)
    if(array[i].Length < 4)
    {
       NewArray[count] = array[i];
       count++;
    }
System.Console.WriteLine("[{0}]",string.Join(", ", NewArray));