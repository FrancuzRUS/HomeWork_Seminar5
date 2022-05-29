// Написать программу копирования массива


Console.Write("Необходимо скопировать массив. Введите количество элементов которое будет содержаться в массиве: ");

int A = int.Parse(Console.ReadLine());

int[] array = new int[A];
int i = 0;
int lenght = array.Length;

int [] MASS = new int[lenght];
int index = 0 ;

Console.WriteLine("Массив №1 состоит из следующих элементов: ");
while ( i < lenght)
{
    array[i] = new Random().Next(0,10);
    Console.WriteLine(array[i]);
    i++;
}
    i=0;

Console.WriteLine("Массив №2 состоит из элементов: ");

while (index < lenght)
    {
        MASS[index] = array[i];
        Console.Write(MASS[index]);
        i++;
        index++;
    }

