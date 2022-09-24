int number = ReadInt("Введите пятизначное число: ");
string numbers = Convert.ToString(number);

if(numbers.Length < 5)
{
    Console.WriteLine("Число не пятизначное!");
}
else if(numbers.Length > 5)
{
    Console.WriteLine("Число не пятизначное!!");
}
else
{
    char[] pal = numbers.ToCharArray();
    Array.Reverse(pal);
    string lap = new string(pal);

    if(numbers == lap)
    {
        Console.WriteLine("Число " + numbers +  " палиндромное");
    } 
    else
    {
        Console.WriteLine("Число " + numbers +  " не палиндромное");   
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

