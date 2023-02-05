/*
Console.Write("Введите несколько чисел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = 0;
 
for (int i = 0; i < array.Length; i++)
{
 if (array[i] > 0) count++;
}
Console.WriteLine($"{count} Чисел больше 0.");
*/
/*
void CAA (double k1, double b1, double k2, double b2){
    double x = 0;
    double y = 0;
     if(k1 == k2 && b1 == b2) Console.Write("Прямые совпадают. Точек пересения бесконечно много.");
    else if(k1 == k2 && b1 != b2) Console.WriteLine("Прямые паралельны. Точек пересения нет");
    else{
        x = Math.Round((b2-b1)/(k1-k2), 1);
        y = Math.Round(k1*x + b1, 1);
        Console.WriteLine($"Абсцисса точки пересения: {x}, ордината: {y}");
    }
}


Console.Write("Input k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Input b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

CAA(k1, k2, b1 ,b2);
*/