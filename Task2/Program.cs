int x1 = ReadInt("Введите координату х первой точки: ");
int y1 = ReadInt("Введите координату y первой точки: ");
int z1 = ReadInt("Введите координату z первой точки: ");
int x2 = ReadInt("Введите координату х второй точки: ");
int y2 = ReadInt("Введите координату y второй точки: ");
int z2 = ReadInt("Введите координату z второй точки: ");

double length = Math.Sqrt((x2 - x1)*(x2 - x1) + (y2 - y1)*(y2 - y1) + (z2 - z1)*(z2 - z1));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine(length);