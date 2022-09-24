int N = ReadInt("Введите число: ");
int i = 1;
while(i <= N)
{
    if(i == N)
    {
        Console.Write(i*i*i);
    }
    else
    {
        Console.Write(i*i*i + ", ");
    }
    i++;
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
