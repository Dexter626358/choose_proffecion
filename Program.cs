String[] array = {"Java", "Python", "PHP", "GO", "Swift", "R", "3", "13", "A"};
String[] getArray(String[] array)
{
    int count = 0;
    for(int i=0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            count++;
        }
    }
    String[] result = new String[count];
    int index = 0;
    for(int i=0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            result[index] += array[i];
            index++;
        }
    }

    return result;
}
String[] newArray = getArray(array);
foreach(var value in newArray)
{
    Console.Write(value + " ");
}

